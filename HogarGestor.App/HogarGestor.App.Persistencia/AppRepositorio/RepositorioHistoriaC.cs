using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;

public class RepositorioHistoriaC : IRepositorioHistoriaC
{
    private readonly AppContext _appContext;
    public RepositorioHistoriaC(AppContext appContext)
    {
        _appContext = appContext;
    }
    
    HogarGestor.App.Dominio.Cls_Historia IRepositorioHistoriaC.CrearHistoriaC(HogarGestor.App.Dominio.Cls_Historia historia)
    {
        throw new NotImplementedException();
    }
   
HogarGestor.App.Dominio.Cls_Historia IRepositorioHistoriaC.AsignarHistoriaC(HogarGestor.App.Dominio.Cls_Historia historia)
    {
        var historiaCreada = _appContext.historia.Add(historia);
        _appContext.SaveChanges();
        return historiaCreada.Entity;
    }
}