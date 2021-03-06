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
    public class DeleteModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public DeleteModel(DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DOLJNOSTI = await _context.DOLJNOSTI.FindAsync(id);

            if (DOLJNOSTI != null)
            {
                _context.DOLJNOSTI.Remove(DOLJNOSTI);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
