﻿using MedicalStatistician.DAL.Entities.Base;
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
    /// Цель направления на лечение
    /// </summary>
    public class PurposeOfReferralForTreatment : NamedEntity
    {
        /// <summary>
        /// Случаи лечения с данной целью
        /// </summary>
        public ICollection<TreatmentCase>? Treatments { get; set; }
    }
}
