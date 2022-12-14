using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbBeneficiarios;
public class IndexModel : PageModel
{
    private readonly IRepositorioBeneficiario repositorioBeneficiario;
    public IEnumerable<Cls_Beneficiario> beneficiarios { get; set; }
    public IndexModel(IRepositorioBeneficiario repositorioBeneficiario)
    {
        this.repositorioBeneficiario = repositorioBeneficiario;
    }
       public void OnGet()
    {
        beneficiarios = repositorioBeneficiario.GetAll();
    }
}