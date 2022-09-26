using System.Linq;
using System.Collections;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioPatronC
{
    IEnumerable<Cls_PatronCrecimiento> GetAllPC();
    HogarGestor.App.Dominio.Cls_PatronCrecimiento AddPC(HogarGestor.App.Dominio.Cls_PatronCrecimiento patronCrecimiento);
    HogarGestor.App.Dominio.Cls_PatronCrecimiento CreatePC(HogarGestor.App.Dominio.Cls_PatronCrecimiento patronCrecimiento);
    HogarGestor.App.Dominio.Cls_PatronCrecimiento UpdatePC(HogarGestor.App.Dominio.Cls_PatronCrecimiento patronCrecimiento);
    void DeletePC(int idPC);
    HogarGestor.App.Dominio.Cls_PatronCrecimiento GetPC(int idPC);
}