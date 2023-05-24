using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using paramotor.Models;
using paramotor.Models.Entities;

namespace paramotor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    ParamotorContext db = new ParamotorContext();

    public IActionResult Index()
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).FirstOrDefault(),
            Slides = db.Slides!.OrderBy(x => x.Order).Where(x => x.IsView == true).ToList(),
            About = db.Abouts!.FirstOrDefault(),
            Teams = db.Teams!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Portfolios = db.Portfolios!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
        };
        return View(model);
    }
    [Route("/aboutus")]
    public IActionResult AboutUs()
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
            Abouts = db.Abouts!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Teams = db.Teams!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
        };
        return View(model);
    }
    [Route("/service")]
    public IActionResult Service()
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }

    [Route("/blog")]
    public IActionResult Blog()
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }
    [Route("/blog-detail/{title}/{id}")]
    public IActionResult BlogDetail(string title, int id)
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }

    [Route("/event")]
    public IActionResult Event()
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }

    [Route("/event-detail/{title}/{id}")]
    public IActionResult EventDetail(string title, int id)
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }

    [Route("/course")]
    public IActionResult Course()
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }

    [Route("/course-detail/{title}/{id}")]
    public IActionResult CourseDetail(string title, int id)
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }
    [Route("/contact")]
    public IActionResult Contact()
    {
        var model = new IndexViewModel
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
        };
        return View(model);
    }
    [Route("/portfolio-detail/{title}/{id}")]
    public IActionResult PortfolioDetail(String title, int id)
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.OrderBy(x => x.Id).First(),
            Portfolios = db.Portfolios!.Where(x => x.Id == id).ToList(),
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
