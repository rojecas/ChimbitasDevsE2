//using Internal;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
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
            Console.Clear();
            Console.WriteLine("==========================================\n   App para la gestion del Hogar Gestor \n==========================================\n");
            Console.WriteLine("Escoja la opcion que quiere ejecutar: \n1. Gestion de Beneficiarios\n2. Gestion de Familiares asignados\n3. Gestion de Personal de Salud");
            int comando;
            comando = int.Parse(Console.ReadLine());
            if (comando==1){
                Console.WriteLine("La opcion seleccionada fue: 1. Gestion de Beneficiarios");
                Console.WriteLine("Escoja la opcion que quiere ejecutar: \n1. Crear Beneficiarios\n2. Consultar todos los Beneficiarios\n3. Consultar Beneficiario por ID\n4. Borrar un Beneficiario dado su ID\n5. Actualizar un Beneficiario dado su ID ");
                comando =  int.Parse(Console.ReadLine());
                int Id = 0;
                switch(comando)
                {
                    case  1:
                    Console.WriteLine("La opcion seleccionada fue: Crear Beneficiarios");
                    Console.Write("Escriba el(los) nombre(s) de el(la) Beneficiario(a): ");
                    string nombre = Console.ReadLine();
                    Console.Write("Escriba el(los) apellidos(s) de el(la) Beneficiario(a): ");
                    string apellido = Console.ReadLine();
                    Console.Write("Escriba el documento: ");
                    string documento = Console.ReadLine();
                    Console.Write("Escoja el genero del beneficiario: \n0. Masculino\n1. Femenino\n3. Intersexual \n4. NoBinario\n Escoja una de las opciones: ");
                    int i=int.Parse(Console.ReadLine());
                    Genero genero;
                    switch (i)
                    {
                        case 0:
                        genero = Genero.Masculino;
                        break;
                        case 1:
                        genero = Genero.Femenino;
                        break;
                        case 2:
                        genero = Genero.Intersexual;
                        break;
                        case 3:
                        genero = Genero.NoBinario;
                        break;
                        default:
                        genero = Genero.NoIngresado;
                        break;
                    }
                    Console.Write("Escriba la Latitud de la vivienda Beneficiario(a), Formato numerico xx,xxxxx: ");
                    float latitud = float.Parse(Console.ReadLine());
                    Console.Write("Escriba la Longitud de la vivienda Beneficiario(a), Formato numerico xx,xxxxx: ");
                    float longitud = float.Parse(Console.ReadLine());
                    Console.Write("Escriba el nombre de la ciudad de vivienda del Beneficiario(a): ");
                    string ciudad = Console.ReadLine();
                    Console.Write("Escriba la fecha de nacimiento de el(la) Beneficiario(a) en formato May 1, 2008  -Mmm dd, yyyy- :");
                    string fecha = Console.ReadLine();
                    DateTime fechaNacimiento = DateTime.Parse(fecha,System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine("Datos completos para creacion de un beneficiario. Conectando a la base de datos, espere confirmación");
                    CrearBeneficiario(nombre, apellido, documento, genero, latitud, longitud, ciudad, fechaNacimiento);                      
                    break;
                    case 2:
                    Console.WriteLine("La opcion seleccionada fue: Consultar todos los Beneficiarios");
                    BuscarBeneficiario(1);
                    break;
                    case 3:
                    Console.WriteLine("La opcion seleccionada fue: Consultar Beneficiario por ID");
                    Console.WriteLine("Escriba el Id de el(la) Beneficiario(a): ");
                    Id = int.Parse(Console.ReadLine());
                    BuscarBeneficiario(Id);
                    break;
                    case 4:
                    Console.WriteLine("La opcion seleccionada fue: Borrar Beneficiario");
                    Console.WriteLine("Escriba el Id de el(la) Beneficiario(a): ");
                    Id = int.Parse(Console.ReadLine());
                    BorrarBeneficiario(Id);
                    break;
                    case 5:
                    Console.WriteLine("La opcion seleccionada fue: Actualizar Beneficiario");
                    Console.WriteLine("Escriba el Id de el(la) Beneficiario(a): ");
                    Id = int.Parse(Console.ReadLine());
                    //ActualizarBeneficiario(3,"Pablo", "Cassals","98'365.418", genero.Masculino, 3.89635F, -75.14960F, "Cali");
                    break;
                }
                
            }
            else
            {
                Console.WriteLine("La opcion seleccionada fue: " + comando + " y todavia no se encuentra implementada");

            }
        }
       private static void CrearBeneficiario(string nombre, string apellido, string documento, Genero genero, float latitud, float longitud, string ciudad, DateTime fechaNacimiento)
        {
            var beneficiario = new Cls_Beneficiario();
            beneficiario.nombre= nombre;
            beneficiario.apellido= apellido;
            beneficiario.documento= documento;
            beneficiario.genero= genero;
            beneficiario.latitud= latitud;
            beneficiario.longitud= longitud;
            beneficiario.ciudad= ciudad;
            beneficiario.fechaNacimiento= fechaNacimiento;
           /*  var beneficiario = new Cls_Beneficiario{
                nombre = "Nicola",
                apellido = "Tesla",
                documento = "14'255.963",
                genero=0,
                latitud = 4.59590F,
                longitud = -74.07699F,
                ciudad = "Bogotá",
                fechaNacimiento = new DateTime (1856,07,10), 
            };*/
            _repoBeneficiario.AddBeneficiario(beneficiario);
            Console.WriteLine("Se creó satisfactoriamente el Beneficiario con nombre: " + nombre +" "+ apellido);
        }
        private static void BuscarBeneficiario(int IdBeneficiario)
        {
            var beneficiario = _repoBeneficiario.GetBeneficiario(IdBeneficiario);
            Console.WriteLine("Nombre el Joven:"+beneficiario.nombre+" "+beneficiario.apellido);
        }
        private static void BorrarBeneficiario(int IdBeneficiario)
        {
            var beneficiario = _repoBeneficiario.GetBeneficiario(IdBeneficiario);
            Console.WriteLine("Se borró el usuario con Documento: "+beneficiario.documento);
            Console.WriteLine("y nombre: "+beneficiario.nombre+" "+beneficiario.apellido);
            _repoBeneficiario.DeleteBeneficiario(IdBeneficiario);
        }
        private static void ActualizarBeneficiario(int IdBeneficiario, string nombre, string apellido, string documento,/* Enum genero ,*/float latitud, float longitud, string ciudad)
        {
            var beneficiario = _repoBeneficiario.GetBeneficiario(IdBeneficiario);
            Console.WriteLine("Se Actualizo la informacion del usuario con Documento: "+beneficiario.documento);
            Console.WriteLine("y nombre: "+beneficiario.nombre+" "+beneficiario.apellido);
            beneficiario.nombre = nombre;
            beneficiario.apellido = apellido;
            beneficiario.documento = documento;
            //beneficiario.genero=genero;
            beneficiario.latitud = latitud;
            beneficiario.longitud = longitud;
            beneficiario.ciudad = "Barranquilla";
            beneficiario.fechaNacimiento = new DateTime (2006,02,19);
            _repoBeneficiario.UpdateBeneficiario(beneficiario);
        }

    }
}