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
    public class InsuranceOrganization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название организации
        /// </summary>
        [MaxLength(512)]
        public string Name { get; set; } = "";
        /// <summary>
        /// Полисы, которые выдала данная организация
        /// </summary>
        public ICollection<Policy> Policies { get; set; }
    }
}
