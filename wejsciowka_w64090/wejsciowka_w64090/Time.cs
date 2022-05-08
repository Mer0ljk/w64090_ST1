using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wejsciowka_w64090
{
    class Time
    {
        private int hours;

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
            }
        }
        
        public void Info()
        {
            Console.WriteLine(Hours);
        }
    }
}
