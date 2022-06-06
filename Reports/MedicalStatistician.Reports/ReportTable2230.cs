using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    /// <summary>
    /// Отчетная таблица 2230 "Из общего числа больных, находящихся в стационаре на конец года"
    /// </summary>
    internal class ReportTable2230
    {
        /// <summary>
        /// Время нахождения на всех видах ПЛ до 1 года
        /// </summary>
        public int UpToAYear { get; set; }
        /// <summary>
        /// Время нахождения на всех видах ПЛ до одного до двух лет
        /// </summary>
        public int FromOneToTwoYears { get; set; }
        /// <summary>
        /// Время нахождения на всех видах ПЛ до двух до пяти лет
        /// </summary>
        public int FromTwoToFiveYears { get; set; }
        /// <summary>
        /// Время нахождения на всех видах ПЛ до пяти до десяти лет
        /// </summary>
        public int FromFiveToTenYears { get; set; }
        /// <summary>
        /// Время нахождения на всех видах ПЛ больше десяти лет
        /// </summary>
        public int MoreThenTenYears { get; set; }
    }
}
