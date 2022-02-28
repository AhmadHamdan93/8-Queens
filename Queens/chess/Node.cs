using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    class Node
    {
        public int[] row = { -1, -1, -1, -1, -1, -1, -1, -1 };
        public void storeSol(int column, int row)
        {
            this.row[column] = row;
        }
    }
}
