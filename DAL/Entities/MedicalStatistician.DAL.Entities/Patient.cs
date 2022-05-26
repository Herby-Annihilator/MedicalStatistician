﻿using MedicalStatistician.DAL.Entities.Base;
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
    /// Пациент
    /// </summary>
    public class Patient : Entity
    {
        /// <summary>
        /// Имя (макс. длина 300)
        /// </summary>
        [MaxLength(300)]
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Фамилия (макс. длина 300)
        /// </summary>
        [MaxLength(300)]
        public string LastName { get; set; } = "";

        /// <summary>
        /// Отчество (макс. длина 300). Необязательное свойство
        /// </summary>
        [MaxLength(300)]
        public string? Patronymic { get; set; }

        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime Birthday { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата первого обращения к наркологу (в жизни)
        /// </summary>
        public DateTime? FirstConyactWithNarcologist { get; set; }
        /// <summary>
        /// Признак использования чужих шприцов
        /// </summary>
        public bool IsUsedOthersSyringes { get; set; } = false;
        /// <summary>
        /// Признак проживания с наркоманом
        /// </summary>
        public bool IsLivesWithAddict { get; set; } = false;
        /// <summary>
        /// Группа инвалидности пациента
        /// </summary>
        public DisabilityGroup? DisabilityGroup { get; set; }
        /// <summary>
        /// Код группы инвалидности пациента
        /// </summary>
        public int? DisabilityGroupId { get; set; }
        /// <summary>
        /// Причина инвалидности
        /// </summary>
        public CauseOfDisability? CauseOfDisability { get; set; }
        /// <summary>
        /// Код причины инвалидности
        /// </summary>
        public int? CauseOfDisabilityId { get; set; }
        /// <summary>
        /// Полисы пациента
        /// </summary>
        public ICollection<Policy> Policies { get; set; }
        /// <summary>
        /// Коллекция наркоты, которой успел обдолбаться пациент (если успел)
        /// </summary>
        public ICollection<PsychoactiveSubstance>? PsychoactiveSubstances { get; set; }
        /// <summary>
        /// Коллекция вариантов обдалбывания со ссылкой на вещество
        /// </summary>
        public ICollection<PatientUseDrugs>? PatientUseDrugs { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Sex Sex { get; set; }
        /// <summary>
        /// Код пола
        /// </summary>
        public int SexId { get; set; }
        /// <summary>
        /// Образование
        /// </summary>
        public Education Education { get; set; }
        /// <summary>
        /// Код образования
        /// </summary>
        public int EducationId { get; set; }
        /// <summary>
        /// Семейное положение
        /// </summary>
        public ResidenceStatus ResidenceStatus { get; set; }
        /// <summary>
        /// Код семейного положения
        /// </summary>
        public int ResidenceStatusId { get; set; }
        /// <summary>
        /// Участие в войне по ОКИН
        /// </summary>
        public ParticipationInTheWar? ParticipationInTheWar { get; set; }
        /// <summary>
        /// Код участия в войне по ОКИН
        /// </summary>
        public int? ParticipationInTheWarId { get; set; }
        /// <summary>
        /// Источник средств существования
        /// </summary>
        public SourceOfLivelihood? SourceOfLivelihood { get; set; }
        /// <summary>
        /// Код источника средств существования
        /// </summary>
        public int? SourceOfLivelihoodId { get; set; }
        /// <summary>
        /// Условия проживания (статус условий проживания)
        /// </summary>
        public Accommodations Accommodations { get; set; }
        /// <summary>
        /// Код условия проживания
        /// </summary>
        public int AccommodationsId { get; set; }

        /// <summary>
        /// Решения суда о начале принудительного лечения в отношении данного пациента
        /// </summary>
        public ICollection<Judgment>? Judgments { get; set; }
        /// <summary>
        /// Листки нетрудоспособности
        /// </summary>
        public ICollection<CertificateOfIncapacityForWork>? CertificateOfIncapacityForWork { get; set; }
        /// <summary>
        /// Обследования на ВИЧ
        /// </summary>
        public ICollection<HivTest>? HivTests { get; set; }
        /// <summary>
        /// Число законченных классов
        /// </summary>
        public int NumberOfCompletedClasses { get; set; }
        /// <summary>
        /// Признак учебы
        /// </summary>
        public bool IsStudies { get; set; } = false;
        /// <summary>
        /// Дата начала заболевания
        /// </summary>
        public DateTime? DateOfOnsetOfIllness { get; set; }
    }
}
