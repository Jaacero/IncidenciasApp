using Core.Entities;
using Core.Interfaces;
using Infrastructure.Repositorios;
using AutoMapper;
namespace Infrastructure.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private readonly AplicationDbContext _context;
        private readonly IMapper _mapper;
        private TrainerRepositorio _trainers;
        private IncidenciaRepositorio _incidencias;
        public UnityOfWork(AplicationDbContext context)
        {
            _context = context;
        }
        public ITrainerInterface Trainers
        {
            get{
                _trainers ??= new TrainerRepositorio(_context, _mapper);
                return _trainers;
            }
        }
        public IIncidenciaInterface Incidencias
        {
            get{
                _incidencias ??= new IncidenciaRepositorio(_context);
                 return _incidencias;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}