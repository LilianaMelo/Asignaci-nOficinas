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
    public class EliminarModel : PageModel
    {
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new Persistencia.AppContext());

        [BindProperty]
        public Proveedor proveedor { get; set; }

        public IActionResult OnGet(int ProveedorId)
        {
            proveedor = _repoProveedor.GetProveedor(ProveedorId);

            // if (proveedor==null)
            //   return RedirectToPage("./ListProveedor");

            return Page();
        }

        
        public IActionResult OnPost()
        {   
            //proveedor = _repoProveedor.DeleteProveedor(ProveedorId);
            _repoProveedor.DeleteProveedor(proveedor.Id);// se agregar .Id
            return RedirectToPage("./ListProveedor");
        }
    }
}