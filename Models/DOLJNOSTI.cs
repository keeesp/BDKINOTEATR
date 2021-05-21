using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBKINOTEATR.Models
{
    public class DOLJNOSTI
    {
        [Display(Name = "Код должности" )]
        public long ID { get; set; }

        [Display(Name = "Наименование должности")]
        public string NAIMENOVANIE_DOLJNOSTI { get; set; }

        [Display(Name = "Оклад")]
        public int OKLAD { get; set; }

        [Display(Name = "Обязаности")]
        public string OBYAZANOSTI { get; set; }

        [Display(Name = "Требования")]
        public string TREBOVANIYA { get; set; }
    }
}
