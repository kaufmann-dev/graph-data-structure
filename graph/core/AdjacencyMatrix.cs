using System;

namespace graph.core
{
    public class AdjacencyMatrix<E,T> where E : System.Enum where T : class
    {
        private T[,] _matrix = new T[Enum.GetValues(typeof(E)).Length, Enum.GetValues(typeof(T)).Length];

        public AdjacencyMatrix()
        {
            Init();
        }

        public T this[E e1, E e2]
        {
            get
            {
                return _matrix[Array.IndexOf(Enum.GetValues(typeof(E)), e1),
                    Array.IndexOf(Enum.GetValues(typeof(E)), e2)];
                
            }
            set
            {
                _matrix[Array.IndexOf(Enum.GetValues(typeof(E)), e1),
                    Array.IndexOf(Enum.GetValues(typeof(E)), e2)] = value;
            }
        }

        private void Init()
        {
            for (int x = 0; x < _matrix.GetLength(0); x++)
            {
                for (int y = 0; y < _matrix.GetLength(1); y++)
                {
                    _matrix[x, y] = null;
                }
            }
        }
    }
}