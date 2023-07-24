using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DTOS
{
    public class IncidenciaDTO
    {
        public int Id { get; set; }
        public int IdTipoIncidencia { get; set; }
        public int IdPuesto { get; set; }
        public int IdCategoria { get; set; }
        public int IdTrainer { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaReporte { get; set; }
    }
}