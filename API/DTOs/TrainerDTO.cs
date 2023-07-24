using Core.Entities;
namespace API.DTOs
{
    public class TrainerDTO
    {
        public int Id { get; set;}
        public string Nombre { get; set;} = null!;
        public List<EmailTrainerCreationDTO> EmailsTrainers  { get; set;}
        = new List<EmailTrainerCreationDTO>();
         public List<TelefonoTrainerCreationDTO> TelefonosTrainer  { get; set;}
         = new List<TelefonoTrainerCreationDTO>();
    }
}