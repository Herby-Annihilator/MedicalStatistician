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
    /// Выписка пациента
    /// </summary>
    public class Discharge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата выписки
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Выписанный пациент
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код выписанного пациента
        /// </summary>
        public int PatientId { get; set; }
    }
}
