//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Multithreading
//{
//    public class Demo
//    {
//        public void M1()
//        {
//            for(int i=1; i<=5; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//        public void M2()
//        {
//            for (int i = 6; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Demo d = new Demo();
//            d.M1();
//            d.M2();
//            Thread t1 = new Thread(new ThreadStart(d.M1));
//            //ThreadStart is a delegete
//            //it will hold method ref that need to exec by the thread
//            Thread t2 = new Thread(new ThreadStart(d.M1));
//            t1.Priority = ThreadPriority.BelowNormal;
//            t2.Priority = ThreadPriority.Highest;
//            t1.Start();
//            t2.Start();
//            t1.Join(); // next all thread will be in wait state to complete the task of t1 thread
//            t2.Join();
//        }
//    } 
//}
