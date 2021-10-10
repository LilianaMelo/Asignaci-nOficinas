using oficinas.app.Dominio;
using System.Collections.Generic;
using System.Linq; /// libreria que arroja objetos de busqueda, para hacer consultas 
using Microsoft.EntityFrameworkCore;

namespace oficinas.app.Persistencia
{
    
    public class RepositorioPersona : IRepositorioPersona // implementa la interfaz
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext) // constructor
        {
            _appContext=appContext;
        }

        //CRUD
        //GetAllPersona
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas; 
        }

        //GetPersona
        Persona IRepositorioPersona.GetPersona(int IdPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id==IdPersona);
            return personaEncontrada;
        }

        //AddPersona
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicional = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicional.Entity;
        }

        //UpdatePersona
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id==persona.Id);
            
            if(personaEncontrada != null)
            {
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.Edad = persona.Edad;
                personaEncontrada.Celular = persona.Celular;
                personaEncontrada.Correo = persona.Correo;
                personaEncontrada.HorasLaboradas = persona.HorasLaboradas;
                personaEncontrada.Estado_covid = persona.Estado_covid;

                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
        //DeletePersona
        bool IRepositorioPersona.DeletePersona(int IdPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id== IdPersona);
            if (personaEncontrada == null)
                return false;
            
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges(); 
            return true;
        }
    }    
}