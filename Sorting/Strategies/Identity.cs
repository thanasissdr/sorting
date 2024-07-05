using Sorting.Operators;

namespace Sorting.Strategies
{
    internal class Identity : IOperator
    {
        public float[] Run(float[] data) => data;
    }
}
