using System;

namespace graph.core
{
    public abstract class AGraph<E, T> where E : System.Enum where T : class
    {
        protected AdjacencyMatrix<E, T> _matrix = new AdjacencyMatrix<E, T>();

        public abstract void AddEdge(E origin, E target, T data);
        public abstract void RemoveEdge(E origin, E target);

        public bool HasEdge(E origin, E target)
        {
            return _matrix[origin, target] != null;
        }
    }
}