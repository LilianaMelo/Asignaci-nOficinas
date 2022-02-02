using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using oficinas.app.Dominio;
using oficinas.app.Persistencia;

namespace oficinas.app.Frontend.Pages
{

    public class DetallesModel : PageModel
    {
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new oficinas.app.Persistencia.AppContext());

        public Proveedor proveedor{get;set;}

        public IActionResult OnGet(int ProveedorId)
        {
            proveedor = _repoProveedor.GetProveedor(ProveedorId);
            if(proveedor==null)
            {
                return RedirectToPage("./Proveedor/ListProveedor");
            }else{
                return Page();
            }
        }
    }
}
