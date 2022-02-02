using System;
using System.Linq;
using oficinas.app.Dominio;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace oficinas.app.Persistencia
{    
    public class RepositorioProveedor : IRepositorioProveedor // implementa la interfaz
    {
        private readonly AppContext _appContext; // se cambia readonly por static

        public RepositorioProveedor(AppContext appContext) // constructor
        {
            _appContext = appContext;
        }

        //CRUD
        //GetAllProveedor
        IEnumerable<Proveedor> IRepositorioProveedor.GetAllProveedores()
        {
            return _appContext.Proveedores; 
        }

        //GetProveedor
        Proveedor IRepositorioProveedor.GetProveedor(int IdProveedor)
        {
            var proveedorEncontrado = _appContext.Proveedores.FirstOrDefault(p => p.Id==IdProveedor);
            return proveedorEncontrado;
        }

        //AddProveedor
        Proveedor IRepositorioProveedor.AddProveedor(Proveedor proveedor)
        {
            var proveedorAdicional = _appContext.Proveedores.Add(proveedor);
            _appContext.SaveChanges();
            return proveedorAdicional.Entity;
        }

        //UpdateProveedor
        Proveedor IRepositorioProveedor.UpdateProveedor(Proveedor proveedor)
        {
            var proveedorEncontrado = _appContext.Proveedores.FirstOrDefault(p => p.Id==proveedor.Id);
            
            if(proveedorEncontrado != null)
            {
                proveedorEncontrado.Nombre = proveedor.Nombre;
                proveedorEncontrado.Apellidos = proveedor.Apellidos;
                proveedorEncontrado.Identificacion = proveedor.Identificacion;
                proveedorEncontrado.Edad = proveedor.Edad;
                proveedorEncontrado.Celular = proveedor.Celular;
                proveedorEncontrado.Correo = proveedor.Correo;
                proveedorEncontrado.HorasLaboradas = proveedor.HorasLaboradas;
                proveedorEncontrado.Estado_covid = proveedor.Estado_covid;                
                proveedorEncontrado.Servicio_realizado = proveedor.Servicio_realizado;
                proveedorEncontrado.Unidad_visitada = proveedor.Unidad_visitada;

                _appContext.SaveChanges();
            }
            return proveedorEncontrado;
        }
        //DeleteProveedor
        
        void IRepositorioProveedor.DeleteProveedor(int IdProveedor) // se cambia Proveedor por void, tambien se cambia (Proveedor proveedor)  por (int IdProveedor)
        {
            var proveedorEncontrado = _appContext.Proveedores.FirstOrDefault(p => p.Id == IdProveedor); // se cambia el (proveedor.Id) por (IdProveedor)
            if (proveedorEncontrado == null)
                return; // se quita el null
            
            _appContext.Proveedores.Remove(proveedorEncontrado);
            _appContext.SaveChanges(); 
            // se quita return proveedorEncontrado;
        }
    }    
}