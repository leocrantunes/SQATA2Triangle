namespace SQATA2Triangle
{
    public static class TriangleSolver
    {
        public const string NOT_TRIANGLE = "Not a triangle";
        public const string ISOSCELES = "Isosceles";
        public const string SCALENE = "Scalene";
        public const string EQUILATERAL = "Equilateral";

        public static string Analyze(int firstValue, int secondValue, int thirdValue)
        {
            string result;

            if (IsValid(firstValue, secondValue, thirdValue))
            {
                if (firstValue == secondValue && secondValue == thirdValue)
                {
                    result = EQUILATERAL;
                }
                else if (firstValue != secondValue && secondValue != thirdValue)
                {
                    result = SCALENE;
                }
                else
                {
                    result = ISOSCELES;
                }
            }
            else
            {
                result = NOT_TRIANGLE;
            }

            return result;
        }

        private static bool IsValid(int firstValue, int secondValue, int thirdValue)
        {
            return ((long)firstValue + (long)secondValue > (long)thirdValue) &&
                   ((long)secondValue + (long)thirdValue > (long)firstValue) &&
                   ((long)firstValue + (long)thirdValue > (long)secondValue);
        }
    }
}