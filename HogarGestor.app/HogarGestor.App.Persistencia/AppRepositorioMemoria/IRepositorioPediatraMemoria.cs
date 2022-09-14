
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioPediatraMemoria // No es una clase, es una interfaz...
{
    IEnumerable<Cls_PersonalSalud> GetAll();

    Cls_PersonalSalud Add(Cls_PersonalSalud pediatra);

   Cls_PersonalSalud Update(Cls_PersonalSalud pediatra);

    void Delete(int idPediatra);

    Cls_PersonalSalud Get(int idPediatra);
    IEnumerable<Cls_PersonalSalud>GetFilter(string filtro);
} 
    