using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Doktori
{
    public long LId { get; set; }

    public int? RabIskustvo { get; set; }

    public string? Specijalnost { get; set; }

    public virtual Lugje LIdNavigation { get; set; } = null!;

    public virtual ICollection<MatichenNa> MatichenNas { get; } = new List<MatichenNa>();

    public virtual ICollection<Recepti1> Recepti1s { get; } = new List<Recepti1>();
}
