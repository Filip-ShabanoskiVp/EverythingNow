using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class FarmakomiBroevi1
{
    public long FkId { get; set; }

    public int FkRedenBr { get; set; }

    public string? TelBroj { get; set; }

    public virtual Farmakomi1 Fk { get; set; } = null!;
}
