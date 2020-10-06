using System;
using System.Collections.Generic;
using System.Text;

namespace MySingleton
{
    class PublicEagerSingleton
    {
        public readonly static PublicEagerSingleton instance = new PublicEagerSingleton();

        private PublicEagerSingleton()
        {

        }
    }
}
