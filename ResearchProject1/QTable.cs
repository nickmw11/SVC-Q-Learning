using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLearning1
{
    class QTable
    {
        public double[] quality = new double[3];
        public int[] freq = new int[3];
    }
}
