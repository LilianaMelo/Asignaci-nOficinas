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
    public class EditarAsesorModel : PageModel
    {
        private static IRepositorioAsesor _repoAsesor = new RepositorioAsesor(new Persistencia.AppContext());// se quita  oficinas.app. de Persistencia.AppContext.

        [BindProperty]

        public Asesor asesor {get; set;}

        public IActionResult  OnGet(int? AsesorId)
        {
            if (AsesorId.HasValue)
            {
                asesor = _repoAsesor.GetAsesor (AsesorId.Value);
            }
            else
            {
                asesor = new Asesor();
            }

            if (asesor == null)
            {
                return RedirectToPage("./ListAsesor");
            }else 
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (asesor.Id > 0)
                {
                    asesor = _repoAsesor.UpdateAsesor(asesor);
                }
                else
                {
                    _repoAsesor.AddAsesor(asesor);
                }
                return RedirectToPage("./ListAsesor");
            }
        }
    }
}
