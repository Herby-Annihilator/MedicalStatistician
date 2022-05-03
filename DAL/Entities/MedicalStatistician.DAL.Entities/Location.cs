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
    /// Место жительства
    /// </summary>
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [MaxLength(255)]
        public string Name { get; set; } = "";
        /// <summary>
        /// Пациенты с данным местом жительства
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
