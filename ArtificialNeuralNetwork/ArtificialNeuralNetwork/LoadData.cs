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
            List<string> ListOfChampions = new List<string>();
            List<string> NumberOfBans = new List<string>();
            List<string> Games  = new List<string>();
            List<string> Wins= new List<string>();
            List<string> Losses = new List<string>();
            List<string> Winrate = new List<string>();

            using (var directory = File.OpenRead(@"C:\Users\Rasmus\Desktop\Uni\P2\Git\P2-A404\Data\Champion_Data\EU 2016 Spring Champion Statistics.csv"))
            using (var reader = new StreamReader(directory))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    ListOfChampions.Add(values[0]);
                    NumberOfBans.Add(values[1]);
                    Games.Add(values[2]);
                    Wins.Add(values[3]);
                    Losses.Add(values[4]);

                }
            }
            foreach (var item in ListOfChampions)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}