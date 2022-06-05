using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    /// <summary>
    /// Отчетная таблица 2220 "Из общего числа выбывших"
    /// </summary>
    internal class ReportTable2220
    {
        /// <summary>
        /// Число умерших
        /// </summary>
        public int Died { get; set; }
        /// <summary>
        /// Число умерших от несчастных случаев
        /// </summary>
        public int DiedBecauseOfAccident { get; set; }
        /// <summary>
        /// Число переведенных в другие психиатрические стационары
        /// </summary>
        public int CountOfTransferredToOtherPsychiatricHospitals { get; set; }
        /// <summary>
        /// Число переведенных в другие психиатрические стационары общего типа
        /// </summary>
        public int CountOfTransferredToOtherGeneralPsychiatricHospitals { get; set; }
        /// <summary>
        /// Число переведенных в другие психиатрические стационары специализированного типа
        /// </summary>
        public int CountOfTransferredToOtherSpecialPsychiatricHospitals { get; set; }
        /// <summary>
        /// Число переведенных в другие психиатрические стационары специализированного типа с интенсивным наблюдением
        /// </summary>
        public int CountOfTransferredToOtherIntensivelyMonitoredSpecialPsychiatricHospitals { get; set; }
        /// <summary>
        /// Число переведенных в другие психиатрические стационары без изменения вида ПЛ
        /// </summary>
        public int CountOfTransferredToOtherPsychiatricHospitalsWithoutOfChangingTypeOfPl { get; set; }
        /// <summary>
        /// Число выбывших в связи с прекращением принудительного лечения
        /// </summary>
        public int CountOfThoseWhoLeftDueToTheTerminationOfCompulsoryTreatment { get; set; }
        /// <summary>
        /// Число дней, проведенных пациентами на ПЛ от начала до конца, включая АПНЛ
        /// </summary>
        public int CountOfDaysPatientsSpentOnPlFromStartToFinish { get; set; }
    }
}
