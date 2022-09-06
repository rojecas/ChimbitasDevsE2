using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia
{
    public interface IRepositorioNutricionista
    {
        Cls_PersonalSalud AddNutricionista(Cls_PersonalSalud nutricionista);
        Cls_PersonalSalud UpdateNutricionista(Cls_PersonalSalud nutricionista);
        void DeleteNutricionista(int IdNutricionista);
        Cls_PersonalSalud GetNutricionista(int IdNutricionista);
    }
}