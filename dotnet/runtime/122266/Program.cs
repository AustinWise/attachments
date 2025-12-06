// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// GenerateBunchmark();

BenchmarkRunner.Run<Benchmarks>();

static void GenerateBunchmark()
{
    for (int i = 0; i < Benchmarks.NUMBER_OF_CALLBACKS; i++)
    {
        Console.WriteLine($"callbacks[{i}] = (delegate* unmanaged<void>)&Callback{i};");
    }
    Console.WriteLine();
    for (int i = 0; i < Benchmarks.NUMBER_OF_CALLBACKS; i++)
    {
        Console.WriteLine($"callbacks[ndx++] = (delegate* unmanaged<void>)&Callback{i};");
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
        int ndx = 0;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback0;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback1;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback2;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback3;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback4;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback5;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback6;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback7;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback8;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback9;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback10;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback11;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback12;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback13;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback14;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback15;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback16;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback17;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback18;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback19;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback20;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback21;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback22;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback23;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback24;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback25;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback26;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback27;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback28;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback29;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback30;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback31;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback32;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback33;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback34;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback35;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback36;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback37;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback38;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback39;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback40;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback41;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback42;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback43;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback44;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback45;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback46;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback47;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback48;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback49;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback50;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback51;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback52;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback53;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback54;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback55;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback56;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback57;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback58;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback59;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback60;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback61;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback62;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback63;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback64;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback65;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback66;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback67;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback68;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback69;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback70;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback71;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback72;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback73;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback74;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback75;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback76;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback77;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback78;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback79;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback80;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback81;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback82;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback83;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback84;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback85;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback86;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback87;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback88;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback89;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback90;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback91;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback92;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback93;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback94;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback95;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback96;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback97;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback98;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback99;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback100;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback101;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback102;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback103;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback104;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback105;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback106;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback107;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback108;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback109;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback110;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback111;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback112;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback113;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback114;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback115;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback116;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback117;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback118;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback119;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback120;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback121;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback122;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback123;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback124;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback125;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback126;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback127;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback128;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback129;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback130;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback131;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback132;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback133;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback134;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback135;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback136;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback137;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback138;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback139;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback140;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback141;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback142;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback143;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback144;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback145;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback146;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback147;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback148;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback149;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback150;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback151;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback152;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback153;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback154;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback155;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback156;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback157;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback158;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback159;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback160;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback161;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback162;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback163;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback164;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback165;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback166;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback167;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback168;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback169;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback170;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback171;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback172;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback173;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback174;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback175;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback176;
        callbacks[ndx++] = (delegate* unmanaged<void>)&Callback177;
        return (nint)callbacks;
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