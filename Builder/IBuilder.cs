namespace Builder
{
    interface IBuilder
    {
        void Reset();
        void AddMotherboard();
        void AddCPU();
        void AddGPU();
        void AddRAM();
        void AddHDD();
        void AddSSD();
        void AddPowerSupply();
        void AddCooler();
        Computer GetResult();
    }
}
