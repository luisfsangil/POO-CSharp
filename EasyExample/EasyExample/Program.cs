// See https://aka.ms/new-console-template for more information

//The machine start's the compilation and interpretation here

//Using the namespace 'EasyExample'
using EasyExample;

//Object 'luis' of class 'Person' instantiate and initialited
Person luis = new Person();

//Setting the name of the object 'luis' of class 'Person'
luis.setName("Luis");

try{
    luis.SetAge(-5);
}
catch (Exception ex){
    Console.WriteLine("Is not possible to set the luis age '-5'");
    Console.WriteLine("Please, read the message error : "+ex.Message);
}

