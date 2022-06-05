using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports
{
    /// <summary>
    /// Отчетная таблица 2240
    /// </summary>
    internal class ReportTable2240
    {
        /// <summary>
        /// Число побегов за год
        /// </summary>
        public int CountOfRunsPerYaer { get; set; }
        /// <summary>
        /// Число находящихся в побеге на конец года
        /// </summary>
        public int CountOfPeopleOnTheRunAtTheEndOfTheYear { get; set; }
        /// <summary>
        /// Число находящихся в побеге более года
        /// </summary>
        public int CountOfPeopleOnTheRunForMoreThanAYear { get; set; }
        /// <summary>
        /// Число нападений больных на персонал
        /// </summary>
        public int CountOfAttacksByPatientsOnStaff { get; set; }
        /// <summary>
        /// Число нападений больных на персонал, повелекшие смерть
        /// </summary>
        public int CountOfAttacksByPatientsOnStaffResultingInDeath { get; set; }
        /// <summary>
        /// Число нападений больных на больных
        /// </summary>
        public int CountOfAttacksByPatientsOnPatients { get; set; }
        /// <summary>
        /// Число нападений больных на больных, повелекшие смерть
        /// </summary>
        public int CountOfAttacksByPatientsOnPatientsResultingInDeath { get; set; }
        /// <summary>
        /// Число суицидов
        /// </summary>
        public int CountOfSuicides { get; set; }
        /// <summary>
        /// Число "удачных" суицидов
        /// </summary>
        public int CountOfSuccessfulSuicides { get; set; }
    }
}
