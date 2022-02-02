using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using oficinas.app.Dominio;
using oficinas.app.Persistencia;


namespace oficinas.App.Frontend.Pages
{
    public class DetallesAsesorModel : PageModel
    {
        private static IRepositorioAsesor _repoAsesor = new RepositorioAsesor(new oficinas.app.Persistencia.AppContext());

        public Asesor asesor{get;set;}
        public IActionResult OnGet(int AsesorId)
        {
            asesor = _repoAsesor.GetAsesor(AsesorId);
            if(asesor==null)
            {
                return RedirectToPage("./ListAsesor");
            }else{
                return Page();
            }
        }
    }
}
