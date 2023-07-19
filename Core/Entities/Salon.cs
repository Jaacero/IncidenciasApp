
namespace Core.Entities;

    public class Salon
    {
        public int Id { get; set; }
        public string NombreSalon { get; set; } = null!;
        public int Numero_Puestos { get; set; }
        public int IdArea { get; set; }
        public AreaCampus Area {get; set; } = null!;
        public ICollection<Puesto> Puestos { get; set; } = new List<Puesto>();
        
    }
