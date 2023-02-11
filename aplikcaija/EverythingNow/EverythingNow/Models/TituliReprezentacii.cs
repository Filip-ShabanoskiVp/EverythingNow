using System;
using System.Collections.Generic;

namespace EverythingNow.Models;

public partial class TituliReprezentacii
{
    public string Drzhava { get; set; } = null!;

    public int Tituli { get; set; }

    public virtual Reprezentacii DrzhavaNavigation { get; set; } = null!;
}
