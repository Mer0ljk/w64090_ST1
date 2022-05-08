using System;

namespace wejsciowka_w64090
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time() { Hours = 5};

            time1.Info();

            time1.Hours = 7;

            time1.Info();
        }
    }
}
