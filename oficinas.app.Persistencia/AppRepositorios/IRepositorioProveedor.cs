using System;
using oficinas.app.Dominio;
using System.Collections.Generic;

namespace oficinas.app.Persistencia
{
    public interface IRepositorioProveedor
    {   
        //CRUD
        IEnumerable <Proveedor> GetAllProveedores();

        Proveedor GetProveedor (int IdProveedor);

        Proveedor AddProveedor (Proveedor proveedor);

        Proveedor UpdateProveedor (Proveedor proveedor);

        void DeleteProveedor (int idProveedor);
    }
}