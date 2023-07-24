using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.DTOS
{
    public class EmailDTO
    {
         public int IdTipoEmail {get; set;}
        public string Email {get; set;}= null!;
    }
}