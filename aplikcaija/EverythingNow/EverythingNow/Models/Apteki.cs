using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Apteki
{
    public long AId { get; set; }

    public string? Aime { get; set; }

    public virtual ICollection<AptekiLokacii> AptekiLokaciis { get; } = new List<AptekiLokacii>();

    public virtual ICollection<Dogovori1> Dogovori1s { get; } = new List<Dogovori1>();

    public virtual ICollection<Prodava1> Prodava1s { get; } = new List<Prodava1>();
}
