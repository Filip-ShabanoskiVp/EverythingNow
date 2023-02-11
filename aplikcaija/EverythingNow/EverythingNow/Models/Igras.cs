namespace EverythingNow.Models
{
    public class Igras
    {
        public string Drzhava { get; set; } = null!;

        public long IdNatprevar { get; set; }


        public virtual Reprezentacii DrzhavaNavigation { get; set; } = null!;

        public virtual Natprevar IdNatprevarNavigation { get; set; } = null!;
    }
}
