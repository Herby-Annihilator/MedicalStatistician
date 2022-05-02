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
    /// Вид медицинской помощи
    /// </summary>
    public class TypeOfMedicalCare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Наименование вида мед помощи
        /// </summary>
        [MaxLength(255)]
        public string Name { get; set; } = "";
        /// <summary>
        /// Столбец для сортировки. Он есть в справочнике, с которого будет заполняться база
        /// </summary>
        public int SortColumn { get; set; }
        /// <summary>
        /// Родительская запись
        /// </summary>
        public TypeOfMedicalCare? Parent { get; set; }
        /// <summary>
        /// Код родительской записи
        /// </summary>
        public int? ParentId { get; set; }
    }
}
