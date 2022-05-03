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
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Наименование отделения
        /// </summary>
        [MaxLength(255)]
        public string Name { get; set; } = "";
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
        /// Тип отделения (мужское, женское, детское)
        /// </summary>
        public DepartmentType DepartmentType { get; set; }
        /// <summary>
        /// Код типа отделения
        /// </summary>
        public int DepartmentTypeId { get; set; }
        /// <summary>
        /// Случаи госпитализации, в которых данное отделение принимало пациента
        /// </summary>
        public ICollection<Hospitalization>? Hospitalizations { get; set; }
    }
}
