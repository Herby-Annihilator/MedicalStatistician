using MedicalStatistician.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Причины инвалидности
    /// </summary>
    public class CauseOfDisability : NamedEntity
    {
        /// <summary>
        /// Пациенты с данной причиной инвалидности
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
