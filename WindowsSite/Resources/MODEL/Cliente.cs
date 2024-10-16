using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsSite.Resources.MODEL
{
    internal class Cliente
    {
        public int NameBox { get; set; }
        public string telBox { get; set; }
        public string City { get; set; }
        public float Price { get; set; }

        public Property(string objective,
            string city, float price)
        {
            Objective = objective;
            City = city;
            Price = price;
        }
    }
}
