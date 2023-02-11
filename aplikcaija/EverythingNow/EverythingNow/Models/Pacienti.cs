using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Pacienti
{
    public long LId { get; set; }

    public string? PAdresa { get; set; }

    public virtual Lugje LIdNavigation { get; set; } = null!;

    public virtual ICollection<MatichenNa> MatichenNas { get; } = new List<MatichenNa>();

    public virtual ICollection<Recepti1> Recepti1s { get; } = new List<Recepti1>();
}
