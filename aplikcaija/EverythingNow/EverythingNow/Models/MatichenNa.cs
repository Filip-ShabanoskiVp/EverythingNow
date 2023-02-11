using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class MatichenNa
{
    public long PLId { get; set; }

    public DateOnly MDatumPoch { get; set; }

    public DateOnly? MDatumKraj { get; set; }

    public long DLId { get; set; }

    public virtual Doktori DL { get; set; } = null!;

    public virtual Pacienti PL { get; set; } = null!;
}
