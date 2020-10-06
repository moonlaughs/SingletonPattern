using System;
using System.Collections.Generic;
using System.Text;

namespace MySingleton
{
    class EagerSingleton
    {        
        private static EagerSingleton instance = new EagerSingleton();

        private EagerSingleton()
        {

        }

        public static EagerSingleton getInstance()
        {
            return EagerSingleton.instance;
        }
    }
}
