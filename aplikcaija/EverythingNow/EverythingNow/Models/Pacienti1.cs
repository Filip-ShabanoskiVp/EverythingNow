using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Pacienti1
{
    public long LId { get; set; }

    public string? PAdresa { get; set; }

    public virtual Lugje1 LIdNavigation { get; set; } = null!;

    public virtual ICollection<MatichenNa1> MatichenNa1s { get; } = new List<MatichenNa1>();

    public virtual ICollection<Recepti> Receptis { get; } = new List<Recepti>();
}
