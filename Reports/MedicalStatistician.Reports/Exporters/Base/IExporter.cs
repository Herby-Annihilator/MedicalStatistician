using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports.Exporters.Base
{
    public interface IExporter
    {
        void Export(string path, Report36pl report36pl);
        void Export(string path, Report16vn report16vn);
        void Export(string path, ActiveDispensaryObservation activeDispensaryObservation);
    }
}
