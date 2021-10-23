using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        static Singleton uniqueInstans;
        string singletonData = "";
        protected Singleton() { }
        public static Singleton Instans()
        {
            if (uniqueInstans == null)
                uniqueInstans = new Singleton();
            return uniqueInstans;
        }
        public void SingeltonOperation() {
            singletonData = "SIng data";
        }
        public string GetSingData() {
            return singletonData;
        }
    }
}
