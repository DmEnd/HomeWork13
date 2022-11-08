using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    internal class Building
    {
        public string Adress { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string adress, double length, double width, double height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Print()
        {
            return $"{Adress} {Length} {Width} {Height}";
        }

    }

    sealed class MultiBuilding : Building
    {
        public int Floors { get; set; }

        public MultiBuilding(string adress, double length, double width, double height, int floors)
            : base(adress, length, width, height)
        {
            Floors = floors;
        }

        public string Print()
        {
            return $"{base.Print()} {Floors}";
        }
    }
}

