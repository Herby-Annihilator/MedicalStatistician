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
        public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.Now;
        /// <summary>
        /// Дата закрытия
        /// </summary>
        public DateTimeOffset ClosingDate { get; set; } = DateTimeOffset.Now;
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
