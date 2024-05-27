using SiteDeLanches.Models;
using System.Numerics;

namespace SiteDeLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
