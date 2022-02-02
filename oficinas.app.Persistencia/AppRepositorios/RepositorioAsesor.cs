using System;
using oficinas.app.Dominio;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.EntityFrameworkCore;

namespace oficinas.app.Persistencia
{
    public class RepositorioAsesor : IRepositorioAsesor // implementa la interfaz
    {
        private readonly AppContext _appContext;

        public RepositorioAsesor(AppContext appContext) // constructor
        {
            _appContext = appContext;
        }

        IEnumerable<Asesor> IRepositorioAsesor.GetAllAsesores()
        {
            return _appContext.Asesores; 
        }

        Asesor IRepositorioAsesor.GetAsesor(int IdAsesor)
        {
            var asesorEncontrado = _appContext.Asesores.FirstOrDefault(p => p.Id==IdAsesor);
            return asesorEncontrado;
        }

        //Add asesor
        Asesor IRepositorioAsesor.AddAsesor(Asesor asesor)
        {
            var asesorAdicional = _appContext.Asesores.Add(asesor);
            _appContext.SaveChanges();
            return asesorAdicional.Entity;
        }

        Asesor IRepositorioAsesor.UpdateAsesor(Asesor asesor)
        {
            
            var asesorEncontrado = _appContext.Asesores.FirstOrDefault(p => p.Id==asesor.Id);
            
            if(asesorEncontrado != null)
            {
                asesorEncontrado.Nombre = asesor.Nombre;
                asesorEncontrado.Apellidos = asesor.Apellidos;
                asesorEncontrado.Identificacion = asesor.Identificacion;
                asesorEncontrado.Edad = asesor.Edad;
                asesorEncontrado.Celular = asesor.Celular;
                asesorEncontrado.Correo = asesor.Correo;
                asesorEncontrado.HorasLaboradas = asesor.HorasLaboradas;
                asesorEncontrado.Estado_covid = asesor.Estado_covid;  
                asesorEncontrado.Oficinas_visitadas = asesor.Oficinas_visitadas;

                _appContext.SaveChanges();
            }
            return asesorEncontrado;
        }
    
        void IRepositorioAsesor.DeleteAsesor(int IdAsesor)
        {
            var asesorEncontrado = _appContext.Asesores.FirstOrDefault(p => p.Id == IdAsesor);
            if (asesorEncontrado == null)
                return; // se quita el false
            
            _appContext.Asesores.Remove(asesorEncontrado);
            _appContext.SaveChanges();
            //return true;
        }
    }    
}