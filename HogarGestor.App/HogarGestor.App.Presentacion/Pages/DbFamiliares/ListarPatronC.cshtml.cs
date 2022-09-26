using System;
using System.Collections.Generic;
using System.Linq;
using HogarGestor.App.Dominio;
using HogarGestor.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HogarGestor.App.Presentacion.Pages_DbFamiliares;

public class ListarPatronCModel : PageModel
{
    private readonly IRepositorioPatronC repositorioPatronC;
    public IEnumerable<Cls_PatronCrecimiento> PatronesCrecimiento { get; set; }
    public ListarPatronCModel(IRepositorioPatronC repositorioPatronC)
    {
        this.repositorioPatronC = repositorioPatronC;
    }
    public void OnGet()
    {
        PatronesCrecimiento = repositorioPatronC.GetAllPC();
    }
}