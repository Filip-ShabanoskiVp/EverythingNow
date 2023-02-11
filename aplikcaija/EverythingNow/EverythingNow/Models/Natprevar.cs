using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EverythingNow.Models;

public partial class Natprevar
{
    public long IdNatprevar { get; set; }


    [DisplayName("Фаза")]
    public string? Faza { get; set; }

    [DisplayName("Датум")]
    [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
[DataType(DataType.Date)]
    public DateTime? Data { get; set; }

    [DisplayName("Час")]
    public TimeSpan? Chas { get; set; }

    [DisplayName("Стадион")]
    public long? IdStadion { get; set; }

    public string? Username { get; set; }

    [DisplayName("Резултат")]
    public long? IdRezultat { get; set; }

    [DisplayName("Домајќин")]
    public string drzhavadomakjin { get; set; } = null!;

    [DisplayName("Гостин")]
    public string drzhavagostin { get; set; } = null!;

    public virtual Rezultat? IdRezultatNavigation { get; set; }

    public virtual Stadion? IdStadionNavigation { get; set; }

    public virtual ICollection<Pogodoci> Pogodocis { get; } = new List<Pogodoci>();

    public virtual ICollection<SudiNa> SudiNas { get; } = new List<SudiNa>();

    public virtual ICollection<Tiket> Tikets { get; } = new List<Tiket>();

    public virtual Admin? UsernameNavigation { get; set; }

    public virtual ICollection<Reprezentacii> Drzhavas { get; } = new List<Reprezentacii>();


    public virtual ICollection<Igra> Igras { get; } = new List<Igra>();

    public virtual Reprezentacii DrzhavaNavigation { get; set; } = null!;
}
