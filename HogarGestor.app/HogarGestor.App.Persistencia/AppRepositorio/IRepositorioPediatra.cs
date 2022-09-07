using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia
{
    public interface IRepositorioPediatra
    {
        Cls_PersonalSalud AddPediatra(Cls_PersonalSalud pediatra);
        Cls_PersonalSalud UpdatePediatra(Cls_PersonalSalud pediatra);
        void DeletePediatra(int IdPediatra);
        Cls_PersonalSalud GetPediatra(int IdPediatra);
    }
}