using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Lekovi
{
    public long FkId { get; set; }

    public long ProdId { get; set; }

    public string? LIme { get; set; }

    public string? Sostav { get; set; }

    public virtual Farmakomi Fk { get; set; } = null!;

    public virtual ICollection<Prodava1> Prodava1s { get; } = new List<Prodava1>();

    public virtual ICollection<Recepti1> Recepti1s { get; } = new List<Recepti1>();
}
