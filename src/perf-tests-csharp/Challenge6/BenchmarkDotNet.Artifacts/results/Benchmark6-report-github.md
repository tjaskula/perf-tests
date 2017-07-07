``` ini

BenchmarkDotNet=v0.10.6, OS=Windows 7 SP1 (6.1.7601)
Processor=Intel Core i7-6600U CPU 2.60GHz (Skylake), ProcessorCount=4
Frequency=2742490 Hz, Resolution=364.6321 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1098.0


```
 |           Method | NbColumns |             Mean |            Error |           StdDev |           Median |              Min |              Max |
 |----------------- |---------- |-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|-----------------:|
 | **Multidimensional** |        **10** |       **4,114.5 ns** |       **172.024 ns** |        **507.22 ns** |       **3,852.7 ns** |       **3,571.5 ns** |       **5,323.0 ns** |
 |           Jagged |        10 |         355.5 ns |         7.343 ns |         10.76 ns |         352.3 ns |         343.0 ns |         384.5 ns |
 | **Multidimensional** |        **20** |      **16,929.0 ns** |       **530.792 ns** |      **1,539.92 ns** |      **16,514.1 ns** |      **15,120.3 ns** |      **21,738.4 ns** |
 |           Jagged |        20 |       1,061.0 ns |        12.653 ns |         11.22 ns |       1,062.0 ns |       1,036.2 ns |       1,081.3 ns |
 | **Multidimensional** |       **200** |   **1,601,874.9 ns** |    **32,319.779 ns** |     **91,685.83 ns** |   **1,581,030.4 ns** |   **1,403,640.4 ns** |   **1,835,831.4 ns** |
 |           Jagged |       200 |      77,384.2 ns |     1,508.799 ns |      2,349.02 ns |      76,992.6 ns |      74,134.0 ns |      82,899.7 ns |
 | **Multidimensional** |      **2000** | **165,672,919.3 ns** | **5,880,090.773 ns** | **17,337,580.31 ns** | **158,198,735.5 ns** | **146,161,636.0 ns** | **219,183,894.0 ns** |
 |           Jagged |      2000 |   8,434,825.1 ns |   346,741.207 ns |  1,022,374.27 ns |   8,227,839.7 ns |   7,096,547.1 ns |  11,203,267.8 ns |
 | **Multidimensional** |     **20000** |               **NA** |               **NA** |               **NA** |               **NA** |               **NA** |               **NA** |
 |           Jagged |     20000 |               NA |               NA |               NA |               NA |               NA |               NA |
 | **Multidimensional** |    **200000** |               **NA** |               **NA** |               **NA** |               **NA** |               **NA** |               **NA** |
 |           Jagged |    200000 |               NA |               NA |               NA |               NA |               NA |               NA |
 | **Multidimensional** |   **2000000** |               **NA** |               **NA** |               **NA** |               **NA** |               **NA** |               **NA** |
 |           Jagged |   2000000 |               NA |               NA |               NA |               NA |               NA |               NA |

Benchmarks with issues:
  Benchmark6.Multidimensional: DefaultJob [NbColumns=20000]
  Benchmark6.Jagged: DefaultJob [NbColumns=20000]
  Benchmark6.Multidimensional: DefaultJob [NbColumns=200000]
  Benchmark6.Jagged: DefaultJob [NbColumns=200000]
  Benchmark6.Multidimensional: DefaultJob [NbColumns=2000000]
  Benchmark6.Jagged: DefaultJob [NbColumns=2000000]