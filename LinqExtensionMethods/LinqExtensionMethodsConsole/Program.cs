using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LinqExtensionMethods.LinqExtensionClasses;
using Microsoft.VSDiagnostics;

[CPUUsageDiagnoser]
public class BenchmarkTesting
{
    private const int N = 100;
    private const long n = 23456789321;
    private List<int> numlist = new List<int>();
    private List<int> numlist2 = new List<int>();
    private List<long> longlist = new List<long>();
    private List<long> longlist2 = new List<long>();
    private List<string> strlist = new List<string>();
    private List<string> strlist2 = new List<string>();


    public BenchmarkTesting()
    {
        for (int i = 0; i < N; i++)
        {
            numlist.Add(i);
            longlist.Add(i+n);
            strlist.Add(i.ToString());
        }

        numlist.Reverse();
        strlist.Reverse();
        longlist.Reverse();


        for (int i = 0; i < N - 1; i++)
        {
            numlist2.Add(i);
            longlist2.Add(i + n);
            strlist2.Add(i.ToString());
        }
    }
    [Benchmark]
    public bool includesInt() => numlist.Includes(numlist2);
    [Benchmark]
    public bool includesLong() => longlist.Includes(longlist2);
    [Benchmark]
    public bool includesStr() => strlist.Includes(strlist2);
}
public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
    }
}