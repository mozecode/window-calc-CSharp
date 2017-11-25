using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //build windows

            Window w1 = new Window();
            //Window is data type, making spot in memory to hold a window, but it has no data inside it yet
            //to assign data, we have to build the window using - new  and choosing one of the constructors we built by calling --Window();
            //this window is w1

            w1.Efficient = true; //changing window 1's efficiency value  and overwrites original data
            w1.Length = -9000;  //doing same for length

            Window w2 = new Window(true);

            //creates a second window
            //uses constructor that just takes boolean value (back in window.cs --public Window (bool isEfficient)

            Window w3 = new Window(10, 10);

            //uses constructor in Window.cs that takes two perameters --public Window (int length, int width)

            Window w4 = new Window(26, 28, true);

            //uses constructor in Window.cs that takes 3 perameters

            double tempPrice = w3.GetPrice(); //tempPrice receives price from class
            Console.WriteLine("The price of Window 3 is {0:C}", tempPrice);

            //lets start a windows quote app here

            //see class notes


            Console.ReadKey();
        }
    }
}
