using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.扩展方法
{
    //<1>扩展方法必须在一个非嵌套、非泛型的静态类中定义
    //<2>扩展方法必须是一个静态方法 --Static classes can only have static members. This sentence is a rubbish.
    //<3>扩展方法至少要有一个参数
    //<4>第一个参数必须附加this关键字作为前缀
    //<5>第一个参数不能有其他修饰符（比如ref或者out）
    //<6>第一个参数不能是指针类型

    /// <summary>
    /// 1.1 non-static class
    /// </summary>
    public class NonStatClass
    {
        public static void PrintString(this String val)
        {
            Console.WriteLine(val);
        }

        public static void UseExtendMethod()
        {
            var a = "aaa";
            a.PrintString();
        }
    }

    /// <summary>
    /// 1.2 Nested class
    /// </summary>
    public static class OutClass
    {
        public static class NestedClass
        {
            public static void PrintString(this String val)
            {
                Console.WriteLine(val);
            }

            public static void UseExtendMethod()
            {
                var a = "aaa";
                a.PrintString();
            }
        }
    }

    /// <summary>
    /// 1.3 Generic class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class GenericClass<T>
    {
        public static void PrintString(this String val)
        {
            Console.WriteLine(val);
        }

        public static void UseExtendMethod()
        {
            var a = "aaa";
            a.PrintString();
        }
    }

    /// <summary>
    /// 1. Right extend method
    /// </summary>
    public static class TopLevelClass
    {
        public static void PrintString(this String val)
        {
            Console.WriteLine(val);
        }

        /// <summary>
        /// 2. 扩展方法必须是一个静态方法
        /// </summary>
        /// <param name="val"></param>
        public void PrintString(this String val)
        {
            Console.WriteLine(val);
        }

        public static void UseExtendMethod()
        {
            var a = "aaa";
            a.PrintString();
        }
    }





}
