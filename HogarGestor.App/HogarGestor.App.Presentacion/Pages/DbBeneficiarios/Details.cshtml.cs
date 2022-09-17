using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbBeneficiarios;

public class DetailsModel : PageModel
{
    private readonly IRepositorioBeneficiario repositorioBeneficiario; // atributo de Clase
    public Cls_Beneficiario beneficiario { get; set; }

    public Cls_PersonalSalud perSaludPediatra { get; set; }
    public Cls_PersonalSalud perSaludNutricionista { get; set; }

    public DetailsModel(IRepositorioBeneficiario repositorioBeneficiario)
    { // Metodo constructor de la clase Details (modelo)
        this.repositorioBeneficiario = repositorioBeneficiario;
    }
    public IActionResult OnGet(int Id)
    {
        beneficiario = repositorioBeneficiario.Get(Id);
        if (beneficiario == null)
        {
            return RedirectToPage("./NotFound");
        }
        else
        {
            if (beneficiario.pediatra == null)
            {
                perSaludPediatra = new Cls_PersonalSalud
                {
                    nombre = "Sin pediatra",
                    apellido = "asignado"
                };
                beneficiario.pediatra = perSaludPediatra;
            }
            if (beneficiario.nutricionista == null)
            {
                perSaludNutricionista = new Cls_PersonalSalud
                {
                    nombre = "Sin nutricionista",
                    apellido = "asignado"
                };
                beneficiario.nutricionista = perSaludNutricionista;
            }
            return Page();
        }
    }
}