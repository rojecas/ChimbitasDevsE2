using System.Collections;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public interface IRepositorioBeneficiario
{
    IEnumerable<Cls_Beneficiario> GetAll();
    Cls_Beneficiario Add(Cls_Beneficiario beneficiario);
    Cls_Beneficiario Update(Cls_Beneficiario beneficiario);
    void Delete(int idBeneficiario);
    Cls_Beneficiario Get(int idBeneficiario);
    Cls_PersonalSalud AssignPersonalSalud(int idBeneficiario, Cls_PersonalSalud perSalud);
    Cls_Familiar AssignFamiliar(int idBeneficiario, Cls_Familiar familiar);
    Cls_Historia AssignHC(int idBeneficiario, int idHistoria);
    Cls_PersonalSalud consultarPS (int idBeneficiario, int identificador);
    Cls_Familiar consultarfamiliar (int idBeneficiario);
}