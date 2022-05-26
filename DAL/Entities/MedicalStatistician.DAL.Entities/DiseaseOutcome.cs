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
    /// Исход заболевания (улучшение, ухудшение, ...)
    /// </summary>
    public class DiseaseOutcome : NamedEntity
    {
        /// <summary>
        /// Случаи лечения с данным исходом
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
