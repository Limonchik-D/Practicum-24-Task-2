using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_24_Task_2
{
    internal class Avto
    {
        private string model;
        private string color;
        private double skor;

        public string Model
        {
            get { return model == "" ? "Неизвестно" : model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color == "" ? "Неизвестно" : model; }
            set { color = value; } 
        }
        public double Skor
        {
            get { return skor; }
            set
            {
                if (value >= 60 && value <= 150)
                {
                    skor = value;
                }
                else
                {
                    Console.WriteLine("Скорсоть должна быть от 60 до 150 км/ч");
                }
            }
        }
        public Avto(string model, string color, double skor)
        {
            Model = model;
            Color = color;
            Skor = skor;
        }
        public override string ToString()
        {
            return $"Модель: {Model}\nЦвет: {Color}\nСкорость: {Skor} км/ч";
        }

    }
}
