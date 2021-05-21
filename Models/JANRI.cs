using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBKINOTEATR.Models
{
    public class JANRI
    {
        [Display(Name = "Наименование")]
        public string NAIMENOVANIE { get; set; }

        [Display(Name = "Описание")]
        public string OPISANIE{ get; set; }

        [Display(Name = "Код жанра")]
        public long ID { get; set; }

        


    }
}

