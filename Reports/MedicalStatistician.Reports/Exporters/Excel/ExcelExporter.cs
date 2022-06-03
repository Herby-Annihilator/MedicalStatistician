using MedicalStatistician.Reports.Exporters.Base;
using MedicalStatistician.Reports.Exporters.Excel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports.Exporters.Excel
{
    public class ExcelExporter : IExcelExporter
    {
        public void Export(string path, Report36pl report36pl)
        {
            throw new NotImplementedException();
        }

        public void Export(string path, Report16vn report16vn)
        {
            throw new NotImplementedException();
        }
    }
}
