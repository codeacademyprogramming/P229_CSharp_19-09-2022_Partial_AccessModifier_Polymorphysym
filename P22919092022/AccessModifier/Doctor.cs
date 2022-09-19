using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Doctor : Person
    {
        public string Experiance;

        public Doctor(string name) : base(name)
        {

        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nExperiance: {Experiance}";
        }

        public override string ShowInfo(int a)
        {
            return base.ShowInfo();
        }
    }
}
