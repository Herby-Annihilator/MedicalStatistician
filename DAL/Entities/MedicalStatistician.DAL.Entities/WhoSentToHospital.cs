using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Кто направил на госпитализацию
    /// </summary>
    public class WhoSentToHospital : NamedEntity
    {
        /// <summary>
        /// Случаи госпитализации
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
