using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialNeuralNetwork
{
    class Layer
    {
        //Variables
        public Neuron[] neurons;

        //Constructor
        public Layer(int size, Layer nextLayer)
        {
            neurons = new Neuron[size];
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i] = new Neuron();
            }
            //SYNAPSES ARE FULLY CONNECTED! CHANGE LATER!
            if (nextLayer != null)
            {
                foreach (Neuron from in neurons)
                {
                    foreach (Neuron next in nextLayer.neurons)
                    {
                        from.outgoingSynapses.Add(new Synapse(from, next, 1));
                        next.ingoingSynapses.Add(new Synapse(from, next, 1));
                    }
                }
            }
        }
    }
}
