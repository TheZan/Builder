using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class OfficePCBuilder : IBuilder
    {
        public OfficePCBuilder()
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
            computer.Result.Add("Gigabyte H61");
        }

        public void AddCPU()
        {
            computer.Result.Add("Intel Core i5 2300");
        }

        public void AddGPU()
        {
            computer.Result.Add("Nvidia GTX 1030");
        }

        public void AddRAM()
        {
            computer.Result.Add("Crucial 8GB");
        }

        public void AddHDD()
        {
            computer.Result.Add("Seagate 1TB");
        }

        public void AddSSD()
        {
            computer.Result.Add("Kingston A400");
        }

        public void AddPowerSupply()
        {
            computer.Result.Add("Be quite! Power 9 400W");
        }

        public void AddCooler()
        {
            computer.Result.Add("Gammax 200T");
        }

        public Computer GetResult() => computer;
    }
}
