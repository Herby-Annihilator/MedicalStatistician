using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MedicalStatistician.DAL.Entities.Migrations
{
    public partial class _initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accommodations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommodations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CauseOfDeath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauseOfDeath", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CausesOfDisabilitiy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CausesOfDisabilitiy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisabilityGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisabilityGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiseaseOutcomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseaseOutcomes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsActual = table.Column<bool>(type: "boolean", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Educations_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceOrganizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCareProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCareProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(type: "text", nullable: false),
                    OkatoCode = table.Column<string>(type: "text", nullable: false),
                    OkogyCode = table.Column<string>(type: "text", nullable: false),
                    Okved2Code = table.Column<string>(type: "text", nullable: false),
                    OkopfCode = table.Column<string>(type: "text", nullable: false),
                    OkfsCode = table.Column<string>(type: "text", nullable: false),
                    OktmoCode = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalOrganizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MethodsOfConsumption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MethodsOfConsumption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MKB10",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    MkbCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    MkbName = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    AdditionalCode = table.Column<int>(type: "integer", nullable: true),
                    Actual = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MKB10", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MKB10_MKB10_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MKB10",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OrderOfAdmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderOfAdmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipationInTheWars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipationInTheWars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientEntryRoutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientEntryRoutes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlacesOfDeparture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesOfDeparture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PsychoactiveSubstances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsychoactiveSubstances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurposeOfReferralForTreatment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurposeOfReferralForTreatment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResidenceStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourcesOfLivelihood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourcesOfLivelihood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourcesOfPaymentForMedicalCares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourcesOfPaymentForMedicalCares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusOfJudgesDecisionUnderArticle35",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusOfJudgesDecisionUnderArticle35", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfDrugTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfDrugTreatments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfOutpatientCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfOutpatientCare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfDiagnosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfDiagnosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfDisease",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfDisease", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfForcedTreatment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfForcedTreatment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfJudgment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfJudgment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfMedicalCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SortColumn = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfMedicalCare", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypesOfMedicalCare_TypesOfMedicalCare_ParentId",
                        column: x => x.ParentId,
                        principalTable: "TypesOfMedicalCare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "WhoSentToHospital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhoSentToHospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    ProfileId = table.Column<int>(type: "integer", nullable: false),
                    MedicalOrganizationId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_MedicalCareProfiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "MedicalCareProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Departments_MedicalOrganizations_MedicalOrganizationId",
                        column: x => x.MedicalOrganizationId,
                        principalTable: "MedicalOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    LastName = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Patronymic = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FirstConyactWithNarcologist = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsUsedOthersSyringes = table.Column<bool>(type: "boolean", nullable: false),
                    IsLivesWithAddict = table.Column<bool>(type: "boolean", nullable: false),
                    DisabilityGroupId = table.Column<int>(type: "integer", nullable: true),
                    CauseOfDisabilityId = table.Column<int>(type: "integer", nullable: true),
                    SexId = table.Column<int>(type: "integer", nullable: false),
                    EducationId = table.Column<int>(type: "integer", nullable: false),
                    ResidenceStatusId = table.Column<int>(type: "integer", nullable: false),
                    ParticipationInTheWarId = table.Column<int>(type: "integer", nullable: true),
                    SourceOfLivelihoodId = table.Column<int>(type: "integer", nullable: true),
                    AccommodationsId = table.Column<int>(type: "integer", nullable: false),
                    NumberOfCompletedClasses = table.Column<int>(type: "integer", nullable: false),
                    IsStudies = table.Column<bool>(type: "boolean", nullable: false),
                    DateOfOnsetOfIllness = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Accommodations_AccommodationsId",
                        column: x => x.AccommodationsId,
                        principalTable: "Accommodations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Patients_CausesOfDisabilitiy_CauseOfDisabilityId",
                        column: x => x.CauseOfDisabilityId,
                        principalTable: "CausesOfDisabilitiy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Patients_DisabilityGroups_DisabilityGroupId",
                        column: x => x.DisabilityGroupId,
                        principalTable: "DisabilityGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_ParticipationInTheWars_ParticipationInTheWarId",
                        column: x => x.ParticipationInTheWarId,
                        principalTable: "ParticipationInTheWars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Patients_ResidenceStatuses_ResidenceStatusId",
                        column: x => x.ResidenceStatusId,
                        principalTable: "ResidenceStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Sex_SexId",
                        column: x => x.SexId,
                        principalTable: "Sex",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_SourcesOfLivelihood_SourceOfLivelihoodId",
                        column: x => x.SourceOfLivelihoodId,
                        principalTable: "SourcesOfLivelihood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalOrganizationTypeOfMedicalCare",
                columns: table => new
                {
                    MedicalOrganizationsId = table.Column<int>(type: "integer", nullable: false),
                    TypesOfMedicalCareId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalOrganizationTypeOfMedicalCare", x => new { x.MedicalOrganizationsId, x.TypesOfMedicalCareId });
                    table.ForeignKey(
                        name: "FK_MedicalOrganizationTypeOfMedicalCare_MedicalOrganizations_M~",
                        column: x => x.MedicalOrganizationsId,
                        principalTable: "MedicalOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalOrganizationTypeOfMedicalCare_TypesOfMedicalCare_Typ~",
                        column: x => x.TypesOfMedicalCareId,
                        principalTable: "TypesOfMedicalCare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificateOfIncapacityForWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateOfIncapacityForWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CertificateOfIncapacityForWorks_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HivTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPositive = table.Column<bool>(type: "boolean", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HivTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HivTests_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Judgments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TypeOfForcedTreatmentId = table.Column<int>(type: "integer", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    TypeOfJudgmentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judgments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Judgments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Judgments_TypesOfForcedTreatment_TypeOfForcedTreatmentId",
                        column: x => x.TypeOfForcedTreatmentId,
                        principalTable: "TypesOfForcedTreatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Judgments_TypesOfJudgment_TypeOfJudgmentId",
                        column: x => x.TypeOfJudgmentId,
                        principalTable: "TypesOfJudgment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientUseDrugs",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    PatientSubstanceId = table.Column<int>(type: "integer", nullable: false),
                    MethodOfConsumptionId = table.Column<int>(type: "integer", nullable: false),
                    StartUseDrugsAge = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientUseDrugs", x => new { x.PatientId, x.PatientSubstanceId });
                    table.ForeignKey(
                        name: "FK_PatientUseDrugs_MethodsOfConsumption_MethodOfConsumptionId",
                        column: x => x.MethodOfConsumptionId,
                        principalTable: "MethodsOfConsumption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientUseDrugs_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientUseDrugs_PsychoactiveSubstances_PatientSubstanceId",
                        column: x => x.PatientSubstanceId,
                        principalTable: "PsychoactiveSubstances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Series = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    Number = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false),
                    IsActual = table.Column<bool>(type: "boolean", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    InsuranceOrganizationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Policies_InsuranceOrganizations_InsuranceOrganizationId",
                        column: x => x.InsuranceOrganizationId,
                        principalTable: "InsuranceOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Policies_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    NumberOfWorkingDaysInLtm = table.Column<int>(type: "integer", nullable: false),
                    NumberOfMedicalHolidays = table.Column<int>(type: "integer", nullable: false),
                    NumberOfMedicalLeaveDays = table.Column<int>(type: "integer", nullable: false),
                    StatisticalCardNumber = table.Column<string>(type: "text", nullable: false),
                    MedicalCardNumber = table.Column<string>(type: "text", nullable: false),
                    ReceiptDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RetirementDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TypeOfDrugTreatmentId = table.Column<int>(type: "integer", nullable: false),
                    SourcesOfPaymentForMedicalCareId = table.Column<int>(type: "integer", nullable: false),
                    OrderOfAdmissionId = table.Column<int>(type: "integer", nullable: false),
                    WhoSentToHospitalId = table.Column<int>(type: "integer", nullable: false),
                    PurposeOfReferralForTreatmentId = table.Column<int>(type: "integer", nullable: false),
                    PatientEntryRoutesId = table.Column<int>(type: "integer", nullable: false),
                    StatusOfJudgesDecisionUnderArticle35Id = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: false),
                    DiseaseOutcomeId = table.Column<int>(type: "integer", nullable: false),
                    PlaceOfDepartureId = table.Column<int>(type: "integer", nullable: false),
                    TypeOfOutpatientCareId = table.Column<int>(type: "integer", nullable: false),
                    CauseOfDeathId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_CauseOfDeath_CauseOfDeathId",
                        column: x => x.CauseOfDeathId,
                        principalTable: "CauseOfDeath",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_DiseaseOutcomes_DiseaseOutcomeId",
                        column: x => x.DiseaseOutcomeId,
                        principalTable: "DiseaseOutcomes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_OrderOfAdmissions_OrderOfAdmissionId",
                        column: x => x.OrderOfAdmissionId,
                        principalTable: "OrderOfAdmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_PatientEntryRoutes_PatientEntryRoutesId",
                        column: x => x.PatientEntryRoutesId,
                        principalTable: "PatientEntryRoutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatments_PlacesOfDeparture_PlaceOfDepartureId",
                        column: x => x.PlaceOfDepartureId,
                        principalTable: "PlacesOfDeparture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_PurposeOfReferralForTreatment_PurposeOfReferralF~",
                        column: x => x.PurposeOfReferralForTreatmentId,
                        principalTable: "PurposeOfReferralForTreatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_SourcesOfPaymentForMedicalCares_SourcesOfPayment~",
                        column: x => x.SourcesOfPaymentForMedicalCareId,
                        principalTable: "SourcesOfPaymentForMedicalCares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_StatusOfJudgesDecisionUnderArticle35_StatusOfJud~",
                        column: x => x.StatusOfJudgesDecisionUnderArticle35Id,
                        principalTable: "StatusOfJudgesDecisionUnderArticle35",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_TypeOfDrugTreatments_TypeOfDrugTreatmentId",
                        column: x => x.TypeOfDrugTreatmentId,
                        principalTable: "TypeOfDrugTreatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_TypeOfOutpatientCare_TypeOfOutpatientCareId",
                        column: x => x.TypeOfOutpatientCareId,
                        principalTable: "TypeOfOutpatientCare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_WhoSentToHospital_WhoSentToHospitalId",
                        column: x => x.WhoSentToHospitalId,
                        principalTable: "WhoSentToHospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeOfDiagnosisId = table.Column<int>(type: "integer", nullable: false),
                    TreatmentCaseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnoses_Treatments_TreatmentCaseId",
                        column: x => x.TreatmentCaseId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diagnoses_TypesOfDiagnosis_TypeOfDiagnosisId",
                        column: x => x.TypeOfDiagnosisId,
                        principalTable: "TypesOfDiagnosis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Mkb10Id = table.Column<int>(type: "integer", nullable: true),
                    DiagnosisId = table.Column<int>(type: "integer", nullable: false),
                    TypeOfDiseaseId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diseases_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diseases_MKB10_Mkb10Id",
                        column: x => x.Mkb10Id,
                        principalTable: "MKB10",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Diseases_TypesOfDisease_TypeOfDiseaseId",
                        column: x => x.TypeOfDiseaseId,
                        principalTable: "TypesOfDisease",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificateOfIncapacityForWorks_PatientId",
                table: "CertificateOfIncapacityForWorks",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MedicalOrganizationId",
                table: "Departments",
                column: "MedicalOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ProfileId",
                table: "Departments",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_TreatmentCaseId",
                table: "Diagnoses",
                column: "TreatmentCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_TypeOfDiagnosisId",
                table: "Diagnoses",
                column: "TypeOfDiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_DiagnosisId",
                table: "Diseases",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_Mkb10Id",
                table: "Diseases",
                column: "Mkb10Id");

            migrationBuilder.CreateIndex(
                name: "IX_Diseases_TypeOfDiseaseId",
                table: "Diseases",
                column: "TypeOfDiseaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ParentId",
                table: "Educations",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_HivTests_PatientId",
                table: "HivTests",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Judgments_PatientId",
                table: "Judgments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Judgments_TypeOfForcedTreatmentId",
                table: "Judgments",
                column: "TypeOfForcedTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Judgments_TypeOfJudgmentId",
                table: "Judgments",
                column: "TypeOfJudgmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalOrganizationTypeOfMedicalCare_TypesOfMedicalCareId",
                table: "MedicalOrganizationTypeOfMedicalCare",
                column: "TypesOfMedicalCareId");

            migrationBuilder.CreateIndex(
                name: "IX_MKB10_ParentId",
                table: "MKB10",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AccommodationsId",
                table: "Patients",
                column: "AccommodationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CauseOfDisabilityId",
                table: "Patients",
                column: "CauseOfDisabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DisabilityGroupId",
                table: "Patients",
                column: "DisabilityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_EducationId",
                table: "Patients",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ParticipationInTheWarId",
                table: "Patients",
                column: "ParticipationInTheWarId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ResidenceStatusId",
                table: "Patients",
                column: "ResidenceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SexId",
                table: "Patients",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_SourceOfLivelihoodId",
                table: "Patients",
                column: "SourceOfLivelihoodId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientUseDrugs_MethodOfConsumptionId",
                table: "PatientUseDrugs",
                column: "MethodOfConsumptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientUseDrugs_PatientSubstanceId",
                table: "PatientUseDrugs",
                column: "PatientSubstanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_InsuranceOrganizationId",
                table: "Policies",
                column: "InsuranceOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PatientId",
                table: "Policies",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_CauseOfDeathId",
                table: "Treatments",
                column: "CauseOfDeathId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DepartmentId",
                table: "Treatments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DiseaseOutcomeId",
                table: "Treatments",
                column: "DiseaseOutcomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_OrderOfAdmissionId",
                table: "Treatments",
                column: "OrderOfAdmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_PatientEntryRoutesId",
                table: "Treatments",
                column: "PatientEntryRoutesId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_PatientId",
                table: "Treatments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_PlaceOfDepartureId",
                table: "Treatments",
                column: "PlaceOfDepartureId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_PurposeOfReferralForTreatmentId",
                table: "Treatments",
                column: "PurposeOfReferralForTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_SourcesOfPaymentForMedicalCareId",
                table: "Treatments",
                column: "SourcesOfPaymentForMedicalCareId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_StatusOfJudgesDecisionUnderArticle35Id",
                table: "Treatments",
                column: "StatusOfJudgesDecisionUnderArticle35Id");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TypeOfDrugTreatmentId",
                table: "Treatments",
                column: "TypeOfDrugTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TypeOfOutpatientCareId",
                table: "Treatments",
                column: "TypeOfOutpatientCareId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_WhoSentToHospitalId",
                table: "Treatments",
                column: "WhoSentToHospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfMedicalCare_ParentId",
                table: "TypesOfMedicalCare",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateOfIncapacityForWorks");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "HivTests");

            migrationBuilder.DropTable(
                name: "Judgments");

            migrationBuilder.DropTable(
                name: "MedicalOrganizationTypeOfMedicalCare");

            migrationBuilder.DropTable(
                name: "PatientUseDrugs");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "MKB10");

            migrationBuilder.DropTable(
                name: "TypesOfDisease");

            migrationBuilder.DropTable(
                name: "TypesOfForcedTreatment");

            migrationBuilder.DropTable(
                name: "TypesOfJudgment");

            migrationBuilder.DropTable(
                name: "TypesOfMedicalCare");

            migrationBuilder.DropTable(
                name: "MethodsOfConsumption");

            migrationBuilder.DropTable(
                name: "PsychoactiveSubstances");

            migrationBuilder.DropTable(
                name: "InsuranceOrganizations");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "TypesOfDiagnosis");

            migrationBuilder.DropTable(
                name: "CauseOfDeath");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "DiseaseOutcomes");

            migrationBuilder.DropTable(
                name: "OrderOfAdmissions");

            migrationBuilder.DropTable(
                name: "PatientEntryRoutes");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PlacesOfDeparture");

            migrationBuilder.DropTable(
                name: "PurposeOfReferralForTreatment");

            migrationBuilder.DropTable(
                name: "SourcesOfPaymentForMedicalCares");

            migrationBuilder.DropTable(
                name: "StatusOfJudgesDecisionUnderArticle35");

            migrationBuilder.DropTable(
                name: "TypeOfDrugTreatments");

            migrationBuilder.DropTable(
                name: "TypeOfOutpatientCare");

            migrationBuilder.DropTable(
                name: "WhoSentToHospital");

            migrationBuilder.DropTable(
                name: "MedicalCareProfiles");

            migrationBuilder.DropTable(
                name: "MedicalOrganizations");

            migrationBuilder.DropTable(
                name: "Accommodations");

            migrationBuilder.DropTable(
                name: "CausesOfDisabilitiy");

            migrationBuilder.DropTable(
                name: "DisabilityGroups");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "ParticipationInTheWars");

            migrationBuilder.DropTable(
                name: "ResidenceStatuses");

            migrationBuilder.DropTable(
                name: "Sex");

            migrationBuilder.DropTable(
                name: "SourcesOfLivelihood");
        }
    }
}
