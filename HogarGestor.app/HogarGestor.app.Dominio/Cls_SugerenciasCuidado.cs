using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.app.Dominio
{
    public class Cls_SugerenciasCuidado:Cls_Historia
    {
       public int Id {get; set;} 
       public DateOnly FechaHora {get; set;}
       public String Descripcion {get; set;}
    }
}