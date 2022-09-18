using System;
using System.Linq;
using System.Collections.Generic;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public class RepositorioBeneficiario : IRepositorioBeneficiario
{
    private readonly AppContext _appContext;
    public RepositorioBeneficiario(AppContext appContext)
    {
        _appContext = appContext;
    }
    HogarGestor.App.Dominio.Cls_Beneficiario IRepositorioBeneficiario.Add(HogarGestor.App.Dominio.Cls_Beneficiario beneficiario)
    {
        var beneficiarioAdicionado = _appContext.beneficiarios.Add(beneficiario);
        _appContext.SaveChanges();
        return beneficiarioAdicionado.Entity;
    }
    void IRepositorioBeneficiario.Delete(int IdBeneficiario)
    {
        var beneficiarioEncontrado = _appContext.beneficiarios.FirstOrDefault(b => b.Id == IdBeneficiario);
        if (beneficiarioEncontrado == null)
            return;
        _appContext.beneficiarios.Remove(beneficiarioEncontrado);
        _appContext.SaveChanges();
    }
    IEnumerable<Cls_Beneficiario> IRepositorioBeneficiario.GetAll()
    {
        return _appContext.beneficiarios;
    }
    Cls_Beneficiario IRepositorioBeneficiario.Get(int IdBeneficiario)
    {
        return _appContext.beneficiarios.FirstOrDefault(p => p.Id == IdBeneficiario);
    }
    Cls_Beneficiario IRepositorioBeneficiario.Update(Cls_Beneficiario beneficiario)
    {
        var beneficiarioEncontrado = _appContext.beneficiarios.FirstOrDefault(b => b.Id == beneficiario.Id);
        if (beneficiarioEncontrado != null)
        {
            beneficiarioEncontrado.nombre = beneficiario.nombre;
            beneficiarioEncontrado.apellido = beneficiario.apellido;
            beneficiarioEncontrado.documento = beneficiario.documento;
            beneficiarioEncontrado.telefono = beneficiario.telefono;
            beneficiarioEncontrado.genero = beneficiario.genero;
            beneficiarioEncontrado.direccion = beneficiario.direccion;
            beneficiarioEncontrado.latitud = beneficiario.latitud;
            beneficiarioEncontrado.longitud = beneficiario.longitud;
            beneficiarioEncontrado.ciudad = beneficiario.ciudad;
            beneficiarioEncontrado.fechaNacimiento = beneficiario.fechaNacimiento;
            beneficiarioEncontrado.familiar = beneficiario.familiar;
            beneficiarioEncontrado.pediatra = beneficiario.pediatra;
            beneficiarioEncontrado.nutricionista = beneficiario.nutricionista;
            beneficiarioEncontrado.historiaClinica = beneficiario.historiaClinica;
            _appContext.SaveChanges();
        }
        return beneficiarioEncontrado;
    }
    public Cls_Historia AsignarHistoriaC(int IdBeneficiario, int IdHistoria)
    {
        var beneficiario = _appContext.beneficiarios.FirstOrDefault(b => b.Id == IdBeneficiario);
        if (beneficiario != null)
        {
            var historiaClinica = _appContext.historia.FirstOrDefault(h => h.Id == IdHistoria);
            if (historiaClinica != null)
            {
                beneficiario.historiaClinica = historiaClinica;
                _appContext.SaveChanges();
            }
            return historiaClinica;
        }
        return null;
    }
}