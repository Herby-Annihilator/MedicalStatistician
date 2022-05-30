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
    /// Место выбытия (домой, в другой стационар, ...)
    /// </summary>
    public class PlaceOfDeparture : NamedEntity
    {
        /// <summary>
        /// Случаи заболевания с данным местом выбытия
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
