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
    public class EditarModel : PageModel
    {
        private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new oficinas.app.Persistencia.AppContext());

        [BindProperty]
        public Proveedor proveedor {get; set;}

        public IActionResult OnGet(int? ProveedorId)
        {
            if (ProveedorId.HasValue)
            {
                proveedor = _repoProveedor.GetProveedor(ProveedorId.Value);
            }
            else
            {
                proveedor = new Proveedor();
            }

            if (proveedor == null)
            {
                return RedirectToPage("./ListProveedor");
            }else // se agrega
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
                if (proveedor.Id > 0)
                {
                    proveedor = _repoProveedor.UpdateProveedor(proveedor);
                }
                else
                {
                    _repoProveedor.AddProveedor(proveedor);
                }
                return RedirectToPage("./ListProveedor");
            }
        }
    }
}
