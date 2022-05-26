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
    /// Листок нетрудоспобности
    /// </summary>
    public class CertificateOfIncapacityForWork : Entity
    {
        /// <summary>
        /// Дата открытия
        /// </summary>
        public DateTime CreationDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата закрытия
        /// </summary>
        public DateTime ClosingDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Пациент, которому принадлежит листок
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код пациента, которому принадлежит листок
        /// </summary>
        public int PatientId { get; set; }
    }
}
