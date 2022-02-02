using System;
using oficinas.app.Dominio;
using oficinas.app.Persistencia;
using System.Collections.Generic;
using System.Linq;


///PERSONA
namespace oficinas.app.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());

        private static IRepositorioEstadoSalud _repoEstadoSalud = new RepositorioEstadoSalud(new Persistencia.AppContext());

        //private static IRepositorioProveedor _repoProveedor = new RepositorioProveedor(new Persistencia.AppContext());

        //private static IRepositorioAsesor _repoAsesor = new RepositorioAsesor(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Esto es un mensaje por consola!");


            Persona personaAdicionada =  AdicionarEstadoSalud();
            Console.WriteLine(personaAdicionada.Nombre);
            //AdicionarPersona();
            //ActualizarPersona(4);
            //BuscarPersona(3);
            //BuscarPersonas();
            //EliminarPersona(5);


            //AdicionarProveedor();
            //ActualizarProveedor(11);
            //BuscarProveedor(9);
            //BuscarProveedores();
            //EliminarProveedor(3);


            //AdicionarAsesor();
            ActualizarAsesor(15);
            //BuscarAsesor(12);
            //BuscarAsesores();
            //EliminarAsesor(13);


        }



        //CRUD  //AdicionarPersona
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

        //BuscarPersona
        private static Persona BuscarPersona(int IdPersona)
        {
            var personaEncontrada = _repoPersona.GetPersona(IdPersona);
            Console.WriteLine(personaEncontrada.Nombre);
            return personaEncontrada;
        }

        
        //EliminarPersona
        private static void EliminarPersona(Persona persona)
        {
            var personaEliminada = _repoPersona.DeletePersona(persona);
            if (persona==null)
            {
                Console.WriteLine("Se eliminó el registro correctamente");
            }    
            else 
            {
                Console.WriteLine("Hubo un error al acceder a la base de datos");
            }
        }
   

        //ActualizarPersona
        private static void ActualizarPersona(int IdPersona)
        {
            var persona = new Persona
            {
                Id = IdPersona,
                Nombre = "Laura",
                Apellidos = "Rodriguez",
                Identificacion = 106874,
                Edad = 19,
                Celular = "3217342678",
                Correo = "laura_rodriguez@gmail.com",
                HorasLaboradas = 48,
                Estado_covid = "Negativo",
            };
            Persona personaActualizada =_repoPersona.UpdatePersona(persona);
            if (personaActualizada!=null)
                Console.WriteLine("Se actualizo el registro");

        }

        
        //BuscarPersonas o GetAllPersonas
        private static void BuscarPersonas()
        {
            IEnumerable<Persona> Personas = _repoPersona.GetAllPersonas();

            foreach (var persona in Personas)
            {
                Console.WriteLine(persona.Nombre+" "+persona.Apellidos+" "+persona.Estado_covid);
            }
        }

        //  CRUD  PERSONA CON ESTADOSALUD
        //AdicionarEstadoSalud
        private static void AdicionarEstadoSalud()
        {
            var sintomas = new EstadoSalud
            {
                Fecha_inicial = new DateTime(2021,08,15),
                Dolor_de_cabeza = true,
                Fiebre = true,
                Tos = false,
                Diarrea = false,
                Vomito = false,
                Perdida_Ofalto = true,
                Perdida_Gusto = true,
                Fecha_final = new DateTime(2021,09,04),
            };

            _repoEstadoSalud.AddEstadoSalud(sintomas);
        }
    
        //BuscarEstadoSalud
        private static void BuscarEstadoSalud(int IdSintomas)
        {
            var sintomaEncontrado = _repoEstadoSalud.GetEstadoSalud(IdSintomas);
            Console.WriteLine(sintomaEncontrado.Dolor_de_cabeza+" "+sintomaEncontrado.Diarrea);
        }


        //ActualizarEstadoSalud
        private static void ActualizarEstadoSalud(int IdEstadoSalud)
        {
            var sintomas = new EstadoSalud
            {
                Id = IdEstadoSalud,
                Fecha_inicial = new DateTime(2021,08,15),
                Dolor_de_cabeza = false,
                Fiebre = false,
                Tos = false,
                Diarrea = false,
                Vomito = false,
                Perdida_Ofalto = false,
                Perdida_Gusto = false,
                Fecha_final = new DateTime(2021,09,14),
            };
            EstadoSalud sintomaActualizado=_repoEstadoSalud.UpdateEstadoSalud(sintomas);
            if (sintomaActualizado!=null)
                Console.WriteLine("Se actualizo el registro");
        }


        //EliminarEstadoSalud
        private static void EliminarEstadoSalud(int IdSintomas)
        {
            bool bandera = _repoEstadoSalud.DeleteEstadoSalud(IdSintomas);
            if (bandera)
            {
                Console.WriteLine("Se eliminó el registro correctamente");
            }    
            else 
            {
                Console.WriteLine("Hubo un error al acceder a la base de datos");
            }
        }
    
    
    




        /*
        //// PROVEEDOR

        //CRUD
        //AdicionarProveedor
        private static void AdicionarProveedor()
        {
            var proveedor = new Proveedor
            {
                Nombre = "Sandra",
                Apellidos = "Muñoz",
                Identificacion = 11111111,
                Edad = 30,
                Celular = "3115556677",
                Correo = "sandram@hotmail.com",
                HorasLaboradas = 48,
                Estado_covid = "Negativo",
                
                Servicio_realizado = "Seguridad-Seguridad Atempi",
                Unidad_visitada = "4"
            };

            _repoProveedor.AddProveedor(proveedor);
        }

        //ActualizarProveedor
        private static void ActualizarProveedor(int IdProveedor)
        {
            var proveedor = new Proveedor
            {

                Nombre = "Jose Manuel",
                Apellidos = "Salcedo",
                Identificacion = 18560021,
                Edad = 28,
                Celular = "3112345566",
                Correo = "josemanu@gmail.com",
                HorasLaboradas = 48,
                Estado_covid = "Positivo",

                Servicio_realizado = "Auditoria-AM Consulting S.A.",
                Unidad_visitada = "3",
            };
            Proveedor proveedorActualizado=_repoProveedor.UpdateProveedor(proveedor);
            if (proveedorActualizado!=null)
                Console.WriteLine("Se actualizo el registro");
        }

        //BuscarProveedor
        private static void BuscarProveedor(int IdProveedor)
        {
            var proveedorEncontrado = _repoProveedor.GetProveedor(IdProveedor);
            Console.WriteLine(proveedorEncontrado.Nombre+" "+proveedorEncontrado.Apellidos);
        }

        //BuscarProveedores
        private static void BuscarProveedores()
        {
            IEnumerable<Proveedor> Proveedores = _repoProveedor.GetAllProveedores();

            foreach (var proveedor in Proveedores)
            {
                Console.WriteLine(proveedor.Nombre+" "+proveedor.Apellidos+" "+proveedor.Estado_covid);
            }
        }

        //EliminarProveedor
        private static void EliminarProveedor(int IdProveedor)
        {
            bool bandera = _repoProveedor.DeleteProveedor(IdProveedor);
            if (bandera)
            {
                Console.WriteLine("Se eliminó el registro correctamente");
            }    
            else 
            {
                Console.WriteLine("Hubo un error al acceder a la base de datos");
            }
        } */



        /*
        ////// ASESOR

        //CRUD
        //AdicionarAsesor
        private static void AdicionarAsesor()
        {
            var asesor = new Asesor
            {
                Nombre = "Marcela",
                Apellidos = "Rubiano",
                Identificacion = 12345678,
                Edad = 23,
                Celular = "3206456877",
                Correo = "oscarzamo@hotmail.com",
                HorasLaboradas = 48,
                Estado_covid = "Negativo",
                
                Oficinas_visitadas = "Calle 90",
            };

            _repoAsesor.AddAsesor(asesor);
        }

        //ActualizarAsesor
        private static void ActualizarAsesor(int IdAsesor)
        {
            var asesor = new Asesor
            {
                Id = IdAsesor,
                Nombre = "Laura",
                Apellidos = "Viña",
                Identificacion = 73540189,
                Edad = 30,
                Celular = "3104456677",
                Correo = "laura.vin@hotmail.com",
                HorasLaboradas = 56,
                Estado_covid = "Negativo",
                
                Oficinas_visitadas = "Calle 80",

            };
            Asesor
            asesorActualizado=_repoAsesor.UpdateAsesor(asesor);
            if (asesorActualizado!=null)
                Console.WriteLine("Se actualizo el registro");
        }

        //BuscarAsesor
        private static void BuscarAsesor(int IdAsesor)
        {
            var asesorEncontrado = _repoAsesor.GetAsesor(IdAsesor);
            Console.WriteLine(asesorEncontrado.Nombre+" "+asesorEncontrado.Apellidos);
        }

        //BuscarAsesores
        private static void BuscarAsesores()
        {
            IEnumerable<Asesor> Asesores = _repoAsesor.GetAllAsesores();

            foreach (var asesor in Asesores)
            {
                Console.WriteLine(asesor.Nombre+" "+asesor.Apellidos+" "+asesor.Estado_covid);
            }
        }

        //EliminarAsesor
        private static void EliminarAsesor(int IdAsesor)
        {
            bool bandera = _repoAsesor.DeleteAsesor(IdAsesor);
            if (bandera)
            {
                Console.WriteLine("Se eliminó el registro correctamente");
            }    
            else 
            {
                Console.WriteLine("Hubo un error al acceder a la base de datos");
            }
        }*/
    






    
    }  // 
} 
