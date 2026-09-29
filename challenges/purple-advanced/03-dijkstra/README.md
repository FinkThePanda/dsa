# Dijkstra

Tier: **Purple**

## Task

Return shortest distances from source in a directed graph with vertices 0..vertexCount-1 and nonnegative int weights. Unreachable distances are long.MaxValue. vertexCount >= 1; source and endpoints are valid. Use a priority queue.

Edit `Solution.cs`. `Tests.cs` contains executable examples; read it before coding and add your own cases after solving.

From this exercise's folder:

```powershell
dotnet build
dotnet run
```

`dotnet run` builds automatically and executes `Tests.cs` against your solution. After building, use `dotnet run --no-build` to skip compilation when the code has not changed.

Alternatively, from the repository root:

```powershell
./scripts/run.ps1 dijkstra
```

## Work through it

1. Trace a small input on paper.
2. Describe a straightforward approach in your own words.
3. Implement it; use a debugger or temporary prints when stuck.
4. Run the checks and add an edge case.
5. Record time and extra-space complexity in `notes.md`.

<details>
<summary>Hint (open after trying)</summary>

Ignore stale queue entries. Use long distances to avoid int overflow.

</details>

Checks verify selected examples, not every possible input or the required complexity. Review the algorithm as well as the output.
