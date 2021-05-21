using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBKINOTEATR.Data;
using DBKINOTEATR.Models;

namespace DBKINOTEATR.Pages.DOLJNOSTI_
{
    public class DetailsModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public DetailsModel(DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        public DOLJNOSTI DOLJNOSTI { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DOLJNOSTI = await _context.DOLJNOSTI.FirstOrDefaultAsync(m => m.ID == id);

            if (DOLJNOSTI == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
