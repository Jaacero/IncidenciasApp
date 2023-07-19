
namespace Core.Entities;

public class TipoHardware
{
    public int Id { get; set; }
    public string NombreHardware { get; set; } = null!;
     public ICollection<Hardware> Hardwares { get; set; } = new List<Hardware>();
}
