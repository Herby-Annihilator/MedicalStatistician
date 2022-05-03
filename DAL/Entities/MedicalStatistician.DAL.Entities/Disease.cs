using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    public class Disease
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
        /// Тип заболевания
        /// </summary>
        public TypeOfDisease TypeOfDisease { get; set; }
        /// <summary>
        /// Код типа заболевания
        /// </summary>
        public int TypeOfDiseaseId { get; set; }
    }
}
