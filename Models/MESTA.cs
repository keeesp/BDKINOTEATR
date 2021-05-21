using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBKINOTEATR.Models
{
    public class MESTA
    {
        [Display(Name = "Занятость")]
        public string ZANYTOST{ get; set; }

        [Display(Name = "Номер места")]
        public short ID { get; set; }

        

    }
}

