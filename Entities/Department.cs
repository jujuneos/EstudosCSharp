using System;

namespace Exercício_composição.Entities
{
    class Department
    {
        public string Name {get; set; }
        public Department()
        {
        }
        public Department(string name){
            Name = name;
        }
    }
}