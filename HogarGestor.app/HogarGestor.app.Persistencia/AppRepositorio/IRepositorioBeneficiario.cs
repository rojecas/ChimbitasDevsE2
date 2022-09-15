using System.Collections.Generic;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia
{
    public interface IRepositorioBeneficiario
    {
        IEnumerable<Cls_Beneficiario> GetAllBeneficiarios();
        Cls_Beneficiario AddBeneficiario(Cls_Beneficiario beneficiario);
        Cls_Beneficiario UpdateBeneficiario(Cls_Beneficiario beneficiario);
        void DeleteBeneficiario(int IdBeneficiario);
        Cls_Beneficiario GetBeneficiario(int IdBeneficiario);
        Cls_Historia AsignarHistoriaC(int IdBeneficiario, int IdHistoria);

    }
}