using System.Collections.Generic;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia
{
    public interface IRepositorioFamiliar
    {
        Cls_Familiar AddFamiliar(Cls_Familiar familiar);
        Cls_Familiar UpdateFamiliar(Cls_Familiar familiar);
        void DeleteFamiliar(int IdFamiliar);
        Cls_Familiar GetFamiliar(int IdFamiliar);
    }
}