using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using follows;
using follows.Data;

namespace follows.Pages.panel
{
    public class CreateModel : PageModel
    {
        private readonly follows.Data.followsContext _context;

        public CreateModel(follows.Data.followsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public docentes docentes { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.docentes == null || docentes == null)
            {
                return Page();
            }

            _context.docentes.Add(docentes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
