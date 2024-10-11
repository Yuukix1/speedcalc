using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed;

            
            do
            {
              Console.Write("Kérlek, add meg a futó kezdő sebességét (3.00 - 5.00 m/s): ");
              speed = double.Parse(Console.ReadLine());
            } while (speed < 3.00 || speed > 5.00);

            Console.WriteLine("Sebesség tíz méterenként:");

            
            for (int i = 0; i <= 100; i += 10)
            {
                double currentSpeed;

                if (i < 90)
                {
                    currentSpeed = speed + (2 * (i / 90.0));
                }
                else
                {
                    
                    currentSpeed = speed + 2 - (2 * ((i - 90) / 10.0)); 
                }

                
                double speedInKmh = currentSpeed * 3.6;
                Console.WriteLine($"{i} méternél: {speedInKmh:F2} km/h");
            }
        }
    }
}
