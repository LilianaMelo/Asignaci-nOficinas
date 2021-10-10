using System;

namespace oficinas.app.Dominio{
    public class EstadoSalud{

        public int Id {get;set;}
        public DateTime Fecha_inicial{get;set;}
        public Boolean Dolor_de_cabeza{get;set;}
        public Boolean Fiebre{get;set;}
        public Boolean Tos{get;set;}
        public Boolean Diarrea{get;set;}
        public Boolean Vomito{get;set;}
        public Boolean Perdida_Ofalto{get;set;}
        public Boolean Perdida_Gusto{get;set;}
        public DateTime Fecha_final{get;set;}

    }
}