using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;
using HogarGestor.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.app.Presentacion.Pages_Beneficiarios
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria; // atributo de Clase
        public Cls_Beneficiario beneficiario {get; set;}

        public DetailsModel(IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria) // Metodo constructor de la clase Details (modelo)
    {
        this.repositorioBeneficiarioMemoria = repositorioBeneficiarioMemoria;
    }
        public IActionResult OnGet(int Id)
        {
            beneficiario=repositorioBeneficiarioMemoria.Get(Id);
            if(beneficiario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
