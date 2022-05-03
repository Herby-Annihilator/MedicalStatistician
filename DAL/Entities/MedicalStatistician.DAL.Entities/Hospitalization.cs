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
    /// Случай госпитализации
    /// </summary>
    public class Hospitalization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата госпитализации
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
        /// <summary>
        /// Пациент, поступивший на госпитализацию
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код пациента
        /// </summary>
        public int PatientId { get; set; }
        /// <summary>
        /// Путь поступления пациента на госпитализацию
        /// </summary>
        public PatientEntryRoutes PatientEntryRoutes { get; set; }
        /// <summary>
        /// Код пути поступления
        /// </summary>
        public int PatientEntryRoutesId { get; set; }
        /// <summary>
        /// Цель направления на лечение
        /// </summary>
        public PurposeOfReferralForTreatment PurposeOfReferralForTreatment { get; set; }
        /// <summary>
        /// Код цели направления на лечение
        /// </summary>
        public int PurposeOfReferralForTreatmentId { get; set; }
    }
}
