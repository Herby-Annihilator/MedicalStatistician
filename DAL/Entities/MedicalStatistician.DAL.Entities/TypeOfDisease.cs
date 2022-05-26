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
    /// Тип заболевания (основное, сопутствующее)
    /// </summary>
    public class TypeOfDisease : NamedEntity
    {
        /// <summary>
        /// Заболевания данного типа
        /// </summary>
        public ICollection<Disease>? Diseases { get; set; }
    }
}
