using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    public class ReportTable2110 : IReport
    {
        /// <summary>
        /// Снято с АДН в отчетном году в связи с переменой места жительства
        /// </summary>
        public int RemovedFromAdnInReportingYearWithChangingOfLivingPlace { get; set; }

        /// <summary>
        /// Снято с АДН в отчетном году в связи со смертью
        /// </summary>
        public int RemovedFromAdnInReportingYearBecauseOfDeath { get; set; }

        /// <summary>
        /// Снято с АДН в отчетном году в связи с отсутствием сведений в течении года
        /// </summary>
        public int RemovedFromAdnInReportingYearBecauseOfThereIsNoInformation { get; set; }

        /// <summary>
        /// Снято с АДН в отчетном году в связи с другими причинами
        /// </summary>
        public int RemovedFromAdnInReportingYearBecauseOfAnotherReasons { get; set; }

        public void Export(string path, IExporter exporter) => exporter.Export(path, this);
    }
}
