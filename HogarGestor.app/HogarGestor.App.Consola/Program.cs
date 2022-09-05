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
        private static void AddBeneficiario()
        {
            var beneficiario = new Cls_Beneficiario{
                nombre = "sebastian",
                apellido = "Restrepo",
                documento = "19'333.963",
                latitud = 4.69590F,
                longitud = -74.19699F,
                ciudad = "Bogotá",
                fechaNacimiento = new DateTime (2019,09,23),
            };
            _repoBeneficiario.AddBeneficiario(beneficiario);
        }
        private static void AddBeneficiario()
        {
            var beneficiario = new Cls_Beneficiario{
                nombre = "Daniela",
                apellido = "Ariza",
                documento = "23'000.163",
                latitud = 4.59990F,
                longitud = -99.12399F,
                ciudad = "Bogotá",
                fechaNacimiento = new DateTime (2012,01,19),
            };
            _repoBeneficiario.AddBeneficiario(beneficiario);
        }    
        private static void AddBeneficiario()
        {
            var beneficiario = new Cls_Beneficiario{
                nombre = "Hugo",
                apellido = "Perez",
                documento = "43'343.663",
                latitud = 2.59590F,
                longitud = -54.00000F,
                ciudad = "Santander",
                fechaNacimiento = new DateTime (2012,02,11),
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