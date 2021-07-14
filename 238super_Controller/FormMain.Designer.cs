
namespace _238super_Controller
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (m_lRealHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
            }
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
            }
            if (m_bInitSDK == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listViewMain = new System.Windows.Forms.ListView();
            this.cHeaderMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHeaderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHeaderAlarmZone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHeaderSystemTrouble = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHeaderPanelType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHeaderOp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TB_238Port = new System.Windows.Forms.TextBox();
            this.BT_Shutdown = new System.Windows.Forms.Button();
            this.BT_Start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_Staus = new System.Windows.Forms.TextBox();
            this.BT_Arm = new System.Windows.Forms.Button();
            this.BT_DisArm = new System.Windows.Forms.Button();
            this.TB_238Password = new System.Windows.Forms.TextBox();
            this.BT_GetAppVer = new System.Windows.Forms.Button();
            this.BT_ClearAll = new System.Windows.Forms.Button();
            this.BT_CopyAll = new System.Windows.Forms.Button();
            this.BT_Save2Other = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_EnterDeviceProG = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_ArmMayday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_ClearArmMemory = new System.Windows.Forms.Button();
            this.TB_SetupPassWord = new System.Windows.Forms.TextBox();
            this.BT_LRR = new System.Windows.Forms.Button();
            this.BT_QueryPanelStatus = new System.Windows.Forms.Button();
            this.BT_GetPanelType = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ProGData = new System.Windows.Forms.TextBox();
            this.TB_ProGAddr = new System.Windows.Forms.TextBox();
            this.BT_ExitProG = new System.Windows.Forms.Button();
            this.BT_StartProG = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label_Monitor = new System.Windows.Forms.Label();
            this.label_Emergency = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.BT_Login = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_MonPassWord = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.TB_MonPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BT_ExitDeviceProG = new System.Windows.Forms.Button();
            this.StatusCountLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LoginDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnergencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Label_DeviceCount = new System.Windows.Forms.ToolStripLabel();
            this.axCooMonitorMain = new AxIPModuleLib.AxCooMonitor();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCooMonitorMain)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMain
            // 
            this.listViewMain.CausesValidation = false;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHeaderMac,
            this.cHeaderState,
            this.cHeaderAlarmZone,
            this.cHeaderSystemTrouble,
            this.cHeaderPanelType,
            this.cHeaderOp});
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.GridLines = true;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(17, 25);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(703, 127);
            this.listViewMain.TabIndex = 12;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
            // 
            // cHeaderMac
            // 
            this.cHeaderMac.Text = "主机MAC地址";
            this.cHeaderMac.Width = 135;
            // 
            // cHeaderState
            // 
            this.cHeaderState.Text = "状态";
            this.cHeaderState.Width = 96;
            // 
            // cHeaderAlarmZone
            // 
            this.cHeaderAlarmZone.Text = "AlarmZone";
            this.cHeaderAlarmZone.Width = 85;
            // 
            // cHeaderSystemTrouble
            // 
            this.cHeaderSystemTrouble.Text = "SystemTrouble";
            this.cHeaderSystemTrouble.Width = 95;
            // 
            // cHeaderPanelType
            // 
            this.cHeaderPanelType.Text = "主机类型";
            this.cHeaderPanelType.Width = 95;
            // 
            // cHeaderOp
            // 
            this.cHeaderOp.Text = "操作";
            this.cHeaderOp.Width = 192;
            // 
            // TB_238Port
            // 
            this.TB_238Port.Location = new System.Drawing.Point(23, 48);
            this.TB_238Port.Name = "TB_238Port";
            this.TB_238Port.Size = new System.Drawing.Size(46, 21);
            this.TB_238Port.TabIndex = 20;
            this.TB_238Port.Text = "7838";
            // 
            // BT_Shutdown
            // 
            this.BT_Shutdown.Location = new System.Drawing.Point(184, 28);
            this.BT_Shutdown.Name = "BT_Shutdown";
            this.BT_Shutdown.Size = new System.Drawing.Size(82, 58);
            this.BT_Shutdown.TabIndex = 22;
            this.BT_Shutdown.Text = "关闭报警器";
            this.BT_Shutdown.UseVisualStyleBackColor = true;
            this.BT_Shutdown.Click += new System.EventHandler(this.BT_Shutdown_Click);
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(83, 28);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(82, 58);
            this.BT_Start.TabIndex = 21;
            this.BT_Start.Text = "连接报警器";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewMain);
            this.groupBox1.Location = new System.Drawing.Point(13, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 162);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主机选择区";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BT_Shutdown);
            this.groupBox2.Controls.Add(this.TB_238Port);
            this.groupBox2.Controls.Add(this.BT_Start);
            this.groupBox2.Location = new System.Drawing.Point(13, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 134);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备连接";
            // 
            // TB_Staus
            // 
            this.TB_Staus.Location = new System.Drawing.Point(0, 42);
            this.TB_Staus.Multiline = true;
            this.TB_Staus.Name = "TB_Staus";
            this.TB_Staus.ReadOnly = true;
            this.TB_Staus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Staus.Size = new System.Drawing.Size(926, 115);
            this.TB_Staus.TabIndex = 26;
            // 
            // BT_Arm
            // 
            this.BT_Arm.Location = new System.Drawing.Point(136, 38);
            this.BT_Arm.Name = "BT_Arm";
            this.BT_Arm.Size = new System.Drawing.Size(75, 23);
            this.BT_Arm.TabIndex = 29;
            this.BT_Arm.Text = "布防";
            this.BT_Arm.UseVisualStyleBackColor = true;
            this.BT_Arm.Click += new System.EventHandler(this.BT_Arm_Click);
            // 
            // BT_DisArm
            // 
            this.BT_DisArm.Location = new System.Drawing.Point(136, 89);
            this.BT_DisArm.Name = "BT_DisArm";
            this.BT_DisArm.Size = new System.Drawing.Size(75, 23);
            this.BT_DisArm.TabIndex = 30;
            this.BT_DisArm.Text = "撤防";
            this.BT_DisArm.UseVisualStyleBackColor = true;
            this.BT_DisArm.Click += new System.EventHandler(this.BT_DisArm_Click);
            // 
            // TB_238Password
            // 
            this.TB_238Password.Location = new System.Drawing.Point(18, 40);
            this.TB_238Password.Name = "TB_238Password";
            this.TB_238Password.PasswordChar = '*';
            this.TB_238Password.Size = new System.Drawing.Size(100, 21);
            this.TB_238Password.TabIndex = 31;
            this.TB_238Password.Text = "1234";
            // 
            // BT_GetAppVer
            // 
            this.BT_GetAppVer.Location = new System.Drawing.Point(47, 20);
            this.BT_GetAppVer.Name = "BT_GetAppVer";
            this.BT_GetAppVer.Size = new System.Drawing.Size(104, 36);
            this.BT_GetAppVer.TabIndex = 32;
            this.BT_GetAppVer.Text = "读取版本";
            this.BT_GetAppVer.UseVisualStyleBackColor = true;
            this.BT_GetAppVer.Click += new System.EventHandler(this.BT_GetAppVer_Click);
            // 
            // BT_ClearAll
            // 
            this.BT_ClearAll.Location = new System.Drawing.Point(852, 13);
            this.BT_ClearAll.Name = "BT_ClearAll";
            this.BT_ClearAll.Size = new System.Drawing.Size(75, 23);
            this.BT_ClearAll.TabIndex = 33;
            this.BT_ClearAll.Text = "清除所有";
            this.BT_ClearAll.UseVisualStyleBackColor = true;
            this.BT_ClearAll.Click += new System.EventHandler(this.BT_ClearAll_Click);
            // 
            // BT_CopyAll
            // 
            this.BT_CopyAll.Location = new System.Drawing.Point(758, 13);
            this.BT_CopyAll.Name = "BT_CopyAll";
            this.BT_CopyAll.Size = new System.Drawing.Size(75, 23);
            this.BT_CopyAll.TabIndex = 34;
            this.BT_CopyAll.Text = "复制全部";
            this.BT_CopyAll.UseVisualStyleBackColor = true;
            this.BT_CopyAll.Click += new System.EventHandler(this.BT_CopyAll_Click);
            // 
            // BT_Save2Other
            // 
            this.BT_Save2Other.Location = new System.Drawing.Point(662, 13);
            this.BT_Save2Other.Name = "BT_Save2Other";
            this.BT_Save2Other.Size = new System.Drawing.Size(75, 23);
            this.BT_Save2Other.TabIndex = 35;
            this.BT_Save2Other.Text = "另存为";
            this.BT_Save2Other.UseVisualStyleBackColor = true;
            this.BT_Save2Other.Click += new System.EventHandler(this.BT_Save2Other_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(561, 13);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 23);
            this.BT_Save.TabIndex = 36;
            this.BT_Save.Text = "保存";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BT_EnterDeviceProG);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BT_ArmMayday);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.BT_ClearArmMemory);
            this.groupBox3.Controls.Add(this.BT_Arm);
            this.groupBox3.Controls.Add(this.TB_SetupPassWord);
            this.groupBox3.Controls.Add(this.BT_DisArm);
            this.groupBox3.Controls.Add(this.TB_238Password);
            this.groupBox3.Location = new System.Drawing.Point(431, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 174);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "布撤防";
            // 
            // BT_EnterDeviceProG
            // 
            this.BT_EnterDeviceProG.Location = new System.Drawing.Point(136, 132);
            this.BT_EnterDeviceProG.Name = "BT_EnterDeviceProG";
            this.BT_EnterDeviceProG.Size = new System.Drawing.Size(97, 32);
            this.BT_EnterDeviceProG.TabIndex = 51;
            this.BT_EnterDeviceProG.Text = "进入设备编程";
            this.BT_EnterDeviceProG.UseVisualStyleBackColor = true;
            this.BT_EnterDeviceProG.Click += new System.EventHandler(this.BT_EnterDeviceProG_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "安装员编程:";
            // 
            // BT_ArmMayday
            // 
            this.BT_ArmMayday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BT_ArmMayday.ForeColor = System.Drawing.Color.Crimson;
            this.BT_ArmMayday.Location = new System.Drawing.Point(241, 25);
            this.BT_ArmMayday.Name = "BT_ArmMayday";
            this.BT_ArmMayday.Size = new System.Drawing.Size(168, 87);
            this.BT_ArmMayday.TabIndex = 1;
            this.BT_ArmMayday.Text = "启动紧急报警";
            this.BT_ArmMayday.UseVisualStyleBackColor = true;
            this.BT_ArmMayday.Click += new System.EventHandler(this.BT_ArmMayday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "布撤防密码";
            // 
            // BT_ClearArmMemory
            // 
            this.BT_ClearArmMemory.Location = new System.Drawing.Point(18, 80);
            this.BT_ClearArmMemory.Name = "BT_ClearArmMemory";
            this.BT_ClearArmMemory.Size = new System.Drawing.Size(95, 33);
            this.BT_ClearArmMemory.TabIndex = 0;
            this.BT_ClearArmMemory.Text = "清除报警记忆";
            this.BT_ClearArmMemory.UseVisualStyleBackColor = true;
            this.BT_ClearArmMemory.Click += new System.EventHandler(this.BT_ClearArmMemory_Click);
            // 
            // TB_SetupPassWord
            // 
            this.TB_SetupPassWord.Location = new System.Drawing.Point(18, 143);
            this.TB_SetupPassWord.Name = "TB_SetupPassWord";
            this.TB_SetupPassWord.PasswordChar = '*';
            this.TB_SetupPassWord.Size = new System.Drawing.Size(63, 21);
            this.TB_SetupPassWord.TabIndex = 46;
            this.TB_SetupPassWord.Text = "012345";
            // 
            // BT_LRR
            // 
            this.BT_LRR.Location = new System.Drawing.Point(47, 65);
            this.BT_LRR.Name = "BT_LRR";
            this.BT_LRR.Size = new System.Drawing.Size(104, 36);
            this.BT_LRR.TabIndex = 38;
            this.BT_LRR.Text = "LRR地址";
            this.BT_LRR.UseVisualStyleBackColor = true;
            this.BT_LRR.Click += new System.EventHandler(this.BT_LRR_Click);
            // 
            // BT_QueryPanelStatus
            // 
            this.BT_QueryPanelStatus.Location = new System.Drawing.Point(47, 111);
            this.BT_QueryPanelStatus.Name = "BT_QueryPanelStatus";
            this.BT_QueryPanelStatus.Size = new System.Drawing.Size(104, 36);
            this.BT_QueryPanelStatus.TabIndex = 39;
            this.BT_QueryPanelStatus.Text = "查询状态";
            this.BT_QueryPanelStatus.UseVisualStyleBackColor = true;
            this.BT_QueryPanelStatus.Click += new System.EventHandler(this.BT_QueryPanelStatus_Click);
            // 
            // BT_GetPanelType
            // 
            this.BT_GetPanelType.Location = new System.Drawing.Point(47, 153);
            this.BT_GetPanelType.Name = "BT_GetPanelType";
            this.BT_GetPanelType.Size = new System.Drawing.Size(104, 36);
            this.BT_GetPanelType.TabIndex = 40;
            this.BT_GetPanelType.Text = "查询主机类型";
            this.BT_GetPanelType.UseVisualStyleBackColor = true;
            this.BT_GetPanelType.Click += new System.EventHandler(this.BT_GetPanelType_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BT_GetAppVer);
            this.groupBox5.Controls.Add(this.BT_LRR);
            this.groupBox5.Controls.Add(this.BT_GetPanelType);
            this.groupBox5.Controls.Add(this.BT_QueryPanelStatus);
            this.groupBox5.Location = new System.Drawing.Point(471, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 200);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "硬件信息查询";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.TB_ProGData);
            this.groupBox6.Controls.Add(this.TB_ProGAddr);
            this.groupBox6.Controls.Add(this.BT_ExitProG);
            this.groupBox6.Controls.Add(this.BT_StartProG);
            this.groupBox6.Location = new System.Drawing.Point(122, 68);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(278, 189);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "编程部分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "编程号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "编程地址:";
            // 
            // TB_ProGData
            // 
            this.TB_ProGData.Location = new System.Drawing.Point(140, 71);
            this.TB_ProGData.Name = "TB_ProGData";
            this.TB_ProGData.Size = new System.Drawing.Size(57, 21);
            this.TB_ProGData.TabIndex = 48;
            this.TB_ProGData.Text = "123456";
            // 
            // TB_ProGAddr
            // 
            this.TB_ProGAddr.Location = new System.Drawing.Point(140, 40);
            this.TB_ProGAddr.Name = "TB_ProGAddr";
            this.TB_ProGAddr.Size = new System.Drawing.Size(57, 21);
            this.TB_ProGAddr.TabIndex = 47;
            this.TB_ProGAddr.Text = "00";
            // 
            // BT_ExitProG
            // 
            this.BT_ExitProG.Location = new System.Drawing.Point(146, 111);
            this.BT_ExitProG.Name = "BT_ExitProG";
            this.BT_ExitProG.Size = new System.Drawing.Size(104, 50);
            this.BT_ExitProG.TabIndex = 44;
            this.BT_ExitProG.Text = "退出编程";
            this.BT_ExitProG.UseVisualStyleBackColor = true;
            this.BT_ExitProG.Click += new System.EventHandler(this.BT_ExitProG_Click);
            // 
            // BT_StartProG
            // 
            this.BT_StartProG.Location = new System.Drawing.Point(27, 111);
            this.BT_StartProG.Name = "BT_StartProG";
            this.BT_StartProG.Size = new System.Drawing.Size(104, 50);
            this.BT_StartProG.TabIndex = 43;
            this.BT_StartProG.Text = "指令输入";
            this.BT_StartProG.UseVisualStyleBackColor = true;
            this.BT_StartProG.Click += new System.EventHandler(this.BT_StartProG_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 359);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登录界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(756, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "两个设备都开启才可正常工作！";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label_Monitor);
            this.groupBox7.Controls.Add(this.label_Emergency);
            this.groupBox7.Location = new System.Drawing.Point(759, 180);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(131, 137);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "工作状态";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "设备运行状态：未工作";
            // 
            // label_Monitor
            // 
            this.label_Monitor.AutoSize = true;
            this.label_Monitor.Location = new System.Drawing.Point(6, 60);
            this.label_Monitor.Name = "label_Monitor";
            this.label_Monitor.Size = new System.Drawing.Size(77, 12);
            this.label_Monitor.TabIndex = 1;
            this.label_Monitor.Text = "监控：未登录";
            // 
            // label_Emergency
            // 
            this.label_Emergency.AutoSize = true;
            this.label_Emergency.Location = new System.Drawing.Point(6, 26);
            this.label_Emergency.Name = "label_Emergency";
            this.label_Emergency.Size = new System.Drawing.Size(89, 12);
            this.label_Emergency.TabIndex = 0;
            this.label_Emergency.Text = "报警器：未开启";
            this.label_Emergency.Click += new System.EventHandler(this.label_Emergency_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.BT_Login);
            this.groupBox8.Controls.Add(this.labelLogin);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.TB_UserName);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.TB_MonPassWord);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.TB_IP);
            this.groupBox8.Controls.Add(this.TB_MonPort);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Location = new System.Drawing.Point(329, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(561, 149);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "监控登录";
            // 
            // BT_Login
            // 
            this.BT_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_Login.Location = new System.Drawing.Point(461, 60);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(78, 50);
            this.BT_Login.TabIndex = 38;
            this.BT_Login.Text = "登录";
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(113, 122);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(113, 12);
            this.labelLogin.TabIndex = 48;
            this.labelLogin.Text = "登录状态（异步）：";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Device IP";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(86, 89);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(114, 21);
            this.TB_UserName.TabIndex = 41;
            this.TB_UserName.Text = "admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "用户名";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(242, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Device Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 44;
            this.label6.Text = "设备端口";
            // 
            // TB_MonPassWord
            // 
            this.TB_MonPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_MonPassWord.Location = new System.Drawing.Point(316, 89);
            this.TB_MonPassWord.Name = "TB_MonPassWord";
            this.TB_MonPassWord.PasswordChar = '*';
            this.TB_MonPassWord.Size = new System.Drawing.Size(112, 21);
            this.TB_MonPassWord.TabIndex = 42;
            this.TB_MonPassWord.Text = "qht20001120";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(20, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "User Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "摄像头登录";
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(86, 43);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(114, 21);
            this.TB_IP.TabIndex = 39;
            this.TB_IP.Text = "192.168.0.200";
            // 
            // TB_MonPort
            // 
            this.TB_MonPort.Location = new System.Drawing.Point(316, 43);
            this.TB_MonPort.Name = "TB_MonPort";
            this.TB_MonPort.Size = new System.Drawing.Size(112, 21);
            this.TB_MonPort.TabIndex = 40;
            this.TB_MonPort.Text = "8000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 46;
            this.label8.Text = "密码";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(242, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "设备IP";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.RealPlayWnd);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "监控界面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(710, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "紧急报警：正常";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(581, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 16);
            this.label18.TabIndex = 39;
            this.label18.Text = "防区3：正常";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(428, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "防区2 ：正常";
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd.Location = new System.Drawing.Point(6, 18);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(374, 296);
            this.RealPlayWnd.TabIndex = 5;
            this.RealPlayWnd.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BT_ExitDeviceProG);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(922, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "设备编程界面";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BT_ExitDeviceProG
            // 
            this.BT_ExitDeviceProG.Location = new System.Drawing.Point(814, 265);
            this.BT_ExitDeviceProG.Name = "BT_ExitDeviceProG";
            this.BT_ExitDeviceProG.Size = new System.Drawing.Size(87, 50);
            this.BT_ExitDeviceProG.TabIndex = 43;
            this.BT_ExitDeviceProG.Text = "退出设备编程";
            this.BT_ExitDeviceProG.UseVisualStyleBackColor = true;
            this.BT_ExitDeviceProG.Click += new System.EventHandler(this.BT_ExitDeviceProG_Click);
            // 
            // StatusCountLabel
            // 
            this.StatusCountLabel.AutoSize = true;
            this.StatusCountLabel.Location = new System.Drawing.Point(6, 179);
            this.StatusCountLabel.Name = "StatusCountLabel";
            this.StatusCountLabel.Size = new System.Drawing.Size(65, 12);
            this.StatusCountLabel.TabIndex = 27;
            this.StatusCountLabel.Text = "连接数量：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TB_Staus);
            this.groupBox4.Controls.Add(this.BT_ClearAll);
            this.groupBox4.Controls.Add(this.BT_CopyAll);
            this.groupBox4.Controls.Add(this.BT_Save2Other);
            this.groupBox4.Controls.Add(this.BT_Save);
            this.groupBox4.Controls.Add(this.StatusCountLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(930, 160);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "状态信息";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginDeviceToolStripMenuItem,
            this.MonitorToolStripMenuItem,
            this.EnergencyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LoginDeviceToolStripMenuItem
            // 
            this.LoginDeviceToolStripMenuItem.Name = "LoginDeviceToolStripMenuItem";
            this.LoginDeviceToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.LoginDeviceToolStripMenuItem.Text = "登录设备";
            this.LoginDeviceToolStripMenuItem.Click += new System.EventHandler(this.LoginDeviceToolStripMenuItem_Click);
            // 
            // MonitorToolStripMenuItem
            // 
            this.MonitorToolStripMenuItem.Enabled = false;
            this.MonitorToolStripMenuItem.Name = "MonitorToolStripMenuItem";
            this.MonitorToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.MonitorToolStripMenuItem.Text = "监控报警";
            this.MonitorToolStripMenuItem.Click += new System.EventHandler(this.MonitorToolStripMenuItem_Click);
            // 
            // EnergencyToolStripMenuItem
            // 
            this.EnergencyToolStripMenuItem.Enabled = false;
            this.EnergencyToolStripMenuItem.Name = "EnergencyToolStripMenuItem";
            this.EnergencyToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.EnergencyToolStripMenuItem.Text = "报警器设置";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.Image = global::_238super_Controller.Properties.Resources._14120750;
            this.btnHelp.Location = new System.Drawing.Point(911, 26);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(26, 26);
            this.btnHelp.TabIndex = 45;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(787, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 46;
            this.label14.Text = "软件使用指南→";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label_DeviceCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 560);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(942, 25);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Label_DeviceCount
            // 
            this.Label_DeviceCount.Name = "Label_DeviceCount";
            this.Label_DeviceCount.Size = new System.Drawing.Size(74, 22);
            this.Label_DeviceCount.Text = "连接数目 : 0";
            // 
            // axCooMonitorMain
            // 
            this.axCooMonitorMain.Enabled = true;
            this.axCooMonitorMain.Location = new System.Drawing.Point(1244, 202);
            this.axCooMonitorMain.Name = "axCooMonitorMain";
            this.axCooMonitorMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCooMonitorMain.OcxState")));
            this.axCooMonitorMain.Size = new System.Drawing.Size(192, 192);
            this.axCooMonitorMain.TabIndex = 28;
            this.axCooMonitorMain.Visible = false;
            this.axCooMonitorMain.DeviceConnected += new AxIPModuleLib._ICooMonitorEvents_DeviceConnectedEventHandler(this.axCooMonitorMain_DeviceConnected);
            this.axCooMonitorMain.DeviceDisConnected += new AxIPModuleLib._ICooMonitorEvents_DeviceDisConnectedEventHandler(this.axCooMonitorMain_DeviceDisConnected);
            this.axCooMonitorMain.PanelStatus += new AxIPModuleLib._ICooMonitorEvents_PanelStatusEventHandler(this.axCooMonitorMain_PanelStatus);
            this.axCooMonitorMain.AppVerQueryResult += new AxIPModuleLib._ICooMonitorEvents_AppVerQueryResultEventHandler(this.axCooMonitorMain_AppVerQueryResult);
            this.axCooMonitorMain.PanelStatusEx += new AxIPModuleLib._ICooMonitorEvents_PanelStatusExEventHandler(this.axCooMonitorMain_PanelStatusEx);
            this.axCooMonitorMain.LRRQueryResult += new AxIPModuleLib._ICooMonitorEvents_LRRQueryResultEventHandler(this.axCooMonitor1_LRRQueryAddr);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 585);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.axCooMonitorMain);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "主机控制器（邱瀚天）";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCooMonitorMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader cHeaderMac;
        private System.Windows.Forms.ColumnHeader cHeaderState;
        private System.Windows.Forms.ColumnHeader cHeaderAlarmZone;
        private System.Windows.Forms.ColumnHeader cHeaderSystemTrouble;
        private System.Windows.Forms.ColumnHeader cHeaderPanelType;
        private System.Windows.Forms.ColumnHeader cHeaderOp;
        private System.Windows.Forms.TextBox TB_238Port;
        private System.Windows.Forms.Button BT_Shutdown;
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_Staus;
        private AxIPModuleLib.AxCooMonitor axCooMonitorMain;
        private System.Windows.Forms.Button BT_Arm;
        private System.Windows.Forms.Button BT_DisArm;
        private System.Windows.Forms.TextBox TB_238Password;
        private System.Windows.Forms.Button BT_GetAppVer;
        private System.Windows.Forms.Button BT_ClearAll;
        private System.Windows.Forms.Button BT_CopyAll;
        private System.Windows.Forms.Button BT_Save2Other;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_LRR;
        private System.Windows.Forms.Button BT_QueryPanelStatus;
        private System.Windows.Forms.Button BT_GetPanelType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_ProGData;
        private System.Windows.Forms.TextBox TB_ProGAddr;
        private System.Windows.Forms.TextBox TB_SetupPassWord;
        private System.Windows.Forms.Button BT_ExitProG;
        private System.Windows.Forms.Button BT_StartProG;
        private System.Windows.Forms.Button BT_ArmMayday;
        private System.Windows.Forms.Button BT_ClearArmMemory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox RealPlayWnd;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_MonPassWord;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox TB_MonPort;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label StatusCountLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem LoginDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EnergencyToolStripMenuItem;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Label_DeviceCount;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_Monitor;
        private System.Windows.Forms.Label label_Emergency;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BT_EnterDeviceProG;
        private System.Windows.Forms.Button BT_ExitDeviceProG;
        private System.Windows.Forms.Label label19;
    }
}

