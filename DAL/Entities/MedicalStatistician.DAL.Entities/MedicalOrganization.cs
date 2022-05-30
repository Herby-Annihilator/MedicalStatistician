using MedicalStatistician.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Медицинская организация
    /// </summary>
    public class MedicalOrganization : NamedEntity
    {
        /// <summary>
        /// Отделения
        /// </summary>
        public ICollection<Department>? Departments { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; } = "";
        /// <summary>
        /// Код ОКАТО
        /// </summary>
        public string OkatoCode { get; set; } = "";
        /// <summary>
        /// Код ОКОГУ
        /// </summary>
        public string OkogyCode { get; set; } = "";
        /// <summary>
        /// Код ОКВЭД2
        /// </summary>
        public string Okved2Code { get; set; } = "";
        /// <summary>
        /// Код ОКОПФ
        /// </summary>
        public string OkopfCode { get; set; } = "";
        /// <summary>
        /// Код ОКФС
        /// </summary>
        public string OkfsCode { get; set; } = "";
        /// <summary>
        /// Код ОКТМО
        /// </summary>
        public string OktmoCode { get; set; } = "";
        /// <summary>
        /// Виды мед помощи, которые оказывает данное учреждение
        /// </summary>
        public ICollection<TypeOfMedicalCare> TypesOfMedicalCare { get; set; }

    }
}
