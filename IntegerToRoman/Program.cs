using System;
class Program
{
    /* 
    <summary> 
    Entry of the application
    </summary>
    */
    public static void Main(string[] args)
    {

        string userChoice = "Y";
        do
        {
            Console.WriteLine("********* Convert Integer To Roman Numeral **********");
            Console.WriteLine("Enter a number between 1 and 3999(both included)");


            try
            {
                int userInputNumber = Convert.ToInt32(Console.ReadLine());
                string romanResult = IntegerConversion.ConvertIntToRoman(userInputNumber);
                Console.WriteLine($"Roman equivalent for number is {romanResult}");
                Console.WriteLine("Do you want to continue: Y or N");
                userChoice = Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } while (userChoice.ToUpper() == "Y");

    }
}

public class IntegerConversion
{

    /* 
    <summary> 
    Convert Integer to Roman Equivalent and 
    </summary>
    <param name="inputNumber">The input given by the userr</param>
    <returns>Roman Equivalent of given integer</returns>
    */
    public static string ConvertIntToRoman(int inputNumber)
    {
        //Out of range checking
        if (inputNumber < 1 || inputNumber > 3999)
        {
            throw new Exception("Number needs to be between 1 and 3999");
        }

        string romanEquivalent = string.Empty; //initialising result as empty

        //Dictionary initialization as <string, int> to get key value pair
        Dictionary<string, int> romanLetterDictionary = new Dictionary<string, int>
        {
            {"M", 1000},
            {"CM", 900},
            {"D", 500},
            {"CD", 400},
            {"C", 100},
            {"XC", 90},
            {"L", 50},
            {"XL", 40},
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
        };


        //Ierating through each item in dictionary 
        foreach (var item in romanLetterDictionary)
        {
            //Checking input number greater or equal to current roman letter value
            while (inputNumber >= item.Value)
            {
                romanEquivalent += item.Key; // Appending each roman letter based ont he value
                inputNumber -= item.Value;  // Subtracting roman letter equivalent value to get the new input number               
            }
        }

        return romanEquivalent;
    }
}