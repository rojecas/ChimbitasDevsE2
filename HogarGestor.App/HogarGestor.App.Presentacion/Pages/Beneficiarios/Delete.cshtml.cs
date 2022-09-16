using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_Beneficiarios;

    public class DeleteModel : PageModel
    {
            private readonly IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria; // atributo de Clase
    [BindProperty] // permite utilizar el objeto repositorioBeneficiarioMemoria en el backend y frontend
    public Cls_Beneficiario beneficiario { get; set; } // atributo disponible en todos los metodos de la clase

        public DeleteModel(IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria)
        {
            this.repositorioBeneficiarioMemoria = repositorioBeneficiarioMemoria;
        }
        public IActionResult OnGet(int id)
        {
            beneficiario= repositorioBeneficiarioMemoria.Get(id); 
            if(beneficiario==null)
                return RedirectToPage("./NotFound");
            return Page();
        }
        public IActionResult OnPostDelete()
        {
            repositorioBeneficiarioMemoria.Delete(beneficiario.Id);
            return RedirectToPage("Index");
        }
    }
