using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Группа инвалидности
    /// </summary>
    public class DisabilityGroup
    {
        public int Id { get; set; }
        /// <summary>
        /// Название группы
        /// </summary>
        [MaxLength(32)]
        public string Name { get; set; } = "1 группа";
        /// <summary>
        /// Пациенты с данной группой инвалидности
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
