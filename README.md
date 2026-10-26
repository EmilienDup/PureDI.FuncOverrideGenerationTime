# Pure.DI: exponential generation under a `Func<T1, T>` delegate

Minimal repro for Pure.DI 2.5.6: a 21-class singleton graph where each class depends on the two previous ones generates in 2 s as a direct root, but takes about 30 s and 143,000 lines when reached through a `Func<string, S20>` delegate; two more classes take over five minutes and then fail with CS0204 (too many locals).

[`ISSUE.md`](ISSUE.md) is the text to paste into a Pure.DI GitHub issue; it includes the measurements from 15 to 29 classes.

```
dotnet build
wc -l obj/Debug/net10.0/generated/Pure.DI/Pure.DI.SourceGenerator/Composition.g.cs
```

To compare with the direct root, replace `.Root<Top>("Root")` with `.Root<S20>("Root")` and remove the `Top` class. Add `S21`, `S22` (and their bindings) to see the growth.
