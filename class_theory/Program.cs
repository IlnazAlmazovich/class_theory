using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace class_theory
{
    class House
    {
        public int right_wall; //правая стена
        public int left_wall; //левая стена

        public int Square(int right, int left) //метод который вычсчитывает площадь дома
        {
            int a = right * left;
            Console.WriteLine(a);
            return a;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House(); //создаём экземляр/объект класса
            Console.WriteLine("Введите первую сторону: ");
            house.right_wall = Convert.ToInt32(Console.ReadLine()); // присваиваем значение
            Console.WriteLine("Введите вторую сторону: ");
            house.left_wall = Convert.ToInt32(Console.ReadLine()); // присваиваем значение

            house.Square(house.right_wall, house.left_wall); // вызываем метод для рассчёта площади
           
            Console.ReadKey();
        }
    }
}
