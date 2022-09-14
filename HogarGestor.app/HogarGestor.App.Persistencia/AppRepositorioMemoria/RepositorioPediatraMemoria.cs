using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;

public class RepositorioPediatraMemoria : IRepositorioPediatraMemoria
{
    List<Cls_PersonalSalud> pediatras;
    public RepositorioPediatraMemoria()
    {
        pediatras = new List<Cls_PersonalSalud>(){
                new Cls_PersonalSalud{
                    Id=5,
                    nombre = "Mark",
                    apellido = "Zukenberg",
                    documento = "443'423.093",
                    genero=Genero.Masculino,
                    especialidad=Especialidad.Pediatra,
                    regRethus="378278",
                    telefono= "3234567809",
                },
                 new Cls_PersonalSalud{
                    Id=6,
                    nombre = "Marie",
                    apellido = "Curie",
                    documento = "56'543.656",
                    genero = Genero.Femenino,
                    especialidad=Especialidad.Pediatra,
                    regRethus="43254654",
                    telefono= "3213456789",
                }
            };
    }
    public IEnumerable<Cls_PersonalSalud> GetAll() // Done!
    {
        return pediatras;
    }
    public Cls_PersonalSalud Add(Cls_PersonalSalud pediatra)  // Done!
    {
        pediatra.Id = pediatras.Max(b => b.Id) + 1;
        pediatras.Add(pediatra);
        return pediatra;
    }
    public Cls_PersonalSalud Get(int idPediatra) 
    {// Recupera de la lista de pediatrass, aquel para el cual el Id sea igual al solicitado ...
        return pediatras.SingleOrDefault(b=>b.Id == idPediatra);
    }
    public Cls_PersonalSalud Update(Cls_PersonalSalud pediatra)
    {
        throw new NotImplementedException();
    }
    public void Delete(int idPediatra)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Cls_PersonalSalud> GetFilter(string filtro = null)  // Done!
    {
        var pediatras = GetAll();
        if (pediatras != null)
        {
            if (!String.IsNullOrEmpty(filtro))
            {
                pediatras = pediatras.Where(b => b.nombre.Contains(filtro));
            }
        }
        return pediatras;
    }
}