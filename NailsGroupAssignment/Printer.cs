using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NailsGroupAssignment
{
    public class Printer
    {
        public Printer() { }
        public void PrintDay(int day)
        {
            Console.WriteLine();
            Console.WriteLine($"Day number {day}:");
        }
        public void PrintNailLength(List<Toe> toes, List<Finger> fingers)
        {
            foreach (Finger finger in fingers)
            {
                Console.WriteLine($"Finger {finger.TypeOfFinger} has reached " + finger.Nail.Length.ToString("F1") + "mm");
            }
            foreach (Toe toe in toes)
            {
                Console.WriteLine($"Toe {toe.TypeOfToe} has reached " + toe.Nail.Length.ToString("F1") + "mm");
            }
        }
    }
}
