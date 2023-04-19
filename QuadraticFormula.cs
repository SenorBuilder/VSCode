using System;
using System.Collections.Generic;

namespace VSCode
{
    internal class QuadraticFormula
    {

        public static void QF()
        {
            double a;
            double b;
            double c;

            double A;
            double _B;
            double B;
            double C;

            double PAnswer;   
            double NAnswer;

            Console.WriteLine("\n    -b +- √b² - 4(a)(c)");
            Console.WriteLine("x = -------------------");
            Console.WriteLine("           2(a)        ");

            Console.WriteLine("\nInsert a number for 'a'");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsert a number for 'b'");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInsert a number for 'c'");
            c = Convert.ToInt32(Console.ReadLine());

            A = b * -1;
            _B = b * b - 4 * a * c;
            if(_B < 0){
                _B = _B * -1;
            }
            _B = Math.Sqrt(_B) * -1;
            B = Math.Round(_B, 3);
            C = a * 2;

            Console.WriteLine("\nThe unsimplified answer is: \n ");
            Console.WriteLine("    " + A + " +- " + B);
            Console.WriteLine("x = ------------");
            Console.WriteLine("         "+ C);

            PAnswer = A + B;
            PAnswer = Math.Round(PAnswer / C, 3);

            Console.WriteLine("The positive simplified answer is: \n" + PAnswer);

            NAnswer = A - B;
            NAnswer = Math.Round(NAnswer / C, 3);      

            Console.WriteLine("\nThe negative simplified answer is: \n" + NAnswer);
            

            Console.ReadKey();
            Console.Clear();
        }
        
    }
}