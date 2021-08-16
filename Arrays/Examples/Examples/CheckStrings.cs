using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public static class CheckStrings
    {
        //The method 'IsText' checks if a string is only text.
        public static bool IsText(string _p)
        {
            char[] chars = _p.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
                if (!Char.IsLetter(chars[i]))
                    return false;   //If one or more chars of the strings are not letters, the methods returns false
            return true;            //In the other case, the method returns true
        }
        //The method 'IsInteger' cheks if a string is a enter number
        public static bool IsInteger(string _p)
        {
            char[] chars = _p.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
                if (!Char.IsDigit(chars[i]))    //If one or more chars of the strings are not decimal characters, the method returns false
                    return false;               //In the other case, the method returns true
            return true;
        }
        //The method 'IsDouble' checks if a string is a real number
        public static bool IsDouble(string _p)
        {

            byte numberOfPoints = 0;                                //A real number can have only one character ','
            char[] chars = _p.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i].Equals(',') || chars[i].Equals('.'))
                {  //If one character is ',' or '.'
                    numberOfPoints++;                               //numberofPoints++;
                }
                else if (!Char.IsDigit(chars[i])) return false;     //If one or more chars of the string are not decimal characters, the method returns false
                if (numberOfPoints > 1) return false;               //If two or more chars of the string are ',' the method returns false
            }
            return true;                                            //In the other cases, the method returns true
        }
        //The method 'repairDouble' permits to represents a real number with the two decimal characters '.' and ',' 
        public static double convertToDouble(string _p)
        {
            string resul = "";
            char[] chars = _p.ToCharArray();
            if (IsDouble(_p))   //The method only works if the string IsDouble
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i].Equals('.')) chars[i] = ',';
                }
            }
            else
            {
                Console.WriteLine($"The string {_p} can't be convert to double, the program crashed" );
                throw new Exception();
            }
            resul = new string(chars);
            return double.Parse(resul);
        }

        //This method can be used to asegure that the user introduces
        //a integer in the console
        public static int ToInt(string p)
        {
            bool endLoop = false;
            while (!endLoop)
            {
                Console.Clear();
                if (CheckStrings.IsInteger(p)) endLoop = true;
                else Console.WriteLine("Please, say a integer number");
            }
            return int.Parse(p);
        }
    }
}