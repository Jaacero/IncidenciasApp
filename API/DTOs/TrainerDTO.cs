
namespace API.DTOs
{
    public class TrainerDTO
    {
        public int Id { get; set;}
        public string Nombre { get; set;} = null!;
        public ICollection<EmailTrainerCreationDTO> EmailsTrainers 
        = new List<EmailTrainerCreationDTO>();
         public ICollection<TelefonoTrainerCreationDTO> TelefonosTrainer 
         = new List<TelefonoTrainerCreationDTO>();
    }
}