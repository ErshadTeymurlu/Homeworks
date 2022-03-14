using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given tasks
            //1.Verilmiş ədədin sadə ədəd olub olmamasını print edən console app yazın.
            //2.Verilmiş ədədin neçə mərtəbəli olduğunu print edənconsole app yazın.(məsələn: 321 ədədi 3 mərtəbəlidir, 23125 ədədi 5 mərtəbəlidir.)
            //3.Verilmiş ədədin palindrom olub olmadığını print edən  console app yazın.
            #endregion
            #region Task1
            //Console.Write("Add a number: ");
            //int givenNumber = Convert.ToInt32(Console.ReadLine());
            //bool check = false;
            //for (int i = 2; i < givenNumber; i++)
            //{
            //    if (givenNumber % i == 0)
            //    {
            //        Console.Write("The Number is composite.");
            //        check = true;
            //        break;
            //    }
            //}
            //if (check == false) Console.Write("The Number is prime.");
            //Console.ReadLine();
            #endregion
            #region Task2
            //Console.Write("Add a number: ");
            //int givenNumber = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //if (givenNumber < 0) givenNumber = givenNumber * (-1);
            //while(givenNumber>0)
            //{
            //    count++;
            //    givenNumber = givenNumber / 10;
            //}
            //Console.Write("The number has " + count + " places.");
            //Console.ReadLine();
            #endregion
            #region Task3
            //Console.Write("Add a number: ");
            //int givenNumber = Convert.ToInt32(Console.ReadLine());
            //int reverse = 0;
            //if (givenNumber < 10 && givenNumber >= 0) Console.Write("The given number is polindrom.");
            //else
            //{
            //    if (givenNumber < 0) givenNumber = givenNumber * (-1);
            //    int copyNumber = givenNumber;
            //    while (givenNumber > 0)
            //    {
            //        reverse = reverse * 10 + givenNumber % 10;
            //        givenNumber = givenNumber / 10;
            //    }
            //    if (reverse == copyNumber) Console.Write("The given number is polindrom.");
            //    else Console.Write("The given number is not polindrom.");
            //}
            //Console.ReadLine();
            #endregion
        }
    }
}
