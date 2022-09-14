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
    private readonly IRepositorioPerSaludMemoria repositorioPerSaludMemoria; // atributo de Clase
    [BindProperty]
    public Cls_PersonalSalud perSalud { get; set; }
    public CreateModel(IRepositorioPerSaludMemoria repositorioPerSaludMemoria) // Metodo constructor de la clase Create (modelo)
    {
        this.repositorioPerSaludMemoria = repositorioPerSaludMemoria;
    }
    public void OnGet()
    {

    }
    public IActionResult OnPostSave()
    {
        perSalud = repositorioPerSaludMemoria.Add(perSalud);
        return RedirectToPage("Index");
    }
}



