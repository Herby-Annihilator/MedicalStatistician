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
    /// Вид диагноза (заключительный, при поступлении)
    /// </summary>
    public class TypeOfDiagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Формулировка
        /// </summary>
        [MaxLength(100)]
        public string Wording { get; set; } = "";
        /// <summary>
        /// Диагнозы данного вида
        /// </summary>
        public ICollection<Diagnosis>? Diagnosis { get; set; }
    }
}
