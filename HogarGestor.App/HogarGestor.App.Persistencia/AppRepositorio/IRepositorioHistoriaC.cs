using System.Linq;
using System.Collections;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioHistoriaC
{
    IEnumerable<Cls_Historia> GetAllHC();
    Cls_Historia AddHC(Cls_Historia historia);
    Cls_Historia CreateHC(Cls_Historia historia);
    Cls_Historia UpdateHC(Cls_Historia historia);
    void DeleteHC(int IdHistoria);
    Cls_Historia GetHC(int IdHistoria);
}