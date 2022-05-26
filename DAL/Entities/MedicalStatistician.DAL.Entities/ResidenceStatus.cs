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
    /// Статус проживания (один, в семье)
    /// </summary>
    public class ResidenceStatus : NamedEntity
    {
        /// <summary>
        /// Пациенты с данным статусом проживания
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
