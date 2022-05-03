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
    /// Цель направления на лечение
    /// </summary>
    public class PurposeOfReferralForTreatment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Формулировка
        /// </summary>
        [MaxLength(255)]
        public string Wording { get; set; } = "";

        /// <summary>
        /// Случаи госпитализации с данной целью
        /// </summary>
        public ICollection<Hospitalization>? Hospitalizations { get; set; }
    }
}
