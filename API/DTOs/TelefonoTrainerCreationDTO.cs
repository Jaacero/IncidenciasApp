using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class TelefonoTrainerCreationDTO
    {
        public int IdTrainer  { get; set;}
        public int IdTipoTelefono  { get; set;}
        public string NumeroTelefono  { get; set;} = null!;
        
    }
}