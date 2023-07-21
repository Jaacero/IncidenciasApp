using System.Linq.Expressions;
using Core.Entities;
namespace Core.Interfaces
{
    public interface IIncidenciaInterface
    {
        Task<Incidencia> GetIncidenciaByIdAsync();
        Task<IEnumerable<Incidencia>> GetAllIncidenciasAsync();
        IEnumerable<Incidencia> Find(Expression<Func<Incidencia,bool>> expression);
        void Add(Incidencia incidencia);
        void AddRange(IEnumerable<Incidencia> incidencias);
        void Remove(Incidencia incidencia);
        void RemoveRange (IEnumerable<Incidencia> incidencias);
        void Update(Incidencia incidencia);
    }
}