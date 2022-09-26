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
    public Cls_Familiar familiar { get; set; }
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
            if (repositorioBeneficiario.consultarPS(Id, 1) == null)
            {
                perSaludPediatra = new Cls_PersonalSalud
                {
                    nombre = "Sin pediatra",
                    apellido = "asignado"
                };
                beneficiario.pediatra = perSaludPediatra;
            }
            else
            {
                beneficiario.pediatra = repositorioBeneficiario.consultarPS(Id, 1);
            }
            if (repositorioBeneficiario.consultarPS(Id, 0) == null)
            {
                perSaludNutricionista = new Cls_PersonalSalud
                {
                    nombre = "Sin nutricionista",
                    apellido = "asignado"
                };
                beneficiario.nutricionista = perSaludNutricionista;
            }
            else
            {
                beneficiario.nutricionista = repositorioBeneficiario.consultarPS(Id, 0);
            }
            if (repositorioBeneficiario.consultarfamiliar(Id) == null)
            {
                familiar = new Cls_Familiar
                {
                    nombre = "Sin Familiar",
                    apellido = "asignado"
                };
                beneficiario.familiar = familiar;
            }
            else
            {
                beneficiario.familiar=repositorioBeneficiario.consultarfamiliar(Id);
            }
            return Page();
        }
    }
}