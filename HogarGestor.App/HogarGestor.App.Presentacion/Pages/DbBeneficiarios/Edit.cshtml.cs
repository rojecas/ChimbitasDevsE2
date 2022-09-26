using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbBeneficiarios;

public class EditModel : PageModel
{
    private readonly IRepositorioBeneficiario repositorioBeneficiario; // atributo de Clase
    [BindProperty] // permite utilizar el objeto repositorioBeneficiarioMemoria en el backend y frontend
    public Cls_Beneficiario beneficiario { get; set; } // atributo disponible en todos los metodos de la clase
    public EditModel(IRepositorioBeneficiario repositorioBeneficiario)
    {
        this.repositorioBeneficiario = repositorioBeneficiario;
    }
    public IActionResult OnGet(int id)
    {
        beneficiario = repositorioBeneficiario.Get(id);
        if (beneficiario == null)
            return RedirectToPage("./NoFound");
        else
            return Page();
    }
    public IActionResult OnPostEdit()
    {
        beneficiario = repositorioBeneficiario.Update(beneficiario);
        return Page();
    }
}