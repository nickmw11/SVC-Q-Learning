using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QLearning1.Program;

namespace QLearning1
{
    class Program
    {

        static void Main(string[] args)
        {
            double alpha = 1.0f;
            double discountFactor = 1.0f;
            double randomFactor = 1.0f;
            double reward = -0.04f;

            // States: Seen, taking damage, dealing damage, critical health (0-3)
            // Actions: Explore, attack, flee (0-2)

            QTable[] q = new QTable[16];
            Random rand = new Random();

            for (int i = 0; i < q.Length; i++)
            {
                q[i] = new QTable();
                for (int j = 0; j < q[i].freq.Length; j++)
                {
                    q[i].freq[j] = rand.Next(1, 100);
                    q[i].quality[j] = rand.Next(0, 100);
                    Console.WriteLine(q[i].freq[j] + " " + q[i].quality[j]);
                }

                Console.WriteLine();
                //q[i].frequencyQualityPairs = new Dictionary<int, double>(rand.Next(1, 1000), 5.0f);

            }

            //foreach(QTable table in q)
            //{
            //    Console.WriteLine(table.freqA + " " + table.freqC + " " + table.freqE + " " + table.freqW + " " + table.quality);
            //    Console.WriteLine();
            //}



        }
    }
}
