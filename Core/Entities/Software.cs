

namespace Core.Entities;

public class Software
{
    public int Id { get; set; }
    public int TipoSofwareId { get; set;}
    public TipoSoftware TipoSoftware { get; set; } = null!;
    public int IdPuesto { get; set; }
    public Puesto Puesto { get; set; }= null!;
    public int IdCategoria { get; set; }
    public CategoriaIncidencia Categoria {get; set; }= null!;
    public string Descripcion { get; set; }= null!;

}
