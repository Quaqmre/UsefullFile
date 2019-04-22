using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Keyvaluetry
{
    public class Program
    {
        //     public Program()
        //     {
        //         asd = "123";
        //         QWE = "456";
        //     }
        //     public string asd { get; set; }
        //     public string QWE { get; set; }
        //     public void asdd()
        //     {

        //     }
        //     static void Main(string[] args)
        //     {
        //         string i = "F9";
        //         byte f = Byte.Parse(i, System.Globalization.NumberStyles.HexNumber);
        //         System.Console.WriteLine(f);
        //         System.Console.WriteLine(Convert.ToString(f, 16).ToUpper());

        //     }

        //     public static string Keyvaluehelper(object t)
        //     {
        //         var x = t.GetHashCode();
        //         System.Console.WriteLine(x);
        //         Console.ReadKey();
        //         return null;
        //     }
        static void Main(string[] args)
        {
            var x = createTimer(1000, null);
            // var y = createTimer(2000, asd);
            System.Console.WriteLine("asdasd");
            for (int i = 0; i < 10000000000; i++)
            {

            }
            x.Enabled = false;
            System.Console.WriteLine("11111");
            Console.ReadKey();

        }
        static System.Timers.Timer createTimer(double interval, ElapsedEventHandler a)
        {
            var aTimer = new System.Timers.Timer();
            aTimer.Interval = interval;
            aTimer.Elapsed += async (_, b) => await OnTimedEvent(_, b, 100, 200);
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            return aTimer;
        }
        private static async Task OnTimedEvent(object t, ElapsedEventArgs x, int a, int b)
        {
            var g = t.GetType().GetProperties().ToList();
            foreach (var h in g)
            {
                System.Console.WriteLine(h.Name);
            }
            System.Console.WriteLine("{0}-- {1} ----{2}", a, b, x.SignalTime);

        }
        // private static async void asd(Object source, System.Timers.ElapsedEventArgs e)
        // {
        //     Console.WriteLine("Ben geldim ula", e.SignalTime);

        // }
    }


}
