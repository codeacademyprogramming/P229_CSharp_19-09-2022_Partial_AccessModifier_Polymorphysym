using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Person
    {
        public string Name;
        public string SurName;

        public Person(string name)
        {
            Name = name;
        }

        public virtual string ShowInfo()
        {
            return $"Name: {Name}\nSurName: {SurName}";
        }

        public virtual string ShowInfo(int a)
        {
            return $"Name: {Name}\nSurName: {SurName}";
        }
    }
}
