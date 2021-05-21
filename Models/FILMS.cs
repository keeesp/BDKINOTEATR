using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBKINOTEATR.Models
{
    public class FILMS
    {
            [Display(Name = "Наименование")]
            public string NAIMENOVANIE { get; set; }

            [Display(Name = "Страна производитель")]
            public string STRANA_PROIZVODITEL { get; set; }

            [Display(Name = "Фирма производитель")]
            public string FIRMA_PROIZVODITEL { get; set; }

            [Display(Name = "Актеры")]
            public string ACTERS { get; set; }

            [Display(Name = "Возврастные ограничения")]
        public long VOZVRASTNIE_OGRANICHENIYA { get; set; }

            [Display(Name = "Длительность")]
        public long DLITELNOST { get; set; }

            [Display(Name = "Описание")]
        public string OPISANIE { get; set; }

                [Display(Name = "Код фильма")]
        public long ID
        { get; set; }

            
        }
    }

