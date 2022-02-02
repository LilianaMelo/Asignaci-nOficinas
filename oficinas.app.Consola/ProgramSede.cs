using System;
using oficinas.app.Dominio;
using oficinas.app.Persistencia;
using System.Collections.Generic;
/*
namespace oficinas.app.Consola
{
    class ProgramSede
    {
        private static IRepositorioSedes _repoSede = new RepositorioSede(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AdicionarSede();
            //ActualizarSede(2);
            //BuscarSede(3);
            //BuscarSedes();
            EliminarSede(3);
        }

    ///////////// CRUD ////////////////
        //AdicionarSede
        private static void AdicionarSede()
        {
            var sede = new Sede
            {
                Nombre = "Torre 20 - 206",
                Direccion = "Calle 200 # 16 - 14"
            };

            _repoSede.AddSede(sede);
        }

        //ActualizarSede
        private static void ActualizarSede(int IdSede)
        {
            var sede = new Sede
            {
                Id =IdSede,
                Nombre = "Torre 4 - 206",
                Direccion = "Calle 26 # 10 37",
            };
            Sede sedeActualizada = _repoSede.UpdateSede(sede);
            if (sedeActualizada!=null)
                Console.WriteLine("Se actualizo el registro");
        }

        //BuscarSede
        private static void BuscarSede(int IdSede)
        {
            var sedeEncontrada = _repoSede.GetSede(IdSede);
            Console.WriteLine(sedeEncontrada.Nombre);
        }

        //BuscarSedes
        private static void BuscarSedes()
        {
            IEnumerable<Sede> Sedes = _repoSede.GetAllSedes();

            foreach (var sede in Sedes)
            {
                Console.WriteLine(sede.Nombre+" "+sede.Direccion);
            }
        }

        //EliminarSede
        private static void EliminarSede(int IdSede)
        {
            bool bandera = _repoSede.DeleteSede(IdSede);
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
}*/