//using Internal;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;

namespace HogarGestor.App.Consola
{
    class Program
    {
        private static IRepositorioBeneficiario _repoBeneficiario= new RepositorioBeneficiario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo EF!");
            AddBeneficiario();
            AddNutricionista();
        }
        private static void AddBeneficiario()
        {
            var beneficiario = new Cls_Beneficiario{
                nombre = "Nicola",
                apellido = "Tesla",
                documento = "14'255.963",
                latitud = 4.59590F,
                longitud = -74.07699F,
                ciudad = "Bogotá",
                fechaNacimiento = new DateTime (1856,07,10),
            };
            _repoBeneficiario.AddBeneficiario(beneficiario);
        }
         private static void AddNutricionista()
        {
            var newNutricionista = new Cls_PersonalSalud{
                nombre = "Camilo",
                apellido = "Moya",
                documento = "94'589.193",
                //latitud = 4.552150F,
                //longitud = -74.07699F,
                //ciudad = "Bogotá",
                //fechaNacimiento = new DateTime (1985,05,20),
                //Especialidad.Nutricionista = 0,
                especialidad=0,
            };
            _repoBeneficiario.AddBeneficiario(newNutricionista);
        }
    }
}