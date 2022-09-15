using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.app.Dominio;
using HogarGestor.app.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.app.Presentacion.Pages_PersonalSalud;

public class DetailsModel : PageModel
{
    private readonly IRepositorioPerSaludMemoria repositorioPerSaludMemoria; // atributo de Clase

 public Cls_PersonalSalud perSalud { get; set; }
    public DetailsModel(IRepositorioPerSaludMemoria repositorioPerSaludMemoria) // Metodo constructor de la clase Details (modelo)
    {
        this.repositorioPerSaludMemoria = repositorioPerSaludMemoria;
    }
    public IActionResult OnGet(int Id)
    {
        perSalud=repositorioPerSaludMemoria.Get(Id);
            if(perSalud==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
    }
}
