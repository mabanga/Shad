using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopGUI
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        //public Car()
        //{
        //    Make = "nothing make";
        //    Model = "nothing Model";
        //    Price = 0.00m;
        //}
        //public Car(string a, string b, decimal c)
        //{
        //    Make = a;
        //    Model = b;
        //    Price = c;
        //}
        public override string ToString()
        {
            return $"-Make: {Make} \n-Model: {Model} \n-Price: {Price:c}";
        }
        public Car(string make = "noMake", string model = "noModel", decimal price = 0.00m)
        {
            Make = make;
            Model = model;
            Price = price;
        }
    }
}
