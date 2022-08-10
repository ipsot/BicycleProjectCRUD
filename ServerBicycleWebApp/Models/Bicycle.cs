﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerBicycleWebApp.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public int MaxSpeed { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}