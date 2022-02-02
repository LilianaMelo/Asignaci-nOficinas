using System;
using oficinas.app.Dominio;
using System.Collections.Generic;


namespace oficinas.app.Persistencia
{
    public interface IRepositorioSedes

    {   
        //CRUD
        //GetAllSede
        IEnumerable<Sede> GetAllSedes(); // es una interfaz, conjunto de firma de los metodos, lista de todos los pacientes

        //GetSede
        Sede GetSede(int IdSede);

        //AddSede
        Sede AddSede (Sede sede);

        // UpdateSede
        Sede UpdateSede (Sede sede);

        //DeletePersona
        bool DeleteSede (int IdSede);
    }
}