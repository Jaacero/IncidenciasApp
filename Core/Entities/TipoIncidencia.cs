

namespace Core.Entities;

public class TipoIncidencia
{
    public int Id { get; set; }
    public string NivelIncidencia { get; set; } = null!;
    public ICollection<Incidencia> Incidencias { get; set; } = new List<Incidencia>();


}
