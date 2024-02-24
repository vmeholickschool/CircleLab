using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLab
{
    internal class Validator
    {
        public static bool ValidateRadius(double radius)
        {
            return radius > 0;
        }
    }
}
