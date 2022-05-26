using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Вид амбулаторного наблюдения
    /// </summary>
    public class TypeOfOutpatientCare : NamedEntity
    {
        /// <summary>
        /// Случаи лечения с данным видом амбулаторного наблюдения
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
