using System.Collections;
using System.Security.Cryptography.X509Certificates;

using System.Collections.Generic;
using HogarGestor.App.Dominio;
namespace HogarGestor.App.Persistencia;

public interface IRepositorioBeneficiarioMemoria // No es una clase, es una interfaz
{
    IEnumerable<Cls_Beneficiario> GetAll();

    Cls_Beneficiario Add(Cls_Beneficiario beneficiario);

    Cls_Beneficiario Update(Cls_Beneficiario beneficiario);

    void Delete(int idBeneficiario);

    Cls_Beneficiario Get(int idBeneficiario);
}
