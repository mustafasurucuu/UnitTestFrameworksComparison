namespace TestReference.Fundamentals
{
    public class Divisibility
    {
        public static string GetOutput(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "3and5";

            if (number % 3 == 0)
                return "only3";

            if (number % 5 == 0)
                return "only5";

            return number.ToString(); 
        }
    }
}