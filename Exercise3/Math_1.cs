using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Math_1
    {
        public int MethodAdd(int x, int y)
        {
            return x + y;
        }
        public decimal MethodAdd(decimal x, decimal y)
        {
            return x + y;
        }
        public string MethodAdd(string x, string y)
        {
            int K = Int32.Parse(x);
            int M = Int32.Parse(y);
            int P = K + M;
            return P.ToString();
        }
        public int MethodSub(int x, int y)
        {
            return x - y;
        }
        public decimal MethodSub(decimal x, decimal y)
        {
            return x - y;
        }
        public string MethodSub(string x, string y)
        {
            int K = Int32.Parse(x);
            int M = Int32.Parse(y);
            int P = K - M;
            return P.ToString();
        }
        public int Methoddiv(int x, int y)
        {
            return x / y;
        }
        public decimal Methoddiv(decimal x, decimal y)
        {
            return x / y;
        }
        public string Methoddiv(string x, string y)
        {
            int K = Int32.Parse(x);
            int M = Int32.Parse(y);
            int P = K / M;
            return P.ToString();
        }







    }
}
