using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialNeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadData Loading = new LoadData();
            Loading.LoadFromPath();
            Console.ReadKey();

            // Comment to Alexander
        }
    }
}
