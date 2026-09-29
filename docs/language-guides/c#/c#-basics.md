# C# for this course

## The minimum to start

```csharp
int count = 3;
bool ready = count > 0;
string name = "DSA";
int[] values = [4, 2, 9];

if (ready)
{
    for (int i = 0; i < values.Length; i++)
        Console.WriteLine(values[i]);
}

static int Add(int a, int b) => a + b;
Console.WriteLine(Add(2, 3));
```

Array indices start at zero; the last is `Length - 1`. `%` computes a remainder. `==` compares, `=` assigns. Integer division truncates: `5 / 2` is `2`. Use `long` when totals can exceed int's range. `var` asks the compiler to infer a static type; it is not dynamic typing.

## Methods and exercise files

Each starter exposes a static `Solution.Solve(...)` method. Put your algorithm there. Return the requested result rather than just printing it. `Tests.cs` invokes that method with sample inputs. Start with variables, `if`, loops, arrays, and simple helper methods; LINQ is optional and can hide work you should understand.

## Values and references

`int`, `bool`, and structs are value types: assigning them copies the value. Classes and arrays are reference types: assigning them copies a reference to the same object. Strings are reference types but immutable.

```csharp
int a = 5;
int b = a;
b = 9;                 // a is still 5
int[] first = [5];
int[] second = first;
second[0] = 9;         // first[0] is now 9
```

Ordinary method parameters are passed by value, including a copy of an object reference. Mutating that object can be visible to the caller; replacing the local parameter does not replace the caller variable. `ref` permits replacing the caller variable. You do not need unsafe pointers or manual memory management for this course. Value types are not guaranteed to live on the stack; storage depends on context.

## Classes, structs, and generics

```csharp
public sealed class Node(int value)
{
    public int Value = value;
    public Node? Next;
}

public struct Position
{
    public int X { get; set; }
    public int Y { get; set; }
}
```

`Node?` permits null: check it before dereferencing. Use `List<int>` for a growable sequence, `Dictionary<string, int>` for key/value lookup, `HashSet<int>` for membership, `Stack<int>` for last-in-first-out, and `Queue<int>` for first-in-first-out. The type inside `<...>` is a generic type argument. `PriorityQueue<TElement, TPriority>` removes the smallest priority first.

## Recursion and debugging

A recursive method needs a stopping case and a smaller subproblem. Each call consumes stack space; deep recursion can overflow the stack. Trace arguments and return values on paper. For debugging, set a breakpoint inside Solve using your C# editor, or add temporary Console.WriteLine calls. Remove noisy prints once the solution works.

Use `dotnet run` inside an exercise folder, or `./scripts/run.ps1 exercise-id` from the repo root. `dotnet build` compiles without running, and `dotnet run --no-build` runs the last build. If checks fail, compare expected and actual results. If compilation fails, start with the first compiler error. A TODO result is expected until you implement the starter.
