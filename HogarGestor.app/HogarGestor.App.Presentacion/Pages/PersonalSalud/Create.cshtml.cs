using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_PersonalSalud;

public class CreateModel : PageModel
{
    private readonly IRepositorioNutricionistaMemoria repositorioNutricionistaMemoria; // atributo de Clase
    [BindProperty]
    public Cls_PersonalSalud nutricionista { get; set; }
    public CreateModel(IRepositorioNutricionistaMemoria repositorioNutricionistaMemoria) // Metodo constructor de la clase Create (modelo)
    {
        this.repositorioNutricionistaMemoria = repositorioNutricionistaMemoria;
    }
    public void OnGet()
    {

    }
    public IActionResult OnPostSave()
    {
        nutricionista = repositorioNutricionistaMemoria.Add(nutricionista);
        return RedirectToPage("Index");
    }
}



