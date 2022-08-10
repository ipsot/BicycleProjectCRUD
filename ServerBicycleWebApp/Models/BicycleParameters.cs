using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerBicycleWebApp.Models
{
    public static class BicycleParameters
    {
        private static List<Bicycle> bicycles = new List<Bicycle>()
        {
            new Bicycle()
            {
                Id=1,MaxSpeed=100,Color="red",Model="BMX",Price=12000
            },
            new Bicycle()
            {
                Id=2,MaxSpeed=120,Color="Green", Model="Stels", Price=8000
            }

        };
        public static void AddNewBicycle(Bicycle bicycle)
        {
            bicycle.Id = bicycles.LastOrDefault().Id + 1;
            bicycles.Add(bicycle);
        }
        public static List<Bicycle> GetAllBicycle()
        {
            return bicycles;
        }
        public static Bicycle GetBicycleById(int id)
        {
            return bicycles.FirstOrDefault(b => b.Id == id);
        }
        public static bool DeleteBicycleById(int id)
        {
            Bicycle foundedBicycle= bicycles.FirstOrDefault(b => b.Id == id);
           
            return bicycles.Remove(foundedBicycle);
        }
        public static bool UpadeteBycicle(Bicycle newBicycle)
        {
            Bicycle foundedBicycle = bicycles.FirstOrDefault(b => b.Id == newBicycle.Id);
            if (foundedBicycle==null)
            {
                return false;
            }
            foundedBicycle.MaxSpeed = newBicycle.MaxSpeed;
            foundedBicycle.Color = newBicycle.Color;
            foundedBicycle.Model = newBicycle.Model;
            foundedBicycle.Price = newBicycle.Price;
            return true;

        }
    }
}