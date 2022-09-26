using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbFamiliares;

public class IndexModel : PageModel
{
    private readonly IRepositorioFamiliar repositorioFamiliar;
    public IEnumerable<Cls_Familiar> familiares { get; set; }
    public IndexModel(IRepositorioFamiliar repositorioFamiliar)
    {
        this.repositorioFamiliar = repositorioFamiliar;
    }
    public void OnGet()
    {
        familiares = repositorioFamiliar.GetAll();
    }
}