using Microsoft.AspNetCore.Mvc;
public class home:Controller
{
   
    public IActionResult Index()
    {
        return View();
    }
}