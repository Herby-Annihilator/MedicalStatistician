using MedicalStatistician.Reports.Exporters.Base;
using OfficeOpenXml;
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
            Stream template = File.OpenRead(@"C:\Users\Rukin\OneDrive\course_4\practice\LAW_52009.attach_LAW_91008_4.xlsx");
            FileInfo result = new FileInfo(@"C:\Users\Rukin\OneDrive\course_4\practice\result.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(template))
            {
                package.Workbook.Worksheets[0].Cells["BZ10"].Value = report36pl.Year;
                package.SaveAs(result);
            }
        }

        public void Export(string path, Report16vn report16vn)
        {
            throw new NotImplementedException();
        }

        public void Export(string path, ActiveDispensaryObservation activeDispensaryObservation)
        {
            throw new NotImplementedException();
        }
    }
}
