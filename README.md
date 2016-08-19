# Feeling Lucky?
**Randomly execute a function on any C# type**

> This is the greatest thing for developer productivity since StackOverflow
>
> -- Me

> Google's Feeling Lucky button comes to your application!
>
> -- Me

Learning to use the various libraries in your project accounts for a large amount
of the time you waste every day. Determining which API method provides the functionality
you require, how to call it and so on. Imagine a world where none of this was an issue,
one where your application could figure out what to do on its own!

That world has arrived, you'll now be able to build applications using nothing more than
a couple of imports!

```csharp
using System;

namespace MyAwesomeApp
{
    public class Program
    {
        public static void Main()
        {
            var someLib = new SomeLib();

            // Run the library!
            Console.WriteLine("{0}", someLib.Lucky());

            // Do 100 works!
            var results = Enumerable
                .Repeat(0, 100)
                .Select(x => target.Lucky())
                .ToArray();
        }
    }
}
```

## Disclaimer

With great power comes great... Just don't use this thing in production unless your
code is INCREDIBLY robust and/or useless. This is the equivalent of feeding gremlins
after midnight, just a bad idea all round.