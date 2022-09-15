using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;
using HogarGestor.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.app.Presentacion.Pages_PersonalSalud;

public class IndexModel : PageModel
{
    private readonly IRepositorioPerSaludMemoria repositorioPerSaludMemoria;
    public IEnumerable<Cls_PersonalSalud> personasSalud { get; set; }
    [BindProperty(SupportsGet = true)]
    public string GetFilters { get; set; }
    public IndexModel(IRepositorioPerSaludMemoria repositorioPerSaludMemoria)
    {
        this.repositorioPerSaludMemoria = repositorioPerSaludMemoria;
    }
    public void OnGet(string GetFilters)
    {
        personasSalud = repositorioPerSaludMemoria.GetFilter(GetFilters);
    }
}
