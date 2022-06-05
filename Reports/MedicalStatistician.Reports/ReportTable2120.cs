using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    public class ReportTable2120 : IReport
    {
        public void Export(string path, IExporter exporter) => exporter.Export(path, this);
        /// <summary>
        /// Взято под АДН в отчетном году, которые совершили ООД в отчетном году (1)
        /// </summary>
        public int TakenUnderAdnInReportingYearHasOodInReportingYear { get; set; }
        /// <summary>
        /// Взято под АДН в отчетном году, которые совершили ООД в отчетном году, в том числе
        /// не находились на диспансерном наблюдении (2)
        /// </summary>
        public int TakenUnderAdnInReportingYearHasOodInReportingYearButWereNotOnDispensaryObservation { get; set; }
        /// <summary>
        /// Взято под АДН в отчетном году, которые совершили ООД в отчетном году, после назначения ПЛ (3)
        /// </summary>
        public int TakenUnderAdnInReportingYearHasOodInReportingYearAfterPl { get; set; }
        /// <summary>
        /// Взято под АДН в отчетном году, которые совершили ООД в отчетном году, после назначения ПЛ, в том числе
        /// после изменения АПНЛ на ПЛ в стационаре (4)
        /// </summary>
        public int TakenUnderAdnInReportingYearHasOodInReportingYearAfterChangingApnlOnPl { get; set; }
    }
}
