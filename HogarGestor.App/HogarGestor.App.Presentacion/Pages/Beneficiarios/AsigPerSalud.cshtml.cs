using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_Beneficiarios;

public class AsigPerSaludModel : PageModel
{
    private readonly IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria;
    private readonly IRepositorioPerSaludMemoria repositorioPerSaludMemoria;
    public IEnumerable<Cls_PersonalSalud> personasSalud { get; set; }
    [BindProperty(SupportsGet = true)]
    public string GetFilters { get; set; }
    [BindProperty]
    public int perSaludId { get; set; }
    [BindProperty]
    public Cls_PersonalSalud personalSalud { get; set; }
    [BindProperty]
    public Cls_Beneficiario beneficiario { get; set; }
    public AsigPerSaludModel(IRepositorioBeneficiarioMemoria repositorioBeneficiarioMemoria,IRepositorioPerSaludMemoria repositorioPerSaludMemoria)
    { // Metodo constructor del objeto 'AsigPersaludModel'
        this.repositorioPerSaludMemoria=repositorioPerSaludMemoria;
        this.repositorioBeneficiarioMemoria=repositorioBeneficiarioMemoria;
    }
    public IActionResult OnGet(int Id)
    {
        personasSalud = repositorioPerSaludMemoria.GetAll();
        beneficiario = repositorioBeneficiarioMemoria.Get(Id);
        if (beneficiario ==null)
            return RedirectToPage("./NotFound");
        else
            return Page();   
    }
    public IActionResult OnPostToAssing(int perSaludId)
    {
        personalSalud=repositorioPerSaludMemoria.Get(perSaludId);
        personalSalud=repositorioBeneficiarioMemoria.toAssignPerSalud(beneficiario.Id, personalSalud);
        return RedirectToPage("Index");
    }
}