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
    /// Вид принудительного лечения
    /// </summary>
    public class TypeOfForcedTreatment : NamedEntity
    {
        /// <summary>
        /// Коллекция решений суда, в которых указан данный вид принудительного лечения
        /// </summary>
        public ICollection<Judgment>? Judgments { get; set; }
    }
}
