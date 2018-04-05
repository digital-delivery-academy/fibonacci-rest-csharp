using System;

namespace fibonacci_csharp
{
    public class Maths
    {
        private const double Phi = 1.6180339;
        private const double ReciprocalPhi = -0.6180339;
        
        public static long Fibonnaci(int index)
        {
            return (long) (Math.Round(Math.Pow(Phi, index) - Math.Pow(ReciprocalPhi, index)) / Math.Sqrt(5));
        }
    }
}