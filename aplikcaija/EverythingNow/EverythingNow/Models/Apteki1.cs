using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Apteki1
{
    public long AId { get; set; }

    public string? Aime { get; set; }

    public virtual ICollection<AptekiLokacii1> AptekiLokacii1s { get; } = new List<AptekiLokacii1>();

    public virtual ICollection<Dogovori> Dogovoris { get; } = new List<Dogovori>();

    public virtual ICollection<Prodava> Prodavas { get; } = new List<Prodava>();
}
