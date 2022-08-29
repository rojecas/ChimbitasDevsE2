using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.app.Dominio
{
    public class Cls_Familiar : Cls_Persona
    {
        public new int Id {get;set;}
        public string Parentesco {get;set;}
    }
}