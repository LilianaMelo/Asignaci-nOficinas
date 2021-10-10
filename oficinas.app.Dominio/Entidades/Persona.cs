using System;

namespace oficinas.app.Dominio{
    
    public class Persona
    {
        public int Id {get;set;}
        public string Nombre{get;set;}
        public string Apellidos{get;set;}
        public int Identificacion{get;set;}
        public int Edad{get;set;}
        public string Celular {get;set;}
        public string Correo {get;set;}
        public int HorasLaboradas {get;set;}
        public string Estado_covid{get;set;}

    }
}