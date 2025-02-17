
using System.Linq.Expressions;

public class Calculator
{
    public int Add(string numbers)
    {
        char[] delimeterChars = { ' ', ',', '\n', '#', '/', '\\'}; 
        if (numbers == "")
        {
            return 0;
        }
        else if (numbers != string.Empty)
        {
            // do the exception handling for negative numbers

            string[] myNumbers;
            myNumbers = numbers.Split(delimeterChars);
            int result = 0;
            foreach (string number in myNumbers)
            {
                int myNumInt = Int32.Parse(number);
                result += myNumInt;
            }
            return result;
        }
        else
        {
            int myNumInt = 0;
            myNumInt = Int32.Parse(numbers);
            return myNumInt;
        }
    }
}
