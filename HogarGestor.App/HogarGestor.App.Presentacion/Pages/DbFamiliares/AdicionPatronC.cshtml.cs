using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbFamiliares;
public class AdicionPatronCModel : PageModel
{
    private readonly IRepositorioPatronC repositorioPatronC;
    [BindProperty]
    public Cls_PatronCrecimiento patronCrecimiento { get; set; }
    public AdicionPatronCModel(IRepositorioPatronC repositorioPatronC)
    { // Metodo constructor de la clase Create (modelo)
        this.repositorioPatronC = repositorioPatronC;
    }
    public void OnGet()
    {
    }
    public IActionResult OnPostSave()
    {
        patronCrecimiento = repositorioPatronC.AddPC(patronCrecimiento);
        return RedirectToPage("Index");
    }
}