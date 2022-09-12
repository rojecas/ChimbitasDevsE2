using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioFamiliarMemoria // No es una clase, es una interfaz
{
    IEnumerable<Cls_Familiar> GetAll();

    Cls_Familiar Add(Cls_Familiar familiar);

    Cls_Familiar Update(Cls_Familiar familiar);

    void Delete(int idfamiliar);

    Cls_Familiar Get(int idfamiliar);
    IEnumerable<Cls_Familiar>GetFilter(string filtro);
}