using oficinas.app.Dominio;
using System.Collections.Generic;


namespace oficinas.app.Persistencia
{
    public interface IRepositorioPersona

    {   
        //CRUD
        //GetAllPersona
        IEnumerable<Persona> GetAllPersonas(); // es una interfaz, conjunto de firma de los metodos, lista de todos los pacientes

        //GetPersona 
        Persona GetPersona(int IdPersona);

        //AddPersona
        Persona AddPersona (Persona persona);

        // UpdatePersona
        Persona UpdatePersona (Persona persona);

        //DeletePersona
        bool DeletePersona (int IdPersona);
    }
}