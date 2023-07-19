
namespace Core.Entities;

public class EmailsTrainers
{
    public int IdTrainer { get; set; }
    public Trainer Trainer { get; set; } = null!;
    public int IdTipoEmail { get; set; }
    public TiposEmail TipoEmail { get; set; } =null!;
    public string Email { get; set; }=null!;
}
