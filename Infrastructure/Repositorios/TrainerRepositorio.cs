using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Infrastructure.Repositorios
{
    public class TrainerRepositorio : ITrainerInterface
    {
        private readonly AplicationDbContext context;
        private readonly IMapper mapper;

        public TrainerRepositorio(AplicationDbContext context ,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void Add(Trainer trainer)
        {
           return ;
        }

        public void AddRangeEmail(IEnumerable<EmailsTrainers> emails)
        {
           context.AddRange(emails);
          
        }

        public void AddRangeT(IEnumerable<Trainer> trainers)
        {
            context.AddRange(trainers);
           
        }

        public  void AddRangeTelefono(IEnumerable<TelefonosTrainers> telefonos)
        {
           context.AddRange(telefonos);   
        }

        public IEnumerable<Trainer> Find(Expression<Func<Trainer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Trainer>> GetAllTrainersAsync()
        {
            return await context.Trainers
            .Include(x =>x.EmailsTrainer)
            .Include(x =>x.TelefonosTrainer)
            .ToListAsync();
        }

        public async  Task<Trainer> GetTrainerByIdAsync(int id)
        {
            var actor = await context.Trainers
            .Include(x => x.EmailsTrainer)
            .Include(x => x.TelefonosTrainer)
            .FirstOrDefaultAsync(x =>x.Id == id);
           
           return actor;
        }


        public void Remove(Trainer trainer)
        {
            context.Set<Trainer>().Remove(trainer);
            
        }

        public void RemoveRange(IEnumerable<Trainer> trainers)
        {
            
        }

        public void Update(Trainer trainer)
        {
            context.Set<Trainer>().Update(trainer);
        }
    }
}