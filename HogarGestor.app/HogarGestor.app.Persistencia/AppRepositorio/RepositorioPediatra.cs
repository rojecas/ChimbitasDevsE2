using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia
{
    public class RepositorioPediatra : IRepositorioPediatra
    {
        private readonly AppContext _appContext;
        public RepositorioPediatra(AppContext appContext)
        {
            _appContext = appContext;
        }
        HogarGestor.app.Dominio.Cls_PersonalSalud IRepositorioPediatra.AddPediatra(HogarGestor.app.Dominio.Cls_PersonalSalud pediatra)
        {
            var pediatraAdicionado = _appContext.pediatra.Add(pediatra);
            _appContext.SaveChanges();
            return pediatraAdicionado.Entity;
        }
        void IRepositorioPediatra.DeletePediatra(int IdPediatra)
        {
            var pediatraEncontrado=_appContext.pediatra.FirstOrDefault(p=>p.Id==IdPediatra);
            if(pediatraEncontrado==null)
            return;
            _appContext.pediatra.Remove(pediatraEncontrado);
            _appContext.SaveChanges();
        }
        Cls_PersonalSalud IRepositorioPediatra.GetPediatra(int IdPediatra)
        {
            return _appContext.pediatra.FirstOrDefault(p=>p.Id==IdPediatra);          
        }
        Cls_PersonalSalud IRepositorioPediatra.UpdatePediatra(HogarGestor.app.Dominio.Cls_PersonalSalud pediatra)
        {
            var pediatraEncontrado = _appContext.pediatra.FirstOrDefault(p=>p.Id==pediatra.Id);
            if(pediatraEncontrado != null)
            {
                pediatraEncontrado.nombre = pediatra.nombre;
                pediatraEncontrado.apellido = pediatra.apellido;
                pediatraEncontrado.documento = pediatra.documento;
                pediatraEncontrado.telefono = pediatra.telefono;
                pediatraEncontrado.genero = pediatra.genero;
                pediatraEncontrado.regRethus = pediatra.regRethus;
                _appContext.SaveChanges();
           }
           return pediatraEncontrado;
        }
    }
}