using MedicalStatistician.Reports.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.Reports.ReportCreators.Base
{
    /// <summary>
    /// Создатель отчетов
    /// </summary>
    public interface IReportCreator
    {
        /// <summary>
        /// Создает новый отчет
        /// </summary>
        /// <param name="startDate">Дата начала отчетного периода</param>
        /// <param name="endDate">Дата окончания отчетного периода</param>
        /// <returns></returns>
        Task<IReport> CreateReportAsync(DateTime startDate, DateTime endDate);
    }
}
