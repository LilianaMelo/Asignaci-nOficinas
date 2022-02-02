using System;
using oficinas.app.Dominio;
using System.Collections.Generic;

namespace oficinas.app.Persistencia
{
    public interface IRepositorioAsesor
    {   
        IEnumerable<Asesor> GetAllAsesores();

        Asesor GetAsesor(int IdAsesor);

        Asesor AddAsesor (Asesor asesor);

        Asesor UpdateAsesor (Asesor asesor);

        void DeleteAsesor (int IdAsesor);
    }
}