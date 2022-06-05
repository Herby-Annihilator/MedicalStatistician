using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    /// <summary>
    /// Отчетная таблица 2210 "Из числа больных, поступивших на стационарное принудительное лечение ПЛ"
    /// </summary>
    internal class ReportTable2210
    {
        /// <summary>
        /// Число больных, поступивших на стационарное ПЛ, ранее находившихся на принудительном лечении
        /// </summary>
        public int CountOfPatientsWhoWerePreviouslyInCompulsoryTreatment { get; set; }

        /// <summary>
        /// Из них последнее ООД совершили после прекращения предыдущего ПЛ в течение до 1 года
        /// </summary>
        public int OodForUpToAYear { get; set; }
        /// <summary>
        /// Из них последнее ООД совершили после прекращения предыдущего ПЛ через 1 - 2 года
        /// </summary>
        public int OodInOneOrTwoYears { get; set; }
        /// <summary>
        /// Из них последнее ООД совершили после прекращения предыдущего ПЛ через 3 - 5 лет
        /// </summary>
        public int OodInThreeOrFiveYears { get; set; }
        /// <summary>
        /// Из них последнее ООД совершили после прекращения предыдущего ПЛ через 5 лет и более
        /// </summary>
        public int OodInFiveOrMoreYears { get; set; }
        /// <summary>
        /// После совершения ООД находились под диспансерным наблюдением
        /// </summary>
        public int AfterOodWereUnderDispensaryObservation { get; set; }
        /// <summary>
        /// Поступило впервые в данном году
        /// </summary>
        public int CountOfFirstTimeApplicantsInAGivenYear { get; set; }
    }
}
