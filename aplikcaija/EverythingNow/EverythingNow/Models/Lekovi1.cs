using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Lekovi1
{
    public long FkId { get; set; }

    public long ProdId { get; set; }

    public string? LIme { get; set; }

    public string? Sostav { get; set; }

    public virtual Farmakomi1 Fk { get; set; } = null!;

    public virtual ICollection<Prodava> Prodavas { get; } = new List<Prodava>();

    public virtual ICollection<Recepti> Receptis { get; } = new List<Recepti>();
}
