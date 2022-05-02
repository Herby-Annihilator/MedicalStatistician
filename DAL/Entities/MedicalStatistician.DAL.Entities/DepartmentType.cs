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
    /// Тип отделения (мужское, женское, детское)
    /// </summary>
    public class DepartmentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Наименование типа
        /// </summary>
        [MaxLength(255)]
        public string Name { get; set; } = "";
        /// <summary>
        /// Отделения данного типа
        /// </summary>
        public ICollection<Department>? Departments { get; set; }
    }
}
