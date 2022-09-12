using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioNutricionistaMemoria // No es una clase, es una interfaz
{
    IEnumerable<Cls_PersonalSalud> GetAll();

    Cls_PersonalSalud Add(Cls_PersonalSalud nutricionista);

   Cls_PersonalSalud Update(Cls_PersonalSalud nutricionista);

    void Delete(int idNutricionista);

    Cls_PersonalSalud Get(int idNutricionista);
    IEnumerable<Cls_PersonalSalud>GetFilter(string filtro);
}