using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Решение суда о принудительном лечении
    /// </summary>
    public class Judgment : Entity
    {
        /// <summary>
        /// Дата принятия решения
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
        /// <summary>
        /// Вид принудительного лечения
        /// </summary>
        public TypeOfForcedTreatment TypeOfForcedTreatment { get; set; }
        /// <summary>
        /// Код вида принудительного лечения
        /// </summary>
        public int TypeOfForcedTreatmentId { get; set; }
        /// <summary>
        /// Пациент, к которому относится данное решение
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код пациента, к которому отностистя данное решение
        /// </summary>
        public int PatientId { get; set; }
        /// <summary>
        /// Тип решения суда о принудительном лечении
        /// </summary>
        public TypeOfJudgment TypeOfJudgment { get; set; }
        /// <summary>
        /// Код типа решения суда о принуд лечении
        /// </summary>
        public int TypeOfJudgmentId { get; set; }
    }
}
