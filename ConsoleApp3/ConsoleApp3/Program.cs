using System;
using System.IO;
using System.Linq;
using Neo;
using Neo.VM;
using Neo.Cryptography;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var engine = new ExecutionEngine(null, Crypto.Default);
            engine.LoadScript(File.ReadAllBytes(@"C:\Users\whm\source\repos\NeoContract_test1\NeoContract_test1\bin\Debug\NeoContract_test1.avm"));
            using (ScriptBuilder sb = new ScriptBuilder())
            {
                /*sb.EmitPush(2); //对应形参 C
                sb.EmitPush(4); //对应形参 B
                sb.EmitPush(3); //对应形参 A
                engine.LoadScript(sb.ToArray());*/

                int[] parameter = { 3, 4, 2 };
                parameter.Reverse().ToList().ForEach(p => sb.EmitPush(p));
                engine.LoadScript(sb.ToArray());
            }
            engine.Execute();

            var result = engine.EvaluationStack.Peek().GetBigInteger();
            Console.WriteLine($"运行结果 {result}");
            Console.Read();
        }
    }
}
