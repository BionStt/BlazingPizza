﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public LatLong DeliveryLocation { get; set; }

        public LatLong CurrentLocation { get; set; }

        public string Status { get; set; }

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
