using System;

namespace MySingleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //SingletonClass.getInstance();
            //SingletonClass.getInstance();
            //SingletonClass.getInstance();

            LazySingleton a = LazySingleton.getInstance();
            LazySingleton b = LazySingleton.getInstance();

            if(a == b)
               Console.WriteLine("Hello World!");   //the best check SHALLOW check, 
                                                    //if they are pointed to the same object


            //SingletonClass sc = new SingletonClass(); //cannot access

        }
    }
}
