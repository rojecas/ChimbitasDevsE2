using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia;

    public class RepositorioFamiliar : IRepositorioFamiliar
{
    private readonly AppContext _appContext;
    public RepositorioFamiliar(AppContext appContext)
    {
        _appContext = appContext;
    }
    HogarGestor.app.Dominio.Cls_Familiar IRepositorioFamiliar.AddFamiliar(HogarGestor.app.Dominio.Cls_Familiar familiar)
    {
        var familiarAdicionado = _appContext.familiar.Add(familiar);
        _appContext.SaveChanges();
        return familiarAdicionado.Entity;
    }
    void IRepositorioFamiliar.DeleteFamiliar(int IdFamiliar)
    {
        var familiarEncontrado = _appContext.familiar.FirstOrDefault(p => p.Id == IdFamiliar);
        if (familiarEncontrado == null)
            return;
        _appContext.familiar.Remove(familiarEncontrado);
        _appContext.SaveChanges();
    }
    Cls_Familiar IRepositorioFamiliar.GetFamiliar(int IdFamiliar)
    {
        return _appContext.familiar.FirstOrDefault(p => p.Id == IdFamiliar);
    }
    Cls_Familiar IRepositorioFamiliar.UpdateFamiliar(Cls_Familiar familiar)
    {
        var familiarEncontrado = _appContext.familiar.FirstOrDefault(p => p.Id == familiar.Id);
        if (familiarEncontrado != null)
        {
            familiarEncontrado.nombre = familiar.nombre;
            familiarEncontrado.apellido = familiar.apellido;
            familiarEncontrado.documento = familiar.documento;
            familiarEncontrado.telefono = familiar.telefono;
            familiarEncontrado.parentesco = familiar.parentesco;
            familiarEncontrado.email = familiar.email;
            familiarEncontrado.genero = familiar.genero;
            _appContext.SaveChanges();
        }
        return familiarEncontrado;
    }
}