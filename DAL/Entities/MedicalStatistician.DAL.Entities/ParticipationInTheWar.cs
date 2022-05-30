using MedicalStatistician.DAL.Entities.Base;
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
    /// Участие в войне по ОКИН
    /// </summary>
    public class ParticipationInTheWar : NamedEntity
    {
        /// <summary>
        /// Пациенты с данным статусом участия в войне
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
