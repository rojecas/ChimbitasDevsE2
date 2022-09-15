using System.Collections.Generic;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia
{
    public interface IRepositorioNutricionista
    {
        Cls_PersonalSalud AddNutricionista(Cls_PersonalSalud nutricionista);
        Cls_PersonalSalud UpdateNutricionista(Cls_PersonalSalud nutricionista);
        void DeleteNutricionista(int IdNutricionista);
        Cls_PersonalSalud GetNutricionista(int IdNutricionista);
    }
}