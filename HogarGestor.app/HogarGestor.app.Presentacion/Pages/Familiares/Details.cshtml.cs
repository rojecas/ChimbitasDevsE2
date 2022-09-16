using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;
using HogarGestor.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.app.Presentacion.Pages_Familiares;

public class DetailsModel : PageModel
{
    private readonly IRepositorioFamiliarMemoria repositorioFamiliarMemoria; // atributo de Clase

    public Cls_Familiar familiar { get; set; }
    public DetailsModel(IRepositorioFamiliarMemoria repositorioFamiliarMemoria) // Metodo constructor de la clase Details (modelo)
    {
        this.repositorioFamiliarMemoria = repositorioFamiliarMemoria;
    }
    public IActionResult OnGet(int Id)
    {
        familiar=repositorioFamiliarMemoria.Get(Id);
            if(familiar==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
    }
}

