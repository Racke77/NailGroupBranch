using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailsGroupAssignment
{
    public abstract class Digit
    {
        public Nail nail { get; set; }

        public Digit(float desiredLength, float startLength)
        {
            nail = new Nail(startLength, desiredLength);

        }
    }
}
