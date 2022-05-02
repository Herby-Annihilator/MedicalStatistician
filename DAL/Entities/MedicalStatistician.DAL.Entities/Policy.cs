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
    /// Медицинский полис
    /// </summary>
    public class Policy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Серия
        /// </summary>
        [MaxLength(11)]
        public string Series { get; set; } = "";
        /// <summary>
        /// Номер
        /// </summary>
        [MaxLength(16)]
        public string Number { get; set; } = "";
        /// <summary>
        /// Признак актуальности
        /// </summary>
        public bool IsActual { get; set; }
        /// <summary>
        /// Пациент, которому принадлежит полис
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код пациента
        /// </summary>
        public int PatientId { get; set; }
        /// <summary>
        /// Страховая, выдавшая полис
        /// </summary>
        public InsuranceOrganization InsuranceOrganization { get; set; }
        /// <summary>
        /// Код страховой
        /// </summary>
        public int InsuranceOrganizationId { get; set; }
    }
}
