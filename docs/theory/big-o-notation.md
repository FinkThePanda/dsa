# Big O

Big O describes how time or memory grows with input size, not the seconds a program takes to start.

| Cost | Typical example |
|---|---|
| O(1) | Read an array element by index |
| O(log n) | Binary search in a sorted array |
| O(n) | Scan n elements |
| O(n log n) | Efficient comparison sorting |
| O(n²) | Compare every pair |
| O(2^n) | Explore subsets without pruning |

Define n first. Consecutive loops add costs; nested loops multiply only when their bounds justify it. A loop that halves the remaining search space is logarithmic. Dictionary lookups are expected O(1), not a universal worst-case guarantee.

Extra space excludes the input but includes temporary collections and the recursion stack; say explicitly how you count returned output. A recursive traversal of a tree takes O(h) stack space where h is its height. Fibonacci without memoization repeats work and has exponential runtime.

Practice: explain why finding the maximum takes O(n) time and O(1) extra space. Why can binary search discard half the candidates? Why does sorting just to find a maximum do unnecessary work?
