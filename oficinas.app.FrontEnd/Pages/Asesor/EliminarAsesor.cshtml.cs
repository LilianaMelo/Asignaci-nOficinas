using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using oficinas.app.Persistencia;
using oficinas.app.Dominio;

namespace oficinas.app.Frontend.Pages
{
    public class EliminarAsesorModel : PageModel
    {
        public static IRepositorioAsesor _repoAsesor = new RepositorioAsesor(new Persistencia.AppContext());
        
        [BindProperty]

        public Asesor asesor {get; set;}

        public IActionResult OnGet(int AsesorId)
        {
            asesor = _repoAsesor.GetAsesor(AsesorId);

            return Page();
        }

        public IActionResult OnPost ()
        {
            _repoAsesor.DeleteAsesor(asesor.Id);
            return RedirectToPage("./ListAsesor");
        }
    }
}
