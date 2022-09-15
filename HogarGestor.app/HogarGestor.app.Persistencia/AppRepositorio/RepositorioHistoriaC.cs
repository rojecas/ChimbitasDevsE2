using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia;

public class RepositorioHistoriaC : IRepositorioHistoriaC
{
    private readonly AppContext _appContext;
    public RepositorioHistoriaC(AppContext appContext)
    {
        _appContext = appContext;
    }
    
    HogarGestor.app.Dominio.Cls_Historia IRepositorioHistoriaC.CrearHistoriaC(HogarGestor.app.Dominio.Cls_Historia historia)
    {
        throw new NotImplementedException();
    }
   
HogarGestor.app.Dominio.Cls_Historia IRepositorioHistoriaC.AsignarHistoriaC(HogarGestor.app.Dominio.Cls_Historia historia)
    {
        var historiaCreada = _appContext.historia.Add(historia);
        _appContext.SaveChanges();
        return historiaCreada.Entity;
    }
}