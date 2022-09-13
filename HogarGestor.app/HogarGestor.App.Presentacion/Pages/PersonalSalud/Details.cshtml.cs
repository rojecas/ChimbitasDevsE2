using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_PersonalSalud;

public class DetailsModel : PageModel
{
    private readonly IRepositorioNutricionistaMemoria repositorioNutricionistaMemoria; // atributo de Clase

 public Cls_PersonalSalud nutricionista { get; set; }
    public DetailsModel(IRepositorioNutricionistaMemoria repositorioNutricionistaMemoria) // Metodo constructor de la clase Details (modelo)
    {
        this.repositorioNutricionistaMemoria = repositorioNutricionistaMemoria;
    }
    public IActionResult OnGet(int Id)
    {
        nutricionista=repositorioNutricionistaMemoria.Get(Id);
            if(nutricionista==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
    }
}
