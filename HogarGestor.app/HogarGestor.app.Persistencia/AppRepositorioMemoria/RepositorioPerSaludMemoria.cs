using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia;
public class RepositorioPerSaludMemoria : IRepositorioPerSaludMemoria
{
    List<Cls_PersonalSalud> personasSalud;
    public RepositorioPerSaludMemoria()
    {
        personasSalud = new List<Cls_PersonalSalud>()
            {
                new Cls_PersonalSalud
                {
                    Id=5,
                    nombre = "Mark",
                    apellido = "Zuckerberg",
                    documento = "443'423.093",
                    genero=Genero.Masculino,
                    especialidad=Especialidad.Nutricionista,
                    regRethus="378278",
                    telefono= "3234567809",
                },
                 new Cls_PersonalSalud
                {
                    Id=6,
                    nombre = "Marie",
                    apellido = "Curie",
                    documento = "56'543.656",
                    genero = Genero.Femenino,
                    especialidad=Especialidad.Pediatra,
                    regRethus="43254654",
                    telefono= "3213456789",
                },
                new Cls_PersonalSalud
				{
                    Id=7,
                    nombre = "Julius",
                    apellido = "Hubbert",
                    documento = "443'423.093",
                    genero=Genero.Masculino,
                    especialidad=Especialidad.Pediatra,
                    regRethus="378278",
                    telefono= "3234567809",
                },
                new Cls_PersonalSalud
				{
                    Id=8,
                    nombre = "Nick",
                    apellido = "Riviera",
                    documento = "14'423.231",
                    genero = Genero.Masculino,
                    especialidad=Especialidad.Pediatra,
                    regRethus="111254654",
                    telefono= "3103456837",
                }
            };
    }
    public IEnumerable<Cls_PersonalSalud> GetAll() // Done!
    {
        return personasSalud;
    }
    public Cls_PersonalSalud Add(Cls_PersonalSalud perSalud)  // Done!
    {
        perSalud.Id = personasSalud.Max(b => b.Id) + 1;
        personasSalud.Add(perSalud);
        return perSalud;
    }
    public Cls_PersonalSalud Get(int idPerSalud)
    {// Recupera de la lista de personasSalud, aquel para el cual el Id sea igual al solicitado
        return personasSalud.SingleOrDefault(b => b.Id == idPerSalud);
    }
    public Cls_PersonalSalud Update(Cls_PersonalSalud perSalud)
    {
        throw new NotImplementedException();
    }
    public void Delete(int idPerSalud)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Cls_PersonalSalud> GetFilter(string filtro = null)  // Done!
    {
        var personasSalud = GetAll();
        if (personasSalud != null)
        {
            if (!String.IsNullOrEmpty(filtro))
            {
                personasSalud = personasSalud.Where(b => b.nombre.Contains(filtro));
            }
        }
        return personasSalud;
    }
}