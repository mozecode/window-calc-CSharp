using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Window
    {

        //data members
        //attributes or characteristics of window
        //only accessible inside class unless you add properties to access data
        //want to control against bad input data -- that's why it's private

        //****do initialization inside a constructor, not here.****

        private int length;
        private int width;
        private bool efficient;
        //bool holds true/false data (could also use string)



        //public constructors
        //methods called when we build an instance of this window to initialize our window
        //has no return type, must have same name as class, just capitalized

        public Window()  //no perameters = default constructor-- generic starting point if user enters no alternative
        {
            length = 24;  //single = sign is assigning value, unlike == comparison value
            width = 12;
            efficient = false;

        }

        public Window(bool isEfficient)  //perameterized constructor (has user entered values here it needs to use to do the work)
        {
            length = 24;  //single = sign is assigning value, unlike == comparison value
            width = 12;
            efficient = isEfficient;

        }

        public Window(int length, int width)  //building a bunch of shortcuts to do the work
        {
            //this.private data member= input perameter passed in from parentheses;
            if (length >= 4)
            { this.length = length; }

            else { this.length = 24;  //give a default value
            }
            Width = width;  //go through property to protect -- it defaults back to original values
            efficient = false;


        }

        public Window (int length, int width, bool eff) //can use other names in parentheses for what user passes to you, 
        {

            this.length = length;
            this.width = width;
            efficient = eff;
        }

        //Properties
        //allow read/write access to private data members
        //public, use same data type as what you're referencing, named same as what you're referencing, just capitalized

        public bool Efficient  //bouncer that guards private data -- controls access to private data member data initialized by constructor methods above
        {
            get //describes how to read from the property
            {
                return efficient;

            }

            set //describes how to write to the property
            {
                efficient = value;  //must be true or false because bool
                //user sets to true or false & it's unprotected
            }
        }


        public int Length
        {
            get
            {
                return length;
            }

            set
            { //protected length -- must be greater than or equal to 4 in
                if (value>=4)
                { length = value; }
                else
                { Console.WriteLine("Invalid length");

                    length = 24;
                }

                //could use while loop instead of if else
            }
        }

        public int Width
        {
            get
            { return width; }
            set
            {
                if (value >= 4)
                { width = value; }
                else
                { Console.WriteLine("Invalid width");
                    width = 12;
                }
            }

        }
            //Methods
        //implement actions or behaviors of window

        //calculate price
        // price = 2* (length + height)
        //if (eff) $75

        //each window can calculate its own price based on its values -- doesn't need into passed into method here

        public double GetPrice()
        {
            double price;
            price = 2 * (length + width) * 2.50;

            //data for length and width come from class

            if (efficient== true)
            { price = price + 75;
            }

            return price;
        }

    }
}
