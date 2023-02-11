using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Dogovori1
{
    public long FkId { get; set; }

    public long AId { get; set; }

    public long LIdSupervizor { get; set; }

    public DateOnly DatumSkl { get; set; }

    public DateOnly? DatumIst { get; set; }

    public string? Sodrzhina { get; set; }

    public virtual Apteki AIdNavigation { get; set; } = null!;

    public virtual Farmakomi Fk { get; set; } = null!;

    public virtual Supervizori LIdSupervizorNavigation { get; set; } = null!;
}
