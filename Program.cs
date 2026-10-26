using Pure.DI;

var composition = new Composition();
Console.WriteLine(composition.Root.GetType().Name);

public sealed class S0(string label) { public string Label => label; }
public sealed class S1(S0 s0);
public sealed class S2(S1 a, S0 b);
public sealed class S3(S2 a, S1 b);
public sealed class S4(S3 a, S2 b);
public sealed class S5(S4 a, S3 b);
public sealed class S6(S5 a, S4 b);
public sealed class S7(S6 a, S5 b);
public sealed class S8(S7 a, S6 b);
public sealed class S9(S8 a, S7 b);
public sealed class S10(S9 a, S8 b);
public sealed class S11(S10 a, S9 b);
public sealed class S12(S11 a, S10 b);
public sealed class S13(S12 a, S11 b);
public sealed class S14(S13 a, S12 b);
public sealed class S15(S14 a, S13 b);
public sealed class S16(S15 a, S14 b);
public sealed class S17(S16 a, S15 b);
public sealed class S18(S17 a, S16 b);
public sealed class S19(S18 a, S17 b);
public sealed class S20(S19 a, S18 b);
public sealed class Top(Func<string, S20> factory) { public S20 Make(string label) => factory(label); }

partial class Composition
{
    private static void Setup() => DI.Setup(nameof(Composition))
        .Bind<string>().To(_ => "default")
        .Bind<S0>().As(Lifetime.Singleton).To<S0>()
        .Bind<S1>().As(Lifetime.Singleton).To<S1>()
        .Bind<S2>().As(Lifetime.Singleton).To<S2>()
        .Bind<S3>().As(Lifetime.Singleton).To<S3>()
        .Bind<S4>().As(Lifetime.Singleton).To<S4>()
        .Bind<S5>().As(Lifetime.Singleton).To<S5>()
        .Bind<S6>().As(Lifetime.Singleton).To<S6>()
        .Bind<S7>().As(Lifetime.Singleton).To<S7>()
        .Bind<S8>().As(Lifetime.Singleton).To<S8>()
        .Bind<S9>().As(Lifetime.Singleton).To<S9>()
        .Bind<S10>().As(Lifetime.Singleton).To<S10>()
        .Bind<S11>().As(Lifetime.Singleton).To<S11>()
        .Bind<S12>().As(Lifetime.Singleton).To<S12>()
        .Bind<S13>().As(Lifetime.Singleton).To<S13>()
        .Bind<S14>().As(Lifetime.Singleton).To<S14>()
        .Bind<S15>().As(Lifetime.Singleton).To<S15>()
        .Bind<S16>().As(Lifetime.Singleton).To<S16>()
        .Bind<S17>().As(Lifetime.Singleton).To<S17>()
        .Bind<S18>().As(Lifetime.Singleton).To<S18>()
        .Bind<S19>().As(Lifetime.Singleton).To<S19>()
        .Bind<S20>().As(Lifetime.Singleton).To<S20>()
        .Root<Top>("Root");
}
