using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbBeneficiarios;

public class DeleteModel : PageModel
{
    private readonly IRepositorioBeneficiario repositorioBeneficiario; // atributo de Clase
    [BindProperty] // permite utilizar el objeto repositorioBeneficiarioMemoria en el backend y frontend
    public Cls_Beneficiario beneficiario { get; set; } // atributo disponible en todos los metodos de la clase
    public DeleteModel(IRepositorioBeneficiario repositorioBeneficiario)
    {
        this.repositorioBeneficiario = repositorioBeneficiario;
    }
    public IActionResult OnGet(int id)
    {
        beneficiario = repositorioBeneficiario.Get(id);
        if (beneficiario == null)
            return RedirectToPage("./NotFound");
        return Page();
    }
    public IActionResult OnPostDelete()
    {
        repositorioBeneficiario.Delete(beneficiario.Id);
        return RedirectToPage("Index");
    }
}