using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailsGroupAssignment
{
    public class Toe : Digit
    {
        public TypeOfToe TypeOfToe { get; set; }
        public Toe(TypeOfToe typeOfToe, float desiredLength, float startLength) : base(desiredLength, startLength)
        {
            TypeOfToe = typeOfToe;
        }
    }
}
