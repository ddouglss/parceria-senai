
using Microsoft.AspNetCore.Mvc;

public class TesteController:Controller
{
    public IActionResult Index(){
        return View(); //páginas cshtml (template engine Razor)
    }
}

