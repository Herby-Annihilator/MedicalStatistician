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
    /// Профиль медицинской помощи
    /// </summary>
    public class MedicalCareProfile : NamedEntity
    {
        /// <summary>
        /// Отделения данного профиля
        /// </summary>
        public ICollection<Department>? Departments { get; set; }
    }
}
