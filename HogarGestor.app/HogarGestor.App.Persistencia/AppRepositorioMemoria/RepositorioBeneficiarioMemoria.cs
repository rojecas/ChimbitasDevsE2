using System.Timers;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;

public class RepositorioBeneficiarioMemoria : IRepositorioBeneficiarioMemoria
{
    List<Cls_Beneficiario> beneficiarios;
    public RepositorioBeneficiarioMemoria()
    {
        beneficiarios = new List<Cls_Beneficiario>(){
                new Cls_Beneficiario{
                    Id=1,
                    nombre = "Nicola",
                    apellido = "Tesla",
                    documento = "14'255.963",
                    genero=0,
                    telefono= "3105893654",
                    direccion= "Cll 11A No.23-78",
                    latitud = 4.59590F,
                    longitud = -74.07699F,
                    ciudad = "Bogotá",
                    fechaNacimiento = new DateTime (1856,07,10),
                    nutricionista = null,
                    pediatra = null,
                },
                 new Cls_Beneficiario{
                    Id=2,
                    nombre = "Bart",
                    apellido = "Simpson",
                    documento = "1'123.276.098",
                    genero=0,
                    telefono= "3150891154",
                    direccion= "Cra 1 No.34-74",
                    latitud = 4.595321F,
                    longitud = -74.072223F,
                    ciudad = "Springfield",
                    fechaNacimiento = new DateTime (2003,07,11),
                    nutricionista = null,
                    pediatra = null,
                }

            };
    }
    public IEnumerable<Cls_Beneficiario> GetFilter(string filtro = null)  // Done!
    {
        var beneficiarios = GetAll();
        if (beneficiarios != null)
        {
            if (!String.IsNullOrEmpty(filtro))
            {
                beneficiarios = beneficiarios.Where(b => b.nombre.Contains(filtro));
            }
        }
        return beneficiarios;
    }
    public Cls_Beneficiario Add(Cls_Beneficiario beneficiario)  // Done!
    {
        beneficiario.Id = beneficiarios.Max(b => b.Id) + 1;
        beneficiarios.Add(beneficiario);
        return beneficiario;
    }
    public Cls_Beneficiario Get(int idBeneficiario)
    {// Recupera de la lista de beneficiarios, aquel para el cual el Id sea igual al solicitado
        return beneficiarios.SingleOrDefault(b => b.Id == idBeneficiario);
    }
    public IEnumerable<Cls_Beneficiario> GetAll() // Done!
    {
        return beneficiarios;
    }
    public Cls_Beneficiario Update(Cls_Beneficiario beneficiario)
    {
        var beneficiarioEncontrado = beneficiarios.SingleOrDefault(b => b.Id == beneficiario.Id);
        if (beneficiarioEncontrado != null)
        {
            beneficiarioEncontrado.nombre = beneficiario.nombre;
            beneficiarioEncontrado.apellido = beneficiario.apellido;
            beneficiarioEncontrado.documento = beneficiario.documento;
            beneficiarioEncontrado.telefono = beneficiario.telefono;
            beneficiarioEncontrado.genero = beneficiario.genero;
            beneficiarioEncontrado.direccion = beneficiario.direccion;
            beneficiarioEncontrado.latitud = beneficiario.latitud;
            beneficiarioEncontrado.longitud = beneficiario.longitud;
            beneficiarioEncontrado.ciudad = beneficiario.ciudad;
            beneficiarioEncontrado.fechaNacimiento = beneficiario.fechaNacimiento;
            beneficiarioEncontrado.familiar = beneficiario.familiar;
            beneficiarioEncontrado.pediatra = beneficiario.pediatra;
            beneficiarioEncontrado.nutricionista = beneficiario.nutricionista;
            beneficiarioEncontrado.historiaClinica = beneficiario.historiaClinica;
        }
        return beneficiarioEncontrado;
    }
    public void Delete(int idBeneficiario)
    {
        var beneficiario = beneficiarios.SingleOrDefault(p => p.Id == idBeneficiario);
        if (beneficiario == null)
            return;
        beneficiarios.Remove(beneficiario);
        //_appContext.SaveChanges();
    }
    public Cls_PersonalSalud toAssignPerSalud(int idBeneficiario, Cls_PersonalSalud perSalud)
    {
        var beneficiarioEncontrado = beneficiarios.SingleOrDefault(p => p.Id == idBeneficiario);
        if (beneficiarioEncontrado != null)
        {
                if(perSalud.especialidad == Especialidad.Pediatra)
                {
                    beneficiarioEncontrado.pediatra = perSalud;
                    return perSalud;
                }
                beneficiarioEncontrado.nutricionista = perSalud;
                return perSalud;
        }
        return null;
    }
}