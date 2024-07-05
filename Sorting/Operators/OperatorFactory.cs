
using Sorting.Strategies;
using Sorting.Strategies.Sorting;

namespace Sorting.Operators
{
    public class OperatorFactory
    {
        public static IOperator Create(string sortStrategy) => sortStrategy switch
        {
            "ascending" => new Ascending(),
            "descending" => new Descending(),
            "identity" => new Identity(),
            _ => throw new ArgumentException($"Sort strategy {sortStrategy} is not supported."),
        };
    }
}
