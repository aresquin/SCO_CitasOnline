using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCO.Config.Business
{
    public interface IGenericBusiness<entity, dType>
    {
        entity grabar(entity objeto, ref string mensajeRespuesta, ref string tipoMensaje);
        entity eliminar(entity objeto, ref string mensajeRespuesta, ref string tipoMensaje);
        entity buscar(entity objeto);
        List<entity> listarGeneral();
        List<entity> listarPaginado(entity objeto, int index, int registros, ref int totalPaginas);
    }
}
