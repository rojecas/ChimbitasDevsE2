using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;

namespace HogarGestor.App.Persistencia
{
    public class RepositorioBeneficiario : IRepositorioBeneficiario
    {
        private readonly AppContext _appContext;
        public RepositorioBeneficiario(AppContext appContext)
        {
            _appContext = appContext;
        }
        HogarGestor.App.Dominio.Cls_Beneficiario IRepositorioBeneficiario.AddBeneficiario(HogarGestor.App.Dominio.Cls_Beneficiario beneficiario)
        {
            var beneficiarioAdicionado = _appContext.beneficiarios.Add(beneficiario);
            _appContext.SaveChanges();
            return beneficiarioAdicionado.Entity;
        }
        void IRepositorioBeneficiario.DeleteBeneficiario(int IdBeneficiario)
        {
            var beneficiarioEncontrado=_appContext.beneficiarios.FirstOrDefault(p=>p.Id==IdBeneficiario);
            if(beneficiarioEncontrado==null)
            return;
            _appContext.beneficiarios.Remove(beneficiarioEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Cls_Beneficiario> IRepositorioBeneficiario.GetAllBeneficiarios()
        {
            return _appContext.beneficiarios;
        }
        Cls_Beneficiario IRepositorioBeneficiario.GetBeneficiario(int IdBeneficiario)
        {
            return _appContext.beneficiarios.FirstOrDefault(p=>p.Id==IdBeneficiario);          
        }
        Cls_Beneficiario IRepositorioBeneficiario.UpdateBeneficiario(Cls_Beneficiario beneficiario)
        {
            var beneficiarioEncontrado = _appContext.beneficiarios.FirstOrDefault(p=>p.Id==beneficiario.Id);
            if(beneficiarioEncontrado != null)
            {
                beneficiarioEncontrado.nombre = beneficiario.nombre;
                beneficiarioEncontrado.apellido = beneficiario.apellido;
                beneficiarioEncontrado.documento = beneficiario.documento;
                beneficiarioEncontrado.genero = beneficiario.genero;
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
    }
}