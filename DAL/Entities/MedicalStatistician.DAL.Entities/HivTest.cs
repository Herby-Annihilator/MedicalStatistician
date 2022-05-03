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
    /// Обследование на ВИЧ
    /// </summary>
    public class HivTest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата обследования
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
        /// <summary>
        /// Результат обследования
        /// </summary>
        public bool IsPositive { get; set; } = false;
        /// <summary>
        /// Обследуемый пациент
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код обследуемого пациента
        /// </summary>
        public int PatientId { get; set; }
    }
}
