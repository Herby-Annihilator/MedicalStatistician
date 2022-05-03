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
    public class Diagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата постановки
        /// </summary>
        DateTime CreationDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Вид диагноза (заключительный, при поступлении)
        /// </summary>
        public TypeOfDiagnosis TypeOfDiagnosis { get; set; }
        /// <summary>
        /// Код вида диагноза
        /// </summary>
        public int TypeOfDiagnosisId { get; set; }
        /// <summary>
        /// Пациент с данным диагнозом
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код диагноза пациента
        /// </summary>
        public int PatientId { get; set; }
    }
}
