using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Farmakomi1
{
    public long FkId { get; set; }

    public string? FkIme { get; set; }

    public virtual ICollection<Dogovori> Dogovoris { get; } = new List<Dogovori>();

    public virtual ICollection<FarmakomiBroevi1> FarmakomiBroevi1s { get; } = new List<FarmakomiBroevi1>();

    public virtual ICollection<Lekovi1> Lekovi1s { get; } = new List<Lekovi1>();
}
