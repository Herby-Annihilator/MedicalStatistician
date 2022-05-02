﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStatistician.DAL.Entities
{
    /// <summary>
    /// Психоактивное вещество (ПАВ)
    /// </summary>
    public class PsychoactiveSubstance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название психоактивного вещества
        /// </summary>
        [MaxLength(512)]
        public string Name { get; set; } = "";
        /// <summary>
        /// Коллекция обдолбанных пациентов
        /// </summary>
        public ICollection<Patient>? Patients { get; set; }
        /// <summary>
        /// Коллекция способов обдалбывания со ссылкой на пациента-обдолбыша
        /// </summary>
        public ICollection<PatientUseDrugs>? PatientUseDrugs { get; set; }
    }
}
