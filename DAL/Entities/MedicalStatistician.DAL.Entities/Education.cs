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
    /// Образование
    /// </summary>
    public class Education : NamedEntity
    {
        /// <summary>
        /// Коллекция пациентов с данным образованием
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
        /// <summary>
        /// Признак актуальности
        /// </summary>
        public bool IsActual { get; set; } = true;
        /// <summary>
        /// Коллекция дочерних записей
        /// </summary>
        public ICollection<Education>? Educations { get; set; }
        /// <summary>
        /// Родительская запись
        /// </summary>
        public Education? Parent { get; set; }
        /// <summary>
        /// Код родительской записи
        /// </summary>
        public int? ParentId { get; set; }
    }
}
