using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialNeuralNetwork
{
    class NeuralNetwork
    {
        //Variables
        public Layer[] layers;
        
        //Constructor
        public NeuralNetwork (int[] size)
        {
            layers = new Layer[size.Length];
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i] = new Layer(size[i]);
            }
        }
    }

    class Layer
    {
        //Variables
        public Neuron[] neurons;

        //Constructor
        public Layer (int size)
        {
            neurons = new Neuron[size];
        }
    }

    class Neuron
    {

    }

    class Synapse
    {

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
