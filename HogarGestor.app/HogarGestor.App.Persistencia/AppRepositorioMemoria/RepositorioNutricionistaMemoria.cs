using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;

public class RepositorioNutricionistaMemoria : IRepositorioNutricionistaMemoria
{
    List<Cls_PersonalSalud> nutricionistas;
    public RepositorioNutricionistaMemoria()
    {
        nutricionistas = new List<Cls_PersonalSalud>(){
                new Cls_PersonalSalud{
                    Id=5,
                    nombre = "Mark",
                    apellido = "Zukenberg",
                    documento = "443'423.093",
                    genero=Genero.Masculino,
                    especialidad=Especialidad.Nutricionista,
                    regRethus="378278",
                    telefono= "3234567809",
                },
                 new Cls_PersonalSalud{
                    Id=6,
                    nombre = "Marie",
                    apellido = "Curie",
                    documento = "56'543.656",
                    genero = Genero.Femenino,
                    especialidad=Especialidad.Nutricionista,
                    regRethus="43254654",
                    telefono= "3213456789",
                }
            };
    }
    public IEnumerable<Cls_PersonalSalud> GetAll() // Done!
    {
        return nutricionistas;
    }
    public Cls_PersonalSalud Add(Cls_PersonalSalud nutricionista)  // Done!
    {
        nutricionista.Id = nutricionistas.Max(b => b.Id) + 1;
        nutricionistas.Add(nutricionista);
        return nutricionista;
    }
    public Cls_PersonalSalud Get(int idNutricionista) 
    {// Recupera de la lista de nutricionistas, aquel para el cual el Id sea igual al solicitado
        return nutricionistas.SingleOrDefault(b=>b.Id == idNutricionista);
    }
    public Cls_PersonalSalud Update(Cls_PersonalSalud nutricionista)
    {
        throw new NotImplementedException();
    }
    public void Delete(int idNutricionista)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Cls_PersonalSalud> GetFilter(string filtro = null)  // Done!
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