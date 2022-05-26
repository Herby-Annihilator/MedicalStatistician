using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities.Base
{
    /// <summary>
    /// Именованая сущность - основа для большинства справочников
    /// </summary>
    public class NamedEntity : Entity
    {
        /// <summary>
        /// Имя сущности, либо формулировка
        /// </summary>
        public string Name { get; set; } = "";
    }
}
