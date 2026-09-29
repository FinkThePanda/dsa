# AlgoQuest: learn DSA with C#

A six-tier learning path. Start with small C# programs and progress toward data structures and algorithms you can implement and explain yourself.

## Start here

Requirements: **.NET 10 SDK**. **PowerShell 7** (`pwsh`) is needed only for the optional helper scripts. No external NuGet packages are required. Your current machine already has .NET 10.

Run directly from an exercise folder:

```powershell
cd challenges/grey-basics/02-fizzbuzz
dotnet build
dotnet run
```

`dotnet run` builds automatically, so `dotnet build` is optional. Use `dotnet run --no-build` after a successful build if you have not edited the code. Both commands operate on the local `Exercise.csproj`, which includes your solution and checks.

Or use the optional helper from the repository root:

```powershell
dotnet --version
./scripts/run.ps1 hello-world
./scripts/run.ps1 -List
./scripts/run.ps1 fizzbuzz
```

Hello World is a completed example. Other exercises deliberately start with `NotImplementedException`: a `TODO` result means you have not implemented that exercise yet.

1. Read the [C# basics guide](docs/language-guides/c%23/c%23-basics.md).
2. Open [FizzBuzz](challenges/grey-basics/02-fizzbuzz/README.md).
3. Edit its `Solution.cs`, then run its checks with the command above.
4. Add your own cases in `Tests.cs` and explain your approach in `notes.md`.
5. Track completed exercises in [PROGRESS.md](PROGRESS.md).

## Progression map

| Tier | Core topics | Challenges |
|---|---|---|
| [Grey](docs/tiers/grey-basics.md) | Data types, loops, conditionals, methods | Hello World, FizzBuzz, Reverse String, Find Max |
| [White](docs/tiers/white-foundations.md) | Values/references, recursion, structs/classes | Recursive Fibonacci, Swap Variables, Custom Struct Builder |
| [Green](docs/tiers/green-data-structures.md) | Arrays, linked lists, stacks, queues, binary search | Valid Parentheses, Reverse Linked List, Binary Search, Array Queue |
| [Blue](docs/tiers/blue-intermediate.md) | Hash maps, trees, BFS/DFS, heaps | Two Sum, Invert Binary Tree, Number of Islands, Top K Frequent |
| [Purple](docs/tiers/purple-advanced.md) | DP, backtracking, graphs, tries | Climbing Stairs, Word Search, Dijkstra, Implement Trie |
| [Gold](docs/tiers/gold-expert.md) | Hard DP, segment trees, Union Find | Trapping Rain Water, N-Queens, Alien Dictionary, Range Sum Query, Union Find, Edit Distance |

The tiers describe this course's progression, not universal problem difficulty. N-Queens reinforces backtracking; Alien Dictionary applies topological sorting; Trapping Rain Water can be solved with two pointers. Edit Distance supplies a multidimensional DP exercise, and Union Find has a dedicated implementation exercise.

## How the setup works

Each exercise has a problem statement, unfinished implementation, executable checks, and a notes page. Each exercise already has a small `Exercise.csproj`, so standard `dotnet build` and `dotnet run` work in that folder. They compile `Solution.cs`, `Tests.cs`, and the shared check helper. There is no test-framework dependency. The optional root runner remains available for selecting exercises by ID.

```powershell
# Compile an exercise without running its checks:
./scripts/run.ps1 binary-search -BuildOnly

# Verify every starter compiles:
./scripts/check-all.ps1 -BuildOnly

# Run all exercises (unfinished exercises will report TODO and cause failure):
./scripts/check-all.ps1
```

Exit codes: 0 = success, 1 = failed check, 2 = unfinished implementation. Compiler failures also return a nonzero code. The runner uses shared build output; run exercises sequentially.

For a standalone scratch program, .NET 10 also supports `dotnet run --file scratch.cs`. Exercise solutions use their local project because their checks and helper types span multiple files. `dotnet run --file Solution.cs` alone does not include those checks or provide an entry point; use `dotnet run` inside the exercise folder. Build/startup time is separate from algorithm runtime.

## Learning habits

Try a solution before asking AI for help. Ask for a hint or code review, and explain every line you keep. Passing examples is only one part of completion: also check boundary cases, required techniques, and time/space complexity.

Read [Big O](docs/theory/big-o-notation.md) and [arrays and strings](docs/theory/arrays-and-strings.md) before Green. Earlier language-guide folders remain available, but this learning path and runner currently focus on C#.
