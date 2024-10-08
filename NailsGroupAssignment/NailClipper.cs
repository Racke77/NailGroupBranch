﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailsGroupAssignment
{
    public class NailClipper
    {
        Random Random = new Random();
        public int PrecisionInMicrometer { get; set; }
        public NailClipper(int precision)
        {
            PrecisionInMicrometer = precision;
        }

        public void Clip(Nail nail, float desiredLength) //it edits the object directly -> no return necessary
        {
            int desiredLengthConverted = (int)desiredLength;
            desiredLengthConverted *= 10; //turning MM into Micrometer

            //randomize cut-precision
            float lengthToCut = (float)Random.Next(desiredLengthConverted - PrecisionInMicrometer, desiredLengthConverted + PrecisionInMicrometer);

            lengthToCut /= 10f; //turning Micrometer into MM
            nail.Length -= lengthToCut; //remove from object.Length
        }
    }
}
