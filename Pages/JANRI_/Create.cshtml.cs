using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DBKINOTEATR.Data;
using DBKINOTEATR.Models;

namespace DBKINOTEATR.Pages.JANRI_
{
    public class CreateModel : PageModel
    {
        private readonly DBKINOTEATR.Data.DBKINOTEATRContext _context;

        public CreateModel(DBKINOTEATR.Data.DBKINOTEATRContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JANRI JANRI { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JANRI.Add(JANRI);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
