using System;
using oficinas.app.Dominio;
using oficinas.app.Persistencia;
using System.Collections.Generic;

namespace oficinas.app.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarPersona();
            //ActualizarPersona(4);
            //BuscarPersona(3);
            //BuscarPersonas();
            //EliminarPersona(5);
        }

        //CRUD
        //AdicionarPersona
        private static void AdicionarPersona()
        {
            var persona = new Persona
            {
                Nombre = "Santiago",
                Apellidos = "Murrillo",
                Identificacion = 3456672,
                Edad = 39,
                Celular = "3217895634",
                Correo = "santiago.murrillo.tic@ucaldas.edu.co",
                HorasLaboradas = 48,
                Estado_covid = "Negativo"
            };

            _repoPersona.AddPersona(persona);
        }

        //ActualizarPersona
        private static void ActualizarPersona(int IdPersona)
        {
            var persona = new Persona
            {
                Id =IdPersona,
                Nombre = "Laura",
                Apellidos = "Martinez",
                Identificacion = 106874,
                Edad = 19,
                Celular = "3217342678",
                Correo = "lorenavelez@gmail.com",
                HorasLaboradas = 48,
                Estado_covid = "Negativo",
            };
            Persona personaActualizada=_repoPersona.UpdatePersona(persona);
            if (personaActualizada!=null)
                Console.WriteLine("Se actualizo el registro");

        }

        //BuscarPersona
        private static void BuscarPersona(int IdPersona)
        {
            var personaEncontrada = _repoPersona.GetPersona(IdPersona);
            Console.WriteLine(personaEncontrada.Nombre);
        }
        //BuscarPersonas
        private static void BuscarPersonas()
        {
            IEnumerable<Persona> Personas = _repoPersona.GetAllPersonas();

            foreach (var persona in Personas)
            {
                Console.WriteLine(persona.Nombre+" "+persona.Apellidos+" "+persona.Estado_covid);
            }
        }

        //EliminarPersona
        private static void EliminarPersona(int IdPersona)
        {
            bool bandera = _repoPersona.DeletePersona(IdPersona);
            if (bandera)
            {
                Console.WriteLine("Se eliminó el registro correctamente");
            }    
            else 
            {
                Console.WriteLine("Hubo un error al acceder a la base de datos");
            }
        }
    }
}