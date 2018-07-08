using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;
using Neo;


namespace NeoContract_whm
{
    public class Contract1 : SmartContract
    {
        public static object Main()
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World!");
            string key = "key";
            string value = "value";
            Storage.Put(Storage.CurrentContext, key, value);

            byte[] rvalue = Storage.Get(Storage.CurrentContext, "Hello");
            Runtime.Log("get ok!");
            var hellostr = "Hello World";
            return hellostr;
        }
    }
}
