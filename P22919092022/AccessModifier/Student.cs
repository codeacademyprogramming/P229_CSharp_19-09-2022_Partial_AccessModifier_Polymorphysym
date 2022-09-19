using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Student : Human
    {
        private string _name;
        //Encapsulation With Property
        //Property
        public string Name 
        {
            //Accessor
            set
            {
                if (value.Length >= 3)
                {
                    foreach (char item in value)
                    {
                        if (!char.IsLetter(item))
                        {
                            Console.WriteLine("Duzgun Ad Daxil et");
                            return;
                        }
                    }

                    _name = value;
                    return;
                }

                Console.WriteLine("Name Minimum 3 simvol Olmalidir");
            }

            get => _name;
            //{
            //    return _name;
            //}
        }
        public string SurName { get; set; }

        #region Old Encupsulation
        //public void SetName(string name)
        //{
        //    if (name.Length >= 3)
        //    {
        //        foreach (char item in name)
        //        {
        //            if (!char.IsLetter(item))
        //            {
        //                Console.WriteLine("Duzgun Ad Daxil et");
        //                return;
        //            }
        //        }

        //        Name = name;
        //        return;
        //    }

        //    Console.WriteLine("Name Minimum 3 simvol Olmalidir");
        //}

        //public string GetName()
        //{
        //    //if (Name.Length < 3)
        //    //{
        //    //    Console.WriteLine("Name Memberine Deyer Set Olunmuyub");
        //    //    return "";
        //    //}

        //    return Name;
        //}
        #endregion

        //string SurName;
        private byte _age;

        public readonly byte Age1;

        public Student(string test) : base(test)
        {
            Age1 = 15;
        }

        #region Old encapsulation
        //public void SetAge(byte age)
        //{
        //    if (age < 18 || age > 40)
        //    {
        //        Console.WriteLine("Yas Minimum 18 Maximum 40 Ola Biler");
        //        return;
        //    }

        //    Age = age;
        //}

        //public byte GetAge() => Age;
        #endregion

        //public void Test()
        //{
        //    Name = "Hamid";

        //    Console.WriteLine(Name);
        //}

        //protected void Test2()
        //{

        //}

        //private void Test3()
        //{

        //}

        //PolyMorphysym
        public override string TestMethod()
        {
            return $"{base.TestMethod()} {Name}";
        }
    }
}
