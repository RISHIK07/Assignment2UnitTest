using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2UnitTest
{
    class Program
    {
        static int MainMenu()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("1.Get Rectangle Length\n");
            Console.WriteLine("2.Change Rectangle Length\n");
            Console.WriteLine("3.Get Rectangle Width\n");
            Console.WriteLine("4.Change Rectangle Width\n");
            Console.WriteLine("5.Get Rectangle Perimeter\n");
            Console.WriteLine("6.Get Rectangle Area\n");
            Console.WriteLine("7.Exit\n");
            int userInput = int.Parse(Console.ReadLine());
            return (userInput);
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            int varlength = 0;
            int varwidth = 0;

            Console.WriteLine("Enter Length for Rectangle :");
            string userLength = Console.ReadLine();

            while (true)
            {

                if (!int.TryParse(userLength, out varlength))
                {
                    Console.WriteLine("Invalid input!\nRectangle Length should be Positive Integer");
                    userLength = Console.ReadLine();
                }
                else if (varlength < 1)
                {
                    Console.WriteLine("Invalid input!\nPlease enter rectanlge length again");
                    userLength = Console.ReadLine();
                }
                if (int.TryParse(userLength, out varlength) && varlength > 0)
                {
                    break;
                }
            }



            Console.WriteLine("Enter Width for Rectangle :");
            string userWidth = Console.ReadLine();
            while (true)
            {

                if (!int.TryParse(userWidth, out varwidth))
                {
                    Console.WriteLine("Invalid input!\nRectangle Width should be Positive Integer");
                    userWidth = Console.ReadLine();
                }
                else if (varwidth < 1)
                {
                    Console.WriteLine("Invalid input!\nPlease enter rectanlge Width again");
                    userWidth = Console.ReadLine();
                }
                if (int.TryParse(userWidth, out varwidth) && varwidth > 0)
                {
                    break;
                }
            }

            Rectangle rec = new Rectangle(varlength, varwidth);
            while (true)
            {
                int choice = MainMenu();


                if (choice >= 1 && choice <= 7)
                {
                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Length of Rectangle is : " + rec.GetLength());
                            break;
                        case 2:
                            Console.WriteLine("Enter new length");
                            string newLength = Console.ReadLine();
                            int l = 0;
                            while (true)
                            {
                                bool lengthCheck = int.TryParse(newLength, out l);
                                if (!lengthCheck)
                                {
                                    Console.WriteLine("Invalid input!\nRectangle Length should be Positive Integer");
                                    newLength = Console.ReadLine();
                                }
                                else if (l < 1)
                                {
                                    Console.WriteLine("Invalid input!\nPlease enter rectanlge length again");
                                    newLength = Console.ReadLine();
                                }
                                if (int.TryParse(newLength, out l) && l > 0)
                                {
                                    l = rec.SetLength(l);
                                    break;
                                }
                            }

                            break;
                        case 3:
                            Console.WriteLine("Rectangle's width: " + rec.GetWidth());
                            break;
                        case 4:
                            Console.WriteLine("Enter new width");
                            string newWidth = Console.ReadLine();
                            int w = 0;
                            while (true)
                            {

                                if (!int.TryParse(newWidth, out w))
                                {
                                    Console.WriteLine("Invalid input!\nRectangle Width should be Positive Integer");
                                    newWidth = Console.ReadLine();
                                }
                                else if (w < 1)
                                {
                                    Console.WriteLine("Invalid input!\nPlease enter rectanlge Width again");
                                    newWidth = Console.ReadLine();
                                }
                                if (int.TryParse(newWidth, out w) && w > 0)
                                {
                                    w = rec.SetWidth(w);
                                    break;
                                }
                            }

                            break;
                        case 5:

                            Console.WriteLine("\nRectangle's perimeter: " + rec.GetPerimeter());
                            break;
                        case 6:

                            Console.WriteLine("\nRectangle's area: " + rec.GetArea());
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            choice = MainMenu();
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Please select option between 1 to 7.");
                    choice = MainMenu();
                }
            }

            Console.ReadKey();

        }
    }
}
