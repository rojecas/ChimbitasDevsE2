using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public class RepositorioFamiliarMemoria : IRepositorioFamiliarMemoria
{
    List<Cls_Familiar> familiares;
    public RepositorioFamiliarMemoria()
    {
        familiares = new List<Cls_Familiar>(){
                new Cls_Familiar{
                    Id=3,
                    nombre = "Thomas",
                    apellido = "Edinson",
                    documento = "94'525.093",
                    genero=Genero.Masculino,
                    telefono= "3105893654",
                    email= "t.edinson@latinmail.com",
                    parentesco="Padre",
                },
                 new Cls_Familiar{
                    Id=4,
                    nombre = "Homero",
                    apellido = "Simpson",
                    documento = "21'876.098",
                    genero=Genero.Masculino,
                    telefono= "3508912154",
                    email= "homersimpson@latinmail.com",
                    parentesco="Padre",
                }
            };
    }
    public IEnumerable<Cls_Familiar> GetAll() // Done!
    {
        return familiares;
    }
    public Cls_Familiar Add(Cls_Familiar familiar)  // Done!
    {
        familiar.Id = familiares.Max(b => b.Id) + 1;
        familiares.Add(familiar);
        return familiar;
    }
    public Cls_Familiar Get(int idFamiliar) 
    {// Recupera de la lista de familiares, aquel para el cual el Id sea igual al solicitado
        return familiares.SingleOrDefault(b=>b.Id == idFamiliar);
    }
    public Cls_Familiar Update(Cls_Familiar familiar)
    {
        throw new NotImplementedException();
    }

    public void Delete(int idFamiliar)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Cls_Familiar> GetFilter(string filtro = null)  // Done!
    {
        var familiares = GetAll();
        if (familiares != null)
        {
            if (!String.IsNullOrEmpty(filtro))
            {
                familiares = familiares.Where(b => b.nombre.Contains(filtro));
            }
        }
        return familiares;
    }
}