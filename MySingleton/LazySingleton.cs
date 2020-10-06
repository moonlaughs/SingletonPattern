using System;
using System.Collections.Generic;
using System.Text;

namespace MySingleton
{
    public class LazySingleton //lazy singleton => you wait untill you really need it
    {
        private static LazySingleton instance;

        private LazySingleton()
        {
                
        }

        public static LazySingleton getInstance()
        {
            if(instance == null)
            {
                instance = new LazySingleton();
                Console.WriteLine("created 1");
            }
            return instance;
            //if (instance != null)
            //{
            //    Console.WriteLine("instance returned");
            //    return instance;
            //}
            //else
            //{
            //    instance = new SingletonClass();
            //    Console.WriteLine("created 1");
            //    return instance;
            //}

        }
    }
}
