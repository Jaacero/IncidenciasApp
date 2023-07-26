using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ITrainerInterface
    {
        Task<Trainer> GetTrainerByIdAsync(int id);
        Task<IEnumerable<Trainer>> GetAllTrainersAsync();
        IEnumerable<Trainer> Find(Expression<Func<Trainer,bool>> expression);
        Task<IEnumerable<Trainer>> GetTrainersByName(string name);
        Task<(int totalRegistros, IEnumerable<Trainer> registros)> GetAllTrinerAsync(int pageIndex, int pageSize,string search);
        void Add(Trainer trainer);
        void AddRangeT(IEnumerable<Trainer> trainers);
        void AddRangeEmail(IEnumerable<EmailsTrainers> emails);
        void AddRangeTelefono(IEnumerable<TelefonosTrainers> telefonos);
        void Remove(Trainer trainer);
        void RemoveRange (IEnumerable<Trainer> trainers);
        void Update(Trainer trainer);
        
    }
}