using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExample
{
    class Person{
        //Encapsulated atributes
        private string name;
        private sbyte age;
        //Public Constructors
        public Person(){
            name = "";
            age = 0;
        }
        public Person(string _name){
            name = _name;
            age = 0;
        }
        public Person(string _name, sbyte _age){
            name = _name;
            if (_age >= 0 && _age < 127) age = _age;
            else throw new ArgumentOutOfRangeException(); //The age of a person must be >=0 and <127
        }
        //Public Methods Guetters and Setters
        //Guetters
        public string GetName() => name;
        public sbyte GetAge() => age;
        //Setters
        public void setName(string _name){
            name = _name;
        }
        public void SetAge(sbyte _age){
            if (_age >= 0 && _age<127) age = _age;
            else throw new ArgumentOutOfRangeException(); //The age of a person must be >=0 and <127
        }
    }
}
