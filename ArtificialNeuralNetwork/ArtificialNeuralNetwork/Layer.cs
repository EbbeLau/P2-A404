using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialNeuralNetwork
{
    class Layer
    {
        //includes data for neurons and ingoing synapses (weights)

        //Variables
        public double[] data;
        public double[,] weights;

        //Constructor
        public Layer(int size, int prevSize)
        {
            data = new double[size];
            weights = new double[prevSize, size];
        }
    }
}
