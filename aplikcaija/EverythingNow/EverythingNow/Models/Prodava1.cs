using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Prodava1
{
    public long FkId { get; set; }

    public long ProdId { get; set; }

    public long AId { get; set; }

    public decimal? Cena { get; set; }

    public virtual Apteki AIdNavigation { get; set; } = null!;

    public virtual Lekovi Lekovi { get; set; } = null!;
}
