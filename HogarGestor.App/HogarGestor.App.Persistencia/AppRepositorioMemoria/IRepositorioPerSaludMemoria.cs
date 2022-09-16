using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using HogarGestor.App.Dominio;
//esta clase aplica para nutricinista y pediatra
namespace HogarGestor.App.Persistencia;
public interface IRepositorioPerSaludMemoria // No es una clase, es una interfaz
{
    IEnumerable<Cls_PersonalSalud> GetAll();
    Cls_PersonalSalud Add(Cls_PersonalSalud perSalud);
   Cls_PersonalSalud Update(Cls_PersonalSalud perSalud);
    void Delete(int idPerSalud);
    Cls_PersonalSalud Get(int idPerSalud);
    IEnumerable<Cls_PersonalSalud>GetFilter(string filtro);
}