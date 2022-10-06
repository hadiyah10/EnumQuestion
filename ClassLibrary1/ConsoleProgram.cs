using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineCategoryByRange
{
    public enum Category
    {
        E = 20,
        D = 40,
        C = 60,
        B = 80,
        A = 100
    }
    public class ConsoleProgram
    {
        /*
        public Class1()
        {
            var xx = GetValue();
            Console.WriteLine(xx);

            var txt = Console.ReadLine();
        }

        private static int GetValue()
        {
            return 10;
        }

        public class Employee
        {
            public String Name { get; set; }

            public Employee()
            {
                Name = "";
            }
        }
        */

        public static void Display()
        {
            int previous = 0;
            foreach (var cat in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine("Category " + cat + " has the range of " + previous + " - " + (int)cat);
                previous = (int)cat + 1;
            }
        }

        public void Check()
        {
            int value = 0;
            int exit = -1;
            do
            {
                Display();

                Console.WriteLine("Enter a value: ");
                value = int.Parse(Console.ReadLine());

                if (value == exit)
                {
                    return;
                }


                Category userCat = new Category();
                int previous = 0;

                foreach (var cat in Enum.GetValues(typeof(Category)))
                {
                    if (value >= previous && value <= (int)cat)
                    {
                        userCat = (Category)cat;
                        break;
                    }
                    previous = (int)cat + 1;
                }

                Console.WriteLine("Your category is: " + userCat);
            }

            while (value != exit);

        }


    }
}



