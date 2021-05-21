using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBKINOTEATR.Models
{
    public class SOTRUDNIKI
    {
        [Display(Name = "Номер телефона")]
        public long phone_number { get; set; }

        [Display(Name = "Адрес")]
        public string adress { get; set; }

        [Display(Name = "Пол")]
        public string pol { get; set; }

        [Display(Name = "Возраст")]
        public short vozrast { get; set; }


        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "Код сотрудника")]
        public long ID { get; set; }

        [Display(Name = "Паспортные данные")]
        public string pasportnie_danie { get; set; }
    }
}