using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
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
            await AddTable2200(startDate, endDate);
            await AddTable2210(startDate, endDate);
            await AddTable2220();
            await AddTable2230();
            await AddTable2240();
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
        /// <summary>
        /// Добавляет таблицу 2200
        /// </summary>
        protected virtual async Task AddTable2200(DateTime startDate, DateTime endDate)
        {
            IEnumerable<TreatmentCase> all = await _treatmentCaseRepository.GetAllAsync();
            IEnumerable<TreatmentCase> inThisYear = (await _treatmentCaseRepository.GetAllAsync())
                ?.Where(item => item.ReceiptDate >= startDate && item.ReceiptDate < endDate
                && item.PurposeOfReferralForTreatment.Name.ToLower() == "принудительное лечение");
            IEnumerable<TreatmentCase> children = GetChildren(inThisYear);
            IEnumerable<TreatmentCase> firstlyInMentalHospital = await SelectThatAreFirstlyInMentalHospital(inThisYear);

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
        /// <summary>
        /// Добавляет таблицу 2210
        /// </summary>
        protected virtual async Task AddTable2210(DateTime startDate, DateTime endDate)
        {
            OrderReportTable2200();
            
            
            
        }
        protected enum TypeOfJudgmentId
        {
            Start = 1,
            Continue,
            End
        }
        /// <summary>
        /// Добавляет таблицу 2220
        /// </summary>
        protected virtual async Task AddTable2220()
        {

        }
        /// <summary>
        /// Добавляет таблицу 2230
        /// </summary>
        protected virtual async Task AddTable2230()
        {

        }
        /// <summary>
        /// Добавляет таблицу 2240
        /// </summary>
        protected virtual async Task AddTable2240()
        {

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
