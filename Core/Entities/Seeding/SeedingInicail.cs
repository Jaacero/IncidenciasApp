using Microsoft.EntityFrameworkCore;
using Core.Entities;
namespace Core.Entities.Seeding
{
    public class SeedingInicail
    {
        public static void Seed(ModelBuilder modelBuilder){
            var Pedro = new Trainer(){
                Id = 1,
                Nombre = "Pedro Carvajal"
            };
            var Marcelo = new Trainer(){
                Id = 2,
                Nombre = "Marcelo Benedetti"
            };
            var Aicia = new Trainer(){
                Id = 3,
                Nombre = "Alicia Romero"
            };
            modelBuilder.Entity<Trainer>().HasData(Pedro,Marcelo,Aicia);

            var emailPersonal= new TiposEmail(){
                Id = 1,
                Tipo = "Email Personal"
            };
            var emailLaboral= new TiposEmail(){
                Id = 2,
                Tipo = "Email Laboral"
            };
            modelBuilder.Entity<TiposEmail>().HasData(emailLaboral,emailPersonal);

            var telefonopersonal = new TiposTelefono(){
                Id = 1,
                Tipo = "Telefono Personal"
            };
            var telefonoEmpresarial = new TiposTelefono(){
                Id = 2,
                Tipo = "Telefono Empresarial"
            };
            var telefonoCasa = new TiposTelefono(){
                Id = 3,
                Tipo = "Telefono Fijo"
            };
            modelBuilder.Entity<TiposTelefono>().HasData(telefonoCasa,telefonoEmpresarial,telefonopersonal);

            var Ework_Pedro = new EmailsTrainers(){
                IdTrainer = Pedro.Id,
                IdTipoEmail = emailLaboral.Id,
                Email = "pedro_work@gmail.com"
            };
            var EPersonal_Pedro = new EmailsTrainers(){
                IdTrainer = Pedro.Id,
                IdTipoEmail = emailPersonal.Id,
                Email = "pedro123@gmail.com"
            };
            var Ework_Marcelo = new EmailsTrainers(){
                IdTrainer = Marcelo.Id,
                IdTipoEmail = emailLaboral.Id,
                Email = "marcelo_work@gmail.com"
            };
            var Eperosnal_Marcelo = new EmailsTrainers(){
                IdTrainer = Marcelo.Id,
                IdTipoEmail = emailPersonal.Id,
                Email = "pedro@gmail.com"
            };
            var Ework_Aicia = new EmailsTrainers(){
                IdTrainer = Aicia.Id,
                IdTipoEmail = emailLaboral.Id,
                Email = "Aicia_work@gmail.com"
            };
            var Eperosnal_Aicia = new EmailsTrainers(){
                IdTrainer = Aicia.Id,
                IdTipoEmail = emailPersonal.Id,
                Email = "Aicia@gmail.com"
            };
            modelBuilder.Entity<EmailsTrainers>().HasData(Eperosnal_Aicia,Eperosnal_Marcelo,EPersonal_Pedro,
            Ework_Aicia,Ework_Marcelo,Ework_Pedro);

            var TworkPedro = new TelefonosTrainers(){
                IdTrainer = Pedro.Id,
                IdTipoTelefono = telefonoEmpresarial.Id,
                NumeroTelefono = "300254214"
            };
            var TworkMarcelo = new TelefonosTrainers(){
                IdTrainer = Marcelo.Id,
                IdTipoTelefono = telefonoEmpresarial.Id,
                NumeroTelefono = "315246325"
            };
            var TworkAicia = new TelefonosTrainers(){
                IdTrainer = Aicia.Id,
                IdTipoTelefono = telefonoEmpresarial.Id,
                NumeroTelefono = "3213383473"
            };
             modelBuilder.Entity<TelefonosTrainers>().HasData(TworkAicia,TworkMarcelo,TworkPedro);
            

        }
        
    }
}