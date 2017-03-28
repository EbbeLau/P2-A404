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
            String[] values = File.ReadAllText(@"C:\Users\Rasmus\Desktop\Uni\P2\Git\P2-A404\Data\CSV Files Champion Data\EU 2016 Spring Champion Statistics.csv").Split(',');

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
/*
 using (var fs = File.OpenRead(@"C:\Users\Rasmus\Desktop\Uni\P2\Git\P2-A404\Data\CSV Files Champion Data\EU 2016 Spring Champion Statistics.csv"))
            using (var reader = new StreamReader(fs))
            {
                List<string> listA = new List<string>();
List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
var values = line.Split(';');

listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }

*/