using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_Familiares;

public class IndexModel : PageModel
{
    private readonly IRepositorioFamiliarMemoria repositorioFamiliarMemoria;
    public IEnumerable<Cls_Familiar> familiares { get; set; }
    [BindProperty(SupportsGet = true)]
    public string GetFilters { get; set; }
    public IndexModel(IRepositorioFamiliarMemoria repositorioFamiliarMemoria)
    {
        this.repositorioFamiliarMemoria = repositorioFamiliarMemoria;
    }
    public void OnGet(string GetFilters)
    {
        //familiares=repositorioFamiliarMemoria.GetAll();
        familiares = repositorioFamiliarMemoria.GetFilter(GetFilters);
    }
}


