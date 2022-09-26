using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbHistoriasC;

public class IndexModel : PageModel
{
    private readonly IRepositorioHistoriaC repositorioHistoriaC;
    public IEnumerable<Cls_Historia> historiasClinicas { get; set; }
    public IndexModel(IRepositorioHistoriaC repositorioHistoriaC)
    {
        this.repositorioHistoriaC = repositorioHistoriaC;
    }
    public void OnGet()
    {
        historiasClinicas = repositorioHistoriaC.GetAllHC();
    }
}