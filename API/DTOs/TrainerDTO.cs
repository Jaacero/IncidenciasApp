using Core.Entities;
namespace API.DTOs
{
    public class TrainerDTO
    {
        public int Id { get; set;}
        public string Nombre { get; set;} = null!;
        public List<EmailsTrainers> EmailsTrainers 
        = new List<EmailsTrainers>();
         public List<TelefonosTrainers> TelefonosTrainer 
         = new List<TelefonosTrainers>();
    }
}