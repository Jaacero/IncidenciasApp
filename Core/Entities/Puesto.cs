

namespace Core.Entities;

public class Puesto
{
    public int Id { get; set; }
    public string NombrePuesto { get; set; }=null!;
    public int IdSalon { get; set; }
    public Salon Salon { get; set; } = null!;
    public ICollection<Software> Softwars { get; set; } = new List<Software>();
     public ICollection<Hardware> Hardwars { get; set; } = new List<Hardware>();
     public ICollection<Incidencia> Incidencias { get; set; } = new List<Incidencia>();

}
