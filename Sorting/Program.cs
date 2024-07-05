using Sorting.Utils;
using Sorting.Operators;

namespace Sorting
{
    public class Program
    {

        public static void Main()
        {
            float[] data = [10, 30, 0, 50, 20, 40];
            string strategy = "descending";
            IOperator _operator;

            try
            {
                _operator = OperatorFactory.Create(strategy);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            var dataProcessed = _operator.Run(data);
            PrintArray.Run(dataProcessed);
        }
    }
}
