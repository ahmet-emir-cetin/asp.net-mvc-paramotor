using System;
using System.Collections.Generic;

namespace paramotor.Models.Entities;

public partial class Site
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Facebook { get; set; } = null!;

    public string Twitter { get; set; } = null!;

    public string Instagram { get; set; } = null!;

    public string Youtube { get; set; } = null!;

    public string LogoImage { get; set; } = null!;

    public string Favicon { get; set; } = null!;
}
