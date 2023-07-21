using System.Linq.Expressions;
using Core.Entities;
namespace Core.Interfaces
{
    public interface ITrainerInterface
    {
        Task<Trainer> GetTrainerByIdAsync(int id);
        Task<IEnumerable<Trainer>> GetAllTrainersAsync();
        IEnumerable<Trainer> Find(Expression<Func<Trainer,bool>> expression);
        void Add(Trainer trainer);
        void AddRange(IEnumerable<Trainer> trainers);
        void Remove(Trainer trainer);
        void RemoveRange (IEnumerable<Trainer> trainers);
        void Update(Trainer trainer);
        
    }
}