using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.App.Dominio
{
    public class Cls_Familiar : Cls_Persona
    {
        public int Id {get;set;}
        public string Parentesco {get;set;}
    }
}