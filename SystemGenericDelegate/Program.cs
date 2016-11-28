using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemGenericDelegate
{
    /// <summary>
    /// bool Predicate<T>(函数名或或delegate或lambda)
    /// Action<T,...,T16>(函数名或或delegate或lambda)
    /// Func<T-input,T-output>(函数名或或delegate或lambda)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("使用方法名作为三个系统委托的参数");
            Console.WriteLine(new Predicate<string>(UsePredicate)(""));
            new Action<string>(UseAction)("");
            new Action<int, int>(UseAction)(1, 2);
            Console.WriteLine(new Func<int, int, string>(UseFunc)(3, 4));

            Console.WriteLine("使用委托");
            Console.WriteLine(new Func<int, int, string>(delegate (int a, int b) { Console.WriteLine("inside delegate body"); return (a + b).ToString(); })(1,2));

            Console.WriteLine("使用lambda expression 作为三个系统委托的参数");
            Console.WriteLine(new Func<int, int, string>((a, b) => { Console.WriteLine("inside labmda body"); return (a + b).ToString(); })(1, 2));
            Console.ReadLine();
        }

        private static bool UsePredicate(string predicate)
        {
            Console.WriteLine("Predicate");
            return false;
        }

        private static void UseAction(int one, int two)
        {
            Console.WriteLine(String.Format("{0}+{1}={2}", one, two, one + two));
        }

        private static void UseAction(string actionArgs)
        {
            Console.WriteLine("Action");
        }

        private static string UseFunc(int args1, int args2)
        {
            return String.Format("args1:{0} args2:{1}", args1, args2);
        }
    }
}
