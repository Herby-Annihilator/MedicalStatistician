using MedicalStatistician.DAL.Entities.Base;
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
    public class DisabilityGroup : NamedEntity
    {
        /// <summary>
        /// Пациенты с данной группой инвалидности
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
