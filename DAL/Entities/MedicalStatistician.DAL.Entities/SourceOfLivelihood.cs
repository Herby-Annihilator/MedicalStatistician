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
    /// Источник средств существования
    /// </summary>
    public class SourceOfLivelihood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Формулировка
        /// </summary>
        [MaxLength(255)]
        public string Wording { get; set; }
        /// <summary>
        /// Пациенты, имеющие такой источник
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
