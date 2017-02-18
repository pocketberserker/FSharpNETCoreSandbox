using System;
using Microsoft.FSharp.Reflection;

namespace CsNETCore
{
    public class Sandbox
    {
        public static void Test() {
            FSharpType.IsTuple(typeof(string));
            FSharpType.IsRecord(typeof(string), null);
        }
    }
}
