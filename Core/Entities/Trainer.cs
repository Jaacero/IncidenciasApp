
namespace Core.Entities;

public class Trainer
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public ICollection<EmailsTrainers> EmailsTrainer { get; set; } = new List<EmailsTrainers>();
    public ICollection<TelefonosTrainers> TelefonosTrainer { get; set; } = new List<TelefonosTrainers>();
    public ICollection<Incidencia> Incidencias { get; set; } = new List<Incidencia>();

}
