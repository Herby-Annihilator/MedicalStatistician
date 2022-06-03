using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports.Base
{
    public interface IReport
    {
        void Export(string path, IExporter exporter);
    }
}
