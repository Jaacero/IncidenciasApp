
namespace Core.Entities;

public class TiposTelefono
{
    public int Id { get; set; }
    public string Tipo { get; set; } = null!;
    public ICollection<TelefonosTrainers> Telefonos { get; set; } = null!;
   

}
