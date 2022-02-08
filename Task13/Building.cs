using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Building
    {
        string address;
        int length;
        int width;
        int height;

        public string Address
        {
            set
            {
                address=value;
            }
            get
            {
                return address;
            }
        }
        public int Length
        {
            set
            {
                if (value < 1 || value > 100)
                {
                    length = 1;
                    Console.WriteLine("Значение некорректно, автоустановка длины: {0}", length);
                }
                else
                {
                    length = value;
                }
            }
            get
            {
                return length;
            }
        }
        public int Width
        {
            set
            {
                if (value < 1 || value > 100)
                {
                    width = 1;
                    Console.WriteLine("Значение некорректно, автоустановка ширины: {0}", width);
                }
                else
                {
                    width = value;
                }
            }
            get
            {
                return width;
            }
        }
        public int Height
        {
            set
            {
                if (value < 1 || value > 100)
                {
                    height = 1;
                    Console.WriteLine("Значение некорректно, автоустановка высоты: {0}", height);
                }
                else
                {
                    height = value;
                }
            }
            get
            {
                return height;
            }
        }
        public Building(string address, int length, int width, int height)
        {
            this.Address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"Aдрес здания:{address} Длина здания:{length} Ширина здания:{width} Высота здания:{height}";
        }
    }
}
