using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogarGestor.app.Dominio
{
    public class Cls_PatronCrecimiento
    {
        public int Id {get; set;}
        public DateTime FechaHora {get;set;}
        public float Valor {get;set;}
        public TipoPartonC TipoPartonC {get; set;}
    }
}