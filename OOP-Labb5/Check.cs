using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb5
{
    class Check<T>
    {
        public bool toCheck(T unknown1, T unknown2)
        {
            if (unknown1.Equals(unknown2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
