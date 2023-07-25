
namespace Core.Interfaces
{
    public interface IUnityOfWork
    {
         ITrainerInterface Trainers {get;}
         IIncidenciaInterface Incidencias {get;}
         Task<int> SaveAsync();  
        // Task NotFound();
    }
}