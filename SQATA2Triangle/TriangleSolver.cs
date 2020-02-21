namespace SQATA2Triangle
{
    public static class TriangleSolver
    {
        public const string NOT_TRIANGLE = "Not a triangle";
        public const string ISOSCELES = "Isosceles"; // scalene, isosceles, or equilateral
        public const string SCALENE = "Scalene";
        public const string EQUILATERAL = "Equilateral";

        public static string Analyze(int firstValue, int secondValue, int thirdValue)
        {
            if (IsValid(firstValue, secondValue, thirdValue))
            {
                if (firstValue == secondValue && secondValue == thirdValue)
                {
                    return EQUILATERAL;
                }
                else if (firstValue != secondValue && secondValue != thirdValue)
                {
                    return SCALENE;
                }
                else
                {
                    return ISOSCELES;
                }
            }
            else
            {
                return NOT_TRIANGLE;
            }
        }

        private static bool IsValid(int firstValue, int secondValue, int thirdValue)
        {
            return ((long)firstValue + (long)secondValue > (long)thirdValue) &&
                   ((long)secondValue + (long)thirdValue > (long)firstValue) &&
                   ((long)firstValue + (long)thirdValue > (long)secondValue);
        }
    }
}
