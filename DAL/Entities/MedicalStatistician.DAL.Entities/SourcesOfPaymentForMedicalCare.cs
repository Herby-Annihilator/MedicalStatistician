using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Источники оплаты медицинской помощи
    /// </summary>
    public class SourcesOfPaymentForMedicalCare : NamedEntity
    {
        /// <summary>
        /// Случаи лечения, где лечение оплачивалось этим источником
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
