using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    public class Okato
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Код региона (2)
        /// </summary>
        [MaxLength(2)]
        public string RegionCode { get; set; } = "00";

        /// <summary>
        /// Код района/города,varchar(3)
        /// </summary>
        [MaxLength(3)]
        public string AreaCode { get; set; } = "000";

        /// <summary>
        /// Код рабочего поселка/сельсовета,varchar(3)
        /// </summary>
        [MaxLength(3)]
        public string WorkingVillageCode { get; set; } = "000";

        /// <summary>
        /// Код сельского населенного пункта,varchar(3)
        /// </summary>
        [MaxLength(3)]
        public string RuralLocalityCode { get; set; } = "000";

        /// <summary>
        /// Код раздела,varchar(1)
        /// </summary>
        [MaxLength(1)]
        public string SectionCode { get; set; } = "0";

        /// <summary>
        /// Наименование территории,varchar(250)
        /// </summary>
        [MaxLength(250)]
        public string SiteName { get; set; } = "";

        /// <summary>
        /// Дополнительная информация,varchar(80)
        /// </summary>
        [MaxLength(80)]
        public string AdditionalInformation { get; set; } = "";

        /// <summary>
        /// Описание,varchar(8000)
        /// </summary>
        [MaxLength(8000)]
        public string Description { get; set; } = "";

        /// <summary>
        /// Номер изменения,numerek(3)
        /// </summary>
        public int ChangeNumber { get; set; }

        /// <summary>
        /// Тип изменения,numerek(1)
        /// </summary>
        public int ChangeType { get; set; }

        /// <summary>
        /// Дата принятия,data(10)
        /// </summary>
        public DateTime DateOfAdoption { get; set; } = DateTime.Now;
        /// <summary>
        /// Дата введения,data(10)
        /// </summary>
        public DateTime IntroductionDate { get; set; } = DateTime.Now;
    }
}
