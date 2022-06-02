using Microsoft.AspNetCore.Mvc;

namespace TagHelperJetBrainsAnnotationsSample.Controllers;

public class TagHelperSampleController : Controller
{
  // GET
  public IActionResult Index()
  {
    return View();
  }
}