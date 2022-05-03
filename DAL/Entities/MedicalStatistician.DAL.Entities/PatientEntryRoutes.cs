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
    /// Пути поступления пациента (из дома, доставлен скорой, переведен откуда-то)
    /// </summary>
    public class PatientEntryRoutes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Формулировка
        /// </summary>
        [MaxLength(512)]
        public string Wording { get; set; }
        /// <summary>
        /// Случаи госпитализации
        /// </summary>
        public ICollection<Hospitalization>? Hospitalizations { get; set; }
    }
}
