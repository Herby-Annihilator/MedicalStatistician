using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Вид наркологической помощи
    /// </summary>
    public class TypeOfDrugTreatment : NamedEntity
    {
        /// <summary>
        /// Случаи лечения пациентов, которые получили данный тип наркологической помощи
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
