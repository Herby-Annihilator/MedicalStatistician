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
    /// Решение суда о принудительном лечении
    /// </summary>
    public class Judgment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата принятия решения
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;
        /// <summary>
        /// Статья УК РФ, в соответствии с которой применяется принудительное лечение
        /// </summary>
        public CriminalCodeArticle CriminalCodeArticle { get; set; }
        /// <summary>
        /// Код статьи УК РФ, в соответствии с которой применяется принудительное лечение
        /// </summary>
        public int CriminalCodeArticleId { get; set; }
        /// <summary>
        /// Вид принудительного лечения
        /// </summary>
        public TypeOfForcedTreatment TypeOfForcedTreatment { get; set; }
        /// <summary>
        /// Код вида принудительного лечения
        /// </summary>
        public int TypeOfForcedTreatmentId { get; set; }
        /// <summary>
        /// Пациент, к которому относится данное решение
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код пациента, к которому отностистя данное решение
        /// </summary>
        public int PatientId { get; set; }
    }
}
