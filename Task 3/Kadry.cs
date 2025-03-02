using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Kadry
    {
        private string fam; //Фамилия
        private int age; //Возраст
        private string dol; //Должность
        private int staj; //Стаж

        public Kadry() //Без параметров
        {
            fam = "Неизвестно";
            age = 0;
            dol = "Неизвестно";
            staj = 0;
        }
        public Kadry(string fam, int age, string dol, int staj) //С параметром
        {
            Fam = fam;
            Age = age;
            Dol = dol;
            Staj = staj;
        }
        public string Fam //Свойство
        {
            get { return fam == "" ? "Неизвестно" : fam; }
            set { fam = value; }
        }

        public int Age //Свойство
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 65)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст должен быть от 18 до 65 лет");
                }
            }
        }
        public string Dol //Свойство
        {
            get { return dol == "" ? "Неизвестно" : dol; }
            set { dol = value; }
        }
        public int Staj //Свойство
        {
            get { return staj; }
            set
            {
                if (value >= 0 && value <= 47)
                {
                    staj = value;
                }
                else
                {
                    Console.WriteLine("Стаж должен быть от 0 до 47 лет");
                }
            }
        }
        public override string ToString() //Метод
        {
            return $"Фамилия: {Fam}\nВозраст: {Age}\nДолжность: {Dol}\nСтаж: {Staj} лет";
        }


    }
}
