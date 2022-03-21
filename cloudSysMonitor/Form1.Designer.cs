namespace sysInfo
{
    partial class app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.performanceButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.all_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.osVersionInfo = new System.Windows.Forms.Label();
            this.osVersion = new System.Windows.Forms.Label();
            this.osInfo = new System.Windows.Forms.Label();
            this.os = new System.Windows.Forms.Label();
            this.diskDriveSerialNumberInfo = new System.Windows.Forms.Label();
            this.diskDriveSerialNumber = new System.Windows.Forms.Label();
            this.diskDriveFirmwareRevInfo = new System.Windows.Forms.Label();
            this.diskDriveFirmwareRev = new System.Windows.Forms.Label();
            this.diskDriveSizeInfo = new System.Windows.Forms.Label();
            this.diskDriveSize = new System.Windows.Forms.Label();
            this.diskDriveModel = new System.Windows.Forms.Label();
            this.diskDriveModelInfo = new System.Windows.Forms.Label();
            this.diskDrive = new System.Windows.Forms.Label();
            this.gpuDriverVersionInfo = new System.Windows.Forms.Label();
            this.gpuDriverVersion = new System.Windows.Forms.Label();
            this.gpuVRamInfo = new System.Windows.Forms.Label();
            this.gpuVRam = new System.Windows.Forms.Label();
            this.gpuCurrentModeInfo = new System.Windows.Forms.Label();
            this.gpuCurrentMode = new System.Windows.Forms.Label();
            this.gpuName = new System.Windows.Forms.Label();
            this.gpuNameInfo = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Label();
            this.ramSpeedInfo = new System.Windows.Forms.Label();
            this.ramSpeed = new System.Windows.Forms.Label();
            this.ramCapacityInfo = new System.Windows.Forms.Label();
            this.ramCapacity = new System.Windows.Forms.Label();
            this.ramPartNumberInfo = new System.Windows.Forms.Label();
            this.ramPartNumber = new System.Windows.Forms.Label();
            this.ramManu = new System.Windows.Forms.Label();
            this.ramManuInfo = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.biosManuInfo = new System.Windows.Forms.Label();
            this.biosManu = new System.Windows.Forms.Label();
            this.biosDescInfo = new System.Windows.Forms.Label();
            this.biosDesc = new System.Windows.Forms.Label();
            this.biosVersionInfo = new System.Windows.Forms.Label();
            this.biosVersion = new System.Windows.Forms.Label();
            this.bios = new System.Windows.Forms.Label();
            this.cpuSocketInfo = new System.Windows.Forms.Label();
            this.cpuSocket = new System.Windows.Forms.Label();
            this.cpuMaxClockSpeedInfo = new System.Windows.Forms.Label();
            this.cpuMaxClockSpeed = new System.Windows.Forms.Label();
            this.cpuCoreCountInfo = new System.Windows.Forms.Label();
            this.cpuCoreCount = new System.Windows.Forms.Label();
            this.motherboardManuInfo = new System.Windows.Forms.Label();
            this.motherboardManu = new System.Windows.Forms.Label();
            this.motherboardProdInfo = new System.Windows.Forms.Label();
            this.cpuName = new System.Windows.Forms.Label();
            this.motherboardProd = new System.Windows.Forms.Label();
            this.motherboardSerialNumberInfo = new System.Windows.Forms.Label();
            this.motherboardSerialNumber = new System.Windows.Forms.Label();
            this.cpuNameInfo = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.motherboard = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ramUsageInUse = new System.Windows.Forms.Label();
            this.ramUsageInUseInfo = new System.Windows.Forms.Label();
            this.diskDriveUsageTransfer = new System.Windows.Forms.Label();
            this.diskDriveUsageTransferInfo = new System.Windows.Forms.Label();
            this.cpuUsageProcesses = new System.Windows.Forms.Label();
            this.cpuUsageProcessesInfo = new System.Windows.Forms.Label();
            this.cpuUsageHandles = new System.Windows.Forms.Label();
            this.cpuUsageHandlesInfo = new System.Windows.Forms.Label();
            this.cpuUsageThreads = new System.Windows.Forms.Label();
            this.cpuUsageThreadsInfo = new System.Windows.Forms.Label();
            this.ramUsageCached = new System.Windows.Forms.Label();
            this.ramUsageCachedInfo = new System.Windows.Forms.Label();
            this.ramUsageCommitted = new System.Windows.Forms.Label();
            this.ramUsageCommittedInfo = new System.Windows.Forms.Label();
            this.diskDriveUsageActive = new System.Windows.Forms.Label();
            this.diskDriveUsageActiveInfo = new System.Windows.Forms.Label();
            this.diskDriveUsageWrite = new System.Windows.Forms.Label();
            this.diskDriveUsageWriteInfo = new System.Windows.Forms.Label();
            this.diskDriveUsageRead = new System.Windows.Forms.Label();
            this.ramUsageAvailable = new System.Windows.Forms.Label();
            this.cpuUsageUtilization = new System.Windows.Forms.Label();
            this.diskDriveUsageReadInfo = new System.Windows.Forms.Label();
            this.ramUsageAvailableInfo = new System.Windows.Forms.Label();
            this.cpuUsageUtilizationInfo = new System.Windows.Forms.Label();
            this.diskDriveUsage = new System.Windows.Forms.Label();
            this.ramUsage = new System.Windows.Forms.Label();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.LinkLabel();
            this.all_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(299, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(224, 22);
            this.title.TabIndex = 0;
            this.title.Text = "Hardware Specification";
            // 
            // getInfoButton
            // 
            this.getInfoButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.getInfoButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getInfoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getInfoButton.Location = new System.Drawing.Point(724, 423);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(86, 30);
            this.getInfoButton.TabIndex = 7;
            this.getInfoButton.Text = "Get Info";
            this.getInfoButton.UseVisualStyleBackColor = false;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // performanceButton
            // 
            this.performanceButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.performanceButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.performanceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.performanceButton.Location = new System.Drawing.Point(357, 423);
            this.performanceButton.Name = "performanceButton";
            this.performanceButton.Size = new System.Drawing.Size(108, 30);
            this.performanceButton.TabIndex = 9;
            this.performanceButton.Text = "Get Performance";
            this.performanceButton.UseVisualStyleBackColor = false;
            this.performanceButton.Click += new System.EventHandler(this.getPerformanceButton_Click);
            // 
            // all_tab
            // 
            this.all_tab.Controls.Add(this.tabPage1);
            this.all_tab.Controls.Add(this.tabPage2);
            this.all_tab.Location = new System.Drawing.Point(12, 34);
            this.all_tab.Name = "all_tab";
            this.all_tab.SelectedIndex = 0;
            this.all_tab.Size = new System.Drawing.Size(798, 387);
            this.all_tab.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.osVersionInfo);
            this.tabPage1.Controls.Add(this.osVersion);
            this.tabPage1.Controls.Add(this.osInfo);
            this.tabPage1.Controls.Add(this.os);
            this.tabPage1.Controls.Add(this.diskDriveSerialNumberInfo);
            this.tabPage1.Controls.Add(this.diskDriveSerialNumber);
            this.tabPage1.Controls.Add(this.diskDriveFirmwareRevInfo);
            this.tabPage1.Controls.Add(this.diskDriveFirmwareRev);
            this.tabPage1.Controls.Add(this.diskDriveSizeInfo);
            this.tabPage1.Controls.Add(this.diskDriveSize);
            this.tabPage1.Controls.Add(this.diskDriveModel);
            this.tabPage1.Controls.Add(this.diskDriveModelInfo);
            this.tabPage1.Controls.Add(this.diskDrive);
            this.tabPage1.Controls.Add(this.gpuDriverVersionInfo);
            this.tabPage1.Controls.Add(this.gpuDriverVersion);
            this.tabPage1.Controls.Add(this.gpuVRamInfo);
            this.tabPage1.Controls.Add(this.gpuVRam);
            this.tabPage1.Controls.Add(this.gpuCurrentModeInfo);
            this.tabPage1.Controls.Add(this.gpuCurrentMode);
            this.tabPage1.Controls.Add(this.gpuName);
            this.tabPage1.Controls.Add(this.gpuNameInfo);
            this.tabPage1.Controls.Add(this.gpu);
            this.tabPage1.Controls.Add(this.ramSpeedInfo);
            this.tabPage1.Controls.Add(this.ramSpeed);
            this.tabPage1.Controls.Add(this.ramCapacityInfo);
            this.tabPage1.Controls.Add(this.ramCapacity);
            this.tabPage1.Controls.Add(this.ramPartNumberInfo);
            this.tabPage1.Controls.Add(this.ramPartNumber);
            this.tabPage1.Controls.Add(this.ramManu);
            this.tabPage1.Controls.Add(this.ramManuInfo);
            this.tabPage1.Controls.Add(this.ram);
            this.tabPage1.Controls.Add(this.biosManuInfo);
            this.tabPage1.Controls.Add(this.biosManu);
            this.tabPage1.Controls.Add(this.biosDescInfo);
            this.tabPage1.Controls.Add(this.biosDesc);
            this.tabPage1.Controls.Add(this.biosVersionInfo);
            this.tabPage1.Controls.Add(this.biosVersion);
            this.tabPage1.Controls.Add(this.bios);
            this.tabPage1.Controls.Add(this.cpuSocketInfo);
            this.tabPage1.Controls.Add(this.cpuSocket);
            this.tabPage1.Controls.Add(this.cpuMaxClockSpeedInfo);
            this.tabPage1.Controls.Add(this.cpuMaxClockSpeed);
            this.tabPage1.Controls.Add(this.cpuCoreCountInfo);
            this.tabPage1.Controls.Add(this.cpuCoreCount);
            this.tabPage1.Controls.Add(this.motherboardManuInfo);
            this.tabPage1.Controls.Add(this.motherboardManu);
            this.tabPage1.Controls.Add(this.motherboardProdInfo);
            this.tabPage1.Controls.Add(this.cpuName);
            this.tabPage1.Controls.Add(this.motherboardProd);
            this.tabPage1.Controls.Add(this.motherboardSerialNumberInfo);
            this.tabPage1.Controls.Add(this.motherboardSerialNumber);
            this.tabPage1.Controls.Add(this.cpuNameInfo);
            this.tabPage1.Controls.Add(this.cpu);
            this.tabPage1.Controls.Add(this.motherboard);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // osVersionInfo
            // 
            this.osVersionInfo.AutoSize = true;
            this.osVersionInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osVersionInfo.Location = new System.Drawing.Point(98, 28);
            this.osVersionInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osVersionInfo.Name = "osVersionInfo";
            this.osVersionInfo.Size = new System.Drawing.Size(0, 16);
            this.osVersionInfo.TabIndex = 115;
            // 
            // osVersion
            // 
            this.osVersion.AutoSize = true;
            this.osVersion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osVersion.Location = new System.Drawing.Point(36, 28);
            this.osVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osVersion.Name = "osVersion";
            this.osVersion.Size = new System.Drawing.Size(58, 16);
            this.osVersion.TabIndex = 114;
            this.osVersion.Text = "Version:";
            // 
            // osInfo
            // 
            this.osInfo.AutoSize = true;
            this.osInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.osInfo.Location = new System.Drawing.Point(133, 3);
            this.osInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osInfo.Name = "osInfo";
            this.osInfo.Size = new System.Drawing.Size(0, 16);
            this.osInfo.TabIndex = 113;
            // 
            // os
            // 
            this.os.AutoSize = true;
            this.os.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.os.Location = new System.Drawing.Point(5, 3);
            this.os.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(124, 16);
            this.os.TabIndex = 112;
            this.os.Text = "Operating System:";
            // 
            // diskDriveSerialNumberInfo
            // 
            this.diskDriveSerialNumberInfo.AutoSize = true;
            this.diskDriveSerialNumberInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveSerialNumberInfo.Location = new System.Drawing.Point(546, 95);
            this.diskDriveSerialNumberInfo.Name = "diskDriveSerialNumberInfo";
            this.diskDriveSerialNumberInfo.Size = new System.Drawing.Size(0, 16);
            this.diskDriveSerialNumberInfo.TabIndex = 111;
            // 
            // diskDriveSerialNumber
            // 
            this.diskDriveSerialNumber.AutoSize = true;
            this.diskDriveSerialNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveSerialNumber.Location = new System.Drawing.Point(441, 95);
            this.diskDriveSerialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diskDriveSerialNumber.Name = "diskDriveSerialNumber";
            this.diskDriveSerialNumber.Size = new System.Drawing.Size(100, 16);
            this.diskDriveSerialNumber.TabIndex = 110;
            this.diskDriveSerialNumber.Text = "Serial Number:";
            // 
            // diskDriveFirmwareRevInfo
            // 
            this.diskDriveFirmwareRevInfo.AutoSize = true;
            this.diskDriveFirmwareRevInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveFirmwareRevInfo.Location = new System.Drawing.Point(573, 73);
            this.diskDriveFirmwareRevInfo.Name = "diskDriveFirmwareRevInfo";
            this.diskDriveFirmwareRevInfo.Size = new System.Drawing.Size(0, 16);
            this.diskDriveFirmwareRevInfo.TabIndex = 109;
            // 
            // diskDriveFirmwareRev
            // 
            this.diskDriveFirmwareRev.AutoSize = true;
            this.diskDriveFirmwareRev.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveFirmwareRev.Location = new System.Drawing.Point(441, 73);
            this.diskDriveFirmwareRev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diskDriveFirmwareRev.Name = "diskDriveFirmwareRev";
            this.diskDriveFirmwareRev.Size = new System.Drawing.Size(127, 16);
            this.diskDriveFirmwareRev.TabIndex = 108;
            this.diskDriveFirmwareRev.Text = "Firmware Revision:";
            // 
            // diskDriveSizeInfo
            // 
            this.diskDriveSizeInfo.AutoSize = true;
            this.diskDriveSizeInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveSizeInfo.Location = new System.Drawing.Point(483, 51);
            this.diskDriveSizeInfo.Name = "diskDriveSizeInfo";
            this.diskDriveSizeInfo.Size = new System.Drawing.Size(0, 16);
            this.diskDriveSizeInfo.TabIndex = 107;
            // 
            // diskDriveSize
            // 
            this.diskDriveSize.AutoSize = true;
            this.diskDriveSize.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveSize.Location = new System.Drawing.Point(441, 51);
            this.diskDriveSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diskDriveSize.Name = "diskDriveSize";
            this.diskDriveSize.Size = new System.Drawing.Size(37, 16);
            this.diskDriveSize.TabIndex = 106;
            this.diskDriveSize.Text = "Size:";
            // 
            // diskDriveModel
            // 
            this.diskDriveModel.AutoSize = true;
            this.diskDriveModel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveModel.Location = new System.Drawing.Point(441, 30);
            this.diskDriveModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diskDriveModel.Name = "diskDriveModel";
            this.diskDriveModel.Size = new System.Drawing.Size(49, 16);
            this.diskDriveModel.TabIndex = 105;
            this.diskDriveModel.Text = "Model:";
            // 
            // diskDriveModelInfo
            // 
            this.diskDriveModelInfo.AutoSize = true;
            this.diskDriveModelInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveModelInfo.Location = new System.Drawing.Point(495, 30);
            this.diskDriveModelInfo.Name = "diskDriveModelInfo";
            this.diskDriveModelInfo.Size = new System.Drawing.Size(0, 16);
            this.diskDriveModelInfo.TabIndex = 104;
            // 
            // diskDrive
            // 
            this.diskDrive.AutoSize = true;
            this.diskDrive.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDrive.Location = new System.Drawing.Point(412, 3);
            this.diskDrive.Name = "diskDrive";
            this.diskDrive.Size = new System.Drawing.Size(71, 16);
            this.diskDrive.TabIndex = 103;
            this.diskDrive.Text = "Disk Drive";
            // 
            // gpuDriverVersionInfo
            // 
            this.gpuDriverVersionInfo.AutoSize = true;
            this.gpuDriverVersionInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuDriverVersionInfo.Location = new System.Drawing.Point(546, 216);
            this.gpuDriverVersionInfo.Name = "gpuDriverVersionInfo";
            this.gpuDriverVersionInfo.Size = new System.Drawing.Size(0, 16);
            this.gpuDriverVersionInfo.TabIndex = 102;
            // 
            // gpuDriverVersion
            // 
            this.gpuDriverVersion.AutoSize = true;
            this.gpuDriverVersion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuDriverVersion.Location = new System.Drawing.Point(441, 216);
            this.gpuDriverVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpuDriverVersion.Name = "gpuDriverVersion";
            this.gpuDriverVersion.Size = new System.Drawing.Size(100, 16);
            this.gpuDriverVersion.TabIndex = 101;
            this.gpuDriverVersion.Text = "Driver Version:";
            // 
            // gpuVRamInfo
            // 
            this.gpuVRamInfo.AutoSize = true;
            this.gpuVRamInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuVRamInfo.Location = new System.Drawing.Point(496, 194);
            this.gpuVRamInfo.Name = "gpuVRamInfo";
            this.gpuVRamInfo.Size = new System.Drawing.Size(0, 16);
            this.gpuVRamInfo.TabIndex = 100;
            // 
            // gpuVRam
            // 
            this.gpuVRam.AutoSize = true;
            this.gpuVRam.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuVRam.Location = new System.Drawing.Point(441, 194);
            this.gpuVRam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpuVRam.Name = "gpuVRam";
            this.gpuVRam.Size = new System.Drawing.Size(50, 16);
            this.gpuVRam.TabIndex = 99;
            this.gpuVRam.Text = "VRAM:";
            // 
            // gpuCurrentModeInfo
            // 
            this.gpuCurrentModeInfo.AutoSize = true;
            this.gpuCurrentModeInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuCurrentModeInfo.Location = new System.Drawing.Point(544, 172);
            this.gpuCurrentModeInfo.Name = "gpuCurrentModeInfo";
            this.gpuCurrentModeInfo.Size = new System.Drawing.Size(0, 16);
            this.gpuCurrentModeInfo.TabIndex = 98;
            // 
            // gpuCurrentMode
            // 
            this.gpuCurrentMode.AutoSize = true;
            this.gpuCurrentMode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuCurrentMode.Location = new System.Drawing.Point(441, 172);
            this.gpuCurrentMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpuCurrentMode.Name = "gpuCurrentMode";
            this.gpuCurrentMode.Size = new System.Drawing.Size(98, 16);
            this.gpuCurrentMode.TabIndex = 97;
            this.gpuCurrentMode.Text = "Current Mode:";
            // 
            // gpuName
            // 
            this.gpuName.AutoSize = true;
            this.gpuName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuName.Location = new System.Drawing.Point(439, 151);
            this.gpuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpuName.Name = "gpuName";
            this.gpuName.Size = new System.Drawing.Size(47, 16);
            this.gpuName.TabIndex = 96;
            this.gpuName.Text = "Name:";
            // 
            // gpuNameInfo
            // 
            this.gpuNameInfo.AutoSize = true;
            this.gpuNameInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpuNameInfo.Location = new System.Drawing.Point(491, 151);
            this.gpuNameInfo.Name = "gpuNameInfo";
            this.gpuNameInfo.Size = new System.Drawing.Size(0, 16);
            this.gpuNameInfo.TabIndex = 95;
            // 
            // gpu
            // 
            this.gpu.AutoSize = true;
            this.gpu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu.Location = new System.Drawing.Point(412, 124);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(36, 16);
            this.gpu.TabIndex = 94;
            this.gpu.Text = "GPU";
            // 
            // ramSpeedInfo
            // 
            this.ramSpeedInfo.AutoSize = true;
            this.ramSpeedInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramSpeedInfo.Location = new System.Drawing.Point(497, 337);
            this.ramSpeedInfo.Name = "ramSpeedInfo";
            this.ramSpeedInfo.Size = new System.Drawing.Size(0, 16);
            this.ramSpeedInfo.TabIndex = 93;
            // 
            // ramSpeed
            // 
            this.ramSpeed.AutoSize = true;
            this.ramSpeed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramSpeed.Location = new System.Drawing.Point(441, 337);
            this.ramSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramSpeed.Name = "ramSpeed";
            this.ramSpeed.Size = new System.Drawing.Size(52, 16);
            this.ramSpeed.TabIndex = 92;
            this.ramSpeed.Text = "Speed:";
            // 
            // ramCapacityInfo
            // 
            this.ramCapacityInfo.AutoSize = true;
            this.ramCapacityInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramCapacityInfo.Location = new System.Drawing.Point(511, 315);
            this.ramCapacityInfo.Name = "ramCapacityInfo";
            this.ramCapacityInfo.Size = new System.Drawing.Size(0, 16);
            this.ramCapacityInfo.TabIndex = 91;
            // 
            // ramCapacity
            // 
            this.ramCapacity.AutoSize = true;
            this.ramCapacity.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramCapacity.Location = new System.Drawing.Point(441, 315);
            this.ramCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramCapacity.Name = "ramCapacity";
            this.ramCapacity.Size = new System.Drawing.Size(66, 16);
            this.ramCapacity.TabIndex = 90;
            this.ramCapacity.Text = "Capacity:";
            // 
            // ramPartNumberInfo
            // 
            this.ramPartNumberInfo.AutoSize = true;
            this.ramPartNumberInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramPartNumberInfo.Location = new System.Drawing.Point(534, 293);
            this.ramPartNumberInfo.Name = "ramPartNumberInfo";
            this.ramPartNumberInfo.Size = new System.Drawing.Size(0, 16);
            this.ramPartNumberInfo.TabIndex = 89;
            // 
            // ramPartNumber
            // 
            this.ramPartNumber.AutoSize = true;
            this.ramPartNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramPartNumber.Location = new System.Drawing.Point(441, 293);
            this.ramPartNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramPartNumber.Name = "ramPartNumber";
            this.ramPartNumber.Size = new System.Drawing.Size(90, 16);
            this.ramPartNumber.TabIndex = 88;
            this.ramPartNumber.Text = "Part Number:";
            // 
            // ramManu
            // 
            this.ramManu.AutoSize = true;
            this.ramManu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramManu.Location = new System.Drawing.Point(441, 271);
            this.ramManu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramManu.Name = "ramManu";
            this.ramManu.Size = new System.Drawing.Size(95, 16);
            this.ramManu.TabIndex = 87;
            this.ramManu.Text = "Manufacturer:";
            // 
            // ramManuInfo
            // 
            this.ramManuInfo.AutoSize = true;
            this.ramManuInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramManuInfo.Location = new System.Drawing.Point(541, 271);
            this.ramManuInfo.Name = "ramManuInfo";
            this.ramManuInfo.Size = new System.Drawing.Size(0, 16);
            this.ramManuInfo.TabIndex = 86;
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ram.Location = new System.Drawing.Point(412, 245);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(37, 16);
            this.ram.TabIndex = 85;
            this.ram.Text = "RAM";
            // 
            // biosManuInfo
            // 
            this.biosManuInfo.AutoSize = true;
            this.biosManuInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biosManuInfo.Location = new System.Drawing.Point(126, 298);
            this.biosManuInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.biosManuInfo.Name = "biosManuInfo";
            this.biosManuInfo.Size = new System.Drawing.Size(0, 16);
            this.biosManuInfo.TabIndex = 84;
            // 
            // biosManu
            // 
            this.biosManu.AutoSize = true;
            this.biosManu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biosManu.Location = new System.Drawing.Point(29, 298);
            this.biosManu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.biosManu.Name = "biosManu";
            this.biosManu.Size = new System.Drawing.Size(95, 16);
            this.biosManu.TabIndex = 83;
            this.biosManu.Text = "Manufacturer:";
            // 
            // biosDescInfo
            // 
            this.biosDescInfo.AutoSize = true;
            this.biosDescInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biosDescInfo.Location = new System.Drawing.Point(113, 320);
            this.biosDescInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.biosDescInfo.Name = "biosDescInfo";
            this.biosDescInfo.Size = new System.Drawing.Size(0, 16);
            this.biosDescInfo.TabIndex = 82;
            // 
            // biosDesc
            // 
            this.biosDesc.AutoSize = true;
            this.biosDesc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biosDesc.Location = new System.Drawing.Point(29, 320);
            this.biosDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.biosDesc.Name = "biosDesc";
            this.biosDesc.Size = new System.Drawing.Size(82, 16);
            this.biosDesc.TabIndex = 81;
            this.biosDesc.Text = "Description:";
            // 
            // biosVersionInfo
            // 
            this.biosVersionInfo.AutoSize = true;
            this.biosVersionInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biosVersionInfo.Location = new System.Drawing.Point(90, 342);
            this.biosVersionInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.biosVersionInfo.Name = "biosVersionInfo";
            this.biosVersionInfo.Size = new System.Drawing.Size(0, 16);
            this.biosVersionInfo.TabIndex = 80;
            // 
            // biosVersion
            // 
            this.biosVersion.AutoSize = true;
            this.biosVersion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biosVersion.Location = new System.Drawing.Point(29, 342);
            this.biosVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.biosVersion.Name = "biosVersion";
            this.biosVersion.Size = new System.Drawing.Size(58, 16);
            this.biosVersion.TabIndex = 79;
            this.biosVersion.Text = "Version:";
            // 
            // bios
            // 
            this.bios.AutoSize = true;
            this.bios.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bios.Location = new System.Drawing.Point(5, 271);
            this.bios.Name = "bios";
            this.bios.Size = new System.Drawing.Size(39, 16);
            this.bios.TabIndex = 78;
            this.bios.Text = "BIOS";
            // 
            // cpuSocketInfo
            // 
            this.cpuSocketInfo.AutoSize = true;
            this.cpuSocketInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuSocketInfo.Location = new System.Drawing.Point(92, 243);
            this.cpuSocketInfo.Name = "cpuSocketInfo";
            this.cpuSocketInfo.Size = new System.Drawing.Size(0, 16);
            this.cpuSocketInfo.TabIndex = 77;
            // 
            // cpuSocket
            // 
            this.cpuSocket.AutoSize = true;
            this.cpuSocket.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuSocket.Location = new System.Drawing.Point(34, 243);
            this.cpuSocket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuSocket.Name = "cpuSocket";
            this.cpuSocket.Size = new System.Drawing.Size(54, 16);
            this.cpuSocket.TabIndex = 76;
            this.cpuSocket.Text = "Socket:";
            // 
            // cpuMaxClockSpeedInfo
            // 
            this.cpuMaxClockSpeedInfo.AutoSize = true;
            this.cpuMaxClockSpeedInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuMaxClockSpeedInfo.Location = new System.Drawing.Point(158, 221);
            this.cpuMaxClockSpeedInfo.Name = "cpuMaxClockSpeedInfo";
            this.cpuMaxClockSpeedInfo.Size = new System.Drawing.Size(0, 16);
            this.cpuMaxClockSpeedInfo.TabIndex = 75;
            // 
            // cpuMaxClockSpeed
            // 
            this.cpuMaxClockSpeed.AutoSize = true;
            this.cpuMaxClockSpeed.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuMaxClockSpeed.Location = new System.Drawing.Point(34, 221);
            this.cpuMaxClockSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuMaxClockSpeed.Name = "cpuMaxClockSpeed";
            this.cpuMaxClockSpeed.Size = new System.Drawing.Size(120, 16);
            this.cpuMaxClockSpeed.TabIndex = 74;
            this.cpuMaxClockSpeed.Text = "Max Clock Speed:";
            // 
            // cpuCoreCountInfo
            // 
            this.cpuCoreCountInfo.AutoSize = true;
            this.cpuCoreCountInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuCoreCountInfo.Location = new System.Drawing.Point(120, 199);
            this.cpuCoreCountInfo.Name = "cpuCoreCountInfo";
            this.cpuCoreCountInfo.Size = new System.Drawing.Size(0, 16);
            this.cpuCoreCountInfo.TabIndex = 73;
            // 
            // cpuCoreCount
            // 
            this.cpuCoreCount.AutoSize = true;
            this.cpuCoreCount.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuCoreCount.Location = new System.Drawing.Point(34, 199);
            this.cpuCoreCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuCoreCount.Name = "cpuCoreCount";
            this.cpuCoreCount.Size = new System.Drawing.Size(84, 16);
            this.cpuCoreCount.TabIndex = 72;
            this.cpuCoreCount.Text = "Core Count:";
            // 
            // motherboardManuInfo
            // 
            this.motherboardManuInfo.AutoSize = true;
            this.motherboardManuInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboardManuInfo.Location = new System.Drawing.Point(131, 87);
            this.motherboardManuInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motherboardManuInfo.Name = "motherboardManuInfo";
            this.motherboardManuInfo.Size = new System.Drawing.Size(0, 16);
            this.motherboardManuInfo.TabIndex = 71;
            // 
            // motherboardManu
            // 
            this.motherboardManu.AutoSize = true;
            this.motherboardManu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboardManu.Location = new System.Drawing.Point(34, 87);
            this.motherboardManu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motherboardManu.Name = "motherboardManu";
            this.motherboardManu.Size = new System.Drawing.Size(95, 16);
            this.motherboardManu.TabIndex = 70;
            this.motherboardManu.Text = "Manufacturer:";
            // 
            // motherboardProdInfo
            // 
            this.motherboardProdInfo.AutoSize = true;
            this.motherboardProdInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboardProdInfo.Location = new System.Drawing.Point(92, 108);
            this.motherboardProdInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motherboardProdInfo.Name = "motherboardProdInfo";
            this.motherboardProdInfo.Size = new System.Drawing.Size(0, 16);
            this.motherboardProdInfo.TabIndex = 69;
            // 
            // cpuName
            // 
            this.cpuName.AutoSize = true;
            this.cpuName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuName.Location = new System.Drawing.Point(34, 178);
            this.cpuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuName.Name = "cpuName";
            this.cpuName.Size = new System.Drawing.Size(47, 16);
            this.cpuName.TabIndex = 68;
            this.cpuName.Text = "Name:";
            // 
            // motherboardProd
            // 
            this.motherboardProd.AutoSize = true;
            this.motherboardProd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboardProd.Location = new System.Drawing.Point(34, 108);
            this.motherboardProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motherboardProd.Name = "motherboardProd";
            this.motherboardProd.Size = new System.Drawing.Size(60, 16);
            this.motherboardProd.TabIndex = 67;
            this.motherboardProd.Text = "Product:";
            // 
            // motherboardSerialNumberInfo
            // 
            this.motherboardSerialNumberInfo.AutoSize = true;
            this.motherboardSerialNumberInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboardSerialNumberInfo.Location = new System.Drawing.Point(137, 130);
            this.motherboardSerialNumberInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motherboardSerialNumberInfo.Name = "motherboardSerialNumberInfo";
            this.motherboardSerialNumberInfo.Size = new System.Drawing.Size(0, 16);
            this.motherboardSerialNumberInfo.TabIndex = 66;
            // 
            // motherboardSerialNumber
            // 
            this.motherboardSerialNumber.AutoSize = true;
            this.motherboardSerialNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboardSerialNumber.Location = new System.Drawing.Point(34, 130);
            this.motherboardSerialNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.motherboardSerialNumber.Name = "motherboardSerialNumber";
            this.motherboardSerialNumber.Size = new System.Drawing.Size(100, 16);
            this.motherboardSerialNumber.TabIndex = 65;
            this.motherboardSerialNumber.Text = "Serial Number:";
            // 
            // cpuNameInfo
            // 
            this.cpuNameInfo.AutoSize = true;
            this.cpuNameInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuNameInfo.Location = new System.Drawing.Point(85, 178);
            this.cpuNameInfo.Name = "cpuNameInfo";
            this.cpuNameInfo.Size = new System.Drawing.Size(0, 16);
            this.cpuNameInfo.TabIndex = 64;
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu.Location = new System.Drawing.Point(5, 151);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(35, 16);
            this.cpu.TabIndex = 63;
            this.cpu.Text = "CPU";
            // 
            // motherboard
            // 
            this.motherboard.AutoSize = true;
            this.motherboard.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motherboard.Location = new System.Drawing.Point(5, 60);
            this.motherboard.Name = "motherboard";
            this.motherboard.Size = new System.Drawing.Size(88, 16);
            this.motherboard.TabIndex = 62;
            this.motherboard.Text = "Motherboard";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ramUsageInUse);
            this.tabPage2.Controls.Add(this.ramUsageInUseInfo);
            this.tabPage2.Controls.Add(this.diskDriveUsageTransfer);
            this.tabPage2.Controls.Add(this.diskDriveUsageTransferInfo);
            this.tabPage2.Controls.Add(this.cpuUsageProcesses);
            this.tabPage2.Controls.Add(this.cpuUsageProcessesInfo);
            this.tabPage2.Controls.Add(this.cpuUsageHandles);
            this.tabPage2.Controls.Add(this.cpuUsageHandlesInfo);
            this.tabPage2.Controls.Add(this.cpuUsageThreads);
            this.tabPage2.Controls.Add(this.cpuUsageThreadsInfo);
            this.tabPage2.Controls.Add(this.ramUsageCached);
            this.tabPage2.Controls.Add(this.ramUsageCachedInfo);
            this.tabPage2.Controls.Add(this.ramUsageCommitted);
            this.tabPage2.Controls.Add(this.ramUsageCommittedInfo);
            this.tabPage2.Controls.Add(this.diskDriveUsageActive);
            this.tabPage2.Controls.Add(this.diskDriveUsageActiveInfo);
            this.tabPage2.Controls.Add(this.diskDriveUsageWrite);
            this.tabPage2.Controls.Add(this.diskDriveUsageWriteInfo);
            this.tabPage2.Controls.Add(this.diskDriveUsageRead);
            this.tabPage2.Controls.Add(this.ramUsageAvailable);
            this.tabPage2.Controls.Add(this.cpuUsageUtilization);
            this.tabPage2.Controls.Add(this.diskDriveUsageReadInfo);
            this.tabPage2.Controls.Add(this.ramUsageAvailableInfo);
            this.tabPage2.Controls.Add(this.cpuUsageUtilizationInfo);
            this.tabPage2.Controls.Add(this.diskDriveUsage);
            this.tabPage2.Controls.Add(this.ramUsage);
            this.tabPage2.Controls.Add(this.cpuUsage);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Performance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ramUsageInUse
            // 
            this.ramUsageInUse.AutoSize = true;
            this.ramUsageInUse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageInUse.Location = new System.Drawing.Point(587, 140);
            this.ramUsageInUse.Name = "ramUsageInUse";
            this.ramUsageInUse.Size = new System.Drawing.Size(51, 20);
            this.ramUsageInUse.TabIndex = 35;
            this.ramUsageInUse.Text = "In Use:";
            this.ramUsageInUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsageInUseInfo
            // 
            this.ramUsageInUseInfo.AutoSize = true;
            this.ramUsageInUseInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageInUseInfo.Location = new System.Drawing.Point(644, 140);
            this.ramUsageInUseInfo.Name = "ramUsageInUseInfo";
            this.ramUsageInUseInfo.Size = new System.Drawing.Size(16, 20);
            this.ramUsageInUseInfo.TabIndex = 34;
            this.ramUsageInUseInfo.Text = "0";
            this.ramUsageInUseInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageTransfer
            // 
            this.diskDriveUsageTransfer.AutoSize = true;
            this.diskDriveUsageTransfer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageTransfer.Location = new System.Drawing.Point(83, 239);
            this.diskDriveUsageTransfer.Name = "diskDriveUsageTransfer";
            this.diskDriveUsageTransfer.Size = new System.Drawing.Size(91, 20);
            this.diskDriveUsageTransfer.TabIndex = 33;
            this.diskDriveUsageTransfer.Text = "Transfer Rate:";
            this.diskDriveUsageTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageTransferInfo
            // 
            this.diskDriveUsageTransferInfo.AutoSize = true;
            this.diskDriveUsageTransferInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageTransferInfo.Location = new System.Drawing.Point(180, 239);
            this.diskDriveUsageTransferInfo.Name = "diskDriveUsageTransferInfo";
            this.diskDriveUsageTransferInfo.Size = new System.Drawing.Size(16, 20);
            this.diskDriveUsageTransferInfo.TabIndex = 32;
            this.diskDriveUsageTransferInfo.Text = "0";
            this.diskDriveUsageTransferInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageProcesses
            // 
            this.cpuUsageProcesses.AutoSize = true;
            this.cpuUsageProcesses.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageProcesses.Location = new System.Drawing.Point(346, 173);
            this.cpuUsageProcesses.Name = "cpuUsageProcesses";
            this.cpuUsageProcesses.Size = new System.Drawing.Size(78, 20);
            this.cpuUsageProcesses.TabIndex = 31;
            this.cpuUsageProcesses.Text = "Processes:";
            this.cpuUsageProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageProcessesInfo
            // 
            this.cpuUsageProcessesInfo.AutoSize = true;
            this.cpuUsageProcessesInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageProcessesInfo.Location = new System.Drawing.Point(430, 173);
            this.cpuUsageProcessesInfo.Name = "cpuUsageProcessesInfo";
            this.cpuUsageProcessesInfo.Size = new System.Drawing.Size(16, 20);
            this.cpuUsageProcessesInfo.TabIndex = 30;
            this.cpuUsageProcessesInfo.Text = "0";
            this.cpuUsageProcessesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageHandles
            // 
            this.cpuUsageHandles.AutoSize = true;
            this.cpuUsageHandles.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageHandles.Location = new System.Drawing.Point(346, 239);
            this.cpuUsageHandles.Name = "cpuUsageHandles";
            this.cpuUsageHandles.Size = new System.Drawing.Size(62, 20);
            this.cpuUsageHandles.TabIndex = 29;
            this.cpuUsageHandles.Text = "Handles:";
            this.cpuUsageHandles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageHandlesInfo
            // 
            this.cpuUsageHandlesInfo.AutoSize = true;
            this.cpuUsageHandlesInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageHandlesInfo.Location = new System.Drawing.Point(414, 239);
            this.cpuUsageHandlesInfo.Name = "cpuUsageHandlesInfo";
            this.cpuUsageHandlesInfo.Size = new System.Drawing.Size(16, 20);
            this.cpuUsageHandlesInfo.TabIndex = 28;
            this.cpuUsageHandlesInfo.Text = "0";
            this.cpuUsageHandlesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageThreads
            // 
            this.cpuUsageThreads.AutoSize = true;
            this.cpuUsageThreads.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageThreads.Location = new System.Drawing.Point(346, 206);
            this.cpuUsageThreads.Name = "cpuUsageThreads";
            this.cpuUsageThreads.Size = new System.Drawing.Size(61, 20);
            this.cpuUsageThreads.TabIndex = 27;
            this.cpuUsageThreads.Text = "Threads:";
            this.cpuUsageThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageThreadsInfo
            // 
            this.cpuUsageThreadsInfo.AutoSize = true;
            this.cpuUsageThreadsInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageThreadsInfo.Location = new System.Drawing.Point(411, 206);
            this.cpuUsageThreadsInfo.Name = "cpuUsageThreadsInfo";
            this.cpuUsageThreadsInfo.Size = new System.Drawing.Size(16, 20);
            this.cpuUsageThreadsInfo.TabIndex = 26;
            this.cpuUsageThreadsInfo.Text = "0";
            this.cpuUsageThreadsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsageCached
            // 
            this.ramUsageCached.AutoSize = true;
            this.ramUsageCached.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageCached.Location = new System.Drawing.Point(587, 239);
            this.ramUsageCached.Name = "ramUsageCached";
            this.ramUsageCached.Size = new System.Drawing.Size(59, 20);
            this.ramUsageCached.TabIndex = 25;
            this.ramUsageCached.Text = "Cached:";
            this.ramUsageCached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsageCachedInfo
            // 
            this.ramUsageCachedInfo.AutoSize = true;
            this.ramUsageCachedInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageCachedInfo.Location = new System.Drawing.Point(652, 239);
            this.ramUsageCachedInfo.Name = "ramUsageCachedInfo";
            this.ramUsageCachedInfo.Size = new System.Drawing.Size(16, 20);
            this.ramUsageCachedInfo.TabIndex = 24;
            this.ramUsageCachedInfo.Text = "0";
            this.ramUsageCachedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsageCommitted
            // 
            this.ramUsageCommitted.AutoSize = true;
            this.ramUsageCommitted.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageCommitted.Location = new System.Drawing.Point(587, 206);
            this.ramUsageCommitted.Name = "ramUsageCommitted";
            this.ramUsageCommitted.Size = new System.Drawing.Size(77, 20);
            this.ramUsageCommitted.TabIndex = 23;
            this.ramUsageCommitted.Text = "Committed:";
            this.ramUsageCommitted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsageCommittedInfo
            // 
            this.ramUsageCommittedInfo.AutoSize = true;
            this.ramUsageCommittedInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageCommittedInfo.Location = new System.Drawing.Point(670, 206);
            this.ramUsageCommittedInfo.Name = "ramUsageCommittedInfo";
            this.ramUsageCommittedInfo.Size = new System.Drawing.Size(16, 20);
            this.ramUsageCommittedInfo.TabIndex = 22;
            this.ramUsageCommittedInfo.Text = "0";
            this.ramUsageCommittedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageActive
            // 
            this.diskDriveUsageActive.AutoSize = true;
            this.diskDriveUsageActive.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageActive.Location = new System.Drawing.Point(83, 140);
            this.diskDriveUsageActive.Name = "diskDriveUsageActive";
            this.diskDriveUsageActive.Size = new System.Drawing.Size(50, 20);
            this.diskDriveUsageActive.TabIndex = 14;
            this.diskDriveUsageActive.Text = "Active:";
            this.diskDriveUsageActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageActiveInfo
            // 
            this.diskDriveUsageActiveInfo.AutoSize = true;
            this.diskDriveUsageActiveInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageActiveInfo.Location = new System.Drawing.Point(140, 140);
            this.diskDriveUsageActiveInfo.Name = "diskDriveUsageActiveInfo";
            this.diskDriveUsageActiveInfo.Size = new System.Drawing.Size(16, 20);
            this.diskDriveUsageActiveInfo.TabIndex = 13;
            this.diskDriveUsageActiveInfo.Text = "0";
            this.diskDriveUsageActiveInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageWrite
            // 
            this.diskDriveUsageWrite.AutoSize = true;
            this.diskDriveUsageWrite.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageWrite.Location = new System.Drawing.Point(83, 206);
            this.diskDriveUsageWrite.Name = "diskDriveUsageWrite";
            this.diskDriveUsageWrite.Size = new System.Drawing.Size(88, 20);
            this.diskDriveUsageWrite.TabIndex = 12;
            this.diskDriveUsageWrite.Text = "Write Speed:";
            this.diskDriveUsageWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageWriteInfo
            // 
            this.diskDriveUsageWriteInfo.AutoSize = true;
            this.diskDriveUsageWriteInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageWriteInfo.Location = new System.Drawing.Point(177, 206);
            this.diskDriveUsageWriteInfo.Name = "diskDriveUsageWriteInfo";
            this.diskDriveUsageWriteInfo.Size = new System.Drawing.Size(16, 20);
            this.diskDriveUsageWriteInfo.TabIndex = 11;
            this.diskDriveUsageWriteInfo.Text = "0";
            this.diskDriveUsageWriteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageRead
            // 
            this.diskDriveUsageRead.AutoSize = true;
            this.diskDriveUsageRead.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageRead.Location = new System.Drawing.Point(83, 173);
            this.diskDriveUsageRead.Name = "diskDriveUsageRead";
            this.diskDriveUsageRead.Size = new System.Drawing.Size(90, 20);
            this.diskDriveUsageRead.TabIndex = 10;
            this.diskDriveUsageRead.Text = "Read Speed:";
            this.diskDriveUsageRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsageAvailable
            // 
            this.ramUsageAvailable.AutoSize = true;
            this.ramUsageAvailable.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageAvailable.Location = new System.Drawing.Point(587, 173);
            this.ramUsageAvailable.Name = "ramUsageAvailable";
            this.ramUsageAvailable.Size = new System.Drawing.Size(68, 20);
            this.ramUsageAvailable.TabIndex = 8;
            this.ramUsageAvailable.Text = "Available:";
            this.ramUsageAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageUtilization
            // 
            this.cpuUsageUtilization.AutoSize = true;
            this.cpuUsageUtilization.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageUtilization.Location = new System.Drawing.Point(346, 140);
            this.cpuUsageUtilization.Name = "cpuUsageUtilization";
            this.cpuUsageUtilization.Size = new System.Drawing.Size(69, 20);
            this.cpuUsageUtilization.TabIndex = 7;
            this.cpuUsageUtilization.Text = "Utilization:";
            this.cpuUsageUtilization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsageReadInfo
            // 
            this.diskDriveUsageReadInfo.AutoSize = true;
            this.diskDriveUsageReadInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsageReadInfo.Location = new System.Drawing.Point(179, 173);
            this.diskDriveUsageReadInfo.Name = "diskDriveUsageReadInfo";
            this.diskDriveUsageReadInfo.Size = new System.Drawing.Size(16, 20);
            this.diskDriveUsageReadInfo.TabIndex = 6;
            this.diskDriveUsageReadInfo.Text = "0";
            this.diskDriveUsageReadInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsageAvailableInfo
            // 
            this.ramUsageAvailableInfo.AutoSize = true;
            this.ramUsageAvailableInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsageAvailableInfo.Location = new System.Drawing.Point(661, 173);
            this.ramUsageAvailableInfo.Name = "ramUsageAvailableInfo";
            this.ramUsageAvailableInfo.Size = new System.Drawing.Size(16, 20);
            this.ramUsageAvailableInfo.TabIndex = 5;
            this.ramUsageAvailableInfo.Text = "0";
            this.ramUsageAvailableInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsageUtilizationInfo
            // 
            this.cpuUsageUtilizationInfo.AutoSize = true;
            this.cpuUsageUtilizationInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsageUtilizationInfo.Location = new System.Drawing.Point(421, 140);
            this.cpuUsageUtilizationInfo.Name = "cpuUsageUtilizationInfo";
            this.cpuUsageUtilizationInfo.Size = new System.Drawing.Size(16, 20);
            this.cpuUsageUtilizationInfo.TabIndex = 4;
            this.cpuUsageUtilizationInfo.Text = "0";
            this.cpuUsageUtilizationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diskDriveUsage
            // 
            this.diskDriveUsage.AutoSize = true;
            this.diskDriveUsage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diskDriveUsage.Location = new System.Drawing.Point(43, 99);
            this.diskDriveUsage.Name = "diskDriveUsage";
            this.diskDriveUsage.Size = new System.Drawing.Size(113, 20);
            this.diskDriveUsage.TabIndex = 2;
            this.diskDriveUsage.Text = "Disk Drive Usage";
            this.diskDriveUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramUsage
            // 
            this.ramUsage.AutoSize = true;
            this.ramUsage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ramUsage.Location = new System.Drawing.Point(557, 99);
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.Size = new System.Drawing.Size(81, 20);
            this.ramUsage.TabIndex = 1;
            this.ramUsage.Text = "RAM Usage";
            this.ramUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuUsage
            // 
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpuUsage.Location = new System.Drawing.Point(318, 99);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(79, 20);
            this.cpuUsage.TabIndex = 0;
            this.cpuUsage.Text = "CPU Usage";
            this.cpuUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(12, 438);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(40, 15);
            this.about.TabIndex = 11;
            this.about.TabStop = true;
            this.about.Text = "About";
            this.about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.about_LinkClicked);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(822, 469);
            this.Controls.Add(this.about);
            this.Controls.Add(this.all_tab);
            this.Controls.Add(this.performanceButton);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.title);
            this.Name = "app";
            this.Text = "CloudSys Monitor";
            this.all_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Button getInfoButton;
        private Button performanceButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabControl all_tab;
        private TabPage tabPage1;
        private Label osVersionInfo;
        private Label osVersion;
        private Label osInfo;
        private Label os;
        private Label diskDriveSerialNumberInfo;
        private Label diskDriveSerialNumber;
        private Label diskDriveFirmwareRevInfo;
        private Label diskDriveFirmwareRev;
        private Label diskDriveSizeInfo;
        private Label diskDriveSize;
        private Label diskDriveModel;
        private Label diskDriveModelInfo;
        private Label diskDrive;
        private Label gpuDriverVersionInfo;
        private Label gpuDriverVersion;
        private Label gpuVRamInfo;
        private Label gpuVRam;
        private Label gpuCurrentModeInfo;
        private Label gpuCurrentMode;
        private Label gpuName;
        private Label gpuNameInfo;
        private Label gpu;
        private Label ramSpeedInfo;
        private Label ramSpeed;
        private Label ramCapacityInfo;
        private Label ramCapacity;
        private Label ramPartNumberInfo;
        private Label ramPartNumber;
        private Label ramManu;
        private Label ramManuInfo;
        private Label ram;
        private Label biosManuInfo;
        private Label biosManu;
        private Label biosDescInfo;
        private Label biosDesc;
        private Label biosVersionInfo;
        private Label biosVersion;
        private Label bios;
        private Label cpuSocketInfo;
        private Label cpuSocket;
        private Label cpuMaxClockSpeedInfo;
        private Label cpuMaxClockSpeed;
        private Label cpuCoreCountInfo;
        private Label cpuCoreCount;
        private Label motherboardManuInfo;
        private Label motherboardManu;
        private Label motherboardProdInfo;
        private Label cpuName;
        private Label motherboardProd;
        private Label motherboardSerialNumberInfo;
        private Label motherboardSerialNumber;
        private Label cpuNameInfo;
        private Label cpu;
        private Label motherboard;
        private TabPage tabPage2;
        private LinkLabel about;
        private Label cpuUsage;
        private Label diskDriveUsageReadInfo;
        private Label ramUsageAvailableInfo;
        private Label cpuUsageUtilizationInfo;
        private Label diskDriveUsage;
        private Label ramUsage;
        private Label cpuUsageUtilization;
        private Label ramUsageAvailable;
        private Label diskDriveUsageRead;
        private Label diskDriveUsageWrite;
        private Label diskDriveUsageWriteInfo;
        private Label diskDriveUsageActive;
        private Label diskDriveUsageActiveInfo;
        private Label ramUsageCommitted;
        private Label ramUsageCommittedInfo;
        private Label ramUsageCached;
        private Label ramUsageCachedInfo;
        private Label cpuUsageThreads;
        private Label cpuUsageThreadsInfo;
        private Label cpuUsageHandles;
        private Label cpuUsageHandlesInfo;
        private Label cpuUsageProcesses;
        private Label cpuUsageProcessesInfo;
        private Label diskDriveUsageTransfer;
        private Label diskDriveUsageTransferInfo;
        private Label ramUsageInUse;
        private Label ramUsageInUseInfo;
    }
}