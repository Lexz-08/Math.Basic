## Math.Basic
### Description
A C# library for performing basic math operations.

### How To Use
```csharp

using Math.Basic;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("{0}",   MathOperations.Add(       1.25f, 0.75f));
        Console.WriteLine("\n{0}", MathOperations.Subtract(  1.25f, 0.75f));
        Console.WriteLine("\n{0}", MathOperations.Multiply(  1.25f, 0.75f));
        Console.WriteLine("\n{0}", MathOperations.Divide(    1.25f, 0.75f));
        Console.WriteLine("\n{0}", MathOperations.GetPowerOf(1.25f, 0.75f));
        Console.WriteLine("\n{0}", MathOperations.Modulo(    1.25f, 0.75f));
        Console.Writeline("\n{0}", MathOperations.Average(   1.25f, 0.75f));
        
        // total output
        /*
        
       Add()  2
            
  Subtract()  0.5
            
  Multiply()  0.9375
            
    Divide()  1.67
            
GetPowerOf()  1.18217701
            
    Modulo()  0.5
    
   Average()  1
    
        */
    }
}

```

### Download
[Math.Basic.dll](https://github.com/Lexz-08/Math.Basic/releases/download/math-basic/Math.Basic.dll)
