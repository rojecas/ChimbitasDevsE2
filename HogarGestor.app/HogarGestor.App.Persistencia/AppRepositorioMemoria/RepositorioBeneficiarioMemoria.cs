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
                    nombre = "Homero",
                    apellido = "Simpson",
                    documento = "21'876.098",
                    genero=0,
                    telefono= "3150891154",
                    direccion= "Cra 1 No.34-74",
                    latitud = 4.595321F,
                    longitud = -74.072223F,
                    ciudad = "Cali",
                    fechaNacimiento = new DateTime (1972,08,11),
                }

            };
    }
    public IEnumerable<Cls_Beneficiario> GetAll()
    {
        throw new NotImplementedException();
    }
    public Cls_Beneficiario Add(Cls_Beneficiario beneficiario)
    {
        throw new NotImplementedException();
    }

    public Cls_Beneficiario Update(Cls_Beneficiario beneficiario)
    {
        throw new NotImplementedException();
    }

    public void Delete(int idBeneficiario)
    {
        throw new NotImplementedException();
    }

    public Cls_Beneficiario Get(int idBeneficiario)
    {
        throw new NotImplementedException();
    }
}