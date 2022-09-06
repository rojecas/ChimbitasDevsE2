using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia
{
    public interface IRepositorioFamiliar
    {
        Cls_Familiar AddFamiliar(Cls_Familiar familiar);
        Cls_Familiar UpdateFamiliar(Cls_Familiar familiar);
        void DeleteFamiliar(int IdFamiliar);
        Cls_Familiar GetFamiliar(int IdFamiliar);
    }
}