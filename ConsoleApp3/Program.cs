using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentnum = { 1, 2, 3, 4, 5 };
            string[] studentName = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] comscore = { 80, 65, 100, 98, 83 };
            int[] codescore = { 75, 67, 93, 25, 82 };
            int[] animaxscore = { 60, 62, 91, 50, 87 };

            while (true)
            {
                Console.WriteLine("請輸入座號(1-5):");

                var x = Console.ReadLine();
                int studentNum = int.Parse(x);
                int arrayindex = Array.IndexOf(studentnum, studentNum);
                if (arrayindex > -1)
                {
                    Console.WriteLine("姓名" + studentName[arrayindex]);
                    Console.WriteLine("電腦概論" + comscore[arrayindex]);
                    Console.WriteLine("程式設計" + codescore[arrayindex]);
                    Console.WriteLine("動畫設計" + animaxscore[arrayindex]);
                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }
                Console.WriteLine("\r");

            }
        }
    }
}
