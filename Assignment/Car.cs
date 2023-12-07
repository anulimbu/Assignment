using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    internal class Car
    {
        private string brand;
        private int year;
        private float price;

        public Car(string brand, int year, float price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public string GetBrand()
        {
            return brand;
        }

        public int GetYear()
        {
            return year;
        }

        public float GetPrice()
        {
            return price;
        }
    }
    }
