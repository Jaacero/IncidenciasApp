using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            context.AddRange(incidencias);
        }

        public async Task<IEnumerable<Incidencia>> Find(Expression<Func<Incidencia, bool>> expression)
        {
           var incidencias = await context.Incidencias.Where(expression)
           .ToListAsync();
            return incidencias;
        }
        public async Task<IEnumerable<Incidencia>>GetIncidinciaByCategoria(int idcategoria)
        {
            return await context.Incidencias.Where(x =>x.IdCategoria == idcategoria)
            .ToListAsync();
        }
        public async Task<IEnumerable<Incidencia>> GetInidenciasByTrainer(int idTrainer)
        {
            return await context.Incidencias.Where(x => x.IdTrainer == idTrainer)
            .ToListAsync();
        }

        public async Task<IEnumerable<Incidencia>> GetAllIncidenciasAsync()
        {
            return await context.Incidencias.ToListAsync();
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