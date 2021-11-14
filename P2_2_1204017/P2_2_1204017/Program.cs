using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204017
{
 public   class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TITAN");
            Console.WriteLine("=========");

            Titans Titan = new Titans("Attack Titan ", "Mengamuk");
          

            Console.WriteLine("Nama  {0} Titan jenis {1} kemampuan \"{2}\"", Titan.Nama, Titan.Jenis, Titan.Kemampuan);
            Console.WriteLine();


        }
    }
}
