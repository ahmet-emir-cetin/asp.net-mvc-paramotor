using paramotor.Models.Entities;

namespace paramotor.Models;

public class IndexViewModel
{
    public Site? Site { get; set; }
    public IEnumerable<Site>? Sites { get; set; }

    public IEnumerable<Slide>? Slides { get; set; }

    public About? About { get; set; }
    public IEnumerable<About>? Abouts { get; set; }

    public IEnumerable<Team>? Teams { get; set; }

    public IEnumerable<Portfolio>? Portfolios { get; set; }
}
