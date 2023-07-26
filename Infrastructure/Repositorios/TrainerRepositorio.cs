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

        public virtual async Task<(int totalRegistros, IEnumerable<Trainer> registros)> GetAllTrinerAsync(int pageIndex, int pageSize, string search)
        {
            var query = context.Trainers as IQueryable<Trainer>;
            if(!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Nombre.ToLower().Contains(search));
            }
            var totalRegistros = await query.CountAsync();
            var registros = await query
                            .Include(p => p.EmailsTrainer)
                            .Include(p => p.TelefonosTrainer)
                            .Skip((pageIndex - 1) * pageSize)
                            .Take(pageSize)
                            .ToListAsync();
            return (totalRegistros, registros);            
       }

        public async Task<Trainer> GetTrainerByIdAsync(int id)
        {
            var actor = await context.Trainers
            .Include(x => x.EmailsTrainer)
            .Include(x => x.TelefonosTrainer)
            .FirstOrDefaultAsync(x =>x.Id == id);

           return actor;
        }

        public async Task<IEnumerable<Trainer>> GetTrainersByName(string name)
        {
            return await context.Trainers
            .Where(x => x.Nombre.Contains(name))
            .Include(x => x.EmailsTrainer)
            .Include(x => x.TelefonosTrainer)
            .ToListAsync();
           
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