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
            Functions allFunc = new Functions();

            NeuralNetwork NN = new NeuralNetwork(new int[4] { 2, 3, 3, 2 }, Functions);
        }
    }

    class Functions
    {
        public static void AF1()
        {
            
        }
        public static void AF2()
        {
            
        }
        public static void OF1()
        {
            
        }
        public static void OF2()
        {
            
        }
    }

    public delegate double ActivationFunction(double[] Data, double[] weights);
    public delegate double OutputFunction(double Zum);
}
