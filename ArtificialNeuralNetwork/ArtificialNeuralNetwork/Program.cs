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
            for (int i = layers.Length; i > 0; i--)
            {
                Layer nextLayer;
                if (i == layers.Length)
                {
                    nextLayer = null;
                }
                else
                {
                    nextLayer = layers[i + 1];
                }
                layers[i] = new Layer(size[i], nextLayer);
            }
        }
    }

    class Layer
    {
        //Variables
        public Neuron[] neurons;
        public Layer nextLayer;

        //Constructor
        public Layer (int size, Layer _nextLayer)
        {
            neurons = new Neuron[size];
            nextLayer = _nextLayer;
            //make better
        }
    }

    class Neuron
    {
        public double data;
        public List<Synapse> synapses;
    }

    class Synapse
    {
        //Variables
        public double weight;
        public Neuron fromNeuron;
        public Neuron toNeuron;
        
        //Constructor
        public Synapse(Neuron _fromNeuron, Neuron _toNeuron)
        {
            fromNeuron = _fromNeuron;
            toNeuron = _toNeuron;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
