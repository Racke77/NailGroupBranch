using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailsGroupAssignment
{
    public class Simulator
    {
        public float DesiredLength { get; set; } = 2.0f;
        public List<Finger> Fingers { get; set; }
        public List<Toe> Toes { get; set; }
        NailClipper NailClipper { get; set; }

        public Simulator()
        {

            NailClipper = new NailClipper(2);
            Fingers = new List<Finger>();
            Toes = new List<Toe>();

            PopulateData();

        }

        public void Run(int numberOfDays)
        {

            List<Digit> digits = new List<Digit>();
            digits.AddRange(Fingers);
            digits.AddRange(Toes);

            for (int i = 0; i < numberOfDays; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Day number {i}:");


                foreach (Digit digit in digits)
                {
                    digit.nail.Grow();
                }

                bool shouldClip = CheckIfShouldClip(Fingers, Toes, DesiredLength);

                foreach (Digit digit in digits)
                {
                    if (shouldClip)
                    {
                        NailClipper.Clip(digit.nail, DesiredLength);
                    }

                    string nailLength = digit.nail.Length.ToString("F1", CultureInfo.InvariantCulture);

                    if (digit is Finger)
                    {
                        Finger finger = (Finger)digit;
                        Console.WriteLine($"Finger {finger.TypeOfFinger} has reached " + nailLength + "mm");
                    }
                    else
                    {
                        Toe toe = (Toe)digit;
                        Console.WriteLine($"Toe {toe.TypeOfToe} has reached " + nailLength + "mm");
                    }


                }
            }

        }

        public void PopulateData()
        {

            foreach (TypeOfFinger fingerType in Enum.GetValues(typeof(TypeOfFinger)))
            {
                Fingers.Add(new Finger(fingerType, 2.0f, 3.5f));
                Fingers.Add(new Finger(fingerType, 2.0f, 3.5f));
            }

            foreach (TypeOfToe toeType in Enum.GetValues(typeof(TypeOfToe)))
            {
                Toes.Add(new Toe(toeType, 2.0f, 3.5f));
                Toes.Add(new Toe(toeType, 2.0f, 3.5f));
            }

        }

        public bool CheckIfShouldClip(List<Finger> fingers, List<Toe> toes, float DesiredLength)
        {

            float averageLength = 0;
            float allAddedLength = 0;

            foreach (Finger finger in fingers)
            {
                allAddedLength += finger.nail.Length;
            }

            foreach (Toe toe in toes)
            {
                allAddedLength += toe.nail.Length;
            }

            averageLength = allAddedLength / (fingers.Count + toes.Count);
            Console.WriteLine(averageLength);
            Console.WriteLine(fingers.Count + toes.Count);


            if (averageLength <= DesiredLength + 2)
            {
                return false;
            }
            return true;
        }
    }
}
