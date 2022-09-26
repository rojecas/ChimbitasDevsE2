using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public class RepositorioHistoriaC : IRepositorioHistoriaC
{
    private readonly AppContext _appContext;
    public RepositorioHistoriaC(AppContext appContext)
    {
        _appContext = appContext;
    }
    Cls_Historia IRepositorioHistoriaC.AddHC(Cls_Historia historia)
    {
        var historiaAdded = _appContext.historias.Add(historia);
        _appContext.SaveChanges();
        return historiaAdded.Entity;
    }
    Cls_Historia IRepositorioHistoriaC.GetHC(int idHistoria)
    {
        return _appContext.historias.FirstOrDefault(h => h.Id == idHistoria);
    }
    public IEnumerable<Cls_Historia> GetAllHC()
    {
        return _appContext.historias;
        //throw new NotImplementedException();
    }
    Cls_Historia IRepositorioHistoriaC.CreateHC(Cls_Historia historia)
    {
        throw new NotImplementedException();
    }
    Cls_Historia IRepositorioHistoriaC.UpdateHC(Cls_Historia historia)
    {
        throw new NotImplementedException();
    }
    void IRepositorioHistoriaC.DeleteHC(int IdHistoria)
    {
        throw new NotImplementedException();
    }

}