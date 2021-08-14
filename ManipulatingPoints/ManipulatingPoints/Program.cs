// See https://aka.ms/new-console-template for more information

//The code start's here

using ManipulatingPoints;

try { Point origin = new Point(); } //The origin of coordenades
catch (Exception ex) { Console.WriteLine(ex.Message); }

try{Point otherPoint = new Point(20, 180);}
catch (Exception ex){ Console.WriteLine(ex.Message);}

try{Point onePoint = new Point(50);}
catch (Exception ex){Console.WriteLine(ex.Message);}

