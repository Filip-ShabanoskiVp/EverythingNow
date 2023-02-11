using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Recepti1
{
    public long PLId { get; set; }

    public long DLId { get; set; }

    public DateOnly DatumIzd { get; set; }

    public long FkId { get; set; }

    public long ProdId { get; set; }

    public string? Doza { get; set; }

    public virtual Doktori DL { get; set; } = null!;

    public virtual Lekovi Lekovi { get; set; } = null!;

    public virtual Pacienti PL { get; set; } = null!;
}
