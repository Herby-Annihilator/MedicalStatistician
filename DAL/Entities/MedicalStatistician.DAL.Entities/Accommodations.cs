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
    /// Условия проживания
    /// </summary>
    public class Accommodations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Формулировка условия
        /// </summary>
        [MaxLength(255)]
        public string Wording { get; set; } = "";
        /// <summary>
        /// Пациенты, проживающие в данных условиях
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
