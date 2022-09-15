using System.Collections.Generic;
using HogarGestor.app.Dominio;

namespace HogarGestor.app.Persistencia
{
    public interface IRepositorioHistoriaC
    {
        Cls_Historia AsignarHistoriaC(Cls_Historia historia);
        Cls_Historia CrearHistoriaC(Cls_Historia historia);
       /* Cls_Historia ActualizarHistoriaC(Cls_Historia historia);

        Cls_Historia BorrarHistoriaC(int IdHistoria);

        Cls_Historia LlamarHistoriaC(int IdHistoria); */
    }
}