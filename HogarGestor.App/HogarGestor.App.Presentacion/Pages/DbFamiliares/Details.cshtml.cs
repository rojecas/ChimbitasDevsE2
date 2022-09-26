using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbFamiliares;
public class DetailsModel : PageModel
{
    private readonly IRepositorioFamiliar repositorioFamiliar; // atributo de Clase
    public Cls_Familiar familiar { get; set; }
    public DetailsModel(IRepositorioFamiliar repositorioFamiliar)
    { // Metodo constructor de la clase Details (modelo)
        this.repositorioFamiliar = repositorioFamiliar;
    }
    public IActionResult OnGet(int Id)
    {
        familiar = repositorioFamiliar.Get(Id);
        return Page();
    }
}