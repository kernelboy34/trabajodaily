using follows.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace follows.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly followsContext _context;

        public PrivacyModel(ILogger<PrivacyModel> logger, followsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public registromaterias RegistroMaterias { get; set; } = new registromaterias(); 

        public IActionResult OnPost()
        {
            string materia = Request.Form["Materia"];
            string nota = Request.Form["Nota"];

            var registrocochino = new registromaterias
            {
                Materia = materia,
                Nota = nota
            };

            _context.Add(registrocochino);
            _context.SaveChanges();

            return RedirectToPage("est");
        }

        public void OnGet()
        {
        }
    }
}