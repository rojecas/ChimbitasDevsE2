using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbFamiliares;
public class CreateModel : PageModel
{
    private readonly IRepositorioFamiliar repositorioFamiliar;
    [BindProperty]
    public Cls_Familiar familiar { get; set; }
    public CreateModel(IRepositorioFamiliar repositorioFamiliar)
    { // Metodo constructor de la clase Create (modelo)
        this.repositorioFamiliar = repositorioFamiliar;
    }
    public void OnGet()
    {
    }
    public IActionResult OnPostSave()
    {
        familiar = repositorioFamiliar.Add(familiar);
        return RedirectToPage("Index");
    }
}