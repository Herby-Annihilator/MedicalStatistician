using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Расшивочная таблица. Содержит способ употребления ПАВ пациентом
    /// </summary>
    public class PatientUseDrugs
    {
        /// <summary>
        /// Пациент-нарик
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код пациента-нарика
        /// </summary>
        public int PatientId { get; set; }
        /// <summary>
        /// Наркота
        /// </summary>
        public PsychoactiveSubstance PatientSubstance { get; set; }
        /// <summary>
        /// Код наркоты
        /// </summary>
        public int PatientSubstanceId { get; set; }
        /// <summary>
        /// Способ употребления
        /// </summary>
        public MethodOfConsumption MethodOfConsumption { get; set; }
        /// <summary>
        /// Код способа обдолбаться
        /// </summary>
        public int MethodOfConsumptionId { get; set; }
        /// <summary>
        /// Возраст начала употребления
        /// </summary>
        public int StartUseDrugsAge { get; set; }
    }
}
