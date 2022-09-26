using System.Collections;
using System.Collections.Generic;
using HogarGestor.App.Dominio;
//esta clase aplica para nutricionista y pediatra
namespace HogarGestor.App.Persistencia;
public interface IRepositorioPersonalSalud // No es una clase, es una interfaz
{
    IEnumerable<Cls_PersonalSalud> GetAll();
    Cls_PersonalSalud Add(Cls_PersonalSalud personalSalud);
   Cls_PersonalSalud Update(Cls_PersonalSalud personalSalud);
    void Delete(int idPersonalSalud);
    Cls_PersonalSalud Get(int idPersonalSalud);
}