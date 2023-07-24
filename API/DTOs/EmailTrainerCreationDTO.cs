
namespace API.DTOs
{
    public class EmailTrainerCreationDTO
    {
        public int IdTrainer  { get; set;}
        public int IdTipoEmail  { get; set;}
        public string Email  { get; set;}= null!;
    }
}