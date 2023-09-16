using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using follows;
using follows.Data;

namespace follows.Pages.panel
{
    public class DetailsModel : PageModel
    {
        private readonly follows.Data.followsContext _context;

        public DetailsModel(follows.Data.followsContext context)
        {
            _context = context;
        }

      public docentes docentes { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.docentes == null)
            {
                return NotFound();
            }

            var docentes = await _context.docentes.FirstOrDefaultAsync(m => m.Id == id);
            if (docentes == null)
            {
                return NotFound();
            }
            else 
            {
                docentes = docentes;
            }
            return Page();
        }
    }
}
