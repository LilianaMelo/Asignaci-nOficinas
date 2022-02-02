using System;
using oficinas.app.Dominio;
using System.Collections.Generic;


namespace oficinas.app.Persistencia
{
    public interface IRepositorioOficinas

    {   
        //CRUD
        //GetAllOficina
        IEnumerable<Oficina> GetAllOficinas(); // es una interfaz, conjunto de firma de los metodos, lista de todos los pacientes

        //GetOficina
        Oficina GetOficina(int IdOficina);

        //AddOficina
        Oficina AddOficina (Oficina oficina);

        // UpdateOficina
        Oficina UpdateOficina (Oficina oficina);

        //DeleteOficina
        bool DeleteOficina (int IdOficina);
    }
}