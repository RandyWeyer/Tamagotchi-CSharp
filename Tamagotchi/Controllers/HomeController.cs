using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index", TamagotchiHealth.newTamagotchiHealth);
    }
    [Route("/Create-Tamagotchi")]
    public ActionResult CreateTamagotchi()
    {
        TamagotchiHealth.newTamagotchiHealth.SetFood(1000);
        TamagotchiHealth.newTamagotchiHealth.SetWater(1000);
        TamagotchiHealth.newTamagotchiHealth.SetSleep(1000);
        TamagotchiHealth.newTamagotchiHealth.SetAttention(1000);
        Console.WriteLine("Food: " + TamagotchiHealth.newTamagotchiHealth.GetFood());
        Console.WriteLine("Water: " + TamagotchiHealth.newTamagotchiHealth.GetWater());
        Console.WriteLine("Sleep: " + TamagotchiHealth.newTamagotchiHealth.GetSleep());
        Console.WriteLine("Attention: " + TamagotchiHealth.newTamagotchiHealth.GetAttention());
        Console.WriteLine("=========================================");
        return View("Index", TamagotchiHealth.newTamagotchiHealth);
    }

    [Route("/Feed-Tamagotchi")]
    public ActionResult FeedTamagotchi()
    {
        TamagotchiHealth.newTamagotchiHealth.Feed(100);
        Console.WriteLine("Food: " + TamagotchiHealth.newTamagotchiHealth.GetFood());
        Console.WriteLine("Water: " + TamagotchiHealth.newTamagotchiHealth.GetWater());
        Console.WriteLine("Sleep: " + TamagotchiHealth.newTamagotchiHealth.GetSleep());
        Console.WriteLine("Attention: " + TamagotchiHealth.newTamagotchiHealth.GetAttention());
        Console.WriteLine("=========================================");
        return View("Index");
    }

    [Route("/Rest-Tamagotchi")]
    public ActionResult RestTamagotchi()
    {
        TamagotchiHealth.newTamagotchiHealth.Sleep(100);
        Console.WriteLine("Food: " + TamagotchiHealth.newTamagotchiHealth.GetFood());
        Console.WriteLine("Water: " + TamagotchiHealth.newTamagotchiHealth.GetWater());
        Console.WriteLine("Sleep: " + TamagotchiHealth.newTamagotchiHealth.GetSleep());
        Console.WriteLine("Attention: " + TamagotchiHealth.newTamagotchiHealth.GetAttention());
        Console.WriteLine("=========================================");
        return View("Index");
    }
    [Route("/Water-Tamagotchi")]
    public ActionResult WaterTamagotchi()
    {
        TamagotchiHealth.newTamagotchiHealth.Water(100);
        Console.WriteLine("Food: " + TamagotchiHealth.newTamagotchiHealth.GetFood());
        Console.WriteLine("Water: " + TamagotchiHealth.newTamagotchiHealth.GetWater());
        Console.WriteLine("Sleep: " + TamagotchiHealth.newTamagotchiHealth.GetSleep());
        Console.WriteLine("Attention: " + TamagotchiHealth.newTamagotchiHealth.GetAttention());
        Console.WriteLine("=========================================");
        return View("Index");
    }
    [Route("/Attention-Tamagotchi")]
    public ActionResult AttentionTamagotchi()
    {
        TamagotchiHealth.newTamagotchiHealth.Attention(100);
        Console.WriteLine("Food: " + TamagotchiHealth.newTamagotchiHealth.GetFood());
        Console.WriteLine("Water: " + TamagotchiHealth.newTamagotchiHealth.GetWater());
        Console.WriteLine("Sleep: " + TamagotchiHealth.newTamagotchiHealth.GetSleep());
        Console.WriteLine("Attention: " + TamagotchiHealth.newTamagotchiHealth.GetAttention());
        Console.WriteLine("=========================================");
        return View("Index");
    }
  }
}
