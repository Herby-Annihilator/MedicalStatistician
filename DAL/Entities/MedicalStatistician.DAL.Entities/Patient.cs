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
    /// Пациент
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Имя (макс. длина 300)
        /// </summary>
        [MaxLength(300)]
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Фамилия (макс. длина 300)
        /// </summary>
        [MaxLength(300)]
        public string LastName { get; set; } = "";

        /// <summary>
        /// Отчество (макс. длина 300). Необязательное свойство
        /// </summary>
        [MaxLength(300)]
        public string? Patronymic { get; set; }

        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Признак использования чужих шприцов
        /// </summary>
        public bool IsUsedOthersSyringes { get; set; } = false;
        /// <summary>
        /// Признак проживания с наркоманом
        /// </summary>
        public bool IsLivesWithAddict { get; set; } = false;
        /// <summary>
        /// Коллекция стат. карт этого пациента
        /// </summary>
        public ICollection<StatisticalCard> StatisticalCards { get; set; }
    }
}
