using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbBeneficiarios;
public class AsigFamiliarModel : PageModel
{
    private readonly IRepositorioBeneficiario repositorioBeneficiario;
    private readonly IRepositorioFamiliar repositorioFamiliar;
    public IEnumerable<Cls_Familiar> familiares { get; set; }
     //[BindProperty(SupportsGet = true)]
    //public string GetFilters { get; set; }
    [BindProperty(SupportsGet = true)]
    public int idFamiliar { get; set; }
    [BindProperty]
    public Cls_Beneficiario beneficiario { get; set; }
    [BindProperty]
    public Cls_Familiar familiar { get; set; }
    public AsigFamiliarModel(IRepositorioBeneficiario repositorioBeneficiario, IRepositorioFamiliar repositorioFamiliar)
    { // Metodo constructor del objeto 'AsigFamiliarModel'
        this.repositorioFamiliar = repositorioFamiliar;
        this.repositorioBeneficiario = repositorioBeneficiario;
    }
    public IActionResult OnGet(int Id)
    {
        familiares = repositorioFamiliar.GetAll();
        beneficiario = repositorioBeneficiario.Get(Id);
        if (beneficiario == null)
            return RedirectToPage("./NotFound");
        else
            return Page();
    }
    public IActionResult OnPostToAssign(int idFamiliar)
    {
        familiar = repositorioFamiliar.Get(idFamiliar);
        familiar = repositorioBeneficiario.AssignFamiliar(beneficiario.Id, familiar);
        return RedirectToPage("Index");
    }
}