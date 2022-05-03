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
    /// Тип заболевания (основное, сопутствующее)
    /// </summary>
    public class TypeOfDisease
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Формулировка
        /// </summary>
        public string Wording { get; set; } = "";
        /// <summary>
        /// Заболевания данного типа
        /// </summary>
        public ICollection<Disease>? Diseases { get; set; }
    }
}
