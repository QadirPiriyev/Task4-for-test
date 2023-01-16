using System.Drawing;

namespace Task4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           programa xosh gelmisiniz");
            Console.Write("Nece kitab yaratmaq isdeyirsiz :");
            int a = helper.yoxlama();
            book[] kitab = new book[a];
            for (int i = 0; i < kitab.Length; i++)
            {
                book s = new book();
                Console.Write($"{i + 1})Muellifin adini daxil edin :");
                s.muellif = helper.stringChecker();
                Console.Write($"{i + 1})Eserin adini daxil edin :");
                s.eser = helper.stringChecker();
                Console.Write($"{i + 1})Kitab nece sehiveden ibaretdir? :");
                label2:
                s.sehife = helper.yoxlama2();
                if (s.sehife<10)
                {
                    Console.WriteLine("duzgun sehife daxil edin");
                    goto label2;
                }
                Console.Write($"{i + 1})Kitabin nesr ilini daxil edin :");
                s.nesr = helper.yoxlama3();
                kitab[i] = s;
            }
            Console.WriteLine("--------------------");
            foreach (book item in kitab)
            {
                Console.WriteLine(item);
            }

            label1:
            Console.WriteLine("Nusxe yaratmaq isdeyirsizse 1-e basin eks halda 0-a basin");
            int test= helper.yoxlama4();
            int copyer = helper.ArrayChecker(a, test);
            if (copyer == -1){ goto label1; }
            
            
            Console.WriteLine($"copyasi yaradilacaq kitap = {kitab[copyer-1]}");
            
        }   
    }    
	
}