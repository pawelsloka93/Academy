namespace Nasa.Models
{
    public class CorpoCeleste
    {

        public int corpoCelesteID { get; set; }
        public  string? nomeCorpo { get; set; } = null!;

        public string? codiceCorpo { get; set; } = Guid.NewGuid().ToString();

        public DateTime? dataScop { get; set; } = null!;

        public string? scopritore { get; set; } = null!;

        public string? tipologia { get; set; } = null!;

        public decimal distanza { get; set; }

        public decimal coordinataRadiale { get; set; }

        public decimal coordinataAngolare { get; set; }




    }
}
