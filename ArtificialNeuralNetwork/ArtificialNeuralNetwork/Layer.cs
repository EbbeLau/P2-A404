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
        public Layer nextLayer;

        //Constructor
        public Layer(int size, Layer _nextLayer)
        {
            neurons = new Neuron[size];
            nextLayer = _nextLayer;
            //SYNAPSES ARE FULLY CONNECTED! CHANGE LATER!
            foreach (Neuron fro in neurons)
            {
                foreach (Neuron nex in nextLayer.neurons)
                {
                    fro.synapses.Add(new Synapse(fro, nex));
                }
            }
        }
    }
}
