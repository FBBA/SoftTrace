using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATrakingBL
{
    public class VeryDynamicClass
    {
        private static dynamic myDynamicField;
        public dynamic DynamicProperty { get; set; }

        public dynamic DynamicMethod(dynamic dynamicParam)
        {
            dynamic dynamicLocalVar = "Local Variable";
            int myInt = 10;

            if (dynamicParam is int)
            {
                return dynamicLocalVar;
            }
            else 
            {
                return myInt;
            }
        }
    }
}
