using System;

using Examples;


//Some examples of code that need some methods of the classs 'CheckStrings'

double KgToLbs(string _kg)
{
    double kg = CheckStrings.convertToDouble(_kg);
    double lbs = 2.20462 * kg;
    return lbs;
}