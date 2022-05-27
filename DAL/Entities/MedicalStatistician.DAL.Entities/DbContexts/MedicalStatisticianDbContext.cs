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

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<CertificateOfIncapacityForWork> CertificateOfIncapacityForWorks { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<SourceOfLivelihood> SourcesOfLivelihood { get; set; }
        public DbSet<Accommodations> Accommodations { get; set; }
        public DbSet<CauseOfDisability> CausesOfDisabilitiy { get; set; }
        public DbSet<ParticipationInTheWar> ParticipationInTheWars { get; set; }
        public DbSet<ResidenceStatus> ResidenceStatuses { get; set; }
        public DbSet<DisabilityGroup> DisabilityGroups { get; set; }
        public DbSet<HivTest> HivTests { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<InsuranceOrganization> InsuranceOrganizations { get; set; }
        public DbSet<Judgment> Judgments { get; set; }
        public DbSet<TypeOfForcedTreatment> TypesOfForcedTreatment { get; set; }
        public DbSet<TreatmentCase> Treatments { get; set; }
        public DbSet<TypeOfDrugTreatment> TypeOfDrugTreatments { get; set; }
        public DbSet<SourcesOfPaymentForMedicalCare> SourcesOfPaymentForMedicalCares { get; set; }
        public DbSet<OrderOfAdmission> OrderOfAdmissions { get; set; }
        public DbSet<PatientEntryRoutes> PatientEntryRoutes { get; set; }
        public DbSet<StatusOfJudgesDecisionUnderArticle35> StatusOfJudgesDecisionUnderArticle35 { get; set; }
        public DbSet<PurposeOfReferralForTreatment> PurposeOfReferralForTreatment { get; set; }
        public DbSet<WhoSentToHospital> WhoSentToHospital { get; set; }
        public DbSet<TypeOfOutpatientCare> TypeOfOutpatientCare { get; set; }
        public DbSet<PlaceOfDeparture> PlacesOfDeparture { get; set; }
        public DbSet<DiseaseOutcome> DiseaseOutcomes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<MedicalCareProfile> MedicalCareProfiles { get; set; }
        public DbSet<MedicalOrganization> MedicalOrganizations { get; set; }
        public DbSet<TypeOfMedicalCare> TypesOfMedicalCare { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<TypeOfDiagnosis> TypesOfDiagnosis { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<TypeOfDisease> TypesOfDisease { get; set; }
        public DbSet<MKB10> MKB10 { get; set; }
        public DbSet<PatientUseDrugs> PatientUseDrugs { get; set; }
        public DbSet<PsychoactiveSubstance> PsychoactiveSubstances { get; set; }
        public DbSet<MethodOfConsumption> MethodsOfConsumption { get; set; }
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
