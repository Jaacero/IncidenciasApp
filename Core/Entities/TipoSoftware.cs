
namespace Core.Entities;

public class TipoSoftware
{
    public int Id { get; set; }
    public string NombreSoftware { get; set; } = null!;
    public ICollection<Software> Softwares { get; set; } = new List<Software>();

}
