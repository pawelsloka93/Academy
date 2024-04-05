namespace Nasa.Models
{
    public class Sistema
    {

        public int sistemaID { get; set; }

        public string? nome { get; set; } = null!;

        public string? codiceSistema { get; set; } = Guid.NewGuid().ToString();

        public string? tipo { get; set; }

    }
}
