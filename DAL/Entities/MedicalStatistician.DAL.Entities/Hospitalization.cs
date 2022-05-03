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
    }
}
