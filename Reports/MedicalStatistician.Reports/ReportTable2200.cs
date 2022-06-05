using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.Exporters.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    /// <summary>
    /// Таблица 2200 "Состав больных, находящихся на принудительном лечении (ПЛ) в психиатрических стационарах"
    /// </summary>
    public class ReportTable2200 : IReport
    {
        public void Export(string path, IExporter exporter) => exporter.Export(path, this);
        public int RowIndex { get; set; }
        /// <summary>
        /// Поступило больных в отчетом году на ПЛ (всего)
        /// </summary>
        public int AllAddmittedPatientsInReportingYear { get; set; }
        /// <summary>
        /// Поступило детей в отчетном году
        /// </summary>
        public int CountOfChildrenAddmittedInReportingYear { get; set; }
        /// <summary>
        /// Поступило больных впервые в жизни в психиатрический стационар
        /// </summary>
        public int ReceivedPatientsForTheFirstTimeInTheirLives { get; set; }
        /// <summary>
        /// Поступило больных впервые по данному УД
        /// </summary>
        public int AdmittedPatientsForTheFirstTimeAccordingToThisUD { get; set; }
        /// <summary>
        /// Поступило больных в связи с изменением вида ПЛ по данному УД
        /// </summary>
        public int AdmittedPatientsAccordingToThisUDBecauseOfChangingTypeOfPl { get; set; }
        /// <summary>
        /// Поступило больных в связи с изменением вида ПЛ по данному УД, из них после АПНЛ
        /// </summary>
        public int AdmittedPatientsAccordingToThisUDBecauseOfChangingTypeOfPlAfterApnl { get; set; }
        /// <summary>
        /// Количество выбывших больных
        /// </summary>
        public int CountOfDroppedOutPatients { get; set; }
        /// <summary>
        /// Количество койко-дней, проведенных в данному стационаре
        /// </summary>
        public int CountOfBedDaysOfDroppedOutPatients { get; set; }
        /// <summary>
        /// Число выбывших в связи с изменением вида ПЛ
        /// </summary>
        public int CountOfDroppedOutPatientsBecauseOfChangingOfPlType { get; set; }
        /// <summary>
        /// Число выбывших в связи с переводом на АПНЛ
        /// </summary>
        public int CountOfDroppedOutPatientsBecauseOfTransferringOnApnl { get; set; }
        /// <summary>
        /// Состоит больных на конец года (всего)
        /// </summary>
        public int ConsistsOfPatientsAtTheEndOfTheYear { get; set; }
        /// <summary>
        /// Состоит детей на конец года
        /// </summary>
        public int ConsistsOfChildrensAtTheEndOfTheYear { get; set; }
    }
}
