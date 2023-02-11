using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Supervizori1
{
    public long LId { get; set; }

    public virtual ICollection<Dogovori> Dogovoris { get; } = new List<Dogovori>();

    public virtual Lugje1 LIdNavigation { get; set; } = null!;
}
