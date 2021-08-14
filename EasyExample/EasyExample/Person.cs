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
        private byte age;
        //Public Constructors
        public Person(){
            name = "";
            age = 0;
        }
        public Person(string _name){
            name = _name;
            age = 0;
        }
        public Person(string _name, byte _age){
            name = _name;
            if (_age>=0)    age = _age;
            else throw new Exception(); //The age of a person must be >=0
        }
        //Public Methods Guetters and Setters
        //Guetters
        public string GetName() => name;
        public byte GetAge() => age;
        //Setters
        public void setName(string _name){
            name = _name;
        }
        public void SetAge(byte _age){
            if (_age >= 0) age = _age;
            else throw new Exception(); //The age of a person must be >=0
        }
    }
}
