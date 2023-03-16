using Microsoft.AspNetCore.Mvc;

public class MicrosoftController:Controller
{
    public IActionResult Index(){
        return View(); //páginas cshtml (template engine Razor)
    }

     public IActionResult Microsoft(){
        return View();
    }

    public IActionResult Oracle(){
        return View();
    }

     public IActionResult Cisco(){
        return View();
    }

     public IActionResult Huawei(){
        return View();
    }

     public IActionResult Google(){
        return View();
    }
}
