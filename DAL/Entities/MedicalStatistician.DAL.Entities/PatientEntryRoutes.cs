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
    /// Пути поступления пациента (из дома, доставлен скорой, переведен откуда-то)
    /// </summary>
    public class PatientEntryRoutes : NamedEntity
    {
        /// <summary>
        /// Случаи лечения с данным путем поступления
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
