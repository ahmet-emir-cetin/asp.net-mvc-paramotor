using System;
using System.Collections.Generic;

namespace paramotor.Models.Entities;

public partial class Portfolio
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Detail { get; set; }

    public string? Image { get; set; }

    public string? Type { get; set; }

    public int? Rating { get; set; }

    public string? Client { get; set; }

    public string? Website { get; set; }

    public string? Complated { get; set; }

    public string? Facebook { get; set; }

    public string? Twitter { get; set; }

    public string? Instagram { get; set; }

    public string? Linkedin { get; set; }

    public bool? Isview { get; set; }

    public int? Order { get; set; }
}
