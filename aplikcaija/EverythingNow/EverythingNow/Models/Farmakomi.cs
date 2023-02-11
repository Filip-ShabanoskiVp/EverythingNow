using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Farmakomi
{
    public long FkId { get; set; }

    public string? FkIme { get; set; }

    public virtual ICollection<Dogovori1> Dogovori1s { get; } = new List<Dogovori1>();

    public virtual ICollection<FarmakomiBroevi> FarmakomiBroevis { get; } = new List<FarmakomiBroevi>();

    public virtual ICollection<Lekovi> Lekovis { get; } = new List<Lekovi>();
}
