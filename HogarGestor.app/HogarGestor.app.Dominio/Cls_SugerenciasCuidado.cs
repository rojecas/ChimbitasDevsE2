using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.app.Dominio
{
    public class Cls_SugerenciasCuidado:Cls_Historia
    {
       private int Id {get; set;} 
       private DateOnly FechaHora {get; set;}
       private String Descripcion {get; set;}
    }
}