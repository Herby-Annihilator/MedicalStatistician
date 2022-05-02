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
    /// Статья УК РФ
    /// </summary>
    public class CriminalCodeArticle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Шифр (код) статьи
        /// </summary>
        [MaxLength(100)]
        public string Code { get; set; } = "";
        /// <summary>
        /// Краткое описание
        /// </summary>
        [MaxLength(1000)]
        public string? ShortDescription { get; set; }
    }
}
