using System.Runtime.CompilerServices;

public static class ExampleClass
{
    public static void Solution()
    {
        string rawInput = Utils.GetInput("input.txt"); //reads a string from a file called input.txt in the same folder as this file

        string[] lines = rawInput.Split('\n'); //splits the input read from the file into an array, each line is one entry

        Console.WriteLine(ExampleMethod(int.Parse(lines[0])));
    }

    private static int ExampleMethod(int exampleInput)
    {
        return exampleInput * 10;
    }
    
}

