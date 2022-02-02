using System;
using oficinas.app.Dominio;
using System.Collections.Generic;
using System.Linq; /// libreria que arroja objetos de busqueda, para hacer consultas 
using Microsoft.EntityFrameworkCore;

namespace oficinas.app.Persistencia
{
    public class RepositorioSede : IRepositorioSedes // implementa la interfaz
    {
        private readonly AppContext _appContext;

        public RepositorioSede(AppContext appContext) // constructor
        {
            _appContext=appContext;
        }

        //CRUD
        //GetAllSede
        IEnumerable<Sede> IRepositorioSedes.GetAllSedes()
        {
            return _appContext.Sedes; 
        }

        //GetSede
        Sede IRepositorioSedes.GetSede(int IdSede)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault(p => p.Id==IdSede);
            return sedeEncontrada;
        }

        //AddSede
        Sede IRepositorioSedes.AddSede(Sede sede)
        {
            var sedeAdicional = _appContext.Sedes.Add(sede);
            _appContext.SaveChanges();
            return sedeAdicional.Entity;
        }

        //UpdateSede
        Sede IRepositorioSedes.UpdateSede(Sede sede)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault(p => p.Id==sede.Id);
            
            if(sedeEncontrada != null)
            {
                sedeEncontrada.Nombre = sede.Nombre;
                sedeEncontrada.Direccion = sede.Direccion;

                _appContext.SaveChanges();
            }
            return sedeEncontrada;
        }
        //DeleteSede
        bool IRepositorioSedes.DeleteSede(int IdSede)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault(p => p.Id== IdSede);
            if (sedeEncontrada == null)
                return false;
            
            _appContext.Sedes.Remove(sedeEncontrada);
            _appContext.SaveChanges(); 
            return true;
        }
    }    
}