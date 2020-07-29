using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        private IBuilder builder;

        public Computer BuildGamingPC()
        {
            builder.AddMotherboard();
            builder.AddCPU();
            builder.AddGPU();
            builder.AddRAM();
            builder.AddHDD();
            builder.AddSSD();
            builder.AddPowerSupply();
            builder.AddCooler();
            return builder.GetResult();
        }
    }
}
