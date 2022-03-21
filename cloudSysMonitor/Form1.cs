using Hardware.Info;
using System.Diagnostics;
using System.Threading.Tasks;

namespace sysInfo
{
    public partial class app : Form

    {
        public IHardwareInfo hardwareInfo = new HardwareInfo();
        public app()
        {
            InitializeComponent();
        }

        public string getOSName(OperatingSystem os_info)
        {
            string getOSVersion =
                os_info.Version.Major.ToString() + "." +
                os_info.Version.Minor.ToString();
            switch (getOSVersion)
            {
                case "11.0": return "Windows 11";
                case "10.0": return "Windows 10";
                case "6.3": return "Windows 8.1";
                case "6.2": return "Windows 8";
                case "6.1": return "Windows 7";
                case "6.0": return "Windows Vista";
                case "5.1": return "Windows XP";
                case "5.0": return "Windows 2000";
            }
            return "Unknown Version";
        }

        public PerformanceCounter diskDriveInUseCounter = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
        public PerformanceCounter diskDriveReadCounter = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
        public PerformanceCounter diskDriveWriteCounter = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");
        public PerformanceCounter diskDriveTransferCounter = new PerformanceCounter("PhysicalDisk", "Disk Transfers/sec", "_Total");

        public PerformanceCounter cpuUtilizationCounter = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
        public PerformanceCounter cpuProcessesCounter = new PerformanceCounter("System", "Processes");
        public PerformanceCounter cpuThreads1Counter = new PerformanceCounter("Terminal Services Session", "Thread Count", "Console");
        public PerformanceCounter cpuThreads2Counter = new PerformanceCounter("Terminal Services Session", "Thread Count", "Services");
        public PerformanceCounter cpuHandles1Counter = new PerformanceCounter("Terminal Services Session", "Handle Count", "Console");
        public PerformanceCounter cpuHandles2Counter = new PerformanceCounter("Terminal Services Session", "Handle Count", "Services");

        public PerformanceCounter ramTotalCounter = new PerformanceCounter("NUMA Node Memory", "Total MBytes", "_Total");
        public PerformanceCounter ramAvailableCounter = new PerformanceCounter("Memory", "Available MBytes");
        public PerformanceCounter ramCommittedCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        public PerformanceCounter ramCachedCounter = new PerformanceCounter("Memory", "Cache Bytes");

        public void GetInfo()
        {
            hardwareInfo.RefreshMotherboardList();
            hardwareInfo.RefreshCPUList();
            hardwareInfo.RefreshBIOSList();
            hardwareInfo.RefreshMemoryList();
            hardwareInfo.RefreshVideoControllerList();
            hardwareInfo.RefreshDriveList();

            hardwareInfo.RefreshAll();

            foreach (var hardware in hardwareInfo.MotherboardList)
                Console.WriteLine(hardware);

            foreach (var cpu in hardwareInfo.CpuList)
            {
                Console.WriteLine(cpu);

                foreach (var cpuCore in cpu.CpuCoreList)
                    Console.WriteLine(cpuCore);
            }

            foreach (var hardware in hardwareInfo.BiosList)
                Console.WriteLine(hardware);

            foreach (var hardware in hardwareInfo.MemoryList)
                Console.WriteLine(hardware);

            foreach (var hardware in hardwareInfo.VideoControllerList)
                Console.WriteLine(hardware);

            foreach (var drive in hardwareInfo.DriveList)
            {
                Console.WriteLine(drive);
            }
        }
        public async void GetUsage()
        {
            while (true)
            {
                diskDriveUsageActiveInfo.Text = Math.Round(diskDriveInUseCounter.NextValue(), 2).ToString() + " %";
                diskDriveUsageReadInfo.Text = ConvertBToKB(diskDriveReadCounter.NextValue())+ " KB/s";
                diskDriveUsageWriteInfo.Text = ConvertBToKB(diskDriveWriteCounter.NextValue()) + " KB/s";
                diskDriveUsageTransferInfo.Text = Math.Round(diskDriveTransferCounter.NextValue()) + " /s";

                cpuUsageUtilizationInfo.Text = Math.Round(cpuUtilizationCounter.NextValue(), 2).ToString().Replace("/", ".") + " %";
                cpuUsageProcessesInfo.Text = cpuProcessesCounter.NextValue().ToString();
                double cpuThreads = cpuThreads1Counter.NextValue() + cpuThreads2Counter.NextValue();
                cpuUsageThreadsInfo.Text = cpuThreads.ToString();
                double cpuHandles = cpuHandles1Counter.NextValue() + cpuHandles2Counter.NextValue();
                cpuUsageHandlesInfo.Text = cpuHandles.ToString();

                ramUsageInUseInfo.Text = ConvertBToKB(ramTotalCounter.NextValue() - ramAvailableCounter.NextValue()) + " GB";
                ramUsageAvailableInfo.Text = ConvertBToKB(ramAvailableCounter.NextValue()).ToString() + " GB";
                ramUsageCommittedInfo.Text = Math.Round(ramCommittedCounter.NextValue(), 2).ToString() + " %";
                ramUsageCachedInfo.Text = ConvertBToGB(ramCachedCounter.NextValue());

                await Task.Delay(1000);
            }
        }
        public static string ConvertBToKB(float _number)
        {
            return Math.Round((_number / 1024), 2).ToString();
        }
        public static string ConvertBToGB(float _number)
        {
            return Math.Round((_number / (1024 * 1024 * 1024)), 2).ToString() + " GB";
        }
        private void getInfoButton_Click(object sender, EventArgs e)
        {
            all_tab.SelectedIndex = 0;

            GetInfo();
            //determines if 32bit or 64bit 
            string osArchitecture = "";
            bool is64BitSystem = Environment.Is64BitOperatingSystem;
            if (is64BitSystem)
            {
                osArchitecture = "64Bit";
            }
            else
            {
                osArchitecture = "32Bit";
            }
            //get os info
            osInfo.Text = getOSName(Environment.OSVersion) + " " + osArchitecture;
            osVersionInfo.Text = Environment.OSVersion.Version.ToString();
            //get motherboard info
            motherboardManuInfo.Text = hardwareInfo.MotherboardList[0].Manufacturer;
            motherboardProdInfo.Text = hardwareInfo.MotherboardList[0].Product;
            motherboardSerialNumberInfo.Text = hardwareInfo.MotherboardList[0].SerialNumber.ToString();
            //get cpu info
            cpuNameInfo.Text = hardwareInfo.CpuList[0].Name.ToString();
            cpuCoreCountInfo.Text = hardwareInfo.CpuList[0].NumberOfCores.ToString();
            cpuMaxClockSpeedInfo.Text = hardwareInfo.CpuList[0].MaxClockSpeed.ToString() + "GHz";
            cpuSocketInfo.Text = hardwareInfo.CpuList[0].SocketDesignation;
            //get bios info
            biosManuInfo.Text = hardwareInfo.BiosList[0].Manufacturer;
            biosDescInfo.Text = hardwareInfo.BiosList[0].Description;
            biosVersionInfo.Text = hardwareInfo.BiosList[0].Version;
            //get diskDrive info
            diskDriveModelInfo.Text = hardwareInfo.DriveList[0].Model;
            diskDriveFirmwareRevInfo.Text = hardwareInfo.DriveList[0].FirmwareRevision;
            diskDriveSerialNumberInfo.Text = hardwareInfo.DriveList[0].SerialNumber.ToString();
            //convert diskDrive size B to GB
            string dSizeGB = ConvertBToGB(hardwareInfo.DriveList[0].Size);
            diskDriveSizeInfo.Text = dSizeGB;
            //get gpu info
            gpuNameInfo.Text = hardwareInfo.VideoControllerList[0].Name;
            gpuCurrentModeInfo.Text = hardwareInfo.VideoControllerList[0].VideoModeDescription.ToString();
            gpuDriverVersionInfo.Text = hardwareInfo.VideoControllerList[0].DriverVersion;
            //convert gpu vram B to GB
            string vRamGB = ConvertBToGB(hardwareInfo.VideoControllerList[0].AdapterRAM);
            gpuVRamInfo.Text = vRamGB;
            //get ram info
            ramManuInfo.Text = hardwareInfo.MemoryList[0].Manufacturer;
            ramPartNumberInfo.Text = hardwareInfo.MemoryList[0].PartNumber;
            ramSpeedInfo.Text = hardwareInfo.MemoryList[0].Speed.ToString() + "MHz";
            //convert ram capacity B to GB and get total
            float singleRamGB = 0;
            float totalRamGB = 0;
            foreach (Memory x in hardwareInfo.MemoryList)
            {
                singleRamGB = x.Capacity / (1024 * 1024 * 1024);
                Math.Round(singleRamGB, 2);
                totalRamGB += x.Capacity / (1024 * 1024 * 1024);
                Math.Round(totalRamGB, 2);
            }
            ramCapacityInfo.Text = hardwareInfo.MemoryList.Count.ToString() + " x " + singleRamGB.ToString() + "GB = " + totalRamGB.ToString() +"GB";
        }
        private void getPerformanceButton_Click(object sender, EventArgs e)
        {
            all_tab.SelectedIndex = 1;
            GetUsage();
        }

        private void about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = 
                "Cloud System Monitor v1.01\n\n" +
                "Developed by Paymon Kazemeini\n\n" +
                "Contact: pkazemei@gmail.com\n\n" +
                "For more projects, go to www.github.com/pkazemei";
            string title = "About";
            MessageBox.Show(message, title);
        }
    }
}