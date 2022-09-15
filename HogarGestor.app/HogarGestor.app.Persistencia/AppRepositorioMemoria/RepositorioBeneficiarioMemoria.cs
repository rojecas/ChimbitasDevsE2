using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia;

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
                }

            };
    }
    public IEnumerable<Cls_Beneficiario> GetAll() // Done!
    {
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
        return beneficiarios.SingleOrDefault(b=>b.Id == idBeneficiario);
    }
    public Cls_Beneficiario Update(Cls_Beneficiario beneficiario)
    {
        throw new NotImplementedException();
    }

    public void Delete(int idBeneficiario)
    {
        throw new NotImplementedException();
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
}