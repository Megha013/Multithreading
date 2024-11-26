//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Multithreading
//{
//    public class Demo2
//    {
//        public void M1()
//        {
//            Monitor.Enter(this);
//            {
//                for (int i = 1; i <= 5; i++)
//                {
//                    Console.WriteLine(Thread.CurrentThread.Name);
//                    Console.WriteLine(i);
//                }
//            }
//            Monitor.Pulse(this);
//            Monitor.Exit(this);
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Demo2 d = new Demo2();
//            Thread t1 = new Thread(new ThreadStart(d.M1));
//            Thread t2 = new Thread(new ThreadStart(d.M1));
//            t1.Name = "T1";
//            t2.Name = "T2";
//            t1.Start();
//            t2.Start();
//        }
//    }
//}
