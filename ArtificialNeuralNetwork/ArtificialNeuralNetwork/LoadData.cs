using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArtificialNeuralNetwork
{
    public class LoadData
    {
        public void LoadFromPath()
        {
            int[,] ChampionArray = new int[71, 19];


            using (var directory = File.OpenRead(@"C:\Users\Rasmus\Desktop\Uni\P2\Git\P2-A404\Data\Champion_Data\EU 2016 Spring Champion Statistics.csv"))
            using (var reader = new StreamReader(directory))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                 

                }
            }            
        }
    }
}