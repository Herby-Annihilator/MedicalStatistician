using MedicalStatistician.DAL.Entities.Base;
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
    /// Страховая мед организация
    /// </summary>
    public class InsuranceOrganization : NamedEntity
    {
        /// <summary>
        /// Полисы, которые выдала данная организация
        /// </summary>
        public ICollection<Policy> Policies { get; set; }
    }
}
