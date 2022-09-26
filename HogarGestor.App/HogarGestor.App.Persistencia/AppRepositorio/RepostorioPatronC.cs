using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public class RepositorioPatronC : IRepositorioPatronC
{
    private readonly AppContext _appContext;
    public RepositorioPatronC(AppContext appContext)
    {
        _appContext = appContext;
    }
    Cls_PatronCrecimiento IRepositorioPatronC.AddPC(Cls_PatronCrecimiento patronCrecimiento)
    {
        var patronCrecimientoAdded = _appContext.patronesDeCrecimiento.Add(patronCrecimiento);
        _appContext.SaveChanges();
        return patronCrecimientoAdded.Entity;
    }
    Cls_PatronCrecimiento IRepositorioPatronC.GetPC(int idPatron)
    {
        return _appContext.patronesDeCrecimiento.FirstOrDefault(h => h.Id == idPatron);
    }
    public IEnumerable<Cls_PatronCrecimiento> GetAllPC()
    {
        return _appContext.patronesDeCrecimiento;
    }
    Cls_PatronCrecimiento IRepositorioPatronC.CreatePC(Cls_PatronCrecimiento patronCrecimiento)
    {
        throw new NotImplementedException();
    }
    Cls_PatronCrecimiento IRepositorioPatronC.UpdatePC(Cls_PatronCrecimiento patronCrecimiento)
    {
        throw new NotImplementedException();
    }
    void IRepositorioPatronC.DeletePC(int IdPatron)
    {
        throw new NotImplementedException();
    }
}