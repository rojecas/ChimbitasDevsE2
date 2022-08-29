using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.app.Dominio
{
    public class Cls_Beneficiario:Cls_Persona
    {
        public int id {get;set;}
        public float Latitud {get;set;}
        public float Longitud {get;set;}
        public string Ciudad {get; set;}
        public DateOnly FechaNacimiento {get;set;}
        public Cls_Familiar familiar {get; set;}
        public Cls_PersonalSalud medico {get;set;}
        public Cls_PersonalSalud nutricionista {get;set;}
        public Cls_Historia historiaClinica {get;set;}
        public System.Collections.Generic.List<Cls_PatronCrecimiento> patronCrecimiento {get;set;}

    }
}