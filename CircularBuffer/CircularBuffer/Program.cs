using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace CircularBufferTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var certificate = Convert.ToBase64String(File.ReadAllBytes(@"C:\Users\rprata\testCert3.pfx"));

            CircularBuffer<Double> cbuff = new CircularBuffer<Double>(capacity: 10);
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    cbuff.Write((double)value);
                    continue;

                }
                break;

            }
            while (!cbuff.IsEmpty())
            {
                Console.WriteLine(cbuff.Read());
            }
            Console.ReadLine();



        }
    }
}
