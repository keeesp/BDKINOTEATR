using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBKINOTEATR.Models
{
    public class REPERTUAR
    {
        [Display(Name = "Цена билета")]
        public long cena_bileta { get; set; }

        [Display(Name = "Код сеанса")]
        public long ID { get; set; }

        [Display(Name = "Дата")]
        public DateTime DATE { get; set; }

        [Display(Name = "Время начала")]
        public DateTime vremya_nachala { get; set; }

        [Display(Name = "Время окончания")]
        public DateTime Vremya_okonchaniya { get; set; }

       


    }
}

