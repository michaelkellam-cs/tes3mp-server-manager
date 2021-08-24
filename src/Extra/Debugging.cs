using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.IO;
using System.CodeDom;

namespace TES3MP_GUI.src.Extra
{
    public static class Debugging
    {
        public static void PrintArray(string[] arr)
        {
            System.Console.Write("[");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                System.Console.Write(arr[i] + ", ");
            }

            System.Console.WriteLine(arr[arr.Length - 1] + "]");
        }

        public static void PrintArray(int[] arr)
        {
            System.Console.Write("[");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                System.Console.Write(arr[i] + ", ");
            }

            System.Console.WriteLine(arr[arr.Length - 1] + "]");
        }

        public static string ToLiteral(string input)
        {
            using (var writer = new StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }
    }

    
}
