using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
namespace Infrastructure.Repositorios
{
    public class IncidenciaRepositorio : IIncidenciaInterface
    {
        private readonly AplicationDbContext context;

        public IncidenciaRepositorio(AplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Incidencia incidencia)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Incidencia> incidencias)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Incidencia> Find(Expression<Func<Incidencia, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Incidencia>> GetAllIncidenciasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Incidencia> GetIncidenciaByIdAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(Incidencia incidencia)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Incidencia> incidencias)
        {
            throw new NotImplementedException();
        }

        public void Update(Incidencia incidencia)
        {
            throw new NotImplementedException();
        }
    }
}