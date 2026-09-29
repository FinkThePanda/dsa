# Fizzbuzz

Tier: **Grey**

## Task

Return strings for integers 1 through n. Multiples of 3 become Fizz, multiples of 5 Buzz, and multiples of both FizzBuzz. n >= 0.

Edit `Solution.cs`. `Tests.cs` contains executable examples; read it before coding and add your own cases after solving.

From this exercise's folder:

```powershell
dotnet build
dotnet run
```

`dotnet run` builds automatically and executes `Tests.cs` against your solution. After building, use `dotnet run --no-build` to skip compilation when the code has not changed.

Alternatively, from the repository root:

```powershell
./scripts/run.ps1 fizzbuzz
```

## Work through it

1. Trace a small input on paper.
2. Describe a straightforward approach in your own words.
3. Implement it; use a debugger or temporary prints when stuck.
4. Run the checks and add an edge case.
5. Record time and extra-space complexity in `notes.md`.

<details>
<summary>Hint (open after trying)</summary>

Use the remainder operator %. Check multiples of both first.

</details>

Checks verify selected examples, not every possible input or the required complexity. Review the algorithm as well as the output.
