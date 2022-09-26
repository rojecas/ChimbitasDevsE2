using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
    public class RepositorioFamiliar : IRepositorioFamiliar
{// Atributos de interfase
    private readonly AppContext _appContext;
    public RepositorioFamiliar(AppContext appContext)
    {//Constructor de Interfaz RepositorioFamilar
        _appContext = appContext;
    }
    IEnumerable<Cls_Familiar> IRepositorioFamiliar.GetAll()
    {
        return _appContext.familiares;
    }
    Cls_Familiar IRepositorioFamiliar.Add(Cls_Familiar familiar)
    {
        var familiarAdicionado = _appContext.familiares.Add(familiar);
        _appContext.SaveChanges();
        return familiarAdicionado.Entity;
    }
    void IRepositorioFamiliar.Delete(int idFamiliar)
    {
        var familiarEncontrado = _appContext.familiares.FirstOrDefault(f => f.Id == idFamiliar);
        if (familiarEncontrado == null)
            return;
        _appContext.familiares.Remove(familiarEncontrado);
        _appContext.SaveChanges();
    }
    Cls_Familiar IRepositorioFamiliar.Get(int idFamiliar)
    {// Recupera de la lista de personasSalud, aquel para el cual el Id sea igual al solicitado
        return _appContext.familiares.FirstOrDefault(f => f.Id == idFamiliar);
    }
    Cls_Familiar IRepositorioFamiliar.Update(Cls_Familiar familiar)
    {
        var familiarEncontrado = _appContext.familiares.FirstOrDefault(p => p.Id == familiar.Id);
        if (familiarEncontrado != null)
        {
            familiarEncontrado.nombre = familiar.nombre;
            familiarEncontrado.apellido = familiar.apellido;
            familiarEncontrado.documento = familiar.documento;
            familiarEncontrado.genero = familiar.genero;
            familiarEncontrado.telefono = familiar.telefono;
            familiarEncontrado.parentesco = familiar.parentesco;
            familiarEncontrado.email = familiar.email;
            _appContext.SaveChanges();
        }
        return familiarEncontrado;
    }
}