using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioNutricionistaMemoria // No es una clase, es una interfaz
{
    IEnumerable<Cls_Nutricionista> GetAll();

    Cls_Nutricionita Add(Cls_Nutricionista nutricionista);

    Cls_Nutricionita Update(Cls_Nutricionita nutricionista);

    void Delete(int idnutricionista);

    Cls_Nutricionita Get(int idnutricionista);
    IEnumerable<Cls_Nutricionita>GetFilter(string filtro);
}