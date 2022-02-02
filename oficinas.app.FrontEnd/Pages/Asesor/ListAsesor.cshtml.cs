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
    public class ListAsesorModel : PageModel
    {
        private static IRepositorioAsesor _repoAsesor = new RepositorioAsesor(new oficinas.app.Persistencia.AppContext());

        public IEnumerable <Asesor> Asesores {get;set;}
        
        public Asesor asesor {get; set;}
        public void OnGet()
        {
            Asesores = _repoAsesor.GetAllAsesores();
        }
    }
}
