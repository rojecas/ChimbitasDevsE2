using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.app.Dominio
{
    public class Cls_PersonalSalud:Cls_Persona
    {
        public int Id {get; set;}

        public Especialidad Especialidad {get; set;}
            
    }
}