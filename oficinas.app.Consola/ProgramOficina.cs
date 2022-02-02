using System;
using oficinas.app.Dominio;
using oficinas.app.Persistencia;
using System.Collections.Generic;
/*
namespace oficinas.app.Consola
{
    class ProgramOficina
    {
        private static IRepositorioOficinas _repoOficina = new RepositorioOficina(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AdicionarOficina();
            //ActualizarOficina(2);
            //BuscarOficina(3);
            //BuscarOficinas();
            EliminarOficina(3);
            
        }

    ///////////// CRUD ////////////////
        //AdicionarOficina
        private static void AdicionarOficina()
        {
            var oficina = new Oficina
            {
                Nombre = "Torre 40",
                Aforo = 20,
                Cant_Oficinas_Disponibles = 10,
                Numero_personas = 7,
            };

            _repoOficina.AddOficina(oficina);
        }

        //ActualizarOficina
        private static void ActualizarOficina(int IdOficina)
        {
            var oficina = new Oficina
            {
                Id =IdOficina,
                Nombre = "Centro",
                Aforo = 8,
                Cant_Oficinas_Disponibles = 15,
                Numero_personas = 8,
            };
            Oficina oficinaActualizada=_repoOficina.UpdateOficina(oficina);
            if (oficinaActualizada!=null)
                Console.WriteLine("Se actualizo el registro");

        }

        //BuscarOficina
        private static void BuscarOficina(int IdOficina)
        {
            var oficinaEncontrada = _repoOficina.GetOficina(IdOficina);
            Console.WriteLine(oficinaEncontrada.Nombre);
        }

        //BuscarOficinas
        private static void BuscarOficinas()
        {
            IEnumerable<Oficina> Oficinas = _repoOficina.GetAllOficinas();

            foreach (var oficina in Oficinas)
            {
                Console.WriteLine(oficina.Nombre+" "+oficina.Aforo+" "+oficina.Cant_Oficinas_Disponibles);
            }
        }

        //EliminarOficina
        private static void EliminarOficina(int IdOficina)
        {
            bool bandera = _repoOficina.DeleteOficina(IdOficina);
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