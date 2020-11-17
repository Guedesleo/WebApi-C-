using ApiCarros.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCarros.Interfaces.Repositories
{
    public interface IMarcaRepository
    {
        public List<Task<Marca>> BuscarMarcas(Marca model);
    }
}
