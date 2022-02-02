using System;
using oficinas.app.Dominio;
using System.Collections.Generic;


namespace oficinas.app.Persistencia
{
    public interface IRepositorioEstadoSalud

    {   
        //CRUD
        //GetAllEstadoSalud
        IEnumerable<EstadoSalud> GetAllEstadoSalud(); // es una interfaz, conjunto de firma de los metodos, lista de todos los pacientes

        //GetPersona 
        EstadoSalud GetEstadoSalud(int IdSintomas);

        //AddPersona
        EstadoSalud AddEstadoSalud (EstadoSalud sintomas);

        // UpdatePersona
        EstadoSalud UpdateEstadoSalud (EstadoSalud sintomas);

        //DeletePersona
        bool DeleteEstadoSalud (int IdSintomas);
    }
}