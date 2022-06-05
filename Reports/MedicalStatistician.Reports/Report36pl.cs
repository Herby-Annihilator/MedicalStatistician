using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    public class Report36pl : IReport
    {
        public int Year { get; set; }
        public string OrganizationAddress { get; set; } = "";
        public string OrganizationName { get; set; } = "";
        public string OkpoCode { get; set; } = "";
        internal IEnumerable<ReportTable2200> ReportTable2200 { get; set; } = Enumerable.Empty<ReportTable2200>();
        internal ReportTable2210 ReportTable2210 { get; set; } = new ReportTable2210();
        internal ReportTable2220 ReportTable2220 { get; set; } = new ReportTable2220();
        internal ReportTable2230 ReportTable2230 { get; set; } = new ReportTable2230();
        internal ReportTable2240 ReportTable2240 { get; set; } = new ReportTable2240();
        public void Export(string path, IExporter exporter)
        {
            exporter.Export(path, this);
        }
    }
}
