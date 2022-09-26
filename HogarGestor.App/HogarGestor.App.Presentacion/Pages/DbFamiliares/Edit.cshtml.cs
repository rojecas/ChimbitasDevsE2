using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbFamiliares;
public class EditModel : PageModel
{
    private readonly IRepositorioFamiliar repositorioFamiliar; // atributo de Clase
    [BindProperty] // permite utilizar el objeto repositorioBeneficiarioMemoria en el backend y frontend
    public Cls_Familiar familiar { get; set; } // atributo disponible en todos los metodos de la clase
    public EditModel(IRepositorioFamiliar repositorioFamiliar)
    {
        this.repositorioFamiliar = repositorioFamiliar;
    }
    public IActionResult OnGet(int id)
    {
        familiar = repositorioFamiliar.Get(id);
        if (familiar == null)
            return RedirectToPage("./NoFound");
        else
            return Page();
    }
    public IActionResult OnPostEdit()
    {
        familiar = repositorioFamiliar.Update(familiar);
        return Page();
    }
}