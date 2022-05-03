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
    /// Причина смерти (Несчастный случай, самоубийство, ...)
    /// </summary>
    public class CauseOfDeath
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Формулировка
        /// </summary>
        [MaxLength(512)]
        public string Wording { get; set; } = "";
        /// <summary>
        /// Выписки с данной причиной смерти
        /// </summary>
        public ICollection<Discharge>? Discharges { get; set; }
    }
}
