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
    public class DetailsModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public DetailsModel(DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        public FILMS FILMS { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FILMS = await _context.FILMS.FirstOrDefaultAsync(m => m.ID == id);

            if (FILMS == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
