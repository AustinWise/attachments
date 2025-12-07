// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// GenerateBunchmark();

BenchmarkRunner.Run<Benchmarks>(args: args);

static void GenerateBunchmark()
{
    for (int i = 0; i < Benchmarks.NUMBER_OF_CALLBACKS; i++)
    {
        Console.WriteLine($"callbacks[{i}] = (delegate* unmanaged<void>)&Callback{i};");
    }
    Console.WriteLine();
    for (int i = 0; i < Benchmarks.NUMBER_OF_CALLBACKS; i++)
    {
        Console.WriteLine($"public delegate* unmanaged<void> Callback{i};");
    }
    Console.WriteLine();
    for (int i = 0; i < Benchmarks.NUMBER_OF_CALLBACKS; i++)
    {
        Console.WriteLine($"s_corJitInfoVtbl.Callback{i} = &Callback{i};");
    }
    Console.WriteLine();
    for (int i = 0; i < Benchmarks.NUMBER_OF_CALLBACKS; i++)
    {
        Console.WriteLine($"[UnmanagedCallersOnly]");
        Console.WriteLine($"private static void Callback{i}() {{ }}");
    }
}

[DisassemblyDiagnoser]
public unsafe class Benchmarks
{
    public const int NUMBER_OF_CALLBACKS = 178;
    void** callbacks;

    [FixedAddressValueType]
    static readonly ICorJitInfoVtbl s_corJitInfoVtbl;

    struct ICorJitInfoVtbl
    {
        public delegate* unmanaged<void> Callback0;
        public delegate* unmanaged<void> Callback1;
        public delegate* unmanaged<void> Callback2;
        public delegate* unmanaged<void> Callback3;
        public delegate* unmanaged<void> Callback4;
        public delegate* unmanaged<void> Callback5;
        public delegate* unmanaged<void> Callback6;
        public delegate* unmanaged<void> Callback7;
        public delegate* unmanaged<void> Callback8;
        public delegate* unmanaged<void> Callback9;
        public delegate* unmanaged<void> Callback10;
        public delegate* unmanaged<void> Callback11;
        public delegate* unmanaged<void> Callback12;
        public delegate* unmanaged<void> Callback13;
        public delegate* unmanaged<void> Callback14;
        public delegate* unmanaged<void> Callback15;
        public delegate* unmanaged<void> Callback16;
        public delegate* unmanaged<void> Callback17;
        public delegate* unmanaged<void> Callback18;
        public delegate* unmanaged<void> Callback19;
        public delegate* unmanaged<void> Callback20;
        public delegate* unmanaged<void> Callback21;
        public delegate* unmanaged<void> Callback22;
        public delegate* unmanaged<void> Callback23;
        public delegate* unmanaged<void> Callback24;
        public delegate* unmanaged<void> Callback25;
        public delegate* unmanaged<void> Callback26;
        public delegate* unmanaged<void> Callback27;
        public delegate* unmanaged<void> Callback28;
        public delegate* unmanaged<void> Callback29;
        public delegate* unmanaged<void> Callback30;
        public delegate* unmanaged<void> Callback31;
        public delegate* unmanaged<void> Callback32;
        public delegate* unmanaged<void> Callback33;
        public delegate* unmanaged<void> Callback34;
        public delegate* unmanaged<void> Callback35;
        public delegate* unmanaged<void> Callback36;
        public delegate* unmanaged<void> Callback37;
        public delegate* unmanaged<void> Callback38;
        public delegate* unmanaged<void> Callback39;
        public delegate* unmanaged<void> Callback40;
        public delegate* unmanaged<void> Callback41;
        public delegate* unmanaged<void> Callback42;
        public delegate* unmanaged<void> Callback43;
        public delegate* unmanaged<void> Callback44;
        public delegate* unmanaged<void> Callback45;
        public delegate* unmanaged<void> Callback46;
        public delegate* unmanaged<void> Callback47;
        public delegate* unmanaged<void> Callback48;
        public delegate* unmanaged<void> Callback49;
        public delegate* unmanaged<void> Callback50;
        public delegate* unmanaged<void> Callback51;
        public delegate* unmanaged<void> Callback52;
        public delegate* unmanaged<void> Callback53;
        public delegate* unmanaged<void> Callback54;
        public delegate* unmanaged<void> Callback55;
        public delegate* unmanaged<void> Callback56;
        public delegate* unmanaged<void> Callback57;
        public delegate* unmanaged<void> Callback58;
        public delegate* unmanaged<void> Callback59;
        public delegate* unmanaged<void> Callback60;
        public delegate* unmanaged<void> Callback61;
        public delegate* unmanaged<void> Callback62;
        public delegate* unmanaged<void> Callback63;
        public delegate* unmanaged<void> Callback64;
        public delegate* unmanaged<void> Callback65;
        public delegate* unmanaged<void> Callback66;
        public delegate* unmanaged<void> Callback67;
        public delegate* unmanaged<void> Callback68;
        public delegate* unmanaged<void> Callback69;
        public delegate* unmanaged<void> Callback70;
        public delegate* unmanaged<void> Callback71;
        public delegate* unmanaged<void> Callback72;
        public delegate* unmanaged<void> Callback73;
        public delegate* unmanaged<void> Callback74;
        public delegate* unmanaged<void> Callback75;
        public delegate* unmanaged<void> Callback76;
        public delegate* unmanaged<void> Callback77;
        public delegate* unmanaged<void> Callback78;
        public delegate* unmanaged<void> Callback79;
        public delegate* unmanaged<void> Callback80;
        public delegate* unmanaged<void> Callback81;
        public delegate* unmanaged<void> Callback82;
        public delegate* unmanaged<void> Callback83;
        public delegate* unmanaged<void> Callback84;
        public delegate* unmanaged<void> Callback85;
        public delegate* unmanaged<void> Callback86;
        public delegate* unmanaged<void> Callback87;
        public delegate* unmanaged<void> Callback88;
        public delegate* unmanaged<void> Callback89;
        public delegate* unmanaged<void> Callback90;
        public delegate* unmanaged<void> Callback91;
        public delegate* unmanaged<void> Callback92;
        public delegate* unmanaged<void> Callback93;
        public delegate* unmanaged<void> Callback94;
        public delegate* unmanaged<void> Callback95;
        public delegate* unmanaged<void> Callback96;
        public delegate* unmanaged<void> Callback97;
        public delegate* unmanaged<void> Callback98;
        public delegate* unmanaged<void> Callback99;
        public delegate* unmanaged<void> Callback100;
        public delegate* unmanaged<void> Callback101;
        public delegate* unmanaged<void> Callback102;
        public delegate* unmanaged<void> Callback103;
        public delegate* unmanaged<void> Callback104;
        public delegate* unmanaged<void> Callback105;
        public delegate* unmanaged<void> Callback106;
        public delegate* unmanaged<void> Callback107;
        public delegate* unmanaged<void> Callback108;
        public delegate* unmanaged<void> Callback109;
        public delegate* unmanaged<void> Callback110;
        public delegate* unmanaged<void> Callback111;
        public delegate* unmanaged<void> Callback112;
        public delegate* unmanaged<void> Callback113;
        public delegate* unmanaged<void> Callback114;
        public delegate* unmanaged<void> Callback115;
        public delegate* unmanaged<void> Callback116;
        public delegate* unmanaged<void> Callback117;
        public delegate* unmanaged<void> Callback118;
        public delegate* unmanaged<void> Callback119;
        public delegate* unmanaged<void> Callback120;
        public delegate* unmanaged<void> Callback121;
        public delegate* unmanaged<void> Callback122;
        public delegate* unmanaged<void> Callback123;
        public delegate* unmanaged<void> Callback124;
        public delegate* unmanaged<void> Callback125;
        public delegate* unmanaged<void> Callback126;
        public delegate* unmanaged<void> Callback127;
        public delegate* unmanaged<void> Callback128;
        public delegate* unmanaged<void> Callback129;
        public delegate* unmanaged<void> Callback130;
        public delegate* unmanaged<void> Callback131;
        public delegate* unmanaged<void> Callback132;
        public delegate* unmanaged<void> Callback133;
        public delegate* unmanaged<void> Callback134;
        public delegate* unmanaged<void> Callback135;
        public delegate* unmanaged<void> Callback136;
        public delegate* unmanaged<void> Callback137;
        public delegate* unmanaged<void> Callback138;
        public delegate* unmanaged<void> Callback139;
        public delegate* unmanaged<void> Callback140;
        public delegate* unmanaged<void> Callback141;
        public delegate* unmanaged<void> Callback142;
        public delegate* unmanaged<void> Callback143;
        public delegate* unmanaged<void> Callback144;
        public delegate* unmanaged<void> Callback145;
        public delegate* unmanaged<void> Callback146;
        public delegate* unmanaged<void> Callback147;
        public delegate* unmanaged<void> Callback148;
        public delegate* unmanaged<void> Callback149;
        public delegate* unmanaged<void> Callback150;
        public delegate* unmanaged<void> Callback151;
        public delegate* unmanaged<void> Callback152;
        public delegate* unmanaged<void> Callback153;
        public delegate* unmanaged<void> Callback154;
        public delegate* unmanaged<void> Callback155;
        public delegate* unmanaged<void> Callback156;
        public delegate* unmanaged<void> Callback157;
        public delegate* unmanaged<void> Callback158;
        public delegate* unmanaged<void> Callback159;
        public delegate* unmanaged<void> Callback160;
        public delegate* unmanaged<void> Callback161;
        public delegate* unmanaged<void> Callback162;
        public delegate* unmanaged<void> Callback163;
        public delegate* unmanaged<void> Callback164;
        public delegate* unmanaged<void> Callback165;
        public delegate* unmanaged<void> Callback166;
        public delegate* unmanaged<void> Callback167;
        public delegate* unmanaged<void> Callback168;
        public delegate* unmanaged<void> Callback169;
        public delegate* unmanaged<void> Callback170;
        public delegate* unmanaged<void> Callback171;
        public delegate* unmanaged<void> Callback172;
        public delegate* unmanaged<void> Callback173;
        public delegate* unmanaged<void> Callback174;
        public delegate* unmanaged<void> Callback175;
        public delegate* unmanaged<void> Callback176;
        public delegate* unmanaged<void> Callback177;
    }

    static Benchmarks()
    {
        s_corJitInfoVtbl.Callback0 = &Callback0;
        s_corJitInfoVtbl.Callback1 = &Callback1;
        s_corJitInfoVtbl.Callback2 = &Callback2;
        s_corJitInfoVtbl.Callback3 = &Callback3;
        s_corJitInfoVtbl.Callback4 = &Callback4;
        s_corJitInfoVtbl.Callback5 = &Callback5;
        s_corJitInfoVtbl.Callback6 = &Callback6;
        s_corJitInfoVtbl.Callback7 = &Callback7;
        s_corJitInfoVtbl.Callback8 = &Callback8;
        s_corJitInfoVtbl.Callback9 = &Callback9;
        s_corJitInfoVtbl.Callback10 = &Callback10;
        s_corJitInfoVtbl.Callback11 = &Callback11;
        s_corJitInfoVtbl.Callback12 = &Callback12;
        s_corJitInfoVtbl.Callback13 = &Callback13;
        s_corJitInfoVtbl.Callback14 = &Callback14;
        s_corJitInfoVtbl.Callback15 = &Callback15;
        s_corJitInfoVtbl.Callback16 = &Callback16;
        s_corJitInfoVtbl.Callback17 = &Callback17;
        s_corJitInfoVtbl.Callback18 = &Callback18;
        s_corJitInfoVtbl.Callback19 = &Callback19;
        s_corJitInfoVtbl.Callback20 = &Callback20;
        s_corJitInfoVtbl.Callback21 = &Callback21;
        s_corJitInfoVtbl.Callback22 = &Callback22;
        s_corJitInfoVtbl.Callback23 = &Callback23;
        s_corJitInfoVtbl.Callback24 = &Callback24;
        s_corJitInfoVtbl.Callback25 = &Callback25;
        s_corJitInfoVtbl.Callback26 = &Callback26;
        s_corJitInfoVtbl.Callback27 = &Callback27;
        s_corJitInfoVtbl.Callback28 = &Callback28;
        s_corJitInfoVtbl.Callback29 = &Callback29;
        s_corJitInfoVtbl.Callback30 = &Callback30;
        s_corJitInfoVtbl.Callback31 = &Callback31;
        s_corJitInfoVtbl.Callback32 = &Callback32;
        s_corJitInfoVtbl.Callback33 = &Callback33;
        s_corJitInfoVtbl.Callback34 = &Callback34;
        s_corJitInfoVtbl.Callback35 = &Callback35;
        s_corJitInfoVtbl.Callback36 = &Callback36;
        s_corJitInfoVtbl.Callback37 = &Callback37;
        s_corJitInfoVtbl.Callback38 = &Callback38;
        s_corJitInfoVtbl.Callback39 = &Callback39;
        s_corJitInfoVtbl.Callback40 = &Callback40;
        s_corJitInfoVtbl.Callback41 = &Callback41;
        s_corJitInfoVtbl.Callback42 = &Callback42;
        s_corJitInfoVtbl.Callback43 = &Callback43;
        s_corJitInfoVtbl.Callback44 = &Callback44;
        s_corJitInfoVtbl.Callback45 = &Callback45;
        s_corJitInfoVtbl.Callback46 = &Callback46;
        s_corJitInfoVtbl.Callback47 = &Callback47;
        s_corJitInfoVtbl.Callback48 = &Callback48;
        s_corJitInfoVtbl.Callback49 = &Callback49;
        s_corJitInfoVtbl.Callback50 = &Callback50;
        s_corJitInfoVtbl.Callback51 = &Callback51;
        s_corJitInfoVtbl.Callback52 = &Callback52;
        s_corJitInfoVtbl.Callback53 = &Callback53;
        s_corJitInfoVtbl.Callback54 = &Callback54;
        s_corJitInfoVtbl.Callback55 = &Callback55;
        s_corJitInfoVtbl.Callback56 = &Callback56;
        s_corJitInfoVtbl.Callback57 = &Callback57;
        s_corJitInfoVtbl.Callback58 = &Callback58;
        s_corJitInfoVtbl.Callback59 = &Callback59;
        s_corJitInfoVtbl.Callback60 = &Callback60;
        s_corJitInfoVtbl.Callback61 = &Callback61;
        s_corJitInfoVtbl.Callback62 = &Callback62;
        s_corJitInfoVtbl.Callback63 = &Callback63;
        s_corJitInfoVtbl.Callback64 = &Callback64;
        s_corJitInfoVtbl.Callback65 = &Callback65;
        s_corJitInfoVtbl.Callback66 = &Callback66;
        s_corJitInfoVtbl.Callback67 = &Callback67;
        s_corJitInfoVtbl.Callback68 = &Callback68;
        s_corJitInfoVtbl.Callback69 = &Callback69;
        s_corJitInfoVtbl.Callback70 = &Callback70;
        s_corJitInfoVtbl.Callback71 = &Callback71;
        s_corJitInfoVtbl.Callback72 = &Callback72;
        s_corJitInfoVtbl.Callback73 = &Callback73;
        s_corJitInfoVtbl.Callback74 = &Callback74;
        s_corJitInfoVtbl.Callback75 = &Callback75;
        s_corJitInfoVtbl.Callback76 = &Callback76;
        s_corJitInfoVtbl.Callback77 = &Callback77;
        s_corJitInfoVtbl.Callback78 = &Callback78;
        s_corJitInfoVtbl.Callback79 = &Callback79;
        s_corJitInfoVtbl.Callback80 = &Callback80;
        s_corJitInfoVtbl.Callback81 = &Callback81;
        s_corJitInfoVtbl.Callback82 = &Callback82;
        s_corJitInfoVtbl.Callback83 = &Callback83;
        s_corJitInfoVtbl.Callback84 = &Callback84;
        s_corJitInfoVtbl.Callback85 = &Callback85;
        s_corJitInfoVtbl.Callback86 = &Callback86;
        s_corJitInfoVtbl.Callback87 = &Callback87;
        s_corJitInfoVtbl.Callback88 = &Callback88;
        s_corJitInfoVtbl.Callback89 = &Callback89;
        s_corJitInfoVtbl.Callback90 = &Callback90;
        s_corJitInfoVtbl.Callback91 = &Callback91;
        s_corJitInfoVtbl.Callback92 = &Callback92;
        s_corJitInfoVtbl.Callback93 = &Callback93;
        s_corJitInfoVtbl.Callback94 = &Callback94;
        s_corJitInfoVtbl.Callback95 = &Callback95;
        s_corJitInfoVtbl.Callback96 = &Callback96;
        s_corJitInfoVtbl.Callback97 = &Callback97;
        s_corJitInfoVtbl.Callback98 = &Callback98;
        s_corJitInfoVtbl.Callback99 = &Callback99;
        s_corJitInfoVtbl.Callback100 = &Callback100;
        s_corJitInfoVtbl.Callback101 = &Callback101;
        s_corJitInfoVtbl.Callback102 = &Callback102;
        s_corJitInfoVtbl.Callback103 = &Callback103;
        s_corJitInfoVtbl.Callback104 = &Callback104;
        s_corJitInfoVtbl.Callback105 = &Callback105;
        s_corJitInfoVtbl.Callback106 = &Callback106;
        s_corJitInfoVtbl.Callback107 = &Callback107;
        s_corJitInfoVtbl.Callback108 = &Callback108;
        s_corJitInfoVtbl.Callback109 = &Callback109;
        s_corJitInfoVtbl.Callback110 = &Callback110;
        s_corJitInfoVtbl.Callback111 = &Callback111;
        s_corJitInfoVtbl.Callback112 = &Callback112;
        s_corJitInfoVtbl.Callback113 = &Callback113;
        s_corJitInfoVtbl.Callback114 = &Callback114;
        s_corJitInfoVtbl.Callback115 = &Callback115;
        s_corJitInfoVtbl.Callback116 = &Callback116;
        s_corJitInfoVtbl.Callback117 = &Callback117;
        s_corJitInfoVtbl.Callback118 = &Callback118;
        s_corJitInfoVtbl.Callback119 = &Callback119;
        s_corJitInfoVtbl.Callback120 = &Callback120;
        s_corJitInfoVtbl.Callback121 = &Callback121;
        s_corJitInfoVtbl.Callback122 = &Callback122;
        s_corJitInfoVtbl.Callback123 = &Callback123;
        s_corJitInfoVtbl.Callback124 = &Callback124;
        s_corJitInfoVtbl.Callback125 = &Callback125;
        s_corJitInfoVtbl.Callback126 = &Callback126;
        s_corJitInfoVtbl.Callback127 = &Callback127;
        s_corJitInfoVtbl.Callback128 = &Callback128;
        s_corJitInfoVtbl.Callback129 = &Callback129;
        s_corJitInfoVtbl.Callback130 = &Callback130;
        s_corJitInfoVtbl.Callback131 = &Callback131;
        s_corJitInfoVtbl.Callback132 = &Callback132;
        s_corJitInfoVtbl.Callback133 = &Callback133;
        s_corJitInfoVtbl.Callback134 = &Callback134;
        s_corJitInfoVtbl.Callback135 = &Callback135;
        s_corJitInfoVtbl.Callback136 = &Callback136;
        s_corJitInfoVtbl.Callback137 = &Callback137;
        s_corJitInfoVtbl.Callback138 = &Callback138;
        s_corJitInfoVtbl.Callback139 = &Callback139;
        s_corJitInfoVtbl.Callback140 = &Callback140;
        s_corJitInfoVtbl.Callback141 = &Callback141;
        s_corJitInfoVtbl.Callback142 = &Callback142;
        s_corJitInfoVtbl.Callback143 = &Callback143;
        s_corJitInfoVtbl.Callback144 = &Callback144;
        s_corJitInfoVtbl.Callback145 = &Callback145;
        s_corJitInfoVtbl.Callback146 = &Callback146;
        s_corJitInfoVtbl.Callback147 = &Callback147;
        s_corJitInfoVtbl.Callback148 = &Callback148;
        s_corJitInfoVtbl.Callback149 = &Callback149;
        s_corJitInfoVtbl.Callback150 = &Callback150;
        s_corJitInfoVtbl.Callback151 = &Callback151;
        s_corJitInfoVtbl.Callback152 = &Callback152;
        s_corJitInfoVtbl.Callback153 = &Callback153;
        s_corJitInfoVtbl.Callback154 = &Callback154;
        s_corJitInfoVtbl.Callback155 = &Callback155;
        s_corJitInfoVtbl.Callback156 = &Callback156;
        s_corJitInfoVtbl.Callback157 = &Callback157;
        s_corJitInfoVtbl.Callback158 = &Callback158;
        s_corJitInfoVtbl.Callback159 = &Callback159;
        s_corJitInfoVtbl.Callback160 = &Callback160;
        s_corJitInfoVtbl.Callback161 = &Callback161;
        s_corJitInfoVtbl.Callback162 = &Callback162;
        s_corJitInfoVtbl.Callback163 = &Callback163;
        s_corJitInfoVtbl.Callback164 = &Callback164;
        s_corJitInfoVtbl.Callback165 = &Callback165;
        s_corJitInfoVtbl.Callback166 = &Callback166;
        s_corJitInfoVtbl.Callback167 = &Callback167;
        s_corJitInfoVtbl.Callback168 = &Callback168;
        s_corJitInfoVtbl.Callback169 = &Callback169;
        s_corJitInfoVtbl.Callback170 = &Callback170;
        s_corJitInfoVtbl.Callback171 = &Callback171;
        s_corJitInfoVtbl.Callback172 = &Callback172;
        s_corJitInfoVtbl.Callback173 = &Callback173;
        s_corJitInfoVtbl.Callback174 = &Callback174;
        s_corJitInfoVtbl.Callback175 = &Callback175;
        s_corJitInfoVtbl.Callback176 = &Callback176;
        s_corJitInfoVtbl.Callback177 = &Callback177;
    }

    [GlobalSetup]
    public void Setup()
    {
        callbacks = (void**)NativeMemory.Alloc((nuint)(sizeof(void*) * NUMBER_OF_CALLBACKS));
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        NativeMemory.Free(callbacks);
    }

    [Benchmark(Baseline = true)]
    public nint GetCallbacksHardCoded()
    {
        callbacks[0] = (delegate* unmanaged<void>)&Callback0;
        callbacks[1] = (delegate* unmanaged<void>)&Callback1;
        callbacks[2] = (delegate* unmanaged<void>)&Callback2;
        callbacks[3] = (delegate* unmanaged<void>)&Callback3;
        callbacks[4] = (delegate* unmanaged<void>)&Callback4;
        callbacks[5] = (delegate* unmanaged<void>)&Callback5;
        callbacks[6] = (delegate* unmanaged<void>)&Callback6;
        callbacks[7] = (delegate* unmanaged<void>)&Callback7;
        callbacks[8] = (delegate* unmanaged<void>)&Callback8;
        callbacks[9] = (delegate* unmanaged<void>)&Callback9;
        callbacks[10] = (delegate* unmanaged<void>)&Callback10;
        callbacks[11] = (delegate* unmanaged<void>)&Callback11;
        callbacks[12] = (delegate* unmanaged<void>)&Callback12;
        callbacks[13] = (delegate* unmanaged<void>)&Callback13;
        callbacks[14] = (delegate* unmanaged<void>)&Callback14;
        callbacks[15] = (delegate* unmanaged<void>)&Callback15;
        callbacks[16] = (delegate* unmanaged<void>)&Callback16;
        callbacks[17] = (delegate* unmanaged<void>)&Callback17;
        callbacks[18] = (delegate* unmanaged<void>)&Callback18;
        callbacks[19] = (delegate* unmanaged<void>)&Callback19;
        callbacks[20] = (delegate* unmanaged<void>)&Callback20;
        callbacks[21] = (delegate* unmanaged<void>)&Callback21;
        callbacks[22] = (delegate* unmanaged<void>)&Callback22;
        callbacks[23] = (delegate* unmanaged<void>)&Callback23;
        callbacks[24] = (delegate* unmanaged<void>)&Callback24;
        callbacks[25] = (delegate* unmanaged<void>)&Callback25;
        callbacks[26] = (delegate* unmanaged<void>)&Callback26;
        callbacks[27] = (delegate* unmanaged<void>)&Callback27;
        callbacks[28] = (delegate* unmanaged<void>)&Callback28;
        callbacks[29] = (delegate* unmanaged<void>)&Callback29;
        callbacks[30] = (delegate* unmanaged<void>)&Callback30;
        callbacks[31] = (delegate* unmanaged<void>)&Callback31;
        callbacks[32] = (delegate* unmanaged<void>)&Callback32;
        callbacks[33] = (delegate* unmanaged<void>)&Callback33;
        callbacks[34] = (delegate* unmanaged<void>)&Callback34;
        callbacks[35] = (delegate* unmanaged<void>)&Callback35;
        callbacks[36] = (delegate* unmanaged<void>)&Callback36;
        callbacks[37] = (delegate* unmanaged<void>)&Callback37;
        callbacks[38] = (delegate* unmanaged<void>)&Callback38;
        callbacks[39] = (delegate* unmanaged<void>)&Callback39;
        callbacks[40] = (delegate* unmanaged<void>)&Callback40;
        callbacks[41] = (delegate* unmanaged<void>)&Callback41;
        callbacks[42] = (delegate* unmanaged<void>)&Callback42;
        callbacks[43] = (delegate* unmanaged<void>)&Callback43;
        callbacks[44] = (delegate* unmanaged<void>)&Callback44;
        callbacks[45] = (delegate* unmanaged<void>)&Callback45;
        callbacks[46] = (delegate* unmanaged<void>)&Callback46;
        callbacks[47] = (delegate* unmanaged<void>)&Callback47;
        callbacks[48] = (delegate* unmanaged<void>)&Callback48;
        callbacks[49] = (delegate* unmanaged<void>)&Callback49;
        callbacks[50] = (delegate* unmanaged<void>)&Callback50;
        callbacks[51] = (delegate* unmanaged<void>)&Callback51;
        callbacks[52] = (delegate* unmanaged<void>)&Callback52;
        callbacks[53] = (delegate* unmanaged<void>)&Callback53;
        callbacks[54] = (delegate* unmanaged<void>)&Callback54;
        callbacks[55] = (delegate* unmanaged<void>)&Callback55;
        callbacks[56] = (delegate* unmanaged<void>)&Callback56;
        callbacks[57] = (delegate* unmanaged<void>)&Callback57;
        callbacks[58] = (delegate* unmanaged<void>)&Callback58;
        callbacks[59] = (delegate* unmanaged<void>)&Callback59;
        callbacks[60] = (delegate* unmanaged<void>)&Callback60;
        callbacks[61] = (delegate* unmanaged<void>)&Callback61;
        callbacks[62] = (delegate* unmanaged<void>)&Callback62;
        callbacks[63] = (delegate* unmanaged<void>)&Callback63;
        callbacks[64] = (delegate* unmanaged<void>)&Callback64;
        callbacks[65] = (delegate* unmanaged<void>)&Callback65;
        callbacks[66] = (delegate* unmanaged<void>)&Callback66;
        callbacks[67] = (delegate* unmanaged<void>)&Callback67;
        callbacks[68] = (delegate* unmanaged<void>)&Callback68;
        callbacks[69] = (delegate* unmanaged<void>)&Callback69;
        callbacks[70] = (delegate* unmanaged<void>)&Callback70;
        callbacks[71] = (delegate* unmanaged<void>)&Callback71;
        callbacks[72] = (delegate* unmanaged<void>)&Callback72;
        callbacks[73] = (delegate* unmanaged<void>)&Callback73;
        callbacks[74] = (delegate* unmanaged<void>)&Callback74;
        callbacks[75] = (delegate* unmanaged<void>)&Callback75;
        callbacks[76] = (delegate* unmanaged<void>)&Callback76;
        callbacks[77] = (delegate* unmanaged<void>)&Callback77;
        callbacks[78] = (delegate* unmanaged<void>)&Callback78;
        callbacks[79] = (delegate* unmanaged<void>)&Callback79;
        callbacks[80] = (delegate* unmanaged<void>)&Callback80;
        callbacks[81] = (delegate* unmanaged<void>)&Callback81;
        callbacks[82] = (delegate* unmanaged<void>)&Callback82;
        callbacks[83] = (delegate* unmanaged<void>)&Callback83;
        callbacks[84] = (delegate* unmanaged<void>)&Callback84;
        callbacks[85] = (delegate* unmanaged<void>)&Callback85;
        callbacks[86] = (delegate* unmanaged<void>)&Callback86;
        callbacks[87] = (delegate* unmanaged<void>)&Callback87;
        callbacks[88] = (delegate* unmanaged<void>)&Callback88;
        callbacks[89] = (delegate* unmanaged<void>)&Callback89;
        callbacks[90] = (delegate* unmanaged<void>)&Callback90;
        callbacks[91] = (delegate* unmanaged<void>)&Callback91;
        callbacks[92] = (delegate* unmanaged<void>)&Callback92;
        callbacks[93] = (delegate* unmanaged<void>)&Callback93;
        callbacks[94] = (delegate* unmanaged<void>)&Callback94;
        callbacks[95] = (delegate* unmanaged<void>)&Callback95;
        callbacks[96] = (delegate* unmanaged<void>)&Callback96;
        callbacks[97] = (delegate* unmanaged<void>)&Callback97;
        callbacks[98] = (delegate* unmanaged<void>)&Callback98;
        callbacks[99] = (delegate* unmanaged<void>)&Callback99;
        callbacks[100] = (delegate* unmanaged<void>)&Callback100;
        callbacks[101] = (delegate* unmanaged<void>)&Callback101;
        callbacks[102] = (delegate* unmanaged<void>)&Callback102;
        callbacks[103] = (delegate* unmanaged<void>)&Callback103;
        callbacks[104] = (delegate* unmanaged<void>)&Callback104;
        callbacks[105] = (delegate* unmanaged<void>)&Callback105;
        callbacks[106] = (delegate* unmanaged<void>)&Callback106;
        callbacks[107] = (delegate* unmanaged<void>)&Callback107;
        callbacks[108] = (delegate* unmanaged<void>)&Callback108;
        callbacks[109] = (delegate* unmanaged<void>)&Callback109;
        callbacks[110] = (delegate* unmanaged<void>)&Callback110;
        callbacks[111] = (delegate* unmanaged<void>)&Callback111;
        callbacks[112] = (delegate* unmanaged<void>)&Callback112;
        callbacks[113] = (delegate* unmanaged<void>)&Callback113;
        callbacks[114] = (delegate* unmanaged<void>)&Callback114;
        callbacks[115] = (delegate* unmanaged<void>)&Callback115;
        callbacks[116] = (delegate* unmanaged<void>)&Callback116;
        callbacks[117] = (delegate* unmanaged<void>)&Callback117;
        callbacks[118] = (delegate* unmanaged<void>)&Callback118;
        callbacks[119] = (delegate* unmanaged<void>)&Callback119;
        callbacks[120] = (delegate* unmanaged<void>)&Callback120;
        callbacks[121] = (delegate* unmanaged<void>)&Callback121;
        callbacks[122] = (delegate* unmanaged<void>)&Callback122;
        callbacks[123] = (delegate* unmanaged<void>)&Callback123;
        callbacks[124] = (delegate* unmanaged<void>)&Callback124;
        callbacks[125] = (delegate* unmanaged<void>)&Callback125;
        callbacks[126] = (delegate* unmanaged<void>)&Callback126;
        callbacks[127] = (delegate* unmanaged<void>)&Callback127;
        callbacks[128] = (delegate* unmanaged<void>)&Callback128;
        callbacks[129] = (delegate* unmanaged<void>)&Callback129;
        callbacks[130] = (delegate* unmanaged<void>)&Callback130;
        callbacks[131] = (delegate* unmanaged<void>)&Callback131;
        callbacks[132] = (delegate* unmanaged<void>)&Callback132;
        callbacks[133] = (delegate* unmanaged<void>)&Callback133;
        callbacks[134] = (delegate* unmanaged<void>)&Callback134;
        callbacks[135] = (delegate* unmanaged<void>)&Callback135;
        callbacks[136] = (delegate* unmanaged<void>)&Callback136;
        callbacks[137] = (delegate* unmanaged<void>)&Callback137;
        callbacks[138] = (delegate* unmanaged<void>)&Callback138;
        callbacks[139] = (delegate* unmanaged<void>)&Callback139;
        callbacks[140] = (delegate* unmanaged<void>)&Callback140;
        callbacks[141] = (delegate* unmanaged<void>)&Callback141;
        callbacks[142] = (delegate* unmanaged<void>)&Callback142;
        callbacks[143] = (delegate* unmanaged<void>)&Callback143;
        callbacks[144] = (delegate* unmanaged<void>)&Callback144;
        callbacks[145] = (delegate* unmanaged<void>)&Callback145;
        callbacks[146] = (delegate* unmanaged<void>)&Callback146;
        callbacks[147] = (delegate* unmanaged<void>)&Callback147;
        callbacks[148] = (delegate* unmanaged<void>)&Callback148;
        callbacks[149] = (delegate* unmanaged<void>)&Callback149;
        callbacks[150] = (delegate* unmanaged<void>)&Callback150;
        callbacks[151] = (delegate* unmanaged<void>)&Callback151;
        callbacks[152] = (delegate* unmanaged<void>)&Callback152;
        callbacks[153] = (delegate* unmanaged<void>)&Callback153;
        callbacks[154] = (delegate* unmanaged<void>)&Callback154;
        callbacks[155] = (delegate* unmanaged<void>)&Callback155;
        callbacks[156] = (delegate* unmanaged<void>)&Callback156;
        callbacks[157] = (delegate* unmanaged<void>)&Callback157;
        callbacks[158] = (delegate* unmanaged<void>)&Callback158;
        callbacks[159] = (delegate* unmanaged<void>)&Callback159;
        callbacks[160] = (delegate* unmanaged<void>)&Callback160;
        callbacks[161] = (delegate* unmanaged<void>)&Callback161;
        callbacks[162] = (delegate* unmanaged<void>)&Callback162;
        callbacks[163] = (delegate* unmanaged<void>)&Callback163;
        callbacks[164] = (delegate* unmanaged<void>)&Callback164;
        callbacks[165] = (delegate* unmanaged<void>)&Callback165;
        callbacks[166] = (delegate* unmanaged<void>)&Callback166;
        callbacks[167] = (delegate* unmanaged<void>)&Callback167;
        callbacks[168] = (delegate* unmanaged<void>)&Callback168;
        callbacks[169] = (delegate* unmanaged<void>)&Callback169;
        callbacks[170] = (delegate* unmanaged<void>)&Callback170;
        callbacks[171] = (delegate* unmanaged<void>)&Callback171;
        callbacks[172] = (delegate* unmanaged<void>)&Callback172;
        callbacks[173] = (delegate* unmanaged<void>)&Callback173;
        callbacks[174] = (delegate* unmanaged<void>)&Callback174;
        callbacks[175] = (delegate* unmanaged<void>)&Callback175;
        callbacks[176] = (delegate* unmanaged<void>)&Callback176;
        callbacks[177] = (delegate* unmanaged<void>)&Callback177;
        return (nint)callbacks;
    }

    [Benchmark]
    public nint GetCallbacksVar()
    {
        return (IntPtr)Unsafe.AsPointer(ref Unsafe.AsRef(in s_corJitInfoVtbl));
    }

    [UnmanagedCallersOnly]
    private static void Callback0() { }
    [UnmanagedCallersOnly]
    private static void Callback1() { }
    [UnmanagedCallersOnly]
    private static void Callback2() { }
    [UnmanagedCallersOnly]
    private static void Callback3() { }
    [UnmanagedCallersOnly]
    private static void Callback4() { }
    [UnmanagedCallersOnly]
    private static void Callback5() { }
    [UnmanagedCallersOnly]
    private static void Callback6() { }
    [UnmanagedCallersOnly]
    private static void Callback7() { }
    [UnmanagedCallersOnly]
    private static void Callback8() { }
    [UnmanagedCallersOnly]
    private static void Callback9() { }
    [UnmanagedCallersOnly]
    private static void Callback10() { }
    [UnmanagedCallersOnly]
    private static void Callback11() { }
    [UnmanagedCallersOnly]
    private static void Callback12() { }
    [UnmanagedCallersOnly]
    private static void Callback13() { }
    [UnmanagedCallersOnly]
    private static void Callback14() { }
    [UnmanagedCallersOnly]
    private static void Callback15() { }
    [UnmanagedCallersOnly]
    private static void Callback16() { }
    [UnmanagedCallersOnly]
    private static void Callback17() { }
    [UnmanagedCallersOnly]
    private static void Callback18() { }
    [UnmanagedCallersOnly]
    private static void Callback19() { }
    [UnmanagedCallersOnly]
    private static void Callback20() { }
    [UnmanagedCallersOnly]
    private static void Callback21() { }
    [UnmanagedCallersOnly]
    private static void Callback22() { }
    [UnmanagedCallersOnly]
    private static void Callback23() { }
    [UnmanagedCallersOnly]
    private static void Callback24() { }
    [UnmanagedCallersOnly]
    private static void Callback25() { }
    [UnmanagedCallersOnly]
    private static void Callback26() { }
    [UnmanagedCallersOnly]
    private static void Callback27() { }
    [UnmanagedCallersOnly]
    private static void Callback28() { }
    [UnmanagedCallersOnly]
    private static void Callback29() { }
    [UnmanagedCallersOnly]
    private static void Callback30() { }
    [UnmanagedCallersOnly]
    private static void Callback31() { }
    [UnmanagedCallersOnly]
    private static void Callback32() { }
    [UnmanagedCallersOnly]
    private static void Callback33() { }
    [UnmanagedCallersOnly]
    private static void Callback34() { }
    [UnmanagedCallersOnly]
    private static void Callback35() { }
    [UnmanagedCallersOnly]
    private static void Callback36() { }
    [UnmanagedCallersOnly]
    private static void Callback37() { }
    [UnmanagedCallersOnly]
    private static void Callback38() { }
    [UnmanagedCallersOnly]
    private static void Callback39() { }
    [UnmanagedCallersOnly]
    private static void Callback40() { }
    [UnmanagedCallersOnly]
    private static void Callback41() { }
    [UnmanagedCallersOnly]
    private static void Callback42() { }
    [UnmanagedCallersOnly]
    private static void Callback43() { }
    [UnmanagedCallersOnly]
    private static void Callback44() { }
    [UnmanagedCallersOnly]
    private static void Callback45() { }
    [UnmanagedCallersOnly]
    private static void Callback46() { }
    [UnmanagedCallersOnly]
    private static void Callback47() { }
    [UnmanagedCallersOnly]
    private static void Callback48() { }
    [UnmanagedCallersOnly]
    private static void Callback49() { }
    [UnmanagedCallersOnly]
    private static void Callback50() { }
    [UnmanagedCallersOnly]
    private static void Callback51() { }
    [UnmanagedCallersOnly]
    private static void Callback52() { }
    [UnmanagedCallersOnly]
    private static void Callback53() { }
    [UnmanagedCallersOnly]
    private static void Callback54() { }
    [UnmanagedCallersOnly]
    private static void Callback55() { }
    [UnmanagedCallersOnly]
    private static void Callback56() { }
    [UnmanagedCallersOnly]
    private static void Callback57() { }
    [UnmanagedCallersOnly]
    private static void Callback58() { }
    [UnmanagedCallersOnly]
    private static void Callback59() { }
    [UnmanagedCallersOnly]
    private static void Callback60() { }
    [UnmanagedCallersOnly]
    private static void Callback61() { }
    [UnmanagedCallersOnly]
    private static void Callback62() { }
    [UnmanagedCallersOnly]
    private static void Callback63() { }
    [UnmanagedCallersOnly]
    private static void Callback64() { }
    [UnmanagedCallersOnly]
    private static void Callback65() { }
    [UnmanagedCallersOnly]
    private static void Callback66() { }
    [UnmanagedCallersOnly]
    private static void Callback67() { }
    [UnmanagedCallersOnly]
    private static void Callback68() { }
    [UnmanagedCallersOnly]
    private static void Callback69() { }
    [UnmanagedCallersOnly]
    private static void Callback70() { }
    [UnmanagedCallersOnly]
    private static void Callback71() { }
    [UnmanagedCallersOnly]
    private static void Callback72() { }
    [UnmanagedCallersOnly]
    private static void Callback73() { }
    [UnmanagedCallersOnly]
    private static void Callback74() { }
    [UnmanagedCallersOnly]
    private static void Callback75() { }
    [UnmanagedCallersOnly]
    private static void Callback76() { }
    [UnmanagedCallersOnly]
    private static void Callback77() { }
    [UnmanagedCallersOnly]
    private static void Callback78() { }
    [UnmanagedCallersOnly]
    private static void Callback79() { }
    [UnmanagedCallersOnly]
    private static void Callback80() { }
    [UnmanagedCallersOnly]
    private static void Callback81() { }
    [UnmanagedCallersOnly]
    private static void Callback82() { }
    [UnmanagedCallersOnly]
    private static void Callback83() { }
    [UnmanagedCallersOnly]
    private static void Callback84() { }
    [UnmanagedCallersOnly]
    private static void Callback85() { }
    [UnmanagedCallersOnly]
    private static void Callback86() { }
    [UnmanagedCallersOnly]
    private static void Callback87() { }
    [UnmanagedCallersOnly]
    private static void Callback88() { }
    [UnmanagedCallersOnly]
    private static void Callback89() { }
    [UnmanagedCallersOnly]
    private static void Callback90() { }
    [UnmanagedCallersOnly]
    private static void Callback91() { }
    [UnmanagedCallersOnly]
    private static void Callback92() { }
    [UnmanagedCallersOnly]
    private static void Callback93() { }
    [UnmanagedCallersOnly]
    private static void Callback94() { }
    [UnmanagedCallersOnly]
    private static void Callback95() { }
    [UnmanagedCallersOnly]
    private static void Callback96() { }
    [UnmanagedCallersOnly]
    private static void Callback97() { }
    [UnmanagedCallersOnly]
    private static void Callback98() { }
    [UnmanagedCallersOnly]
    private static void Callback99() { }
    [UnmanagedCallersOnly]
    private static void Callback100() { }
    [UnmanagedCallersOnly]
    private static void Callback101() { }
    [UnmanagedCallersOnly]
    private static void Callback102() { }
    [UnmanagedCallersOnly]
    private static void Callback103() { }
    [UnmanagedCallersOnly]
    private static void Callback104() { }
    [UnmanagedCallersOnly]
    private static void Callback105() { }
    [UnmanagedCallersOnly]
    private static void Callback106() { }
    [UnmanagedCallersOnly]
    private static void Callback107() { }
    [UnmanagedCallersOnly]
    private static void Callback108() { }
    [UnmanagedCallersOnly]
    private static void Callback109() { }
    [UnmanagedCallersOnly]
    private static void Callback110() { }
    [UnmanagedCallersOnly]
    private static void Callback111() { }
    [UnmanagedCallersOnly]
    private static void Callback112() { }
    [UnmanagedCallersOnly]
    private static void Callback113() { }
    [UnmanagedCallersOnly]
    private static void Callback114() { }
    [UnmanagedCallersOnly]
    private static void Callback115() { }
    [UnmanagedCallersOnly]
    private static void Callback116() { }
    [UnmanagedCallersOnly]
    private static void Callback117() { }
    [UnmanagedCallersOnly]
    private static void Callback118() { }
    [UnmanagedCallersOnly]
    private static void Callback119() { }
    [UnmanagedCallersOnly]
    private static void Callback120() { }
    [UnmanagedCallersOnly]
    private static void Callback121() { }
    [UnmanagedCallersOnly]
    private static void Callback122() { }
    [UnmanagedCallersOnly]
    private static void Callback123() { }
    [UnmanagedCallersOnly]
    private static void Callback124() { }
    [UnmanagedCallersOnly]
    private static void Callback125() { }
    [UnmanagedCallersOnly]
    private static void Callback126() { }
    [UnmanagedCallersOnly]
    private static void Callback127() { }
    [UnmanagedCallersOnly]
    private static void Callback128() { }
    [UnmanagedCallersOnly]
    private static void Callback129() { }
    [UnmanagedCallersOnly]
    private static void Callback130() { }
    [UnmanagedCallersOnly]
    private static void Callback131() { }
    [UnmanagedCallersOnly]
    private static void Callback132() { }
    [UnmanagedCallersOnly]
    private static void Callback133() { }
    [UnmanagedCallersOnly]
    private static void Callback134() { }
    [UnmanagedCallersOnly]
    private static void Callback135() { }
    [UnmanagedCallersOnly]
    private static void Callback136() { }
    [UnmanagedCallersOnly]
    private static void Callback137() { }
    [UnmanagedCallersOnly]
    private static void Callback138() { }
    [UnmanagedCallersOnly]
    private static void Callback139() { }
    [UnmanagedCallersOnly]
    private static void Callback140() { }
    [UnmanagedCallersOnly]
    private static void Callback141() { }
    [UnmanagedCallersOnly]
    private static void Callback142() { }
    [UnmanagedCallersOnly]
    private static void Callback143() { }
    [UnmanagedCallersOnly]
    private static void Callback144() { }
    [UnmanagedCallersOnly]
    private static void Callback145() { }
    [UnmanagedCallersOnly]
    private static void Callback146() { }
    [UnmanagedCallersOnly]
    private static void Callback147() { }
    [UnmanagedCallersOnly]
    private static void Callback148() { }
    [UnmanagedCallersOnly]
    private static void Callback149() { }
    [UnmanagedCallersOnly]
    private static void Callback150() { }
    [UnmanagedCallersOnly]
    private static void Callback151() { }
    [UnmanagedCallersOnly]
    private static void Callback152() { }
    [UnmanagedCallersOnly]
    private static void Callback153() { }
    [UnmanagedCallersOnly]
    private static void Callback154() { }
    [UnmanagedCallersOnly]
    private static void Callback155() { }
    [UnmanagedCallersOnly]
    private static void Callback156() { }
    [UnmanagedCallersOnly]
    private static void Callback157() { }
    [UnmanagedCallersOnly]
    private static void Callback158() { }
    [UnmanagedCallersOnly]
    private static void Callback159() { }
    [UnmanagedCallersOnly]
    private static void Callback160() { }
    [UnmanagedCallersOnly]
    private static void Callback161() { }
    [UnmanagedCallersOnly]
    private static void Callback162() { }
    [UnmanagedCallersOnly]
    private static void Callback163() { }
    [UnmanagedCallersOnly]
    private static void Callback164() { }
    [UnmanagedCallersOnly]
    private static void Callback165() { }
    [UnmanagedCallersOnly]
    private static void Callback166() { }
    [UnmanagedCallersOnly]
    private static void Callback167() { }
    [UnmanagedCallersOnly]
    private static void Callback168() { }
    [UnmanagedCallersOnly]
    private static void Callback169() { }
    [UnmanagedCallersOnly]
    private static void Callback170() { }
    [UnmanagedCallersOnly]
    private static void Callback171() { }
    [UnmanagedCallersOnly]
    private static void Callback172() { }
    [UnmanagedCallersOnly]
    private static void Callback173() { }
    [UnmanagedCallersOnly]
    private static void Callback174() { }
    [UnmanagedCallersOnly]
    private static void Callback175() { }
    [UnmanagedCallersOnly]
    private static void Callback176() { }
    [UnmanagedCallersOnly]
    private static void Callback177() { }

}