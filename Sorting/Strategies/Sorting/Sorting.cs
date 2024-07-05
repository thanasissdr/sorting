using Sorting.Operators;


namespace Sorting.Strategies.Sorting
{
    public class Sorting : IOperator
    {

        public virtual float[] Run(float[] data)
        {

            float[] clonedData = (float[])data.Clone();
            Array.Sort(clonedData);
            return clonedData;
        }
    }
}
