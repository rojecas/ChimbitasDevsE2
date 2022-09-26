using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbBeneficiarios;
public class CreateModel : PageModel
{ // atributos de Clase
    private readonly IRepositorioBeneficiario repositorioBeneficiario;
    [BindProperty]
    public Cls_Beneficiario beneficiario { get; set; }
    public CreateModel(IRepositorioBeneficiario repositorioBeneficiario)
    { // Metodo constructor de la clase Create (modelo)
        this.repositorioBeneficiario = repositorioBeneficiario;
    }
    public void OnGet()
    {
    }
    public IActionResult OnPostSave()
    {
        beneficiario = repositorioBeneficiario.Add(beneficiario);
        return RedirectToPage("Index");
    }
}