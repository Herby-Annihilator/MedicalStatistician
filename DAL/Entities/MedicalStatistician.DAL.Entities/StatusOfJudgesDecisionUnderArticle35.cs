using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Статус решения судьи по статье 35
    /// </summary>
    public class StatusOfJudgesDecisionUnderArticle35 : NamedEntity
    {
        /// <summary>
        /// Случаи лечения с данным решением судьи по статье 35
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
