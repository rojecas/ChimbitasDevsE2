using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;
using HogarGestor.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.app.Presentacion.Pages_Beneficiarios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria;
        public IEnumerable<Cls_Beneficiario> beneficiarios {get;set;}
        [BindProperty(SupportsGet=true)]
        public string GetFilters{get; set;}
        public IndexModel(IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria)
        {
            this.repositorioBeneficiarioMemoria = repositorioBeneficiarioMemoria; 
        }
        public void OnGet(string GetFilters)
        {
            //beneficiarios=repositorioBeneficiarioMemoria.GetAll();
            beneficiarios=repositorioBeneficiarioMemoria.GetFilter(GetFilters);
        }
    }
}
