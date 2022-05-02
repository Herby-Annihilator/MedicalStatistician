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
    /// Статистическая карта выбывшего из стационара
    /// </summary>
    public class StatisticalCard
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Номер стат. карты в учреждении
        /// </summary>
        public string CardNumber { get; set; } = "";
        /// <summary>
        /// Номер соответствующей мед. карты
        /// </summary>
        public string MedicalCardNumber { get; set; } = "";
        /// <summary>
        /// Пациент, к которому привязана эта карта
        /// </summary>
        public Patient Patient { get; set; } = new Patient();
        /// <summary>
        /// Идентификатор пациента, к которому привязана эта карта
        /// </summary>
        public int PatientId { get; set; }
    }
}
