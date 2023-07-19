
namespace Core.Entities;

public class Incidencia
{
    public int Id { get; set; }
    public int IdTipoIncidencia { get; set; }
    public TipoIncidencia TipoIncidencia { get; set; } = null!;
    public int IdPuesto { get; set; }
    public Puesto Puesto { get; set; } = null!;
    public int IdCategoria { get; set; }
    public CategoriaIncidencia CategoriaIncidencia { get; set; } = null!;
    public int IdTrainer { get; set; }
    public Trainer Trainer { get; set; } = null!;
    public string ? Descripcion { get; set; }
    public DateTime FechaReporte { get; set; }


}
