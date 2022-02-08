using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    sealed class MultiBuilding : Building
    {
        int floors;

        public int Floors
        {
            set
            {
                if (value < 1 || value > 100)
                {
                    floors = 1;
                    Console.WriteLine("Значение некорректно, автоустановка этажности: {0}", floors);
                }
                else
                {
                    floors = value;
                }
            }
            get
            {
                return floors;
            }
        }
        public MultiBuilding(string address, int length, int width, int height, int floors)
            :base(address, length, width, height)
        {
            this.Floors = floors;
        }

        public string Print()
        {
            string result = base.Print();
            result += $" Этажность:{floors}";
            return result;
        }
    }
}
