using System.Collections;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioFamiliar // No es una clase, es una interfaz
{
    IEnumerable<Cls_Familiar> GetAll();
    Cls_Familiar Add(Cls_Familiar familiar);
    Cls_Familiar Update(Cls_Familiar familiar);
    void Delete(int IdFamiliar);
    Cls_Familiar Get(int IdFamiliar);
}