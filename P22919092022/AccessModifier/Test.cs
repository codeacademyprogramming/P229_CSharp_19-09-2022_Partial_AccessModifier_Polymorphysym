using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Test : Doctor
    {
        public byte TestMember;
        public Test(string str) : base(str)
        {

        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nTest: {TestMember}";
        }
    }
}
