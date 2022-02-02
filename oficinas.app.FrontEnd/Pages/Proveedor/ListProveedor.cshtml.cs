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
    public class ListProveedoresModel : PageModel
    {   
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new oficinas.app.Persistencia.AppContext());

        public IEnumerable <Proveedor> Proveedores {get;set;}

        public Proveedor proveedor{get;set;}

        public void OnGet()
        {
            Proveedores = _repoProveedor.GetAllProveedores();
            
        }
    }
}
