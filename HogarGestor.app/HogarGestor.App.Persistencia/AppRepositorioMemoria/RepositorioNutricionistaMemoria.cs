using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;

public class RepositorioNutricionistaMemoria : IRepositorioNutricionistaMemoria
{
    List<Cls_Nutricionista> nutricionistas;
    public RepositorioNutricionistaMemoria()
    {
        familiares = new List<Cls_Nutricionista>(){
                new Cls_Nutricionista{
                    Id=1,
                    nombre = "Mark",
                    apellido = "Zukenberg",
                    documento = "443'423.093",
                    genero=0,
                    Especialidad=Nutricionista,
                    RegRethus=378278,
                    telefono= "3234567809",
                    email= "M.Zukenberg@latinmail.com",
                },
                 new Cls_Nutricionista{
                    Id=2,
                    nombre = "Marie",
                    apellido = "Curie",
                    documento = "56'543.656",
                    genero=1,
                    Especialidad=Nutricionista,
                    RegRethus=43254654,
                    telefono= "3213456789",
                    email= "M.Curie@latinmail.com",
                }
            };
    }
    public IEnumerable<Cls_Nutricionista> GetAll() // Done!
    {
        return nutricionistas;
    }
    public Cls_Nutricionista Add(Cls_Nutricionista nutricionista)  // Done!
    {
        nutricionista.Id = nutricionistas.Max(b => b.Id) + 1;
        nutricionistas.Add(nutricionista);
        return nutricionista;
    }
    public Cls_Nutricionista Get(int idnutricionista) 
    {// Recupera de la lista de nutricionistas, aquel para el cual el Id sea igual al solicitado
        return nutricionistas.SingleOrDefault(b=>b.Id == idnutricionista);
    }
    public Cls_Nutricionista Update(Cls_Nutricionista nutricionista)
    {
        throw new NotImplementedException();
    }

    public void Delete(int idnutricionista)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Cls_Nutricionista> GetFilter(string filtro = null)  // Done!
    {
        var nutricionistas = GetAll();
        if (nutricionistas != null)
        {
            if (!String.IsNullOrEmpty(filtro))
            {
                nutricionistas = nutricionistas.Where(b => b.nombre.Contains(filtro));
            }
        }
        return nutricionistas;
    }
}