using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports.Exporters.Word
{
    public class WordExporter : IWordExporter
    {
        public void Export(string path, Report36pl report36pl)
        {
            throw new NotImplementedException();
        }

        public void Export(string path, Report16vn report16vn)
        {
            throw new NotImplementedException();
        }

        public void Export(string path, ActiveDispensaryObservation activeDispensaryObservation)
        {
            throw new NotImplementedException();
        }

        public void Export(string path, ReportTable2110 reportTable2110)
        {
            throw new NotImplementedException();
        }

        public void Export(string path, ReportTable2120 reportTable2120)
        {
            throw new NotImplementedException();
        }

        public void Export(string path, ReportTable2130 reportTable2130)
        {
            throw new NotImplementedException();
        }
    }
}
