using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using MedicalStatistician.Reports.Builders.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports.Builders
{
    public class Report36plBuilder : IReport36plBuilder
    {
        protected DateTime _startDate;
        protected DateTime _endtDate;
        protected ICrudRepository<MedicalOrganization> _medicalOrganisationRepository;
        protected ICrudRepository<MKB10> _mkb10Repository;
        protected ICrudRepository<TreatmentCase> _treatmentCaseRepository;
        protected Report36pl report;
        public Report36plBuilder()
        {
            report = new Report36pl();
        }       

        public async Task CreateHeader()
        {
            var result = await _medicalOrganisationRepository.GetByIdAsync(1);
            report.OrganizationAddress = result.Address;
            report.OrganizationName = result.Name;
            report.OkpoCode = result.OkopfCode; // TODO: проверить соответсвтие кодов ОКПО и ОКОПФ
        }
        /// <summary>
        /// Добавляет таблицу 2100
        /// </summary>
        public async Task AddTable2100()
        {

        }

        public void Reset()
        {
            report = new Report36pl();
        }
    }
}
