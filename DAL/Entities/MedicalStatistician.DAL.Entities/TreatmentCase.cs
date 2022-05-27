using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Случай лечения
    /// </summary>
    public class TreatmentCase : Entity
    {
        /// <summary>
        /// Пациент
        /// </summary>
        public Patient Patient { get; set; }
        /// <summary>
        /// Код пациента
        /// </summary>
        public int PatientId { get; set; }
        /// <summary>
        /// Число дней работы в ЛТМ
        /// </summary>
        public int NumberOfWorkingDaysInLtm { get; set; }
        /// <summary>
        /// Число лечебных отпусков
        /// </summary>
        public int NumberOfMedicalHolidays { get; set; }
        /// <summary>
        /// Число дней лечебных отпусков
        /// </summary>
        public int NumberOfMedicalLeaveDays { get; set; }
        /// <summary>
        /// Номер статистической карты
        /// </summary>
        public string StatisticalCardNumber { get; set; } = "";
        /// <summary>
        /// Номер медицинской карты
        /// </summary>
        public string MedicalCardNumber { get; set; } = "";
        /// <summary>
        /// Дата поступления
        /// </summary>
        public DateTime ReceiptDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата выбытия
        /// </summary>
        public DateTime RetirementDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Вид полученной наркологической помощи
        /// </summary>
        public TypeOfDrugTreatment TypeOfDrugTreatment { get; set; }
        /// <summary>
        /// Код вида полученной наркологической помощи
        /// </summary>
        public int TypeOfDrugTreatmentId { get; set; }
        /// <summary>
        /// Источник оплаты мед помощи
        /// </summary>
        public SourcesOfPaymentForMedicalCare SourcesOfPaymentForMedicalCare { get; set; }
        /// <summary>
        /// Код источника оплаты мед помощи
        /// </summary>
        public int SourcesOfPaymentForMedicalCareId { get; set; }
        /// <summary>
        /// Порядок поступления
        /// </summary>
        public OrderOfAdmission OrderOfAdmission { get; set; }
        /// <summary>
        /// Код порядка поступления
        /// </summary>
        public int OrderOfAdmissionId { get; set; }
        /// <summary>
        /// Кто направил на госпитализацию (кем направлен)
        /// </summary>
        public WhoSentToHospital WhoSentToHospital { get; set; }
        /// <summary>
        /// Код того, кто направил на госпитализацию
        /// </summary>
        public int WhoSentToHospitalId { get; set; }
        /// <summary>
        /// Цель направления на лечение
        /// </summary>
        public PurposeOfReferralForTreatment PurposeOfReferralForTreatment { get; set; }
        /// <summary>
        /// Код цели направления на лечение
        /// </summary>
        public int PurposeOfReferralForTreatmentId { get; set; }
        /// <summary>
        /// Путь поступления (Откуда поступил)
        /// </summary>
        public PatientEntryRoutes PatientEntryRoutes { get; set; }
        /// <summary>
        /// Код пути поступления
        /// </summary>
        public int PatientEntryRoutesId { get; set; }
        /// <summary>
        /// Решение судьи по статье 35
        /// </summary>
        public StatusOfJudgesDecisionUnderArticle35 StatusOfJudgesDecisionUnderArticle35 { get; set; }
        /// <summary>
        /// Код решения судьи по статье 35
        /// </summary>
        public int StatusOfJudgesDecisionUnderArticle35Id { get; set; }
        /// <summary>
        /// Отделение
        /// </summary>
        public Department Department { get; set; }
        /// <summary>
        /// Код отделения
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// Исход заболевания
        /// </summary>
        public DiseaseOutcome DiseaseOutcome { get; set; }
        /// <summary>
        /// Код исхода заболевания
        /// </summary>
        public int DiseaseOutcomeId { get; set; }
        /// <summary>
        /// Место выбытия
        /// </summary>
        public PlaceOfDeparture PlaceOfDeparture { get; set; }
        /// <summary>
        /// Код места выбытия
        /// </summary>
        public int PlaceOfDepartureId { get; set; }
        /// <summary>
        /// Вид амбулаторного наблюдения
        /// </summary>
        public TypeOfOutpatientCare TypeOfOutpatientCare { get; set; }
        /// <summary>
        /// Код вида амбулаторного наблюдения
        /// </summary>
        public int TypeOfOutpatientCareId { get; set; }
        /// <summary>
        /// Причина смерти
        /// </summary>
        public CauseOfDeath CauseOfDeath { get; set; }
        /// <summary>
        /// Код причины смерти
        /// </summary>
        public int CauseOfDeathId { get; set; }
        /// <summary>
        /// Диагнозы
        /// </summary>
        public ICollection<Diagnosis> Diagnoses { get; set; }
    }
}
