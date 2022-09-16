using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;
using HogarGestor.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.app.Presentacion.Pages_Beneficiarios;

public class CreateModel : PageModel
{
    private readonly IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria; // atributo de Clase
    [BindProperty]
    public Cls_Beneficiario beneficiario {get; set;}
    public CreateModel(IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria) // Metodo constructor de la clase Create (modelo)
    {
        this.repositorioBeneficiarioMemoria = repositorioBeneficiarioMemoria;
    }

    public void OnGet()
    {

    }
    public IActionResult OnPostSave()
    {
        beneficiario=repositorioBeneficiarioMemoria.Add(beneficiario);
        return RedirectToPage("Index");
    }
}

