using MedicalStatistician.DAL.Entities.Base;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Вид решения суда по принудительному лечению
    /// </summary>
    public class TypeOfJudgment : NamedEntity
    {
        /// <summary>
        /// Коллекция решений суда с данным типом
        /// </summary>
        public ICollection<Judgment>? Judgments { get; set; }
    }
}
