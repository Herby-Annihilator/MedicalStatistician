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
        public void Export(string path, IExporter exporter)
        {
            exporter.Export(path, this);
        }
    }
}
