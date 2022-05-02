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
    /// Образование
    /// </summary>
    public class Education
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Наименование образования
        /// </summary>
        [MaxLength(255)]
        public string Name { get; set; } = "";

        /// <summary>
        /// Коллекция пациентов с данным образованием
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
