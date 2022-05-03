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
    /// Место выбытия (домой, в другой стационар, ...)
    /// </summary>
    public class PlaceOfDeparture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название места выбытия
        /// </summary>
        [MaxLength(512)]
        public string Name { get; set; } = "";

        /// <summary>
        /// Выписки в данное место
        /// </summary>
        public ICollection<Discharge>? Discharges { get; set; }
    }
}
