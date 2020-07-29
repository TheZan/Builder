using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class GamingPcBuilder : IBuilder
    {
        public GamingPcBuilder()
        {
            computer = new Computer();
        }

        private Computer computer;

        public void Reset()
        {
            computer = new Computer();
        }

        public void AddMotherboard()
        {
            computer.Result.Add("Gigabyte B450M S2H");
        }

        public void AddCPU()
        {
            computer.Result.Add("AMD Ryzen 5 3600");
        }

        public void AddGPU()
        {
            computer.Result.Add("Nvidia RTX 2070");
        }

        public void AddRAM()
        {
            computer.Result.Add("Kingston HyperX 16GB");
        }

        public void AddHDD()
        {
            computer.Result.Add("Seagate 2TB");
        }

        public void AddSSD()
        {
            computer.Result.Add("Samsung EVO 860 1 TB");
        }

        public void AddPowerSupply()
        {
            computer.Result.Add("Be quite! Power 9 700W");
        }

        public void AddCooler()
        {
            computer.Result.Add("Gammax 300");
        }

        public Computer GetResult() => computer;
    }
}
