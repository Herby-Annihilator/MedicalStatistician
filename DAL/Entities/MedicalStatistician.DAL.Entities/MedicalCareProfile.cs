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
    public class MedicalCareProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Наименование профиля медицинской помощи
        /// </summary>
        [MaxLength(255)]
        public string Name { get; set; } = "";
        /// <summary>
        /// Отделения данного профиля
        /// </summary>
        public ICollection<Department>? Departments { get; set; }
    }
}
