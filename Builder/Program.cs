using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new GamingPcBuilder();
            Director director = new Director(builder);

            Console.WriteLine("Created Gaming PC:");

            director.BuildGamingPC().PrintPcSpec();

            Console.WriteLine("Created Custom Office PC:");

            builder = new OfficePCBuilder();

            builder.AddMotherboard();
            builder.AddCPU();
            builder.AddCooler();
            builder.AddRAM();
            builder.AddHDD();
            builder.AddPowerSupply();

            builder.GetResult().PrintPcSpec();

            Console.ReadKey();
        }
    }
}
