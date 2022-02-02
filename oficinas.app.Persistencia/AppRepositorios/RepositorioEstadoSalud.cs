using System;
using oficinas.app.Dominio;
using System.Collections.Generic;
using System.Linq; /// libreria que arroja objetos de busqueda, para hacer consultas. 
using Microsoft.EntityFrameworkCore;

namespace oficinas.app.Persistencia
{
    
    public class RepositorioEstadoSalud : IRepositorioEstadoSalud // implementa la interfaz
    {
        private readonly AppContext _appContext;

        public RepositorioEstadoSalud(AppContext appContext) // constructor
        {
            _appContext=appContext;
        }

        //CRUD
        //GetAllEstadoSalud
        IEnumerable<EstadoSalud> IRepositorioEstadoSalud.GetAllEstadoSalud()
        {
            return _appContext.Covid1; 
        }

        //GetEstadoSalud
        EstadoSalud IRepositorioEstadoSalud.GetEstadoSalud(int IdSintomas)
        {
            var sintomaEncontrado = _appContext.Covid1.FirstOrDefault(p => p.Id==IdSintomas);
            return sintomaEncontrado;
        }

        //AddEstadoSalud
        EstadoSalud IRepositorioEstadoSalud.AddEstadoSalud(EstadoSalud sintomas)
        {
            var sintomaAdicional = _appContext.Covid1.Add(sintomas);
            _appContext.SaveChanges();
            return sintomaAdicional.Entity;
        }

        //UpdateEstadoSalud
        EstadoSalud IRepositorioEstadoSalud.UpdateEstadoSalud(EstadoSalud sintomas)
        {
            var sintomaEncontrado = _appContext.Covid1.FirstOrDefault(p => p.Id==sintomas.Id);
            
            if(sintomaEncontrado != null)
            {
                sintomaEncontrado.Fecha_inicial = sintomas.Fecha_inicial;
                sintomaEncontrado.Dolor_de_cabeza = sintomas.Dolor_de_cabeza;
                sintomaEncontrado.Fiebre = sintomas.Fiebre;
                sintomaEncontrado.Tos = sintomas.Tos;
                sintomaEncontrado.Diarrea = sintomas.Diarrea;
                sintomaEncontrado.Vomito = sintomas.Vomito;
                sintomaEncontrado.Perdida_Ofalto = sintomas.Perdida_Ofalto;
                sintomaEncontrado.Perdida_Gusto = sintomas.Perdida_Gusto;
                sintomaEncontrado.Fecha_final = sintomas.Fecha_final;

                _appContext.SaveChanges();
            }
            return sintomaEncontrado;
        }
        //DeleteEstadoSalud
        bool IRepositorioEstadoSalud.DeleteEstadoSalud(int IdSintomas)
        {
            var sintomaEncontrado = _appContext.Covid1.FirstOrDefault(p => p.Id== IdSintomas);
            if (sintomaEncontrado == null)
                return false;
            
            _appContext.Covid1.Remove(sintomaEncontrado);
            _appContext.SaveChanges(); 
            return true;
        }
    }    
}