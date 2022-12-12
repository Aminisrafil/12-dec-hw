using System;

namespace c_sharp_hw_12_dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // # verilmis 2 ededi toplayan
            Console.WriteLine("1ci ededi daxil edin");
            var num1 = Console.ReadLine();
            var Num1 = Convert.ToInt32(num1);
            Console.WriteLine("2ci ededi daxil edin");
            var num2 = Console.ReadLine();
            var Num2 = Convert.ToInt32(num2);
            var result = Increment(Num1, Num2);
            Console.WriteLine(result);

            //verilmis eded cutdu?
            Console.WriteLine("Ededi daxil edin");
            var numm1 = Console.ReadLine();
            var Numm1 = Convert.ToInt32(num1);
            var result1 = Even(Num1);
            Console.WriteLine(result1);

            //verilmisin kvadratini tap
            Console.WriteLine("Ededi daxil edin");
            var num = Console.ReadLine();
            var Num = Convert.ToInt32(num);
            var result2 = Square(Num);
            Console.WriteLine(result2);

            // Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
            Console.WriteLine("ifadeni daxil edin");
            string word = Console.ReadLine();
            var result3 = Isa(word);
            Console.WriteLine(result3);

            //verilmis ededin reqemleri cemini tap
            Console.WriteLine("Ededi daxil edin");
            var eded1 = Console.ReadLine();
            var eded = Convert.ToInt32(eded1);
            var result4 = Numssum(eded);
            Console.WriteLine(result4);

            //Verilmis 4 ededin ortalamasini tapan
            Console.WriteLine("1ci ededi daxil edin");
            var Number1 = Console.ReadLine();
            var number1 = Convert.ToInt32(Number1);
            Console.WriteLine("2ci ededi daxil edin");
            var Number2 = Console.ReadLine();
            var number2 = Convert.ToInt32(Number2);
            Console.WriteLine("3cu ededi daxil edin");
            var Number3 = Console.ReadLine();
            var number3 = Convert.ToInt32(Number3);
            Console.WriteLine("4cu ededi daxil edin");
            var Number4 = Console.ReadLine();
            var number4 = Convert.ToInt32(Number4);
            var result5 = Average(number1, number2, number3, number4);
            Console.WriteLine(result5);
        }
        static int Square(int num)
        {
            var multiply = num * num;
            return multiply;


        }

        static int Increment(int num, int num2)
        {
            var cem = num + num2;
            return cem;

        }
        static bool Even(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Isa(string word)
        {
            var has = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    has = true;
                    break;
                }
                else
                {
                    has = false;
                }


            }
            return has;

        }
        static int Numssum(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                var x = num % 10;
                sum += x;
                num = (num - x) / 10;
            }
            return sum;

        }
        static int Average(int num1, int num2, int num3, int num4)
        {
            int average = (num1 + num2 + num3 + num4) / 4;
            return average;
        }
    }
}

