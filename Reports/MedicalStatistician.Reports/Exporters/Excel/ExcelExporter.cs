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
                package.Workbook.Worksheets[0].Cells["AV25"].Value = report36pl.OrganizationName;
                package.Workbook.Worksheets[0].Cells["S27"].Value = report36pl.OrganizationAddress;
                //
                // 2100
                //
                report36pl.Table2100.OrderBy(t => t.RowIndex);
                var table = report36pl.Table2100.ToArray();
                int j = 0;
                int cellIndex = 8;  // в шаблоне 8
                for (int i = 0; i < table.Length; i++)
                {
                    cellIndex += j;
                    package.Workbook.Worksheets[1].Cells[$"BN{cellIndex}"].Value =
                    table[i].TotalTakenUnderActiveDispensaryObservation;
                    package.Workbook.Worksheets[1].Cells[$"BX{cellIndex}"].Value =
                        table[i].ChildrenTakenUnderActiveDispensaryObservation;
                    package.Workbook.Worksheets[1].Cells[$"CH{cellIndex}"].Value =
                        table[i].TotalRemovedFromActiveDispensaryObservation;
                    package.Workbook.Worksheets[1].Cells[$"CR{cellIndex}"].Value =
                        table[i].WithdrawnFromActiveDispensaryObservationDueToADecreaseInPublicDanger;
                    package.Workbook.Worksheets[1].Cells[$"DG{cellIndex}"].Value =
                        table[i].TotalCountOfPeopleOnAdnAtTheEndOfTheReportingYear;
                    package.Workbook.Worksheets[1].Cells[$"DQ{cellIndex}"].Value =
                        table[i].ChildrenOnAdnAtTheEndOfTheReportingYear;
                    package.Workbook.Worksheets[1].Cells[$"EA{cellIndex}"].Value =
                        table[i].AreOnAdnAtTheEndOfTheReportingYearAndHaveCommittedOodDuringTheirLifetime;
                    package.Workbook.Worksheets[1].Cells[$"EK{cellIndex}"].Value =
                        table[i].AreOnAdnAtTheEndOfTheReportingYearAndHaveCommittedOodDuringTheirLifetimeAndAtTheReportingYear;
                    package.Workbook.Worksheets[1].Cells[$"EX{cellIndex}"].Value =
                        table[i].AreOnAdnAtTheEndOfTheReportingYearAndHaveCommittedOodDuringTheirLifetimeButWereNotOnAdn;
                    j++;
                    if (i == 1)
                    {
                        j++;
                    }
                }               
                //
                // 2110
                //
                package.Workbook.Worksheets[1].Cells["DI17"].Value =
                    report36pl.ReportTable2110.RemovedFromAdnInReportingYearWithChangingOfLivingPlace;
                package.Workbook.Worksheets[1].Cells["EF17"].Value =
                    report36pl.ReportTable2110.RemovedFromAdnInReportingYearBecauseOfDeath;
                package.Workbook.Worksheets[1].Cells["AU18"].Value =
                    report36pl.ReportTable2110.RemovedFromAdnInReportingYearBecauseOfThereIsNoInformation;
                package.Workbook.Worksheets[1].Cells["CA18"].Value =
                    report36pl.ReportTable2110.RemovedFromAdnInReportingYearBecauseOfAnotherReasons;
                //
                // 2120
                //
                package.Workbook.Worksheets[1].Cells["O20"].Value =
                    report36pl.ReportTable2120.TakenUnderAdnInReportingYearHasOodInReportingYear;
                package.Workbook.Worksheets[1].Cells["BW20"].Value =
                    report36pl.ReportTable2120.TakenUnderAdnInReportingYearHasOodInReportingYearButWereNotOnDispensaryObservation;
                package.Workbook.Worksheets[1].Cells["DC20"].Value =
                    report36pl.ReportTable2120.TakenUnderAdnInReportingYearHasOodInReportingYearAfterPl;
                package.Workbook.Worksheets[1].Cells["W21"].Value =
                    report36pl.ReportTable2120.TakenUnderAdnInReportingYearHasOodInReportingYearAfterChangingApnlOnPl;
                //
                // 2130
                //
                package.Workbook.Worksheets[2].Cells["AL3"].Value =
                    report36pl.ReportTable2130.AreOnAdnOnTheEndOfTheReportingYearAreInPsychiatricHospital;
                package.Workbook.Worksheets[2].Cells["BJ3"].Value =
                    report36pl.ReportTable2130.AreOnAdnOnTheEndOfTheReportingYearAreInPsychiatricHospitalOnpl;
                package.SaveAs(result);
            }
        }

        public void Export(string path, Report16vn report16vn)
        {
            throw new NotImplementedException();
        }

       
    }
}
