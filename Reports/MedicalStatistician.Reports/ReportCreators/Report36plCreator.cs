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
        protected Report36pl _report;
        public Report36plCreator()
        {
            _report = new Report36pl();
        }       
        
        public virtual async Task<IReport> CreateReportAsync(DateTime startDate, DateTime endDate)
        {
            await CreateHeader();
            await AddTable2200(startDate, endDate);
            await AddTable2210();
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
            IEnumerable<Judgment> judgments = (await _judgmentRepository
                .GetAllAsync())
                .Where(item => item.Date > startDate && item.Date < endDate);
            IEnumerable<TreatmentCase> treatments = (await _treatmentCaseRepository
                .GetAllAsync())
                .Where(t => t.ReceiptDate > startDate && t.RetirementDate < endDate);

        }
        /// <summary>
        /// Добавляет таблицу 2210
        /// </summary>
        protected virtual async Task AddTable2210()
        {

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
    }
}
