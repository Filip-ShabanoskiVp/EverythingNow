using System.ComponentModel.DataAnnotations.Schema;

namespace EverythingNow.Models
{
    public class Igra
    {
        public string Drzhava { get; set; } = null!;

        public long IdNatprevar { get; set; }


        public virtual Reprezentacii DrzhavaNavigation { get; set; } = null!;

        public virtual Natprevar IdNatprevarNavigation { get; set; } = null!;
    }
}
