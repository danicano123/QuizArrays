using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        int[,] _array;
        public TwoDimensions(int m, int n)
        {
            _array = new int[m, n];
        }

        public int M
        {
            get => _array.GetLength(0);
        }
        public int N
        {
            get => _array.GetLength(1);
        }

        public void Fill()
        {
            var random = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _array[i, j] = random.Next(1, 100);
                }
            }
        }

        public string ToOneDimension()
        {

            int sizeNewArray = N * M;
            var one = new OneDimension(sizeNewArray);
            int counter = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    one.Add(_array[i, j]);
                    counter++;
                }
            }
            return one.ToString();
        }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }

    }
}
