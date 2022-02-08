using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        //Задан класс Building, который описывает здание. Класс содержит следующие элементы:
        //адрес здания; длина здания; ширина здания; высота здания.
        //В классе Building нужно реализовать следующие методы:
        //конструктор с 4 параметрами; свойства get/set для доступа к полям класса; метод Print(), который выводит информацию о здании.
        //Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:
        //конструктор с 5 параметрами – реализует вызов конструктора базового класса;
        //свойство get/set доступа к внутреннему полю класса;
        //метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
        //Класс MultiBuilding сделать таким, что не может быть унаследован.

        static void Main(string[] args)
        {
            Console.Write("Введите адрес здания:");
            string address = Console.ReadLine();
            Console.Write("Укажите длину здания:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите ширину здания:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите высоту здания:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите этажность здания:");
            int floors = Convert.ToInt32(Console.ReadLine());
            Building building = new Building(address, length, width, height);
            MultiBuilding multiBuilding = new MultiBuilding(address, length, width, height, floors);
            Console.WriteLine(building.Print());
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
