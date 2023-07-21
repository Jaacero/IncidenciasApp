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

        public void AddRange(IEnumerable<Trainer> trainers)
        {
            throw new NotImplementedException();
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
            var actor = await context.Trainers.FirstOrDefaultAsync(x =>x.Id == id);
           return actor;
        }

        public Task<Trainer> GetTrainerByIdAsync()
        {
            throw new NotImplementedException();
        }

        public void Remove(Trainer trainer)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Trainer> trainers)
        {
            throw new NotImplementedException();
        }

        public void Update(Trainer trainer)
        {
            throw new NotImplementedException();
        }
    }
}