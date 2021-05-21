using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBKINOTEATR.Data;
using DBKINOTEATR.Models;

namespace DBKINOTEATR.Pages.FILMS_
{
    public class IndexModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public IndexModel(DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        public IList<FILMS> FILMS { get;set; }

        public async Task OnGetAsync()
        {
            FILMS = await _context.FILMS.ToListAsync();
        }
    }
}
