using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialNeuralNetwork
{
    class Neuron
    {
        public Neuron (ActivationFunction AF, OutputFunction OF)
        {
            
        }
        //public double data = 0;
        
        public List<Synapse> ingoingSynapses;
        public List<Synapse> outgoingSynapses;

        public double TransferFunction (double[] Data, double[] weights)
        {
            return Outputfunktion(ActivationFunction());
        }

    }
}
