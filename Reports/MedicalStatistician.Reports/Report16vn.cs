using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    public class Report16vn : IReport
    {
        public void Export(string path, IExporter exporter)
        {
            exporter.Export(path, this);
        }
    }
}
