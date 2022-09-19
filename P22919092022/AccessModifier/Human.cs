using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Human
    {
        public string Test;

        public Human(string test)
        {

        }

        //Polymorphysym
        public virtual string TestMethod()
        {
            return Test;
        }
    }
}
