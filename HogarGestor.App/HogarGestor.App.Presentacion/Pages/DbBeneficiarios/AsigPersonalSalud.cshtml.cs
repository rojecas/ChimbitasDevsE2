using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbBeneficiarios;
public class AsigPersonalSaludModel : PageModel
{
    private readonly IRepositorioBeneficiario repositorioBeneficiario;
    private readonly IRepositorioPersonalSalud repositorioPersonalSalud;
    public IEnumerable<Cls_PersonalSalud> personasSalud { get; set; }
/*  public IEnumerable<Cls_PersonalSalud> pediatras { get; set; }
    public IEnumerable<Cls_PersonalSalud> nutricionistas { get; set; } */
  /*   public string GetFilters { get; set; }*/
    [BindProperty(SupportsGet = true)]
    public int idPersonalSalud { get; set; }
        [BindProperty]
    public Cls_Beneficiario beneficiario { get; set; }
    [BindProperty]
    public Cls_PersonalSalud personalSalud { get; set; }

    public AsigPersonalSaludModel(IRepositorioBeneficiario repositorioBeneficiario, IRepositorioPersonalSalud repositorioPersonalSalud)
    { // Metodo constructor del objeto 'AsigPersonalSaludModel'
        this.repositorioPersonalSalud = repositorioPersonalSalud;
        this.repositorioBeneficiario = repositorioBeneficiario;
    }
    public IActionResult OnGet(int Id)
    {
        // pediatras = repositorioPersonalSalud.GetAll();
        // nutricionistas = repositorioPersonalSalud.GetAll();
        personasSalud = repositorioPersonalSalud.GetAll();
        beneficiario = repositorioBeneficiario.Get(Id);
        if (beneficiario == null)
            return RedirectToPage("./NotFound");
        else
            return Page();
    }
    public IActionResult OnPostToAssign(int idPersonalSalud)
    {
        personalSalud = repositorioPersonalSalud.Get(idPersonalSalud);
        personalSalud = repositorioBeneficiario.AssignPersonalSalud(beneficiario.Id, personalSalud);
        return RedirectToPage("Index");
    }
}