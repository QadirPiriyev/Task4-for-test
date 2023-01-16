using System.Collections.Generic;

namespace Task4_
{
    internal class helper
    {
       internal static int yoxlama()
        {
        Label1:
            int a;

            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Tam ededi daxil edin");
                goto Label1;
            }
            else
            {
                return a;
            }
        }
       internal static int yoxlama2()
        {
            int a;
        Label1:
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Duzgun sehive daxil edin");
                goto Label1;
            }
            else
            {
                return a;
            }
        }//sehive ucun
       internal static int yoxlama3()
        {
            int a;
        Label1:
            string inputvalue = Console.ReadLine();
            int.TryParse(inputvalue, out a);
            if (int.TryParse(inputvalue, out a) != true)
            {
                Console.WriteLine("Duzgun nesr ili daxil edin");
                goto Label1;
            }
            else
            {
                return a;
            }
        }//nesr ucun
       internal static int yoxlama4()//nusxe ucun
        {
        label1:
            int b = yoxlama();
            if (b == 1)
            {
                Console.WriteLine("Hansi eserin nusxesini isdeyirsiz? ");
                int value = yoxlama2();
                return value;

            }
            else if (b == 0)
            {
                Console.WriteLine("Umid edirik size komek ola bildik");
            }
            else
            {
                Console.WriteLine("Yanlis!");
                goto label1;
            }
            return b;

        }
        internal static string stringChecker()
        {
            l1:
            string input=Console.ReadLine();
            if (int.TryParse(input,out int a))
            {
                Console.WriteLine("Duzgun daxil edin");
                goto l1;
            }
            return input;
        }
        internal static int ArrayChecker(int limit,int Copy)
        {

            if ( limit < Copy)
            {
                Console.WriteLine("daxil ettdiyiniz melumat tapilmadi");
                return -1;
            }
            else
            {
                return Copy;
            }
       
        }
    }
}
