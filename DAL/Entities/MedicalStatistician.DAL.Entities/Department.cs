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
    /// Медицинское отделение
    /// </summary>
    public class Department : NamedEntity
    {
        /// <summary>
        /// Номер отделения
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Профиль мед помощи, оказываемой в отделении
        /// </summary>
        public MedicalCareProfile Profile { get; set; }
        /// <summary>
        /// Код профиля оказываемой мед помощи
        /// </summary>
        public int ProfileId { get; set; }
        /// <summary>
        /// Случаи лечения в данном отделении
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
