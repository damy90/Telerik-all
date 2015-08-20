using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Text;

/*public class MyType : System.Reflection.TypeInfo
{
    public override string ToString()
    {
        return "Buahaha";
    }
}*/

/*public class MyException : Exception
{
    public MyException(Type type)
    {
        MyType = type;
    }
    public System.Type GetType()
    {
        return MyType;
    }
    Type MyType;
    public static Type type;
}*/

public class MyException<T> : Exception
{
}

class Program
{
    private static Assembly BuildAssembly(string code)
    {
        Microsoft.CSharp.CSharpCodeProvider provider =
           new CSharpCodeProvider();
        ICodeCompiler compiler = provider.CreateCompiler();
        CompilerParameters compilerparams = new CompilerParameters();
        compilerparams.GenerateExecutable = false;
        compilerparams.GenerateInMemory = true;
        CompilerResults results =
           compiler.CompileAssemblyFromSource(compilerparams, code);
        if (results.Errors.HasErrors)
        {
            StringBuilder errors = new StringBuilder("Compiler Errors :\r\n");
            foreach (CompilerError error in results.Errors)
            {
                errors.AppendFormat("Line {0},{1}\t: {2}\n",
                       error.Line, error.Column, error.ErrorText);
            }
            throw new Exception(errors.ToString());
        }
        else
        {
            return results.CompiledAssembly;
        }
    }
    public static Type MakeType(string code, string namespacename, string classname, string functionname, bool isstatic, params object[] args)
    {
        object returnval = null;
        Assembly asm = BuildAssembly(code);
        return asm.GetType(namespacename + "." + classname);
    }
    /*public static object ExecuteCode(string code,
    string namespacename, string classname,
    string functionname, bool isstatic, params object[] args)
    {
        object returnval = null;
        Assembly asm = BuildAssembly(code);
        object instance = null;
        Type type = null;
        if (isstatic)
        {
            type = asm.GetType(namespacename + "." + classname);
        }
        else
        {
            instance = asm.CreateInstance(namespacename + "." + classname);
            type = instance.GetType();
        }
        MethodInfo method = type.GetMethod(functionname);
        returnval = method.Invoke(instance, args);
        return returnval;
    }*/
    static void Main()
    {
        /*MyException.type = MakeType(
            "namespace CompiledAtRuntime\n" +
            "{\n" +
            "    public class TestClass\n" +
            "    {\n" +
            "        public int Sum(int a, int b) { return a + b; }\n" +
            "    }\n" +
            "}",
            "CompiledAtRuntime",
            "TestClass",
            "Sum", true,
            new Object[] { 3, 5 }
        );
        throw new MyException(MyException.type);*/

        throw new MyException<123>();

        //Console.WriteLine(res);

        //return;

        string[] coins = Console.ReadLine().Replace(" ", "").Split(',');
        int patternCount = int.Parse(Console.ReadLine());
        string[] patterns = new string[patternCount];
        int valeyLength = coins.Length;
        int[] money = new int[valeyLength];

        for (int i = 0; i < patternCount; i++)
            patterns[i] = Console.ReadLine();

        for (int i = 0; i < valeyLength; i++)
            money[i] = int.Parse(coins[i]);

        int bestResult = int.MinValue;
        foreach (string pattern in patterns)
        {
            int result = TestPattern(money, pattern);
            if (bestResult < result)
                bestResult = result;
        }
        Console.WriteLine(bestResult);
    }

    private static int TestPattern(int[] money, string pattern)
    {
        bool[] visited = new bool[money.Length];
        string[] steps = pattern.Replace(" ", "").Split(',');
        int result = 0;
        int patternLength = steps.Length;

        int[] stepsArray = new int[patternLength];
        for (int i = 0; i < patternLength; i++)
            stepsArray[i] = int.Parse(steps[i]);

        int position = 0;
        while (true)
        {
            try
            {
                for (int i = 0; i < patternLength; i++)
                {
                    if (position > money.Length || visited[position])
                        return result;
                    result += money[position];
                    visited[position] = true;
                    position += stepsArray[i];
                }
            }
            catch
            {
                throw new MyException(MyException.type);
            }
        }
    }
}
