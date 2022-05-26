using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Заболевание
    /// </summary>
    public class Disease : NamedEntity
    {
        /// <summary>
        /// Заболевание по МКБ
        /// </summary>
        public MKB10 Mkb10 { get; set; }
        /// <summary>
        /// Код МКБ
        /// </summary>
        public int Mkb10Id { get; set; }
        /// <summary>
        /// Диагноз
        /// </summary>
        public Diagnosis Diagnosis { get; set; }
        /// <summary>
        /// Код диагноза
        /// </summary>
        public int DiagnosisId { get; set; }
        /// <summary>
        /// Тип заболевания (основное, сопутствующее, осложнение основного, фоновое, ...)
        /// </summary>
        public TypeOfDisease TypeOfDisease { get; set; }
        /// <summary>
        /// Код типа заболевания
        /// </summary>
        public int TypeOfDiseaseId { get; set; }
    }
}
