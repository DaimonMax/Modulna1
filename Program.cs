using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main()
        {
            string forLogPath = "logPD21.txt";

            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger(forLogPath, publisher);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Your text");
                string input = Console.ReadLine();

                publisher.Send(input);
            }
        }
    }
}
