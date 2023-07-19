
namespace Core.Entities;

public class TiposEmail
{
    public int Id { get; set; }
    public string Tipo { get; set; } = null!;
    public ICollection<EmailsTrainers> Emails { get; set; } = null!;

}
