using System;

namespace oficinas.app.Dominio{

    public class Oficina{

        public int Id {get;set;}
        public string Nombre{get;set;}
        public int Aforo{get;set;}
        public int Cant_Oficinas_Disponibles {get;set;}
        public int Numero_personas {get;set;}

    }
}