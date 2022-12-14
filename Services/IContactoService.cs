using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Models;

namespace Tienda_De_Instrumentos_MUsicales.ClienteBlazor.Services
{
    public interface IContactoService
    {
        Task<IEnumerable<Contacto>> GetAll();
        Task<IEnumerable<Contacto>> GetByCategoria(int idInstrumentos);
        Task<Contacto> GetById(int id);
    }
}
