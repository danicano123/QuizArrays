namespace QuizArrays.Logic
{
    public class OneDimension
    {
        private int[] _array;
        private int _top = 0;

        public OneDimension(int n)
        {
            _array = new int[n];
        }

        private bool IsEmpty
        {
            get
            {
                if (_top == 0)
                {
                    return true;
                }
                return false;

            }
        }

        private bool IsFull
        {
            get
            {
                if (_top == N)
                {
                    return true;
                }
                return false;

            }
        }

        public int N
        {
            get => _array.Length;
        }

        public void Add(int n)
        {
            if (IsFull) { throw new Exception("Array is full!"); } else _array[_top] = n;

            _top++;
        }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                output += $"{_array[i]}\t";
            }
            return output;
        }


    }
}