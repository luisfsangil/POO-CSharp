//// See https://aka.ms/new-console-template for more information

//int[] ages;
//ages = new int[4];
//ages[0] = 10;
//ages[1] = 15;
//ages[2] = 23;
//ages[3] = 91;

//string[] names = { "Luis", "Maria", "Juan", "Bea" };

////Implicits Arrays
//var myImplicitArray = new[] { 17.5, 88.2, 36.56 };

////Objects Arrays
//Person[] people = new Person[5];
//people[0] = new Person("Luis", 27);
//people[1] = new Person("Alejandro", 25);
//people[2] = new Person("Maria", 18);
//people[3] = new Person("Beatriz", 22);
//people[4] = new Person("Angeles", 55);

////Anonymous classes Arrays
//var AnonymoysClassesArray = new[]
//{
//    new {Name="Luis",Age=27,Weight=1.85},
//    new {Name="Marta",Age=40,Weight=1.62},
//    new {Name="Ángel",Age =30,Weight=1.55}
//};

////Theese two lines are exactly the same
//for (int i = 0; i < ages.Length; i++) Console.WriteLine(ages[i]);
//foreach(int v in ages)  Console.WriteLine(v);
////---------------------------------------------------------------------------------------
////A Commonly example: check that a string is a real number
//bool endLoop = false;
//string resp;
//do
//{
//    Console.WriteLine("Say a real number please");
//    resp = Console.ReadLine();
//    if (IsNumber(resp)) endLoop = true;
//} while (!endLoop);
//float number = float.Parse(resp);
//number++;
//Console.WriteLine(number);

//bool IsNumber(string p)
//{
//    char[] characters = p.ToCharArray();
//    sbyte numberOfPoints = 0;
//    for (int i=0; i<characters.Length; i++)
//    {
//        if (characters[i].Equals(".")) characters[i] = ',';
//    }
//    for (int i = 0; i < characters.Length; i++)
//    {
//        if (char.IsPunctuation(characters[i])) numberOfPoints++;
//        else if (!char.IsDigit(characters[i])) return false;         
//        if (numberOfPoints > 1) return false;
//    } 
//    return true;
//}
////---------------------------------------------------------------------------------------
//class Person
//{
//    private string name;
//    private sbyte age;
//    public Person(string _name, sbyte _age)
//    {
//        name = _name;
//        age = _age;
//    }
//}

























// Arrays.

/*
    First, the definition and use of an Array.

    An array is a object, like all in C#. This class 'Array' belongs to the System namespace    ->  System.Array
    If you make some searches on the internet (preferably on the  API of .NET) you can see that:
            Is a public and a abstract class.
            Is the daughter of the class Object.
            Implements the interfaces :
                ICollection
                IEnumerable
                IList
                IStructuralComparable
                IStructuraIEquatable
                ICloneable
    
    You can read all about the class Array on the .NET API, but here i write the most common examples and codes,
    i hope you enjoy ;)
 */

