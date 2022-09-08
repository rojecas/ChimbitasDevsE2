using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.App.Dominio;
namespace  HogarGestor.App.Persistencia
{
   public class RepositorioBeneficiarioMemoria:IRepositorioBeneficiarioMemoria
   {
        List<Beneficiario> Beneficiarios;
        public RepositorioBeneficiarioMemoria(){
            Beneficiarios=new List<Benefisciario>(){
                new Beneficiario{
                    nombre = "Nicola",
                    apellido = "Tesla",
                    documento = "14'255.963",
                    genero=0,
                    latitud = 4.59590F,
                    longitud = -74.07699F,
                    ciudad = "Bogotá",
                    fechaNacimiento = new DateTime (1856,07,10), 
                },
                 new Beneficiario{
                    nombre = "Homero",
                    apellido = "Simpson",
                    documento = "21'876.098",
                    genero=0,
                    latitud = 4.595321F,
                    longitud = -74.072223F,
                    ciudad = "Bogotá",
                    fechaNacimiento = new DateTime (1960,08,11), 
                }

            };
        }
        public IEnumerable<Beneficiario> GetAll(){
            throw new NotImplementedException();
        }
        public Beneficiario Add(Beneficiario beneficiario){
            throw new NotImplementedException();
        }

        public Beneficiario Update(Beneficiario beneficiario){
            throw new NotImplementedException();
        }

        public void Delete(int idBeneficiario){
            throw new NotImplementedException();
        }

        public Beneficiario Get(int idBeneficiario){
            throw new NotImplementedException();
        }
   }
}

