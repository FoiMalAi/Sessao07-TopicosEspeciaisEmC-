using System.Xml;
using System.Globalization;

namespace DateTimeClass

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow; //horario global de greenwich

            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("15/06/2000");

            DateTime d8 = DateTime.ParseExact
                ("15/06/2000", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            
        }
    }
}
