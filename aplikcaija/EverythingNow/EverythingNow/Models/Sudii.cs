using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class Sudii
{
    public string EmbgSudii { get; set; } = null!;

    public string? ImeSudii { get; set; }

    public string? Drzavjanstvo { get; set; }

    public virtual ICollection<SudiNa> SudiNas { get; } = new List<SudiNa>();
}
