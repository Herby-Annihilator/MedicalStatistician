using MedicalStatistician.DAL.Entities;
using MedicalStatistician.Reports.Base;
using MedicalStatistician.Reports.Exporters.Base;

namespace MedicalStatistician.Reports
{
    /// <summary>
    /// Контингент больных, находящихся под активным диспансерным наблюденим (АДН). Таблица 2100
    /// </summary>
    public class ActiveDispensaryObservation : IReport
    {
        /// <summary>
        /// Наименование болезни
        /// </summary>
        public string DeseaseName { get; set; } = "";
        /// <summary>
        /// Индекс строки в отчете. Начало с 1.
        /// </summary>
        public int RowIndex { get; set; } = 1;
        /// <summary>
        /// Всего взято под АДН в отчетном году
        /// </summary>
        public int TotalTakenUnderActiveDispensaryObservation { get; set; }
        /// <summary>
        /// Кол-во детей, взятых под АДН в отчетном году
        /// </summary>
        public int ChildrenTakenUnderActiveDispensaryObservation { get; set; }
        /// <summary>
        /// Кол-во снятых с АДН
        /// </summary>
        public int TotalRemovedFromActiveDispensaryObservation { get; set; }
        /// <summary>
        /// Кол-во снятых с АДН в связи со снижением общественной опасности
        /// </summary>
        public int WithdrawnFromActiveDispensaryObservationDueToADecreaseInPublicDanger { get; set; }
        /// <summary>
        /// Всего состоит на АДН на конец отчетного года
        /// </summary>
        public int TotalCountOfPeopleOnAdnAtTheEndOfTheReportingYear { get; set; }
        /// <summary>
        /// Количество детей на АДН на конец отчетного года
        /// </summary>
        public int ChildrenOnAdnAtTheEndOfTheReportingYear { get; set; }
        /// <summary>
        /// Кол-во состоящих на АДН и совершивших ООД в течении жизни
        /// </summary>
        public int AreOnAdnAtTheEndOfTheReportingYearAndHaveCommittedOodDuringTheirLifetime { get; set; }
        /// <summary>
        /// Кол-во состоящих на АДН и совершивших ООД в течении жизни, в том числе и в отчетном году
        /// </summary>
        public int AreOnAdnAtTheEndOfTheReportingYearAndHaveCommittedOodDuringTheirLifetimeAndAtTheReportingYear { get; set; }
        /// <summary>
        /// Кол-во состоящих на АДН и совершивших ООД в течении жизни, но до этого не находились на АДН
        /// </summary>
        public int AreOnAdnAtTheEndOfTheReportingYearAndHaveCommittedOodDuringTheirLifetimeButWereNotOnAdn { get; set; }

        public void Export(string path, IExporter exporter)
        {
            exporter.Export(path, this);
        }
    }
}
