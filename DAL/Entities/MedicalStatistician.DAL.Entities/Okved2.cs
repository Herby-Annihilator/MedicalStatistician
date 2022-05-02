using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// ОКВЭД2
    /// </summary>
    public class Okved2
    {
        public int Id { get; set; }
        /// <summary>
        /// Раздел общероссийского классификатора видов экономической деятельности
        /// </summary>
        [MaxLength(1)]
        public string SectionName { get; set; } = "A";
        /// <summary>
        /// Код по общероссийскому классификатору видов экономической деятельности
        /// </summary>
        [MaxLength(100)]
        public string Code { get; set; } = "";
        /// <summary>
        /// Наименование по общероссийскому классификатору видов экономической деятельности
        /// </summary>
        [MaxLength(2048)]
        public string Name { get; set; } = "";
    }
}
