//using System;
using System.Linq;
using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public class RepositorioPersonalSalud : IRepositorioPersonalSalud
{ // Atributos de interfase
    private readonly AppContext _appContext;
    public RepositorioPersonalSalud(AppContext appContext)
    {//Constructor de Interfaz RepositorioPersonalSalud
        _appContext = appContext;
    }
    IEnumerable<Cls_PersonalSalud> IRepositorioPersonalSalud.GetAll() // Done!
    {
        return _appContext.personasSalud;
    }
    Cls_PersonalSalud IRepositorioPersonalSalud.Add(Cls_PersonalSalud personalSalud)  // Done!
    {
        var personalSaludAdicionado = _appContext.personasSalud.Add(personalSalud);
        _appContext.SaveChanges();
        return personalSaludAdicionado.Entity;
    }
    void IRepositorioPersonalSalud.Delete(int idPersonalSalud)
    {
        var personalSaludEncontrado = _appContext.personasSalud.FirstOrDefault(p => p.Id == idPersonalSalud);
        if (personalSaludEncontrado == null)
            return;
        _appContext.personasSalud.Remove(personalSaludEncontrado);
        _appContext.SaveChanges();
    }
    Cls_PersonalSalud IRepositorioPersonalSalud.Get(int idPersonalSalud)
    {// Recupera de la lista de personasSalud, aquel para el cual el Id sea igual al solicitado
        return _appContext.personasSalud.FirstOrDefault(p => p.Id == idPersonalSalud);
    }
    Cls_PersonalSalud IRepositorioPersonalSalud.Update(Cls_PersonalSalud personalSalud)
    {
        var personalSaludEncontrado = _appContext.personasSalud.FirstOrDefault(p => p.Id == personalSalud.Id);
        if (personalSaludEncontrado != null)
        {
            personalSaludEncontrado.nombre = personalSalud.nombre;
            personalSaludEncontrado.apellido = personalSalud.apellido;
            personalSaludEncontrado.documento = personalSalud.documento;
            personalSaludEncontrado.telefono = personalSalud.telefono;
            personalSaludEncontrado.genero = personalSalud.genero;
            personalSaludEncontrado.especialidad = personalSalud.especialidad;
            personalSaludEncontrado.RegRethus = personalSalud.RegRethus;
            _appContext.SaveChanges();
        }
        return personalSaludEncontrado;
    }
}