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
                // 2210
                //
                package.Workbook.Worksheets[4].Cells["A28"].Value =
                    report36pl.ReportTable2210.CountOfPatientsWhoWerePreviouslyInCompulsoryTreatment;
                package.Workbook.Worksheets[4].Cells["AD28"].Value =
                    report36pl.ReportTable2210.OodForUpToAYear;
                package.Workbook.Worksheets[4].Cells["AX28"].Value =
                    report36pl.ReportTable2210.OodInOneOrTwoYears;
                package.Workbook.Worksheets[4].Cells["BN28"].Value =
                    report36pl.ReportTable2210.OodInTwoOrThreeYears;
                package.Workbook.Worksheets[4].Cells["CD28"].Value =
                    report36pl.ReportTable2210.OodInThreeOrFiveYears;
                package.Workbook.Worksheets[4].Cells["CT28"].Value =
                    report36pl.ReportTable2210.OodInFiveOrMoreYears;
                package.Workbook.Worksheets[4].Cells["DM28"].Value =
                    report36pl.ReportTable2210.AfterOodWereUnderDispensaryObservation;
                package.Workbook.Worksheets[4].Cells["EQ28"].Value =
                    report36pl.ReportTable2210.CountOfFirstTimeApplicantsInAGivenYear;
                //
                // 2220
                //
                package.Workbook.Worksheets[4].Cells["A36"].Value =
                    report36pl.ReportTable2220.Died;
                package.Workbook.Worksheets[4].Cells["K36"].Value =
                    report36pl.ReportTable2220.DiedBecauseOfAccident;
                package.Workbook.Worksheets[4].Cells["Z36"].Value =
                    report36pl.ReportTable2220.CountOfTransferredToOtherPsychiatricHospitals;
                package.Workbook.Worksheets[4].Cells["AQ36"].Value =
                    report36pl.ReportTable2220.CountOfTransferredToOtherGeneralPsychiatricHospitals;
                package.Workbook.Worksheets[4].Cells["BC36"].Value =
                    report36pl.ReportTable2220.CountOfTransferredToOtherSpecialPsychiatricHospitals;
                package.Workbook.Worksheets[4].Cells["BU36"].Value =
                    report36pl.ReportTable2220.CountOfTransferredToOtherIntensivelyMonitoredSpecialPsychiatricHospitals;
                package.Workbook.Worksheets[4].Cells["CQ36"].Value =
                    report36pl.ReportTable2220.CountOfTransferredToOtherPsychiatricHospitalsWithoutOfChangingTypeOfPl;
                package.Workbook.Worksheets[4].Cells["DS36"].Value =
                    report36pl.ReportTable2220.CountOfThoseWhoLeftDueToTheTerminationOfCompulsoryTreatment;
                package.Workbook.Worksheets[4].Cells["EO36"].Value =
                    report36pl.ReportTable2220.CountOfDaysPatientsSpentOnPlFromStartToFinish;
                //
                // 2230
                //
                package.Workbook.Worksheets[5].Cells["A7"].Value =
                    report36pl.ReportTable2230.UpToAYear;
                package.Workbook.Worksheets[5].Cells["Z7"].Value =
                    report36pl.ReportTable2230.FromOneToTwoYears;
                package.Workbook.Worksheets[5].Cells["AY7"].Value =
                    report36pl.ReportTable2230.FromTwoToFiveYears;
                package.Workbook.Worksheets[5].Cells["BX7"].Value =
                    report36pl.ReportTable2230.FromFiveToTenYears;
                package.Workbook.Worksheets[5].Cells["CW7"].Value =
                    report36pl.ReportTable2230.MoreThenTenYears;
                //
                // 2240
                //
                package.Workbook.Worksheets[5].Cells["A15"].Value =
                    report36pl.ReportTable2240.CountOfRunsPerYaer;
                package.Workbook.Worksheets[5].Cells["Q15"].Value =
                    report36pl.ReportTable2240.CountOfPeopleOnTheRunAtTheEndOfTheYear;
                package.Workbook.Worksheets[5].Cells["AG15"].Value =
                    report36pl.ReportTable2240.CountOfPeopleOnTheRunForMoreThanAYear;
                package.Workbook.Worksheets[5].Cells["AW15"].Value =
                    report36pl.ReportTable2240.CountOfAttacksByPatientsOnStaff;
                package.Workbook.Worksheets[5].Cells["BP15"].Value =
                    report36pl.ReportTable2240.CountOfAttacksByPatientsOnStaffResultingInDeath;
                package.Workbook.Worksheets[5].Cells["CM15"].Value =
                    report36pl.ReportTable2240.CountOfAttacksByPatientsOnPatients;
                package.Workbook.Worksheets[5].Cells["DF15"].Value =
                    report36pl.ReportTable2240.CountOfAttacksByPatientsOnPatientsResultingInDeath;
                package.Workbook.Worksheets[5].Cells["EC15"].Value =
                    report36pl.ReportTable2240.CountOfSuicides;
                package.Workbook.Worksheets[5].Cells["ET15"].Value =
                    report36pl.ReportTable2240.CountOfSuccessfulSuicides;
                package.SaveAs(result);
            }
        }

        public void Export(string path, Report16vn report16vn)
        {
            throw new NotImplementedException();
        }

       
    }
}
