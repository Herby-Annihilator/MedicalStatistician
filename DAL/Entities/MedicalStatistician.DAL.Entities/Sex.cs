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
    /// Пол
    /// </summary>
    public class Sex : NamedEntity
    {
        /// <summary>
        /// Пациенты данного пола
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
