using System.Linq.Expressions;
using Core.Entities;
namespace Core.Interfaces
{
    public interface IIncidenciaInterface
    {
        Task<Incidencia> GetIncidenciaByIdAsync();
        Task<IEnumerable<Incidencia>> GetAllIncidenciasAsync();
        Task<IEnumerable<Incidencia>> Find(Expression<Func<Incidencia,bool>> expression); 
        Task<IEnumerable<Incidencia>>GetIncidinciaByCategoria(int idcategoria);
        Task<IEnumerable<Incidencia>> GetInidenciasByTrainer(int idTrainer);
        void Add(Incidencia incidencia);
        void AddRange(IEnumerable<Incidencia> incidencias);
        void Remove(Incidencia incidencia);
        void RemoveRange (IEnumerable<Incidencia> incidencias);
        void Update(Incidencia incidencia);
    }
}