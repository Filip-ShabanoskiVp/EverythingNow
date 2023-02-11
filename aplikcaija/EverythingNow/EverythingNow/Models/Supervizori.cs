using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Supervizori
{
    public long LId { get; set; }

    public virtual ICollection<Dogovori1> Dogovori1s { get; } = new List<Dogovori1>();

    public virtual Lugje LIdNavigation { get; set; } = null!;
}
