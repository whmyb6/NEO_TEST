using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace NeoContract_test1
{
    public class Contract1 : SmartContract
    {
        public static int Main(int a,int b,int c)
        {
            //Storage.Put(Storage.CurrentContext, "Hello", "World");
            if (a > b)
                return a * Sum(b, c);
            else
                return Sum(a, b) * c;

        }
        public static int Sum(int a,int b)
        {
            return a+b;
        }
    }
}
