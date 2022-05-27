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
    /// Диагноз
    /// </summary>
    public class Diagnosis : Entity
    {
        /// <summary>
        /// Дата постановки
        /// </summary>
        DateTime CreationDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Вид диагноза (заключительный, при поступлении, паталогоанатомический, основная причина сметрит, ...)
        /// </summary>
        public TypeOfDiagnosis TypeOfDiagnosis { get; set; }
        /// <summary>
        /// Код вида диагноза
        /// </summary>
        public int TypeOfDiagnosisId { get; set; }
        /// <summary>
        /// Основное заболевание, сопутствующее заболевание, осложнения основного заболевания
        /// </summary>
        public ICollection<Disease> Diseases { get; set; }
        /// <summary>
        /// Случай лечения
        /// </summary>
        public TreatmentCase TreatmentCase { get; set; }
        /// <summary>
        /// Код случая лечения
        /// </summary>
        public int TreatmentCaseId { get; set; }
    }
}
