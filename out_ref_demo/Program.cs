using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_ref_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            //add1(a);//输出
            //add2(ref a);
            //add3(out a);
            // Console.WriteLine("main:" + a);


            ClassParam cp = new ClassParam();
            Person p = new Person();
            p.name = "fashi";
            //cp.say1(p);
            cp.say2(ref p);
            //cp.say3(out p);d
            Console.WriteLine("main:" + p.name);


            Console.ReadKey();
        }

        public static void add1(int a)
        {
            Console.WriteLine("内部改写前 add1:" + a);
            //直接将变量值带入函数中

            a = 10;
            Console.WriteLine("内部改写后 add1:" + a);
        }

        public static void add2(ref int a)
        {
            Console.WriteLine("内部改写前 add2:" + a);
            //即会将变量值带入函数中，又会改写a的值
            a = 10;
            Console.WriteLine("内部改写后 add2:" + a);
        }  
        public static void add3(out int a)
        {
           // Console.WriteLine("before add3:" + a);
            //改写a的值，但是不会把a的值带入函数中
            a = 10;
            Console.WriteLine("内部改写后 add3:" + a);
        }

    }

    public class ClassParam
    {
        public void say1(Person p)
        {
            Console.WriteLine("内部改写前 say1:" + p.name);
            p = new Person();
            p.name = "xue";
            Console.WriteLine("内部改写后 say1:" + p.name);
        }

        public void say2(ref Person p)
        {
            Console.WriteLine("内部改写前 say2:" + p.name);
            p = new Person();
            p.name = "xue";
            Console.WriteLine("内部改写后 say2:" + p.name);
        }

        public void say3(out Person p)
        {
            // Console.WriteLine("内部改写前 say3:" + p.name);
            //因为out只出不进，所有要重新new
            p = new Person();
            p.name = "xue";
            Console.WriteLine("内部改写后 say3:" + p.name);
        }
    }

    public class Person
    {
        public string name;
    }

}
