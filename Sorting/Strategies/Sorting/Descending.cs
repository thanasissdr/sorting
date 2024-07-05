using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Strategies.Sorting
{
    public class Descending : Sorting
    {

        public override float[] Run(float[] data)
        {
            var dataSorted = base.Run(data);
            Array.Reverse(dataSorted);
            return dataSorted;
        }
    }
}
