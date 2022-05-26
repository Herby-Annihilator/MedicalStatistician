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
    /// Причина смерти (Несчастный случай, самоубийство, ...)
    /// </summary>
    public class CauseOfDeath : NamedEntity
    {
        /// <summary>
        /// Случаи лечения с данной причиной смерти
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
