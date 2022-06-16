using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using MedicalStatistician.Extensions;
using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.ReportCreators.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports.ReportCreators
{
    /// <summary>
    /// Создает годовой отчет по форме 36-ПЛ
    /// </summary>
    public class Report36plCreator : IReportCreator
    {
        protected ICrudRepository<MedicalOrganization> _medicalOrganisationRepository;
        protected ICrudRepository<MKB10> _mkb10Repository;
        protected ICrudRepository<TreatmentCase> _treatmentCaseRepository;
        protected ICrudRepository<Judgment> _judgmentRepository;
        protected ICrudRepository<TypeOfJudgment> _typeOfJudgmentRepository;
        protected ICrudRepository<Patient> _patientRepository;
        protected Report36pl _report;
        protected bool _isReportTable2200Ordered = false;
        public Report36plCreator()
        {
            _report = new Report36pl();
        }       
        
        public virtual async Task<IReport> CreateReportAsync(DateTime startDate, DateTime endDate)
        {
            await CreateHeader();
            IEnumerable<TreatmentCase> all = await _treatmentCaseRepository.GetAllAsync();
            IEnumerable<TreatmentCase> inThisYear = (await _treatmentCaseRepository.GetAllAsync())
                ?.Where(item => item.ReceiptDate >= startDate && item.ReceiptDate < endDate
                && item.PurposeOfReferralForTreatment.Name.ToLower() == "принудительное лечение");
            IEnumerable<TreatmentCase> children = GetChildren(inThisYear);
            IEnumerable<TreatmentCase> firstlyInMentalHospital = await SelectThatAreFirstlyInMentalHospital(inThisYear);
            

            IEnumerable<TreatmentCase> droppedOutInThisYear = all.Where(
                item =>
                item.PurposeOfReferralForTreatment.Name.ToLower() == "принудительное лечение"
                && item.RetirementDate >= startDate
                && item.RetirementDate <= endDate);


            return _report;
        }
        /// <summary>
        /// Создает шапку отчета
        /// </summary>
        /// <returns></returns>
        protected virtual async Task CreateHeader()
        {
            var result = await _medicalOrganisationRepository.GetByIdAsync(1);
            _report.OrganizationAddress = result.Address;
            _report.OrganizationName = result.Name;
            _report.OkpoCode = result.OkopfCode; // TODO: проверить соответсвтие кодов ОКПО и ОКОПФ
        }

        private IEnumerable<TreatmentCase> GetChildren(IEnumerable<TreatmentCase> treatmentCases)
        {
            List<TreatmentCase> children = new List<TreatmentCase>();
            foreach (var treatmentCase in treatmentCases)
            {
                if (IsChild(treatmentCase.Patient))
                    children.Add(treatmentCase);
            }
            return children;
        }
        private bool IsChild(Patient patient) => CalculateAge(patient.Birthday.Date) <= 17;
        private int CalculateAge(DateTime birthdate)
        {
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            int age = today.Year - birthdate.Year;
            // Go back to the year in which the person was born in case of a leap year
            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }

        private async Task<IEnumerable<TreatmentCase>> SelectThatAreFirstlyInMentalHospital(IEnumerable<TreatmentCase> inThisYear)
        {
            List<TreatmentCase> result = new List<TreatmentCase>();
            foreach (var item in inThisYear)
            {
                if (item.Patient.Treatments.Count == 1)
                    result.Add(item);
            }
            return result;
        }
        private int CalculateBedDays(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new ArgumentException($"{nameof(startDate)} is more than {nameof(endDate)}");
            DateTime convertedStart = new DateTime(startDate.Year, startDate.Month, startDate.Day);
            DateTime convertedEnd = new DateTime(endDate.Year, endDate.Month, endDate.Day);
            int result;
            if (convertedStart == convertedEnd)
                result = 1;
            else
                result = (convertedEnd - convertedStart).Days;
            return result;
        }

        private bool IsPlTypeWasChanged(TreatmentCase treatmentCase, out bool isApnl)
        {
            isApnl = false;
            if (treatmentCase.PlaceOfDeparture.Name.ToLower() != "умер"
                && treatmentCase.Patient.Judgments != null)
            {
                var judgments = treatmentCase.Patient.Judgments.OrderBy(j => j.Date).ToArray();
                int lastIndex = judgments.IndexOf(j => j.TypeOfJudgmentId == (int)TypeOfJudgmentId.Start);
                int typeOfPl = judgments[lastIndex].TypeOfForcedTreatmentId;
                int indexOfLastContinious = 0;
                bool isContinueExists = false, isEndOfPlExists = false;
                for (int i = lastIndex + 1; i < judgments.Length; i++)
                {
                    if (judgments[i].TypeOfJudgmentId == (int)TypeOfJudgmentId.End)
                    {
                        isEndOfPlExists = true;
                        break;
                    }
                    else if (judgments[i].TypeOfJudgmentId == (int)TypeOfJudgmentId.Continue
                        && judgments[i].Date <= treatmentCase.RetirementDate
                        && typeOfPl != judgments[i].TypeOfForcedTreatmentId)
                    {
                        isContinueExists = true;
                        indexOfLastContinious = i;
                        typeOfPl = judgments[i].TypeOfForcedTreatmentId;
                    }
                    else if (judgments[i].TypeOfJudgmentId == (int)TypeOfJudgmentId.Continue
                        && judgments[i].Date > treatmentCase.RetirementDate)
                        return false;
                }
                if (isEndOfPlExists)
                    return false;
                else if (isContinueExists)
                {
                    if (typeOfPl == (int)TypesOfPl.Ambulant)
                        isApnl = true;
                    return true;
                }
            }
            return false;
        }
        private bool IsPlTypeWasChanged(TreatmentCase treatmentCase) => IsPlTypeWasChanged(treatmentCase, out bool isApnl);
        private bool IsInHospitalAtTheEndOfYear(TreatmentCase treatmentCase)
        {
            if (treatmentCase.PlaceOfDeparture.Name.ToLower() == "не выбывал не конец года")
                return true;
            return false;
        }
        protected enum TypeOfJudgmentId
        {
            Start = 1,
            Continue,
            End
        }
        protected enum TypesOfPl
        {
            Ambulant = 1,
        }
        /// <summary>
        /// "Обнуляет" отчет
        /// </summary>
        protected virtual void Reset()
        {
            _report = new Report36pl();
        }

        protected void OrderReportTable2200()
        {
            if (!_isReportTable2200Ordered)
            {
                _isReportTable2200Ordered = true;
                _report.ReportTable2200.OrderBy(t => t.RowIndex);
            }
        }
    }
}
