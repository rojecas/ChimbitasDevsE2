using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia
{
    public interface IRepositorioBeneficiario
    {
        IEnumerable<Cls_Beneficiario> GetAllBeneficiarios();
        Cls_Beneficiario AddBeneficiario(Cls_Beneficiario beneficiario);
        Cls_Beneficiario UpdateBeneficiario(Cls_Beneficiario beneficiario);
        void DeleteBeneficiario(int IdBeneficiario);
        Cls_Beneficiario Get(int IdBeneficiario);
        Cls_Historia AsignarHistoriaC(int IdBeneficiario, int IdHistoria);

    }
}