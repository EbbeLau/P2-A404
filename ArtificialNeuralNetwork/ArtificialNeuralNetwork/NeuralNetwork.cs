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
        private int inputSize;
        public Layer[] layers;
        private ActivationFunction AF;

        //Constructor
        public NeuralNetwork(int[] size, ActivationFunction _AF)
        {
            AF = _AF;
            layers = new Layer[size.Length-1];
            inputSize = size[0];
            for (int i = layers.Length-1; i > 0; i--)
            {
                layers[i] = new Layer(size[i], size[i-1]);
            }
        }

        //Methods
        public void cycle(double[] input)
        {
            if (input.Length != inputSize)
            {
                throw new Exception($"Wrong input array size, expected {inputSize}, but got {input.Length}.");
            }
            else
            {
                
                /*for (int i = 0; i < layers.Length; i++)
                {
                    Forward();
                }*/
                //everything else here
                //tree
                //cost
                //learn
            }
        }

        private void Forward(Layer lay)
        {
        }
    }
}
