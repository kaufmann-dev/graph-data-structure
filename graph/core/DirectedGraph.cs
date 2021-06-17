namespace graph.core
{
    public abstract class DirectedGraph<E, T> : AGraph<E, T> where E : System.Enum where T : class
    {
        public override void AddEdge(E origin, E target, T data)
        {
            _matrix[origin, target] = data;
        }
        
        public override void RemoveEdge(E origin, E target)
        {
            _matrix[origin, target] = null;
        }
    }
}