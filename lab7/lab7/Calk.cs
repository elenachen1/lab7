using System;
using System.Collections.Generic;
using System.Text;

namespace lab7
{
    public static class Calk
    {
         public static int Plus(int f, int s)
        {
            return f + s;
        }

        static public int Sub (int f, int s)
        {
            return f - s;
        }

        static public int Mul (int f, int s)
        {
            return f * s;
        }

        static public int Div (int f, int s)
        {
            if ( s == 0)
            {
                return 404; 
            }
            return f / s;
        }
    }
}
