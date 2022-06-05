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
        public IEnumerable<ActiveDispensaryObservation> Table2100 { get; set; } = Enumerable.Empty<ActiveDispensaryObservation>();
        public ReportTable2110 ReportTable2110 { get; set; } = new ReportTable2110();
        public ReportTable2120 ReportTable2120 { get; set; } = new ReportTable2120();
        public ReportTable2130 ReportTable2130 { get; set; } = new ReportTable2130();
        public void Export(string path, IExporter exporter)
        {
            exporter.Export(path, this);
        }
    }
}
