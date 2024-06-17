using System;
using System.Collections;

namespace FizzBuzzApi.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        static bool  CheckIfNumberOrString(string value)
        {
            // Try parsing the value as different types of numbers
            if (int.TryParse(value, out _) ||
                float.TryParse(value, out _) ||
                double.TryParse(value, out _) ||
                decimal.TryParse(value, out _))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public (List<string> Results, List<string> Divisions) ProcessValues(string[] values)
        {
            var results = new List<string>();
            var divisions = new List<string>();

            //string[] splitted = values.Split('')

            //Int32 [] stringArray = values.Select (i => i.ToString()).ToArray();
             
            
            foreach (var value in values)
            {

                string result;

                if (CheckIfNumberOrString(value) || value=="")
                {
                    
                    result = "Invalid Item";
                    results.Add(result);
                    continue;
                }                
                else if (int.Parse(value) % 3 == 0 && int.Parse(value) % 5 == 0)
                {
                    result = "FizzBuzz";
                }
                else if (int.Parse(value) % 3 == 0)
                {
                    result = "Fizz";
                }
                else if (int.Parse(value) % 5 == 0)
                {
                    result = "Buzz";
                }
                else
                {
                    result = "Divided" +" " + value.ToString() + " by 3" + " & " + "Divided" + " " + value.ToString() + " by 5 ";
                                        
                    //Divided 1 by 3
                }

                results.Add(result);
                divisions.Add($"Value {value} is divisible by: {GetDivisors (int.Parse(value))}");
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
