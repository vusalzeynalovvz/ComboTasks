using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathHelper
    {
        public int PrintValue(int a, int b)
        {
            return a + b;
        }

        public int PrintValue(bool value)
        {
            if (value == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void PrintValue(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        public int PrintValue(int a, int b, int c)
        {
            return a * b * c;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();

            int result1 = mathHelper.PrintValue(3, 5);
            int result2 = mathHelper.PrintValue(true);
            mathHelper.PrintValue("Hello ", "World!");
            int result3 = mathHelper.PrintValue(2, 4, 6);

            Console.WriteLine("Result 1: " + result1);
            Console.WriteLine("Result 2: " + result2);
            Console.WriteLine("Result 3: " + result3);
        }
    }
}

////3) "MathHelper" adli bir klass yaradin. Ichinde ancaq "PrintValue()"  metodu olmalidi. Bu metodun bir neche dene 
////overload-i movcud olmalidi:

////1.Iki dene integer gebul edib onlarin cemini integer kimi qaytaran variant
////2. Bir dene boolean qebul edib integer qaytaran variant (true qebul edirse 1, false qebul edirse 0 qaytarir)
////3.Iki dene string qebul edib olari birleshdirib ve neticesini console-da yazdiran variant (hansiki void qaytarir)
////4.Uch dene integer qebul edib olarin vurmasini integer kimi qaytaran variant

////Istediyim netice:
////"MathHelper" klassindan object yaradin ver her 4 metodu yoxlayin. Nese qaytaran metodlarin neticesini console-cixardin
