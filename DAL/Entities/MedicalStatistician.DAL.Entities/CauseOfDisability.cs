using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Причины инвалидности
    /// </summary>
    public class CauseOfDisability
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; } = "";
        /// <summary>
        /// Пациенты с данной причиной инвалидности
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
    }
}
