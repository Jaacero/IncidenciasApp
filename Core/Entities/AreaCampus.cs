
namespace Core.Entities;

public class AreaCampus
{
    public int Id { get; set; }
    public string NombreArea { get; set; } = null!;
    public string ? Descripcion { get; set; }
    public ICollection<Salon> Salones { get; set; } = new List<Salon>();

}
