using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailsGroupAssignment
{
    public class NailClipper
    {
        Random random = new Random();
        public int PrecisionInMicrometer { get; set; }
        public NailClipper(int precision)
        {
            PrecisionInMicrometer = precision;
        }

        public double Clip(Nail nail, float DesiredLength)
        {
            int desiredLengthConverted = (int)DesiredLength;

            nail.Length = random.Next(desiredLengthConverted - PrecisionInMicrometer, desiredLengthConverted + PrecisionInMicrometer);
            nail.Length /= 10.0f;

            return nail.Length;
        }
    }
}
