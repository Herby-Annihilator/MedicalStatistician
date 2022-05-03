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
    /// Исход заболевания (улучшение, ухудшение, ...)
    /// </summary>
    public class DiseaseOutcome
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
        /// Выписки с данным исходом
        /// </summary>
        public ICollection<Discharge>? Discharges { get; set; }
    }
}
