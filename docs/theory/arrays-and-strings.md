# Arrays and strings

C# arrays have fixed length and O(1) index access. Scanning costs O(n). Inserting into the middle of a sequence generally requires moving elements. List<T> supports amortized O(1) append but O(n) middle insertion.

Strings are immutable. Repeatedly extending a string in a loop can allocate and copy repeatedly; use a char array or StringBuilder when building output. C# char is a UTF-16 code unit, not necessarily a whole visible character. The early string exercises restrict input to ASCII so reversing chars is sufficient.

Common boundaries: empty input, one element, negative values, duplicates, and the last valid index. Binary search requires sorted input. Practice tracing a linear scan and a binary search over [1, 3, 5, 7, 9].
