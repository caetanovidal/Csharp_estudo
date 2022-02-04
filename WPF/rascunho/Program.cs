using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rascunho
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type d1 = typeof(Dictionary<,>);

            //string separacao = "-----------------------------------";

            //Console.WriteLine(d1);
            //Console.WriteLine(separacao);
            //Console.WriteLine(d1.IsGenericType);
            //Console.WriteLine(separacao);
            //Console.WriteLine(d1.IsGenericTypeDefinition);
            //Console.WriteLine(separacao);

            //Type[] typeParameters = d1.GetGenericArguments();


            //Console.WriteLine("List {0} type arguments: ", typeParameters.Length);

            //foreach (Type tParam in typeParameters)
            //{
            //    if (tParam.IsGenericParameter)
            //    {
            //        DisplayGenericParameter(tParam);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Type Argument: {0}", tParam);
            //    }
            //}


            //Console.WriteLine(separacao);

            

            Type d1 = typeof(Dictionary<,>);

            Dictionary<short, Example> d2 = new Dictionary<short, Example>();

            Type d3 = d2.GetType();
            Type d4 = d3.GetGenericTypeDefinition();

            Console.WriteLine(d3);
            Console.WriteLine(d4);


            Type[] typeArgs = { typeof(short), typeof(Example) };

            Console.WriteLine(typeArgs);

            Type constructed = d1.MakeGenericType(typeArgs);
            
            Console.WriteLine(constructed);

            object o = Activator.CreateInstance(constructed);
            
            Console.WriteLine(o);
            

        }

        private static void DisplayGenericParameter(Type tp)
        {
            Console.WriteLine("      Type parameter: {0} position {1}",
        tp.Name, tp.GenericParameterPosition); ;
        }
    }
}
