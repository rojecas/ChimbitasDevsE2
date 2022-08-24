using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.app.Dominio
{
    public class Cls_Beneficiario:Cls_Persona
    {
        //public int Id {get; set;}
        public int Familiar {get; set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get; set;}
        public DateOnly FechaNacimiento {get;set;}

    }
}