using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia;
public class RepositorioBeneficiario : IRepositorioBeneficiario
{// Atributos de interfase
    private readonly AppContext _appContext;
    public RepositorioBeneficiario(AppContext appContext)
    {
        _appContext = appContext;
    }
    Cls_Beneficiario IRepositorioBeneficiario.Add(Cls_Beneficiario beneficiario)
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
    Cls_Beneficiario IRepositorioBeneficiario.Get(int idBeneficiario)
    {
        return _appContext.beneficiarios.FirstOrDefault(p => p.Id == idBeneficiario);
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
    public Cls_PersonalSalud AssignPersonalSalud(int idBeneficiario, Cls_PersonalSalud personalSalud)
    {
        var beneficiarioEncontrado = _appContext.beneficiarios.SingleOrDefault(b => b.Id == idBeneficiario);
        if (beneficiarioEncontrado != null)
        {
            //if (personalSalud.especialidad.Equals(0))
            if (personalSalud.especialidad == Especialidad.Nutricionista)
            {
                beneficiarioEncontrado.nutricionista = personalSalud;
                beneficiarioEncontrado.pediatra = personalSalud;
                _appContext.SaveChanges();
                return personalSalud;
            }
            else
            {
                beneficiarioEncontrado.pediatra = personalSalud;
                _appContext.SaveChanges();
                return personalSalud;
            }
        }
        return null;
    }
    public Cls_Familiar AssignFamiliar(int idBeneficiario, Cls_Familiar familiar)
    {
        var beneficiarioEncontrado = _appContext.beneficiarios.SingleOrDefault(b => b.Id == idBeneficiario);
        if (beneficiarioEncontrado != null)
        {
            beneficiarioEncontrado.familiar = familiar;
            _appContext.SaveChanges();
            return familiar;
        }
        return null;
    }
    public Cls_Historia AssignHC(int IdBeneficiario, int IdHistoria)
    {
        var beneficiario = _appContext.beneficiarios.FirstOrDefault(b => b.Id == IdBeneficiario);
        if (beneficiario != null)
        {
            var historiaClinica = _appContext.historias.FirstOrDefault(h => h.Id == IdHistoria);
            if (historiaClinica != null)
            {
                beneficiario.historiaClinica = historiaClinica;
                _appContext.SaveChanges();
            }
            return historiaClinica;
        }
        return null;
    }

    public Cls_PersonalSalud consultarPS(int idBeneficiario, int identificador)
    {
        if (identificador == 1)
        {
            var beneficiario = _appContext.beneficiarios.Where(b => b.Id == idBeneficiario).Include(b => b.pediatra).FirstOrDefault();
            return beneficiario.pediatra;
        }
        else
        {
            var beneficiario = _appContext.beneficiarios.Where(b => b.Id == idBeneficiario).Include(b => b.nutricionista).FirstOrDefault();
            return beneficiario.nutricionista;
        }
    }

    public Cls_Familiar consultarfamiliar(int idBeneficiario)
    {
      
            var beneficiario = _appContext.beneficiarios.Where(b => b.Id == idBeneficiario).Include(b => b.familiar).FirstOrDefault();
            return beneficiario.familiar;
       
    }
}
