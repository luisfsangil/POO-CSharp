//Here is an example of Anonymous classes.


//If two or more objects have the same number of fields, with the same name, in the same order and with the same data type, both object belongs the same class
var objectOne = new { Name = "Luis", Age = 27 };
var objectTwo = new { Name = "Marta", Age = 32 };
objectOne = objectTwo;

//There are a few rules with the anonymous classes:
    //All the fields are public
    //All the fields have to been initialiced
    //The fields can't be static
    //This clases don't have methods
