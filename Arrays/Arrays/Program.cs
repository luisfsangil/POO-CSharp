//// See https://aka.ms/new-console-template for more information


bool[] logicArray = new bool[3];
for (int i = 0; i < logicArray.Length; i++) Console.WriteLine(logicArray[i]);
//by default, the tipe bool iniciate as false

short[] numbers = new short[3];
foreach (char i in numbers) Console.WriteLine(numbers[i]);
//by default, the type short iniciate as 0

char[] characteres = new char[3];
foreach (char i in characteres) Console.WriteLine(characteres[i]);
//by default, the type char iniciate as ' ' (space character)

decimal[] decimals = new decimal[3];
foreach (int i in decimals) Console.WriteLine(decimals[i]);
//by default, the type char iniciate as 0

//  Its a good practique alway iniciate the values of everithing. This code is better
//  ¿Why? because nothing, just in case this code is better
int[] integers = new int[3];
foreach (byte i in integers) integers[i] = 0;
foreach (byte i in integers) Console.WriteLine(integers[i]);

//You can declarated and iniciated an Array with this:
string[] names = { "Luis", "Maria", "Juan", "Bea" };

//Anonymous classes Arrays
var AnonymoysClassesArray = new[]
{
    new {Name="Luis",Age=27,Weight=1.85},
    new {Name="Marta",Age=40,Weight=1.62},
    new {Name="Ángel",Age =30,Weight=1.55}
};

//Implicits Arrays
var myImplicitArray = new[] { 17.5, 88.2, 36.56 };

//It's possible in C# to created a Array whith many dimensions
int[][][][][][][][][][] Array10D = new int[1][][][][][][][][][];




