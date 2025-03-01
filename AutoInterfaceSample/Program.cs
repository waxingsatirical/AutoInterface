﻿using System;

namespace AutoInterfaceSample.Test
{
    public class Program
    {
        public static void Main()
        {
            //System.Diagnostics.Debug.WriteLine(BeaKona.Output.Debug_TestClass_1.Info);
            //IArbitrary<int> p = new Person();
            //int f;
            //int g = 1;
            //p.Method(1, out f, ref g, "t", 1, 2, 3);

            //IPrintableComplex p = new Person2();
            //p.Print();
            //p.PrintComplex();
        }
    }

    interface IPrintableComplex
    {
        void Print();
        void PrintComplex();
    }

    public class SimplePrinter // : IPrintableComplex
    {
        public void Print() { Console.WriteLine("OK"); }
        public void PrintComplex() { Console.WriteLine("OKC"); }
    }

    public partial class Person2 /*: IPrintableComplex*/
    {
        //[BeaKona.AutoInterface(typeof(IPrintableComplex), AllowMissingMembers = true, MemberMatch = BeaKona.MemberMatchTypes.Public)]
        //private readonly SimplePrinter aspect1 = new SimplePrinter();

        //[BeaKona.AutoInterface(typeof(IPrintableComplex), AllowMissingMembers = true, MemberMatch = BeaKona.MemberMatchTypes.Explicit)]
        //private readonly SimplePrinter aspect2 = new SimplePrinter();

        [BeaKona.AutoInterface(typeof(IPrintableComplex), AllowMissingMembers = true)]
        private readonly SimplePrinter aspect3 = new SimplePrinter();

        //[BeaKona.AutoInterface(typeof(IPrintableComplex), AllowMissingMembers = true, MemberMatch = BeaKona.MemberMatchTypes.Any)]
        //private readonly SimplePrinter aspect4 = new SimplePrinter();

        //void IPrintableComplex.PrintComplex() => Console.WriteLine("OKC2");

        public void PrintComplex() { Console.WriteLine("Oh, K."); }
        //void IPrintableComplex.PrintComplex() { Console.WriteLine("Oh, K."); }
    }


    public class SignalPlotXYConst<TX, TY, T> where TX : struct, IComparable
    {
    }

    public interface ISome
    {
    }

    public interface ISome2
    {
    }

    public struct Heatmap
    {
    }

    public class Colormap
    {
    }

    public interface IArbitrary<T>
    {
        T Length { get; }
        int? Method(int a, out int b, ref int c, dynamic d, params int[] p);

        SignalPlotXYConst<TXi, TYi?, T>? Method2<TXi, TYi>(TXi x, TYi[] ys, in int s) where TXi : struct, IComparable where TYi : struct, IComparable, ISome, ISome2;

        Heatmap AddHeatmap(double?[,] intensities, Colormap? colormap = null, bool? lockScales = true);
        Heatmap AddHeatmap(double[,] intensities, Colormap? colormap = null, bool? lockScales = null);
    }

    public class PrinterV1
    {
        public void Print()
        {
        }

        public int Length => 1;

        public int? Method(int a, out int b, ref int c, dynamic d, params int[] p)
        {
            b = a;
            return a;
        }

        public SignalPlotXYConst<TXc, TYc?, int>? Method2<TXc, TYc>(TXc x, TYc[] ys, in int s) where TXc : struct, IComparable where TYc : struct, IComparable, ISome, ISome2
        {
            return null;
        }

        public Heatmap AddHeatmap(double?[,] intensities, Colormap? colormap = null, bool? lockScales = true)
        {
            return new Heatmap();
        }

        public Heatmap AddHeatmap(double[,] intensities, Colormap? colormap = null, bool? lockScales = null)
        {
            return new Heatmap();
        }
    }

    public partial class Person
    {
        [BeaKona.AutoInterface(typeof(IArbitrary<int>), PreferCoalesce = true)]
        //[BeaKona.AutoInterface(typeof(ITestable))]
        //[BeaKona.AutoInterface(typeof(IPrintable), true)]
        //[BeaKona.AutoInterface(typeof(IPrintable), false)]
        //[BeaKona.AutoInterface(typeof(IPrintable))]//, TemplateBody = "void TestB1() {}"
        //[BeaKona.AutoInterface(typeof(IPrintable2))]//, TemplateBody = "void TestB2() {}"
        //[BeaKona.AutoInterfaceTemplate(BeaKona.AutoInterfaceTargets.PropertyGetter, Filter = "Length", Language = "scriban", Body = "return 1;")]
        //[BeaKona.AutoInterfaceTemplate(BeaKona.AutoInterfaceTargets.Method, Filter = "Print(\\d)?", Body = "LogDebug(nameof({{interface}}.{{name}})); {{expression}};")]
        private readonly PrinterV1? aspect1 = new PrinterV1();

        //[BeaKona.AutoInterface(typeof(IPrintable), IncludeBaseInterfaces = true)]
        //[BeaKona.AutoInterfaceTemplate(BeaKona.AutoInterfaceTargets.Method, Filter = "Print2", Body = "/* */")]
        //[BeaKona.AutoInterfaceTemplate(BeaKona.AutoInterfaceTargets.Method, Filter = "Print2", Body = "/* */")]
        //[BeaKona.AutoInterface(typeof(ITestable))]
        //private readonly PrinterV1? aspect2 = new PrinterV1();
    }
}
