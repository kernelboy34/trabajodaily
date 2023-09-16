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
    public class IndexModel : PageModel
    {
        private readonly follows.Data.followsContext _context;

        public IndexModel(follows.Data.followsContext context)
        {
            _context = context;
        }

        public IList<docentes> docentes { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.docentes != null)
            {
                docentes = await _context.docentes.ToListAsync();
            }
        }
    }
}
