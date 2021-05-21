using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DBKINOTEATR.Data;
using DBKINOTEATR.Models;

namespace DBKINOTEATR.Pages.MESTA_
{
    public class DeleteModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public DeleteModel(DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MESTA MESTA { get; set; }

        public async Task<IActionResult> OnGetAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MESTA = await _context.MESTA.FirstOrDefaultAsync(m => m.ID == id);

            if (MESTA == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MESTA = await _context.MESTA.FindAsync(id);

            if (MESTA != null)
            {
                _context.MESTA.Remove(MESTA);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
