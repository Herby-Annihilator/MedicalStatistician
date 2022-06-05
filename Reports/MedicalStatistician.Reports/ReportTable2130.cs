using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    public class ReportTable2130 : IReport
    {
        public void Export(string path, IExporter exporter) => exporter.Export(path, this);
        /// <summary>
        /// Состоит на АДН на конец отчетного периода - находятся в психиатрическом стационаре (1)
        /// </summary>
        public int AreOnAdnOnTheEndOfTheReportingYearAreInPsychiatricHospital { get; set; }
        /// <summary>
        /// Состоит на АДН на конец отчетного периода - находятся в психиатрическом стационаре, из них на ПЛ (2)
        /// </summary>
        public int AreOnAdnOnTheEndOfTheReportingYearAreInPsychiatricHospitalOnpl { get; set; }
    }
}
