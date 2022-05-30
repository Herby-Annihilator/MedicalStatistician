using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities.DbContexts
{
    public class MedicalStatisticianDbContext : DbContext
    {
        public MedicalStatisticianDbContext(DbContextOptions options)
            : base(options) { }

        /// <summary>
        /// Таблица пациентов
        /// </summary>
        public DbSet<Patient> Patients { get; set; }
        /// <summary>
        /// Справочник образований
        /// </summary>
        public DbSet<Education> Educations { get; set; }
        /// <summary>
        /// Таблица листков нетрудоспособности
        /// </summary>
        public DbSet<CertificateOfIncapacityForWork> CertificateOfIncapacityForWorks { get; set; }
        /// <summary>
        /// Справочник полов
        /// </summary>
        public DbSet<Sex> Sex { get; set; }
        /// <summary>
        /// Таблица источков существования
        /// </summary>
        public DbSet<SourceOfLivelihood> SourcesOfLivelihood { get; set; }
        /// <summary>
        /// Таблица условий проживания (статус проживания)
        /// </summary>
        public DbSet<Accommodations> Accommodations { get; set; }
        /// <summary>
        /// Таблица причин инвалидности
        /// </summary>
        public DbSet<CauseOfDisability> CausesOfDisabilitiy { get; set; }
        /// <summary>
        /// Таблица участия в войне
        /// </summary>
        public DbSet<ParticipationInTheWar> ParticipationInTheWars { get; set; }
        /// <summary>
        /// Таблица статусов проживания (семейное положение: один, в семье, ....)
        /// </summary>
        public DbSet<ResidenceStatus> ResidenceStatuses { get; set; }
        /// <summary>
        /// Таблица групп инвалидности
        /// </summary>
        public DbSet<DisabilityGroup> DisabilityGroups { get; set; }
        /// <summary>
        /// Таблица обследований на ВИЧ
        /// </summary>
        public DbSet<HivTest> HivTests { get; set; }
        /// <summary>
        /// Таблица полисов
        /// </summary>
        public DbSet<Policy> Policies { get; set; }
        /// <summary>
        /// Таблица страховых организаций
        /// </summary>
        public DbSet<InsuranceOrganization> InsuranceOrganizations { get; set; }
        /// <summary>
        /// Таблица решений суда о принудительном лечении
        /// </summary>
        public DbSet<Judgment> Judgments { get; set; }
        /// <summary>
        /// Таблица видов принудительного лечения
        /// </summary>
        public DbSet<TypeOfForcedTreatment> TypesOfForcedTreatment { get; set; }
        /// <summary>
        /// Таблица случаев лечения
        /// </summary>
        public DbSet<TreatmentCase> Treatments { get; set; }
        /// <summary>
        /// Таблица видов наркологической помощи
        /// </summary>
        public DbSet<TypeOfDrugTreatment> TypeOfDrugTreatments { get; set; }
        /// <summary>
        /// Таблица источников оплаты мед помощи
        /// </summary>
        public DbSet<SourcesOfPaymentForMedicalCare> SourcesOfPaymentForMedicalCares { get; set; }
        /// <summary>
        /// Таблица порядков поступления
        /// </summary>
        public DbSet<OrderOfAdmission> OrderOfAdmissions { get; set; }
        /// <summary>
        /// Таблица путей поступления
        /// </summary>
        public DbSet<PatientEntryRoutes> PatientEntryRoutes { get; set; }
        /// <summary>
        /// Таблица статусов решения судьи по статье 35
        /// </summary>
        public DbSet<StatusOfJudgesDecisionUnderArticle35> StatusOfJudgesDecisionUnderArticle35 { get; set; }
        /// <summary>
        /// Таблица целей направления на лечение
        /// </summary>
        public DbSet<PurposeOfReferralForTreatment> PurposeOfReferralForTreatment { get; set; }
        /// <summary>
        /// Таблица отправивших на госптализацию
        /// </summary>
        public DbSet<WhoSentToHospital> WhoSentToHospital { get; set; }
        /// <summary>
        /// Таблица видов амбулаторного наблюдения
        /// </summary>
        public DbSet<TypeOfOutpatientCare> TypeOfOutpatientCare { get; set; }
        /// <summary>
        /// Таблица мест выбытия
        /// </summary>
        public DbSet<PlaceOfDeparture> PlacesOfDeparture { get; set; }
        /// <summary>
        /// Таблица исходов заболевания
        /// </summary>
        public DbSet<DiseaseOutcome> DiseaseOutcomes { get; set; }
        /// <summary>
        /// Таблица отделений
        /// </summary>
        public DbSet<Department> Departments { get; set; }
        /// <summary>
        /// Таблица профилей мед помощи
        /// </summary>
        public DbSet<MedicalCareProfile> MedicalCareProfiles { get; set; }
        /// <summary>
        /// Таблица мед организаций
        /// </summary>
        public DbSet<MedicalOrganization> MedicalOrganizations { get; set; }
        /// <summary>
        /// Таблица видов мед помощи
        /// </summary>
        public DbSet<TypeOfMedicalCare> TypesOfMedicalCare { get; set; }
        /// <summary>
        /// Таблица диагнозов
        /// </summary>
        public DbSet<Diagnosis> Diagnoses { get; set; }
        /// <summary>
        /// Таблица видов диагнозов
        /// </summary>
        public DbSet<TypeOfDiagnosis> TypesOfDiagnosis { get; set; }
        /// <summary>
        /// Таблица заболеваний
        /// </summary>
        public DbSet<Disease> Diseases { get; set; }
        /// <summary>
        /// Таблица типов заболеваний
        /// </summary>
        public DbSet<TypeOfDisease> TypesOfDisease { get; set; }
        /// <summary>
        /// Справочник МКБ-10
        /// </summary>
        public DbSet<MKB10> MKB10 { get; set; }
        /// <summary>
        /// Таблица "Пациент употребляет"
        /// </summary>
        public DbSet<PatientUseDrugs> PatientUseDrugs { get; set; }
        /// <summary>
        /// Справочник ПАВ
        /// </summary>
        public DbSet<PsychoactiveSubstance> PsychoactiveSubstances { get; set; }
        /// <summary>
        /// Таблица способов употребления ПАВ
        /// </summary>
        public DbSet<MethodOfConsumption> MethodsOfConsumption { get; set; }
        /// <summary>
        /// Таблица видов решения суда о принуд лечении
        /// </summary>
        public DbSet<TypeOfJudgment> TypesOfJudgment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Education)
                .WithMany(e => e.Patients)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Education>()
                .HasOne(e => e.Parent)
                .WithMany(p => p.Educations)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.SourceOfLivelihood)
                .WithMany(s => s.Patients)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Accommodations)
                .WithMany(a => a.Patients)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.CauseOfDisability)
                .WithMany(cd => cd.Patients)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Sex)
                .WithMany(s => s.Patients)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.ParticipationInTheWar)
                .WithMany(pw => pw.Patients)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.ResidenceStatus)
                .WithMany(r => r.Patients)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.DisabilityGroup)
                .WithMany(g => g.Patients)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HivTest>()
                .HasOne(ht => ht.Patient)
                .WithMany(p => p.HivTests)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CertificateOfIncapacityForWork>()
                .HasOne(c => c.Patient)
                .WithMany(p => p.CertificateOfIncapacityForWork)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Policy>()
                .HasOne(pl => pl.Patient)
                .WithMany(p => p.Policies)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Policy>()
                .HasOne(pl => pl.InsuranceOrganization)
                .WithMany(i => i.Policies)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Judgment>()
                .HasOne(j => j.Patient)
                .WithMany(p => p.Judgments)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .Entity<Judgment>()
                .HasOne(j => j.TypeOfJudgment)
                .WithMany(t => t.Judgments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Judgment>()
                .HasOne(j => j.TypeOfForcedTreatment)
                .WithMany(t => t.Judgments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.Patient)
                .WithMany(p => p.Treatments)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.TypeOfDrugTreatment)
                .WithMany(tt => tt.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.SourcesOfPaymentForMedicalCare)
                .WithMany(s => s.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.OrderOfAdmission)
                .WithMany(o => o.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.PatientEntryRoutes)
                .WithMany(p => p.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.StatusOfJudgesDecisionUnderArticle35)
                .WithMany(s => s.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.PurposeOfReferralForTreatment)
                .WithMany(p => p.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.WhoSentToHospital)
                .WithMany(w => w.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.TypeOfOutpatientCare)
                .WithMany(tc => tc.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.PlaceOfDeparture)
                .WithMany(p => p.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.DiseaseOutcome)
                .WithMany(d => d.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TreatmentCase>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Treatments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Diagnosis>()
                .HasOne(d => d.TreatmentCase)
                .WithMany(t => t.Diagnoses)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Profile)
                .WithMany(p => p.Departments)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.MedicalOrganization)
                .WithMany(m => m.Departments)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TypeOfMedicalCare>()
                .HasOne(m => m.Parent)
                .WithMany(p => p.MedicalCares)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Diagnosis>()
                .HasOne(d => d.TypeOfDiagnosis)
                .WithMany(t => t.Diagnosis)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Disease>()
                .HasOne(d => d.Diagnosis)
                .WithMany(d => d.Diseases)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Disease>()
                .HasOne(d => d.TypeOfDisease)
                .WithMany(t => t.Diseases)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Disease>()
                .HasOne(d => d.Mkb10)
                .WithMany(m => m.Diseases)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<MKB10>()
                .HasOne(m => m.Parent)
                .WithMany(p => p.Children)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<PatientUseDrugs>()
                .HasKey(t => new { t.PatientId, t.PatientSubstanceId });
            modelBuilder.Entity<PatientUseDrugs>()
                .HasOne(d => d.Patient)
                .WithMany(p => p.PatientUseDrugs)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PatientUseDrugs>()
                .HasOne(d => d.PatientSubstance)
                .WithMany(s => s.PatientUseDrugs)
                .HasForeignKey(d => d.PatientSubstanceId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<PatientUseDrugs>()
                .HasOne(d => d.MethodOfConsumption)
                .WithMany(m => m.PatientUseDrugs)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
