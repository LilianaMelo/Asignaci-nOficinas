using System;
using oficinas.app.Dominio;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.EntityFrameworkCore;

namespace oficinas.app.Persistencia
{
    
    public class RepositorioOficina : IRepositorioOficinas
    {
    
        private readonly AppContext _appContext;

        public RepositorioOficina(AppContext appContext) // constructor
        {
            _appContext=appContext;
        }

        //CRUD
        //GetAllOficina
        IEnumerable<Oficina> IRepositorioOficinas.GetAllOficinas()
        {
            return _appContext.Oficinas; 
        }

        //GetOficina
        Oficina IRepositorioOficinas.GetOficina(int IdOficina)
        {
            var oficinaEncontrada = _appContext.Oficinas.FirstOrDefault(p => p.Id==IdOficina);
            return oficinaEncontrada;
        }

        //AddOficina
        Oficina IRepositorioOficinas.AddOficina(Oficina oficina)
        {
            var oficinaAdicional = _appContext.Oficinas.Add(oficina);
            _appContext.SaveChanges();
            return oficinaAdicional.Entity;
        }

        //UpdateOficina
        Oficina IRepositorioOficinas.UpdateOficina(Oficina oficina)
        {
            var oficinaEncontrada = _appContext.Oficinas.FirstOrDefault(p => p.Id==oficina.Id);

            if(oficinaEncontrada != null)
            {
                oficinaEncontrada.Nombre = oficina.Nombre;
                oficinaEncontrada.Aforo = oficina.Aforo;
                oficinaEncontrada.Cant_Oficinas_Disponibles = oficina.Cant_Oficinas_Disponibles;
                oficinaEncontrada.Numero_personas = oficina.Numero_personas;

                _appContext.SaveChanges();
            }
            return oficinaEncontrada;
        }

        //DeleteOficina
        bool IRepositorioOficinas.DeleteOficina(int IdOficina)
        {
            var oficinaEncontrada = _appContext.Oficinas.FirstOrDefault(p => p.Id== IdOficina);
            if (oficinaEncontrada == null)
                return false;

            _appContext.Oficinas.Remove(oficinaEncontrada);
            _appContext.SaveChanges();
            return true;
        }
    }    
}