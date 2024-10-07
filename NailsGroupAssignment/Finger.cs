using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailsGroupAssignment
{
    public class Finger : Digit
    {
        public TypeOfFinger TypeOfFinger { get; set; }
        public Finger(TypeOfFinger typeOfFinger, float desiredLength, float startLength) : base(desiredLength, startLength)
        {
            TypeOfFinger = typeOfFinger;
        }
    }
}
