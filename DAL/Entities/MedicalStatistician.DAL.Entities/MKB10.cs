using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// МКБ - 10
    /// </summary>
    public class MKB10
    {
        public int Id { get; set; }
        /// <summary>
        /// Поле сортировки. Макс. длина 20
        /// </summary>
        [MaxLength(20)]
        public string RecCode { get; set; } = "";
        /// <summary>
        /// Код болезни по МКБ, например, F145 (длина 20)
        /// </summary>
        [MaxLength(20)]
        public string MkbCode { get; set; } = "";
        /// <summary>
        /// Имя болезни. Макс. длина 1024
        /// </summary>
        [MaxLength(1024)]
        public string MkbName { get; set; } = "";
        /// <summary>
        /// Родительская запись
        /// </summary>
        public MKB10? Parent { get; set; }
        /// <summary>
        /// Ключ родительской записи
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// Дочерние записи
        /// </summary>
        public ICollection<MKB10>? Children { get; set; }

        /// <summary>
        /// Дополнительный код, используется только в записях МКБ, предусматривающих двойное кодирование.
        /// Данное поле является числовым и может содержать код 1 или 2;
        /// </summary>
        public int? AdditionalCode { get; set; }
        /// <summary>
        /// Признак актуальности, Целочисленный, числовой код.
        /// Используется для обозначения актуальности записи. Может содержать значение 1 или 0;
        /// </summary>
        public int Actual { get; set; } = 1;
        /// <summary>
        /// Дата изменения актуальности, Дата, отражает дату начала работы изменений:
        /// внесенной новой записи или исключенной ранее существующей записи, в ходе текущей и последующих
        /// актуализаций справочника. Для записей МКБ, существовавших ранее в версии справочника 1.1 ,
        /// поле DATE остается пустым;
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// Коллекция заболеваний пациентов с данным МКБ кодом
        /// </summary>
        public ICollection<Disease>? Diseases { get; set; }
        /// <summary>
        /// Выписки пациентов, причиной смерти которых стало это заболевание
        /// </summary>
        public ICollection<Discharge>? DischargesWhenPatientWasDie { get; set; } 
    }
}
