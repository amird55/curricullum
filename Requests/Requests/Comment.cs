using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests
{
    public class Comment
    {
        private int[,] scedual;
        public Comment()
        {
            scedual = new int[6, 6];
            for (int i = 0; i < scedual.GetLength(0); i++)
            {
                for (int j = 0; j < scedual.GetLength(1); j++)
                {
                    scedual[i, j] = 1;
                }
            }
        }
        public void cantCome(int day, int hour)
        {
            scedual[day, hour + 1] = 2;
        }
        public void preferToCome(int day, int hour)
        {
            scedual[day, hour + 1] = 0;
        }
        public int[,] getScedual()
        {
            return scedual;
        }
        public void printScedual()
        {
            for (int i = 0; i < scedual.GetLength(0); i++)
            {
                Console.Write("[");

                for (int j = 0; j < scedual.GetLength(1); j++)
                {
                    Console.Write(scedual[i, j] + ", ");
                }
                Console.WriteLine("]");

            }
        }
    }
}
