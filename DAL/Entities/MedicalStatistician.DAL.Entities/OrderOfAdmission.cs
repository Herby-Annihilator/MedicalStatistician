using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Порядок поступления
    /// </summary>
    public class OrderOfAdmission : NamedEntity
    {
        /// <summary>
        /// Случаи лечения с данным порядком поступления
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
