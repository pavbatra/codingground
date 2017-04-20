using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(args.Length);
        Console.WriteLine("Hello, World!");
        int fiveFactorial = PBFunctions.Factorial(Convert.ToInt32(args[0]));
        Console.WriteLine(fiveFactorial);
        int fiveFactorial2 = PBFunctions.Factorial2(5);
        Console.WriteLine(fiveFactorial2);
        PBFunctions.ReadDocument();
        
    }
    
}

public class PBFunctions
{
    public static int Factorial (int x)
    {
        int result = 1;
        for (int i=x;i>1;i--)
        {
            result = result * i;  
        }
        return result;
    }
    
    public static int Factorial2(int x)
    {
        if (x <= 1)
        {
            return 1;
        }
        else
        {
            return (x * Factorial2(x-1));
        }
    }
    
        public static void ReadDocument()
        {
            string documentContents = String.Empty;
            string docName = "Newfile.txt";
            string docPath = @"/home/cg/root/";
            using (FileStream stream = new FileStream(docPath + docName, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                documentContents = reader.ReadToEnd();
            }
            Console.WriteLine(documentContents);
        }
    
    
    
}
