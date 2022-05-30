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
    /// Способ употребления ПАВ
    /// </summary>
    public class MethodOfConsumption : NamedEntity
    {
        /// <summary>
        /// Коллекция расшивочных таблиц - "Пациент упортебляет"
        /// </summary>
        public ICollection<PatientUseDrugs>? PatientUseDrugs { get; set; }
    }
}
