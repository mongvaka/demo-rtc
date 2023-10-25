using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebRtcDemo.Controllers;

public class HomeController : Controller
{

    private static Random random = new Random();


    public IActionResult Index()
    {
        const string chars = "0123456789";
        string strRan = new string(Enumerable.Repeat(chars, 2)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        return Redirect($"/{strRan}");
    }
    [HttpGet("/{roomId}")]
    public IActionResult Room (string roomId)
    {
        ViewBag.roomId = roomId;
        return View();
    }

}


