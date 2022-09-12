using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_Familiares;

public class CreateModel : PageModel
{
    private readonly IRepositorioFamiliarMemoria repositorioFamiliarMemoria; // atributo de Clase
    [BindProperty]
    public Cls_Familiar familiar { get; set; }
    public CreateModel(IRepositorioFamiliarMemoria repositorioFamiliarMemoria) // Metodo constructor de la clase Create (modelo)
    {
        this.repositorioFamiliarMemoria = repositorioFamiliarMemoria;
    }
    public void OnGet()
    {

    }
    public IActionResult OnPostSave()
    {
        familiar = repositorioFamiliarMemoria.Add(familiar);
        return RedirectToPage("Index");
    }
}

