using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBKINOTEATR.Data;
using DBKINOTEATR.Models;

namespace DBKINOTEATR.Pages.JANRI_
{
    public class DeleteModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public DeleteModel(DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JANRI JANRI { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JANRI = await _context.JANRI.FirstOrDefaultAsync(m => m.ID == id);

            if (JANRI == null)
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

            JANRI = await _context.JANRI.FindAsync(id);

            if (JANRI != null)
            {
                _context.JANRI.Remove(JANRI);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
