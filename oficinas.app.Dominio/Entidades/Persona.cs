using System;
using System.Resources;
using System.ComponentModel.DataAnnotations;

namespace oficinas.app.Dominio
{
    
    public class Persona
    {
        public int Id {get;set;}

        //[Required]
        public string Nombre{get;set;}
        public string Apellidos{get;set;}
        
        [Range(0,1090000000)]
        [Required]
        public int Identificacion{get;set;}
        public int Edad{get;set;}
        public string Celular {get;set;}
        public string Correo {get;set;}
        public int HorasLaboradas {get;set;}
        public string Estado_covid{get;set;}
    }
}