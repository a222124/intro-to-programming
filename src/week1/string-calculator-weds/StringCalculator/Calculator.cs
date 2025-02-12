
public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        else if (numbers.Contains(','))
        {
            string[] myNumbers;
            myNumbers = numbers.Split(',');
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
