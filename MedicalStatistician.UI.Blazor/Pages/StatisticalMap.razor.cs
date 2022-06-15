using MedicalStatistician.DAL.Entities;

namespace MedicalStatistician.UI.Blazor.Pages
{
    public partial class StatisticalMap
    {
        /// <summary>
        /// Модель данных
        /// </summary>
        ViewModel model = new();

        //
        // Списки данных из базы
        //
        IList<Sex>? sexCollection;
        IList<SourcesOfPaymentForMedicalCare>? typesOfPaymentCollection;
        IList<WhoSentToHospital>? sentByWhomCollection;
        IList<OrderOfAdmission>? admissionProcedureCollection;
        IList<StatusOfJudgesDecisionUnderArticle35>? judgesDecisionOnArticle35Collection;
        IList<PatientEntryRoutes>? whereDidHeComeFromCollection;
        IList<PurposeOfReferralForTreatment>? purposeOfTheDirectionCollection;
        IList<DisabilityGroup>? disabilityGroupCollection;
        IList<PlaceOfDeparture>? leaveCollection;
        IList<CauseOfDeath>? deathHasOccurredCollection;
        IList<TypeOfOutpatientCare>? typeOfOutpatientObservationCollection;
        IList<Education>? educationCollection;
        IList<SourceOfLivelihood>? sourceOfLivelihoodCollection;
        IList<ResidenceStatus>? livesCollection;
        IList<Accommodations>? livingConditionsCollection;
        IList<DiseaseOutcome>? outcomeOfTheDiseaseCollection;

        /// <summary>
        /// Инициализация списков
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            sexCollection = (await sexCatalog.GetAllAsync()).ToList();
            typesOfPaymentCollection = (await sourcesOfPaymentForMedicalCareCatalog.GetAllAsync()).ToList();
            sentByWhomCollection = (await whoSentToHospitalCatalog.GetAllAsync()).ToList();
            admissionProcedureCollection = (await orderOfAdmissionCatalog.GetAllAsync()).ToList();
            judgesDecisionOnArticle35Collection = (await statusOfJudgesDecisionUnderArticle35Catalog.GetAllAsync()).ToList();
            whereDidHeComeFromCollection = (await patientEntryRoutesCatalog.GetAllAsync()).ToList();
            purposeOfTheDirectionCollection = (await purposeTreatmentCatalog.GetAllAsync()).ToList();
            disabilityGroupCollection = (await invalidGroupCatalog.GetAllAsync()).ToList();
            leaveCollection = (await placeOfDepartureCatalog.GetAllAsync()).ToList();
            deathHasOccurredCollection = (await causeOfDeathCatalog.GetAllAsync()).ToList();
            typeOfOutpatientObservationCollection = (await typeOfOutpatientCareCatalog.GetAllAsync()).ToList();
            educationCollection = (await educationCatalog.GetAllAsync()).ToList();
            sourceOfLivelihoodCollection = (await sourceOfLivelihoodCatalog.GetAllAsync()).ToList();
            livesCollection = (await residenceStatusCatalog.GetAllAsync()).ToList();
            livingConditionsCollection = (await accommodationsCatalog.GetAllAsync()).ToList();
            outcomeOfTheDiseaseCollection = (await diseaseOutcomeCatalog.GetAllAsync()).ToList();
        }

        //
        // Методы
        //
        void Add() => model.HistoryOfCompulsoryTreatments.Add(new ViewModel.HistoryOfCompulsoryTreatment());
        void Sub() => model.HistoryOfCompulsoryTreatments.RemoveAt(model.HistoryOfCompulsoryTreatments.Count - 1);

        /// <summary>
        /// Сохранение стат. карты
        /// </summary>
        void Save()
        {

        }
    }
}
