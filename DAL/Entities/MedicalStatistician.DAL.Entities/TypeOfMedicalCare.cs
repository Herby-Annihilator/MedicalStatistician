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
    /// Вид медицинской помощи
    /// </summary>
    public class TypeOfMedicalCare : NamedEntity
    {
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
        /// <summary>
        /// Мед организации, оказывающие данную мед помощь
        /// </summary>
        public ICollection<MedicalOrganization> MedicalOrganizations { get; set; }
        /// <summary>
        /// Дочерние записи
        /// </summary>
        public ICollection<TypeOfMedicalCare>? MedicalCares { get; set; }
    }
}
