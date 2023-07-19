
namespace Core.Entities;

public class TelefonosTrainers
{
    public int IdTrainer { get; set; }
    public Trainer Trainer { get; set; } = null!;
    public int IdTipoTelefono { get; set; } 
    public TiposTelefono TipoTelefono { get; set; } =null!;
    public string NumeroTelefono { get; set; }=null!;

}
