using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysListsAndDictionariesSpring2019
{
    public class Car
    {
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int MilesPerGallon { get; set; }
    }
}
