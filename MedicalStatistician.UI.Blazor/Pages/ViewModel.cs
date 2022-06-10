namespace MedicalStatistician.UI.Blazor.Pages
{
    public class ViewModel
    {
        //
        // Данные для заполнения
        //

        /// <summary>
        /// Фамилия
        /// </summary>
        public string? Family { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string? Patronymic { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public string? Sex { get; set; }

        /// <summary>
        /// Место жительства
        /// </summary>
        public string? PlaceOfResidence { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birtthdate { get; set; }

        /// <summary>
        /// Виды оплаты
        /// </summary>
        public string? TypesOfPayment { get; set; }

        /// <summary>
        /// Название страховой компании
        /// </summary>
        public string? NameOfTheInsuranceCompany { get; set; }

        /// <summary>
        /// Серия страхового полиса
        /// </summary>
        public int InsurancePolicySeries { get; set; }

        /// <summary>
        /// Номер страхового полиса
        /// </summary>
        public int InsurancePolicyNumber { get; set; }

        /// <summary>
        /// Номер статистической карты
        /// </summary>
        public int StatisticalCardNumber { get; set; }

        /// <summary>
        /// Номер медицинской крты
        /// </summary>
        public int MedicalCardNumber { get; set; }

        /// <summary>
        /// Номер отделения
        /// </summary>
        public int DepartmentNumber { get; set; }

        /// <summary>
        /// Дата поступления
        /// </summary>
        public DateTime DateOfReceipt { get; set; }

        /// <summary>
        /// Дата выбытия
        /// </summary>
        public DateTime DateOfDisposal { get; set; }

        /// <summary>
        /// Дата открытия больничного листа
        /// </summary>
        public DateTime DateOfOpeningOfTheSickLeave { get; set; }

        /// <summary>
        /// Дата закрытия больничного листа
        /// </summary>
        public DateTime SickLeaveClosingDate { get; set; }

        /// <summary>
        /// Госпитализирован
        /// </summary>
        public string? Hospitalized { get; set; }

        /// <summary>
        /// Поступление
        /// </summary>
        public string? Admission { get; set; }

        /// <summary>
        /// Кем направлен
        /// </summary>
        public string? SentByWhom { get; set; }

        /// <summary>
        /// Порядок поступления
        /// </summary>
        public string? AdmissionProcedure { get; set; }

        /// <summary>
        /// Решение судьи по статье 35
        /// </summary>
        public string? JudgesDecisionOnArticle35 { get; set; }

        /// <summary>
        /// Откуда поступил
        /// </summary>
        public string? WhereDidHeComeFrom { get; set; }

        /// <summary>
        /// Цель направления
        /// </summary>
        public string? PurposeOfTheDirection { get; set; }

        /// <summary>
        /// Диагноз направившего учреждения
        /// </summary>
        public string? DiagnosisOfTheSendingInstitution { get; set; }

        /// <summary>
        /// Диагноз направившего учреждения (код МКБ)
        /// </summary>
        public string? DiagnosisOfTheSendingInstitutionMKB { get; set; }

        /// <summary>
        /// Заключительный диагноз
        /// </summary>
        public string? FinalDiagnosis { get; set; }

        /// <summary>
        /// Заключительный диагноз (код МКБ)
        /// </summary>
        public string? FinalDiagnosisMKB { get; set; }

        /// <summary>
        /// Основной код (+) по МКБ-10
        /// </summary>
        public string? MainCodeMKB { get; set; }

        /// <summary>
        /// Инвалидность при выписке по заболеванию
        /// </summary>
        public string? DisabilityAtDischargeDueToIllness { get; set; }

        /// <summary>
        /// Обследование больного на ВИЧ
        /// </summary>
        public string? ExaminationOfPatientForHIV { get; set; }

        /// <summary>
        /// Выбыл
        /// </summary>
        public string? Leave { get; set; }

        /// <summary>
        /// Смерть наступила
        /// </summary>
        public string? DeathHasOccurred { get; set; }

        /// <summary>
        /// Основная причина смерти
        /// </summary>
        public string? MainCauseOfDeath { get; set; }

        /// <summary>
        /// Основная причина смерти (код МКБ)
        /// </summary>
        public string? MainCauseOfDeathMKB { get; set; }

        /// <summary>
        /// Истории принудительного лечения
        /// </summary>
        public List<HistoryOfCompulsoryTreatment>? HistoryOfCompulsoryTreatments;

        /// <summary>
        /// История принудительного лечения
        /// </summary>
        public struct HistoryOfCompulsoryTreatment
        {
            DateTime startDate, extensionDate1, extensionDate2, extensionDate3, endDate;
            string startType, extensionType1, extensionType2, extensionType3;
        }

        /// <summary>
        /// В случае окончания принудительного лечения
        /// </summary>
        public string? InCaseOfTerminationOfCompulsoryTreatment { get; set; }

        /// <summary>
        /// Дата окончания предыдущего принудительного лечения
        /// </summary>
        public DateTime EndDateOfPreviousCompulsoryTreatment { get; set; }

        //-----------------------------------
        // Дополнительные сведения о больном
        //-----------------------------------

        /// <summary>
        /// Дата начала заболевания
        /// </summary>
        public DateTime DateOfOnsetOfTheDisease { get; set; }

        /// <summary>
        /// Дата обращения к психиатру (наркологу) впервые в жизни
        /// </summary>
        public DateTime DateOfReferralToPsychiatristForTheFirstTimeInLife { get; set; }

        /// <summary>
        /// Ранее находился на принудительном лечении число раз
        /// </summary>
        public int PreviouslyWasOnCompulsoryTreatmentNumberOfTimes { get; set; }

        /// <summary>
        /// Вид амбулаторного наблюдения
        /// </summary>
        public string? TypeOfOutpatientObservation { get; set; }

        /// <summary>
        /// Дата предыдущей выписки из психиатрического стационара
        /// </summary>
        public DateTime DateOfPreviousDischargeFromTheHospital { get; set; }

        /// <summary>
        /// Число дней работы в ЛТМ
        /// </summary>
        public int NumberOfWorkingDaysInLTM { get; set; }

        /// <summary>
        /// Число дней лечебных отпусков (за период госпитализации)
        /// </summary>
        public int NumberOfDaysOfMedicalVacations { get; set; }

        /// <summary>
        /// Число лечебных отпусков (за период госпитализации)
        /// </summary>
        public int NumberOfMedicalVacations { get; set; }

        /// <summary>
        /// Сопутствующее психическое заболевание
        /// </summary>
        public string? ConcomitantMentalIllness { get; set; }

        /// <summary>
        /// Сопутствующее психическое заболевание (код МКБ)
        /// </summary>
        public string? ConcomitantMentalIllnessMKB { get; set; }

        /// <summary>
        /// Сопутствующее соматическое заболевание (код МКБ)
        /// </summary>
        public string? ConcomitantSomaticDiseaseMKB { get; set; }

        /// <summary>
        /// Инвалидность по общему заболеванию
        /// </summary>
        public string? DisabilityDueToCommonDisease { get; set; }

        /// <summary>
        /// Инвалид ВОВ
        /// </summary>
        public bool IsDisabledVeteran { get; set; }

        /// <summary>
        /// Участник ВОВ
        /// </summary>
        public bool IsVeteran { get; set; }

        /// <summary>
        /// Число законченных классов среднеобразовательного учреждения
        /// </summary>
        public int NumberOfCompletedClassesOfSecondaryEducationalInstitution { get; set; }

        /// <summary>
        /// Образование
        /// </summary>
        public string? Education { get; set; }

        /// <summary>
        /// Учится
        /// </summary>
        public bool IsStudy { get; set; }

        /// <summary>
        /// Источник средств существования
        /// </summary>
        public string? SourceOfLivelihood { get; set; }

        /// <summary>
        /// Проживает
        /// </summary>
        public string? Lives { get; set; }

        /// <summary>
        /// Условия проживания
        /// </summary>
        public string? LivingConditions { get; set; }

        /// <summary>
        /// Исход заболевания
        /// </summary>
        public string? OutcomeOfTheDisease { get; set; }
    }
}
