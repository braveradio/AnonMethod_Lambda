using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMethod_Lambda
{
    class Program
    {
        delegate int MyHandler(int i);
        static void Main(string[] args)
        {

            var lesson = new Lesson("Programming in C#");
            lesson.Started += (sender, date) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };

            lesson.Start();


            if (int.TryParse(Console.ReadLine(), out int result))
            {
                MyHandler handler = delegate (int i)
                {
                    var r = i * i;
                    Console.WriteLine(r);
                    return r;
                };
                handler += Method;

                handler(result);

                MyHandler lambdaHandler = (i) =>
                {
                    var r = i * i * i;
                    Console.WriteLine(r);
                    return r;
                };

                lambdaHandler(4);
            }
            Console.ReadLine();
        }
        public static int Method(int i)
        {
            var r = i * i * i;
            Console.WriteLine(r);
            return r;
        }
    }
}
