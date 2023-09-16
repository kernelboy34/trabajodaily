using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using follows.Data;

namespace follows.Pages
{
    public class estModel : PageModel
    {
        private readonly followsContext _context;

        public estModel(followsContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            string nombre = Request.Form["nom"];
            string curso = Request.Form["cur"];

            Class registrocochino = new Class
            {
                Name = nombre,
                course = curso
            };
            _context.Class.Add(registrocochino);
            _context.SaveChanges();

            return RedirectToPage("est");
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Class Class { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Class == null || Class == null)
            {
                return Page();
            }

            _context.Class.Add(Class);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}