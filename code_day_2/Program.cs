using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_day_2
{


    namespace question1
    {
        class program
        {
            public static void question1()
            {
                ushort number1 = 52130;
                sbyte number2 = -115;
                uint number3 = 4825932;
                byte number4 = 97;
                short number5 = -10000;
                short number6 = 20000;
                byte number7 = 224;
                uint number8 = 970700000;
                sbyte number9 = 112;
                sbyte number10 = -44;
                int number11 = -1000000;
                ushort number12 = 1992;
                ulong number13 = 123456789123456789;
            }
        }
    }


    namespace question2
    {
        class program
        {
            public static void question2()
            {
                bool isMale = true;
                Console.Write("Enter The Gender For Male Type: M or m and for Female type : F or f");
                string gender =Console.ReadLine();

                isMale = (gender == "M" || gender == "m") ? isMale = true : isMale = false;

                Console.WriteLine(isMale);
            }
        }
    }


    namespace question3
    {
        class program
        {
            public static void question3()
            {
                string str1 = "Hello";
                string str2 = "World";
                object obj = str1 + " " + str2;
                Console.WriteLine(obj);
            }
        }
    }

    namespace question4
    {
        class program
        {
            public static void question4()
            {
                Console.Write("Enter The score in the range [1 to 9] ");
                int score = int.Parse(Console.ReadLine());


                switch(score)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("The BONUS score is: " + (score * 10));
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("The BONUS score is: " + (score * 100));
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("The BONUS score is: " + (score * 1000));
                        break;
                    default:
                        Console.WriteLine("Invalid Score!");
                        break;
                }

            }
        }
    }




    class Programxx
    {
        static void Main(string[] args)
        {
            //question2.program.question2();
            //question3.program.question3();
            //question3.program.question3();
            question4.program.question4();
        }
    }
}
