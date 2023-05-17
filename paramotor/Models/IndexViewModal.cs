using paramotor.Models.Entities;

namespace paramotor.Models;

public class IndexViewModel
{
    public Site? Site { get; set; }
    public IEnumerable<Site>? Sites { get; set; }
}
