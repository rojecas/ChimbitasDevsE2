using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_PersonalSalud;

public class IndexModel : PageModel
{
    private readonly IRepositorioNutricionistaMemoria repositorioNutricionistaMemoria;
    public IEnumerable<Cls_PersonalSalud> nutricionistas { get; set; }
    [BindProperty(SupportsGet = true)]
    public string GetFilters { get; set; }
    public IndexModel(IRepositorioNutricionistaMemoria repositorioNutricionistaMemoria)
    {
        this.repositorioNutricionistaMemoria = repositorioNutricionistaMemoria;
    }
    public void OnGet(string GetFilters)
    {
        
        nutricionistas = repositorioNutricionistaMemoria.GetFilter(GetFilters);
    }
}
