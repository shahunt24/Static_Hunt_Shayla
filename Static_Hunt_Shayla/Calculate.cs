using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_Hunt_Shayla
{
    static class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        // Intergers being added, subtracted, multiplied, and divided and getting a result.
        public static int Add (int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y) 
        {
            return x - y;
        }

        public static int Multiply(int x, int y) 
        {
            return x * y;
        }
        public static int Divide(int x, int y) 
        {
            return x / y;
        }

        //Float being added, subtracted, multiplied, and divided and getting a result.

        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Subtract(float x, float y)
        {
            return x - y;
        }

        public static float Multiply(float x, float y)
        {
            return x * y;
        }
        public static float Divide(float x, float y)
        {
            return x / y;
        }
    }
}
