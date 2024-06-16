namespace FizzBuzzApi.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public (List<string> Results, List<string> Divisions) ProcessValues(int[] values)
        {
            var results = new List<string>();
            var divisions = new List<string>();

            foreach (var value in values)
            {
                string result;
                if (value % 3 == 0 && value % 5 == 0)
                {
                    result = "FizzBuzz";
                }
                else if (value % 3 == 0)
                {
                    result = "Fizz";
                }
                else if (value % 5 == 0)
                {
                    result = "Buzz";
                }
                else
                {
                    result = value.ToString();
                }

                results.Add(result);
                divisions.Add($"Value {value} is divisible by: {GetDivisors(value)}");
            }

            return (results, divisions);
        }

        private string GetDivisors(int value)
        {
            var divisors = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return string.Join(", ", divisors);
        }
    }
}
