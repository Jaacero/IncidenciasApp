using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class CategoriaIncidencia
{
    public int Id { get; set; }
    public string Categoria { get; set; } = null!;
    public ICollection<Incidencia> Incidencias { get; set; } = new List<Incidencia>();
}
