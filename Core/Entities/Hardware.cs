
namespace Core.Entities;

public class Hardware
{
    public int Id { get; set; }
    public int TipoHardwareId { get; set;}
    public TipoHardware TipoHardware { get; set; } = null!;
    public int IdPuesto { get; set; }
    public Puesto Puesto { get; set; }= null!;
    public int IdCategoria { get; set; }
    public CategoriaIncidencia Categoria {get; set; }= null!;
    public string Descripcion { get; set; }= null!;

}
