using System.Reflection;
using Microsoft.FSharp.Reflection;

namespace CsNETCore
{
    public class Sandbox
    {
        public static bool Test() {
            FSharpType.IsTuple(typeof(string));
            //FSharpType.IsRecord(typeof(string), null);
            return (bool)typeof(FSharpReflectionExtensions).GetTypeInfo()
                .GetMethod("FSharpType.IsRecord.Static")
                .Invoke(null, new object[] {typeof(string), null});
        }
    }
}
