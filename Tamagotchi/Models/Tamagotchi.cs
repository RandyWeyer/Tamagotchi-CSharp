
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Tamagotchi.Models
{
  public class TamagotchiHealth
  {
    private int _food;
    private int _water;
    private int _sleep;
    private int _attention;

    public static TamagotchiHealth newTamagotchiHealth = new TamagotchiHealth();

    public int GetFood()
    {
      return _food;
    }

    public void SetFood(int newFood)
    {
      _food = newFood;
    }
    public void Feed(int foodModifier)
    {
      _food += foodModifier;
    }
    public int GetWater()
    {
      return _water;
    }

    public void SetWater(int newWater)
    {
      _water = newWater;
    }
    public void Water(int waterModifier)
    {
      _water += waterModifier;
    }
    public int GetSleep()
    {
      return _sleep;
    }

    public void SetSleep(int newSleep)
    {
      _sleep = newSleep;
    }
    public void Sleep(int sleepModifier)
    {
      _sleep += sleepModifier;
    }
    public int GetAttention()
    {
      return _attention;
    }

    public void SetAttention(int newAttention)
    {
      _attention = newAttention;
    }
    public void Attention(int attentionModifier)
    {
      _attention += attentionModifier;
    }

  }
}
