using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia
{
    public class RepositorioNutricionista : IRepositorioNutricionista
    {
        private readonly AppContext _appContext;
        public RepositorioNutricionista(AppContext appContext)
        {
            _appContext = appContext;
        }
        HogarGestor.App.Dominio.Cls_PersonalSalud IRepositorioNutricionista.AddNutricionista(HogarGestor.App.Dominio.Cls_PersonalSalud nutricionista)
        {
            var nutricionistaAdicionado = _appContext.nutricionista.Add(nutricionista);
            _appContext.SaveChanges();
            return nutricionistaAdicionado.Entity;
        }
        void IRepositorioNutricionista.DeleteNutricionista(int IdNutricionista)
        {
            var nutricionistaEncontrado=_appContext.nutricionista.FirstOrDefault(p=>p.Id==IdNutricionista);
            if(nutricionistaEncontrado==null)
            return;
            _appContext.nutricionista.Remove(nutricionistaEncontrado);
            _appContext.SaveChanges();
        }
        Cls_PersonalSalud IRepositorioNutricionista.GetNutricionista(int IdNutricionista)
        {
            return _appContext.nutricionista.FirstOrDefault(p=>p.Id==IdNutricionista);          
        }
        Cls_PersonalSalud IRepositorioNutricionista.UpdateNutricionista(Cls_PersonalSalud nutricionista)
        {
            var nutricionistaEncontrado = _appContext.nutricionista.FirstOrDefault(p=>p.Id==nutricionista.Id);
            if(nutricionistaEncontrado != null)
            {
                nutricionistaEncontrado.nombre = nutricionista.nombre;
                nutricionistaEncontrado.apellido = nutricionista.apellido;
                nutricionistaEncontrado.documento = nutricionista.documento;
                nutricionistaEncontrado.genero = nutricionista.genero;
                _appContext.SaveChanges();
           }
           return nutricionistaEncontrado;
        }
    }
}