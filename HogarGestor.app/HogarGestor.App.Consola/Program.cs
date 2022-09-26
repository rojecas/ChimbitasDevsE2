using System.ComponentModel;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;

namespace HogarGestor.App.Consola;

class Program
{
    //private static IRepositorioBeneficiario _repoBeneficiario = new RepositorioBeneficiario(new Persistencia.AppContext());
    private static IRepositorioBeneficiario _repoBeneficiario = new RepositorioBeneficiario(new Persistencia.AppContext());
    private static IRepositorioFamiliar _repoFamiliar = new RepositorioFamiliar(new Persistencia.AppContext());
    //private static IRepositorioPersonalSalud _repoNutricionista2 = new RepositorioNutricionista(new Persistencia.AppContext());
    private static IRepositorioPersonalSalud _repoNutricionista = new RepositorioPersonalSalud(new Persistencia.AppContext());
    private static IRepositorioPersonalSalud _repoPediatra = new RepositorioPersonalSalud(new Persistencia.AppContext());
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("==========================================\n   App para la gestion del Hogar Gestor \n==========================================\n");
        Console.Write("Opciones\n1. Gestion de Beneficiarios\n2. Gestion de Familiares asignados\n3. Gestion de Personal de Salud\nEscoja la opcion que quiere ejecutar: ");
        int comando;
        comando = int.Parse(Console.ReadLine());
        if (comando == 1) // opcion seleccionada: Gestion de Beneficiarios
        {
            Console.WriteLine("La opcion seleccionada fue: 1. Gestion de Beneficiarios");
            Console.WriteLine("Escoja la opcion que quiere ejecutar: \n1. Crear Beneficiarios\n2. Consultar todos los Beneficiarios\n3. Consultar Beneficiario por ID\n4. Borrar un Beneficiario dado su ID\n5. Actualizar un Beneficiario dado su ID ");
            comando = int.Parse(Console.ReadLine());
            int Id = 0;
            switch (comando)
            {
                case 1:
                    Console.WriteLine("La opcion seleccionada fue: Crear Beneficiarios");
                    Console.Write("Escriba el(los) nombre(s) de el(la) Beneficiario(a): ");
                    string nombre = Console.ReadLine();
                    Console.Write("Escriba el(los) apellidos(s) de el(la) Beneficiario(a): ");
                    string apellido = Console.ReadLine();
                    Console.Write("Escriba el documento: ");
                    string documento = Console.ReadLine();
                    Console.Write("Escoja el genero del beneficiario: \n0. Masculino\n1. Femenino\n3. Intersexual \n4. NoBinario\n Escoja una de las opciones: ");
                    int i = int.Parse(Console.ReadLine());
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
                    DateTime fechaNacimiento = DateTime.Parse(fecha, System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine("Datos completos para creacion de un beneficiario.\n Conectando a la base de datos, espere confirmación");
                    CrearBeneficiario(nombre, apellido, documento, genero, latitud, longitud, ciudad, fechaNacimiento);
                    break;
                case 2:
                    Console.WriteLine("La opcion seleccionada fue: Consultar todos los Beneficiarios");
                    ListarBeneficiarios();
                    break;
                case 3:
                    Console.WriteLine("La opcion seleccionada fue: Consultar Beneficiario por ID");
                    Console.Write("Escriba el Id de el(la) Beneficiario(a): ");
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
                    Console.Write("Escriba el(los) nuevo(s) nombre(s) de el(la) Beneficiario(a): ");
                    nombre = Console.ReadLine();
                    Console.Write("Escriba el(los) nuevo(s) apellidos(s) de el(la) Beneficiario(a): ");
                    apellido = Console.ReadLine();
                    Console.Write("Escriba el documento: ");
                    documento = Console.ReadLine();
                    Console.Write("Escoja el genero del beneficiario: \n0. Masculino\n1. Femenino\n3. Intersexual \n4. NoBinario\n Escoja una de las opciones: ");
                    i = int.Parse(Console.ReadLine());
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
                    latitud = float.Parse(Console.ReadLine());
                    Console.Write("Escriba la Longitud de la vivienda Beneficiario(a), Formato numerico xx,xxxxx: ");
                    longitud = float.Parse(Console.ReadLine());
                    Console.Write("Escriba el nombre de la ciudad de vivienda del Beneficiario(a): ");
                    ciudad = Console.ReadLine();
                    Console.Write("Escriba la fecha de nacimiento de el(la) Beneficiario(a) en formato May 1, 2008  -Mmm dd, yyyy- :");
                    fecha = Console.ReadLine();
                    fechaNacimiento = DateTime.Parse(fecha, System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine("Datos completos para actualizacion de un beneficiario.\n Conectando a la base de datos, espere confirmación ...");
                    ActualizarBeneficiario(Id, nombre, apellido, documento, genero, latitud, longitud, ciudad, fechaNacimiento);
                    break;
            }
        }
        else
        {
            if (comando == 2)  // opcion seleccionada: Gestion de Familiares
            {
                Console.WriteLine("La opcion seleccionada fue: 2. Gestion de Familiares");
                Console.Write("Opciones\n1. Crear Familiar\nEscoja la opcion que quiere ejecutar: ");
                comando = int.Parse(Console.ReadLine());
                Console.Write("Escriba el(los) nombre(s) de el(la) familiar: ");
                string nombre = Console.ReadLine();
                Console.Write("Escriba el(los) apellidos(s) de el(la) familiar: ");
                string apellido = Console.ReadLine();
                Console.Write("Escriba el documento: ");
                string documento = Console.ReadLine();
                Console.Write("Escoja el genero de el(la) familiar: \n0. Masculino\n1. Femenino\n3. Intersexual \n4. NoBinario\n Escoja una de las opciones: ");
                int i = int.Parse(Console.ReadLine());
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
                Console.WriteLine("Datos completos para creacion de un Familiar.\n Conectando a la base de datos, espere confirmación ...");
                CrearFamiliar(nombre, apellido, documento, genero);
            }
            else
            {
                if (comando == 3)  // opcion seleccionada: Gestion de Personal Salud
                {
                    Console.WriteLine("La opcion seleccionada fue: 3. Gestion de Personal de la Salud");
                    Console.Write("Opciones\n1. Crear Nutricionista\n2. Crear Pediatra\nEscoja la opcion que quiere ejecutar: ");
                    comando = int.Parse(Console.ReadLine());
                    string tipo;
                    if (comando == 1)
                    {
                        tipo = "Nutricionista";
                    }
                    else
                    {
                        tipo = "Pediatra";
                    }
                    Console.Write("Escriba el(los) nombre(s) de el(la) " + tipo + " :");
                    string nombre = Console.ReadLine();
                    Console.Write("Escriba el(los) apellidos(s) de el(la) " + tipo + " :");
                    string apellido = Console.ReadLine();
                    Console.Write("Escriba el documento: ");
                    string documento = Console.ReadLine();
                    Console.Write("Escoja el genero de el(la) " + tipo + " :  \n0. Masculino\n1. Femenino\n3. Intersexual \n4. NoBinario\n Escoja una de las opciones: ");
                    int i = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Datos completos para creacion de personal de la salud.\n Conectando a la base de datos, espere confirmación ...");
                    CrearPersonalSalud(nombre, apellido, documento, genero,tipo);

                }
                else
                    Console.WriteLine("Seleccionó una opcion invalida - Programa Finalizado");
            }
        }
    }
    private static void CrearBeneficiario(string nombre, string apellido, string documento, Genero genero, float latitud, float longitud, string ciudad, DateTime fechaNacimiento)
    {
        var beneficiario = new Cls_Beneficiario();
        beneficiario.nombre = nombre;
        beneficiario.apellido = apellido;
        beneficiario.documento = documento;
        beneficiario.genero = genero;
        beneficiario.latitud = latitud;
        beneficiario.longitud = longitud;
        beneficiario.ciudad = ciudad;
        beneficiario.fechaNacimiento = fechaNacimiento;
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
        _repoBeneficiario.Add(beneficiario);
        Console.WriteLine("Se creó satisfactoriamente el Beneficiario con nombre: " + nombre + " " + apellido);
    }

    private static void CrearFamiliar(string nombre, string apellido, string documento, Genero genero)
    {
        var familiar = new Cls_Familiar();
        familiar.nombre = nombre;
        familiar.apellido = apellido;
        familiar.documento = documento;
        familiar.genero = genero;
        _repoFamiliar.Add(familiar);
        Console.WriteLine("Se creó satisfactoriamente el Familiar con nombre: " + nombre + " " + apellido);
    }

    private static void CrearPersonalSalud(string nombre, string apellido, string documento, Genero genero, string tipo)
    {
        if (tipo == "Nutricionista")
        {
            var nutricionista = new Cls_PersonalSalud();
            nutricionista.nombre = nombre;
            nutricionista.apellido = apellido;
            nutricionista.documento = documento;
            nutricionista.genero = genero;
            nutricionista.especialidad = Especialidad.Nutricionista;
            _repoNutricionista.Add(nutricionista);
        }
        else
        {
            var pediatra = new Cls_PersonalSalud();
            pediatra.nombre = nombre;
            pediatra.apellido = apellido;
            pediatra.documento = documento;
            pediatra.genero = genero;
            pediatra.especialidad = Especialidad.Pediatra;
            _repoPediatra.Add(pediatra);
        }

        Console.WriteLine("Se creó satisfactoriamente el " + tipo + " con nombre: " + nombre + " " + apellido);
    }
    private static void ListarBeneficiarios()
    {
        var beneficiarios = _repoBeneficiario.GetAll();
        Console.WriteLine("Nombres      Apellidos         DocId       Genero");
        Console.WriteLine("______________________________________________________");
        foreach (var beneficiario in beneficiarios)
        {
            Console.WriteLine(beneficiario.nombre + "        " + beneficiario.apellido + "        " + beneficiario.documento + "        " + beneficiario.genero);
        }
        Console.WriteLine("\nConsulta finalizada fin del programa\n");
    }
    private static void BuscarBeneficiario(int IdBeneficiario)
    {
        var beneficiario = _repoBeneficiario.Get(IdBeneficiario);
        if (beneficiario != null)
        {
            Console.WriteLine("Nombres      Apellidos         DocId       Genero");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(beneficiario.nombre + "        " + beneficiario.apellido + "        " + beneficiario.documento + "        " + beneficiario.genero);
            Console.WriteLine("\nConsulta finalizada fin del programa\n");
            return;
        }
        Console.WriteLine("No existe un beneficiario con el Id ingresado");
    }
    private static void BorrarBeneficiario(int IdBeneficiario)
    {
        var beneficiario = _repoBeneficiario.Get(IdBeneficiario);
        Console.WriteLine("Se borró el usuario con Documento: " + beneficiario.documento);
        Console.WriteLine("y nombre: " + beneficiario.nombre + " " + beneficiario.apellido);
        _repoBeneficiario.Delete(IdBeneficiario);
    }
    private static void ActualizarBeneficiario(int IdBeneficiario, string nombre, string apellido, string documento, Genero genero, float latitud, float longitud, string ciudad, DateTime fechaNacimiento)
    {
        var beneficiario = _repoBeneficiario.Get(IdBeneficiario);
        Console.WriteLine("Se Actualizo la informacion del usuario con anterior Documento: " + beneficiario.documento);
        Console.WriteLine("y antiguo nombre: " + beneficiario.nombre + " " + beneficiario.apellido);
        beneficiario.nombre = nombre;
        beneficiario.apellido = apellido;
        beneficiario.documento = documento;
        beneficiario.genero = genero;
        beneficiario.latitud = latitud;
        beneficiario.longitud = longitud;
        beneficiario.ciudad = ciudad;
        beneficiario.fechaNacimiento = fechaNacimiento;
        _repoBeneficiario.Update(beneficiario);
    }

}
