using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using follows;
using follows.Data;

namespace follows.Pages.panel
{
    public class EditModel : PageModel
    {
        private readonly follows.Data.followsContext _context;

        public EditModel(follows.Data.followsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public docentes docentes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.docentes == null)
            {
                return NotFound();
            }

            var docentes =  await _context.docentes.FirstOrDefaultAsync(m => m.Id == id);
            if (docentes == null)
            {
                return NotFound();
            }
            docentes = docentes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(docentes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!docentesExists(docentes.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool docentesExists(int id)
        {
          return (_context.docentes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
