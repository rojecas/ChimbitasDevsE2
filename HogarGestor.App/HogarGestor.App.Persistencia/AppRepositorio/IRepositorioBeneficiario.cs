using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia
{
    public interface IRepositorioBeneficiario
    {
        IEnumerable<Cls_Beneficiario> GetAll();
        Cls_Beneficiario Add(Cls_Beneficiario beneficiario);
        Cls_Beneficiario Update(Cls_Beneficiario beneficiario);
        void Delete(int IdBeneficiario);
        Cls_Beneficiario Get(int IdBeneficiario);
        Cls_Historia AsignarHistoriaC(int IdBeneficiario, int IdHistoria);

    }
}