using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBKINOTEATR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DBKINOTEATR.Pages.FilReq.Request
{
    public class PerDepModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public PerDepModel (DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        public IList<SOTRUDNIKI> SOTRUDNIKI { get; set; }
        public IList<DOLJNOSTI> DOLJNOSTI { get; set; }

        public async Task OnGetAsync()
        {
            SOTRUDNIKI = await _context.SOTRUDNIKI.ToListAsync();

            DOLJNOSTI = await _context.DOLJNOSTI.ToListAsync();
        }
    }
}