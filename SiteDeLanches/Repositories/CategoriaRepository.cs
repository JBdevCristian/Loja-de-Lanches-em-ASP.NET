using SiteDeLanches.Context;
using SiteDeLanches.Models;
using SiteDeLanches.Repositories.Interfaces;

namespace SiteDeLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
