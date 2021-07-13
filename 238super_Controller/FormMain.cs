using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using IPModuleLib;
using System.IO;

using System.Xml.Linq;


namespace _238super_Controller
{
    
    public partial class FormMain : Form
    {

        public FormMain()
        {

            InitializeComponent();

            {

                m_bInitSDK = CHCNetSDK.NET_DVR_Init();
                if (m_bInitSDK == false)
                {
                    MessageBox.Show("NET_DVR_Init error!");
                    return;
                }
                else
                {
                    //保存SDK日志 To save the SDK log
                    CHCNetSDK.NET_DVR_SetLogToFile(3, "G:/StudyData/EmergencyMonitor/238super_Controller/238super_Controller\bin", true);
                }
            }//监控部分
        }
        
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            tabPage1.Parent = this.tabControl1;
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            BT_ArmMayday.Enabled = false;
            
            TB_ProGAddr.Enabled = false;
            TB_ProGData.Enabled = false;
            BT_ExitProG.Enabled = false;
            button3.Enabled = false;
        }

        private void WorkStaus()
        {
            if (EmergencyLoginStaus == 1 && m_LoginStaus == 1)
            {
                this.MonitorToolStripMenuItem.Enabled = true;
                label15.Text = "设备运行状态：已工作";
            }
            else
            {
                this.MonitorToolStripMenuItem.Enabled = false;
            }
        }

        private void MonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.Parent = null;
            tabPage2.Parent = this.tabControl1;
            tabPage3.Parent = null;
        }

        private void LoginDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.Parent = this.tabControl1;
            tabPage2.Parent = null;
            tabPage3.Parent = null;
        }

        #region 238super

        private int EmergencyLoginStaus;

        private void BT_Start_Click(object sender, EventArgs e) //开始连接
        {
            //axCooMonitorMain.Port = int.Parse(textBoxPort.Text);
            axCooMonitorMain.Port = 7838;
            try
            {
                axCooMonitorMain.Startup();
            }
            catch
            {
                MessageBox.Show("打开失败");
            }

            BT_Start.Enabled = false;
            listViewMain.Items.Clear();
            
        }




        private void BT_Shutdown_Click(object sender, EventArgs e)  //断开连接
        {
            axCooMonitorMain.Shutdown();
            BT_Start.Enabled = true;
            WorkStaus();
        }


        private void axCooMonitorMain_DeviceConnected(object sender, AxIPModuleLib._ICooMonitorEvents_DeviceConnectedEvent e)  //连接设备后返回信息
        {
            if (!listViewMain.Items.ContainsKey(e.strMac))
            {
                ListViewItem item = new ListViewItem(e.strMac);
                item.Checked = false;
                item.Name = e.strMac;       //Key
                item.SubItems.Add("...");   //状态
                item.SubItems.Add("");      //Alarm
                item.SubItems.Add("");      //Toruble
                item.SubItems.Add("");      //Type
                item.SubItems.Add("");      //操作
                listViewMain.Items.Add(item);
                Label_DeviceCount.Text = "连接数量：" + listViewMain.Items.Count.ToString();
                EmergencyLoginStaus = listViewMain.Items.Count;  //记录报警器状态
                if (EmergencyLoginStaus == 1)
                {
                    label_Emergency.Text = "报警器：" + "已开启";
                }

                //PanelType panelType = axCooMonitorMain.GetPanelType(item.Name);
                //item.SubItems[4].Text = panelType.ToString();
                
                int nId = listViewMain.Items.IndexOfKey(e.strMac);
                PanelType panelType = axCooMonitorMain.GetPanelType(e.strMac);
                listViewMain.Items[nId].SubItems[4].Text = panelType.ToString();                                               
                WorkStaus();
            }
        }

        private void axCooMonitorMain_DeviceDisConnected(object sender, AxIPModuleLib._ICooMonitorEvents_DeviceDisConnectedEvent e)  //断开连接后返回信息
        {
            PanelType panelType = axCooMonitorMain.GetPanelType(e.strMac);
            listViewMain.Items.RemoveByKey(e.strMac);
            Label_DeviceCount.Text = "连接数量：" + listViewMain.Items.Count.ToString();
            EmergencyLoginStaus = listViewMain.Items.Count;     //记录报警器状态
            if (EmergencyLoginStaus == 0)
            {
                label_Emergency.Text = "报警器：" + "未开启";
            }
            String sText = panelType.ToString() + "型主机" + e.strMac + "断开连接!" + "\r\n";
            TB_Staus.AppendText(sText);
            //dsMaster.Enabled = false;
            WorkStaus();
        }

        private string ByteToBinary(byte nValue)  //
        {
            string sByte = "";
            for (int i = 7; i >= 0; i--)
            {
                sByte += ((byte)(nValue >> i) & 0x01).ToString();
            }
            return sByte;

        }

        private void BT_Arm_Click(object sender, EventArgs e)  //布防按钮
        {
            TextBox tbPW = TB_238Password;
            if (sender == BT_Arm)
                tbPW = TB_238Password;

            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                int nRelult = axCooMonitorMain.FCSendCtrlCmd(listViewMain.Items[i].Name, FC_Ctrl_Type.FC_CTRL_ARM, tbPW.Text.Trim());
                listViewMain.Items[i].SubItems[2].Text = nRelult == 1 ? "成功(1)" : "失败(0)";
                listViewMain.Items[i].SubItems[5].Text = "普通布防";
                if (nRelult == 1)
                {
                    listViewMain.Items[i].SubItems[1].Text = "布防";
                    BT_ArmMayday.Enabled = true;
                }
                    
                String sText = "主机" + listViewMain.Items[i].Name + "布防" + listViewMain.Items[i].SubItems[5].Text + "\r\n";
                TB_Staus.AppendText(sText);
                //enableArmBtn(false);
            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }

        private void BT_DisArm_Click(object sender, EventArgs e) //撤防按钮
        {
            TextBox tbPW = TB_238Password;
            if (sender == BT_Arm)
                tbPW = TB_238Password;

            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                int nRelult = axCooMonitorMain.FCSendCtrlCmd(listViewMain.Items[i].Name, FC_Ctrl_Type.FC_CTRL_DISARM, tbPW.Text.Trim());
                listViewMain.Items[i].SubItems[2].Text = nRelult == 1 ? "成功(1)" : "失败(0)";
                listViewMain.Items[i].SubItems[5].Text = "普通撤防";
                if (nRelult == 1)
                {
                    listViewMain.Items[i].SubItems[1].Text = "撤防";
                    BT_ArmMayday.Enabled = false;
                }
                    
                String sText = "主机" + listViewMain.Items[i].Name + "撤防" + listViewMain.Items[i].SubItems[5].Text + "\r\n";
                TB_Staus.AppendText(sText);
                //enableArmBtn(true);

            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }


        
        private void axCooMonitorMain_AppVerQueryResult(object sender, AxIPModuleLib._ICooMonitorEvents_AppVerQueryResultEvent e) //返回版本信息
        {
            int nId = listViewMain.Items.IndexOfKey(e.strMac);
            if (nId == -1)
            {
                return;
            }
            listViewMain.Items[nId].SubItems[5].Text = "当前版本:" + (e.lSuccess == 1 ? e.strAppVer : "(获取错误)");
            String sText = DateTime.Now.ToString() + "当前版本:" + (e.lSuccess == 1 ? e.strAppVer : "(获取错误)") + "\r\n";
            TB_Staus.AppendText(sText);
        }

        private void BT_Save_Click(object sender, EventArgs e)  //储存信息按钮
        {
            String strDirect = "..\\SDKDemo" + DateTime.Now.ToString("yyyy-MM-dd") + "_Manual";
            if (!Directory.Exists(strDirect))
            {
                Directory.CreateDirectory(strDirect);
            }


            String strFN = strDirect + "\\SDKDemo" + DateTime.Now.ToString("yyyy-MM-dd");
            String strFM = strFN;
            int iFileNo = 0;

            strFM = strFN + "(" + (iFileNo++).ToString() + ")" + "_manual.txt";
            while (File.Exists(strFM))
            {
                strFM = strFN + "(" + (iFileNo++).ToString() + ")" + "_manual.txt";
            }


            StreamWriter sw = new StreamWriter(strFM);
            sw.Write("保存时间：" + DateTime.Now.ToString() + "\r\n" + "\r\n" + TB_Staus.Text);
            sw.Close();

            MessageBox.Show("文件已保存至工程目录下:" + strFM + "\r\n" + "保存时间" + DateTime.Now.ToString());
        }

        private void AutoSaveToTime()  //自动存储
        {
            String strDirect = "..\\SDKDemo" + DateTime.Now.ToString("yyyy-MM-dd") + "_Auto";
            if (!Directory.Exists(strDirect))
            {
                Directory.CreateDirectory(strDirect);
            }


            String strFN = strDirect + "\\SDKDemo" + DateTime.Now.ToString("yyyy-MM-dd");
            String strFM = strFN;
            int iFileNo = 0;

            strFM = strFN + "(" + (iFileNo++).ToString() + ")" + "_auto.txt";
            while (File.Exists(strFM))
            {
                strFM = strFN + "(" + (iFileNo++).ToString() + ")" + "_auto.txt";
            }


            StreamWriter sw = new StreamWriter(strFM);
            sw.Write("保存时间：" + DateTime.Now.ToString() + "\r\n" + "\r\n" + TB_Staus.Text);
            sw.Close();

            //  MessageBox.Show("文件已保存至工程目录下:" + strFM + "\r\n" + "保存时间" + DateTime.Now.ToString());


        }

        #region 状态栏四按钮

        private void BT_Save2Other_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.FileName = DateTime.Now.ToUniversalTime().ToString();
                String fName = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(TB_Staus.Text);
                sw.Close();

            }
        }

        private void BT_CopyAll_Click(object sender, EventArgs e)
        {
            TB_Staus.SelectAll();
            TB_Staus.Copy();
        }

        private void BT_ClearAll_Click(object sender, EventArgs e)
        {
            TB_Staus.Clear();
        }

        #endregion

        private void BT_EnterDeviceProG_Click(object sender, EventArgs e)
        {
            if (int.Parse(TB_SetupPassWord.Text) == 012345)
            {
                this.EnergencyToolStripMenuItem.Enabled = true;
                MessageBox.Show("密码正确", "提示");
                tabPage1.Parent = null;
                tabPage2.Parent = null;
                tabPage3.Parent = this.tabControl1;         
            }
            else
            {
                MessageBox.Show("密码错误，请检查密码是否已经被修改", "提示");
            }
        }

        private void BT_ExitDeviceProG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要退出设备编程？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                tabPage1.Parent = null;
                tabPage2.Parent = this.tabControl1;
                tabPage3.Parent = null;
                this.EnergencyToolStripMenuItem.Enabled = false;
            }
            
        }

        private void BT_GetAppVer_Click(object sender, EventArgs e)  //获取版本按钮
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                axCooMonitorMain.QueryAppVersion(listViewMain.Items[i].Name);
                String sText = "主机" + listViewMain.Items[i].Name + "读取版本\r\n";
                TB_Staus.AppendText(sText);
            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }

        private void BT_LRR_Click(object sender, EventArgs e)  //获取LRR地址
        {
            if (listViewMain.SelectedItems.Count > 0)
            {

                int i = listViewMain.SelectedItems[0].Index;
                int nRelult = axCooMonitorMain.QueryLRRAddr(listViewMain.Items[0].Name);
                listViewMain.Items[i].SubItems[2].Text = nRelult == 1 ? "成功(1)" : "失败(0)";
                String sText = "主机" + listViewMain.Items[i].Name + "获得LRR地址服务器操作" + (nRelult == 1 ? "成功(1)" : "失败(0)").ToString() + "\r\n";
                TB_Staus.AppendText(sText);
            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }

        
        private void axCooMonitor1_LRRQueryAddr(object sender, AxIPModuleLib._ICooMonitorEvents_LRRQueryResultEvent e) //查询LRR地址结果
        {
            int nId = listViewMain.Items.IndexOfKey(e.strMac);
            if (nId == -1)
            {
                return;
            }
            listViewMain.Items[nId].SubItems[5].Text = "获得LRR地址结果";
            String sText = "主机" + listViewMain.Items[nId].Name + "LRR地址结果：" + "\r\n";
            sText += "lsuccess:" + e.lSuccess.ToString() + "\r\n";
            sText += "LRR：" + e.lRR.ToString() + "\r\n";
            TB_Staus.AppendText(sText);

        }

        private void BT_GetPanelType_Click(object sender, EventArgs e)   //查询主机类型
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                PanelType panelType = axCooMonitorMain.GetPanelType(listViewMain.Items[i].Name);
                listViewMain.Items[i].SubItems[4].Text = panelType.ToString();
                String sText = "主机" + listViewMain.Items[i].Name + "查询主机类型完成\r\n";
                sText += "主机类型：" + panelType.ToString() + "\r\n";
                TB_Staus.AppendText(sText);
            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }

        private void BT_QueryPanelStatus_Click(object sender, EventArgs e) //查询状态
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                // int nRelult = axCooMonitorMain.RaiseZoneStatus(listViewMain.Items[i].Name,ZoneType.AlarmZone);
                int nRelult = axCooMonitorMain.RaiseZoneStatusEx(listViewMain.Items[i].Name);
                listViewMain.Items[i].SubItems[2].Text = nRelult == 1 ? "成功(1)" : "失败(0)";
                String sText = "主机" + listViewMain.Items[i].Name + listViewMain.Items[i].SubItems[5].Text + "查询状态EX\r\n";
                TB_Staus.AppendText(sText);
            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }

        private void axCooMonitorMain_PanelStatus(object sender, AxIPModuleLib._ICooMonitorEvents_PanelStatusEvent e) //状态查询函数
        {
            int nId = listViewMain.Items.IndexOfKey(e.strMac);
            if (nId == -1)
            {
                return;
            }
            String sText = DateTime.Now.ToString() + "主机" + listViewMain.Items[nId].Name + "状态查询结果：" + "\r\n";
            if (e.zt == ZoneType.SystemTrouble)
            {
                listViewMain.Items[nId].SubItems[1].Text = ((e.zoneBit & 0x80) > 0) ? "(布防)" : "撤防";
                if ((e.zoneBit & 0x80) > 0)
                {
                    //enableArmBtn(false);
                    //enableDsarmBtn(true);
                }
                else
                {
                    //enableArmBtn(true);
                    //enableDsarmBtn(false);
                }
                listViewMain.Items[nId].SubItems[3].Text = ByteToBinary((byte)(e.zoneBit & 0xFF));
                for (int i = 0; i < 8; i++)
                {
                    if ((e.zoneBit & (0x01 << i)) == (0x01 << i))
                    {
                        switch (i + 1)
                        {
                            case 1:
                                sText += "电池电压低\r\n";
                                break;
                            case 2:
                                sText += "AC Power Fail\r\n";
                                break;
                            case 3:
                                sText += "Bell Fuse Fail\r\n";
                                break;
                            case 4:
                                sText += "Kill\r\n";
                                break;
                            case 5:
                                sText += "Condition\r\n";
                                break;
                            case 6:
                                sText += "Connection Fail\r\n";
                                break;
                            case 7:
                                sText += "Watchdog Reset\r\n";
                                break;
                            case 8:
                                sText += "Armed\r\n";
                                break;
                        }
                    }
                }
            }
            else if (e.zt == ZoneType.AlarmZone)
            {
                if ((e.zoneBit & 0x80) > 0)
                {
                    //enableArmBtn(false);
                    //enableDsarmBtn(true);
                }
                else
                {
                    //enableArmBtn(true);
                    //enableDsarmBtn(false);
                }
                listViewMain.Items[nId].SubItems[2].Text = ByteToBinary((byte)(e.zoneBit & 0xFF));
                for (int i = 0; i < 8; i++)
                {
                    if ((e.zoneBit & (0x01 << i)) == (0x01 << i))
                    {
                        switch (i + 1)
                        {
                            case 1:
                                sText += "Bell = 1\r\n";
                                break;
                            case 2:
                                sText += "Chime = 2\r\n";
                                break;
                            case 3:
                                sText += "Instant\r\n";
                                break;
                            case 4:
                                sText += "AC LED\r\n";
                                break;
                            case 5:
                                sText += "Program Mode\r\n";
                                break;
                            case 6:
                                sText += "Test Report\r\n";
                                break;
                            case 7:
                                sText += "Battery Test\r\n";
                                break;
                            case 8:
                                sText += "Walk Test\r\n";
                                break;
                        }
                    }
                }
            }

            listViewMain.Items[nId].SubItems[5].Text = "状态查询结果";

            sText += "状态发生时间：" + e.strTime.ToString() + "\r\n";
            sText += "lPlayback:" + e.lPlayback.ToString() + "\r\n";
            sText += "防区类型：" + e.zt.ToString() + "\r\n";
            sText += "zonebit:" + e.zoneBit.ToString() + "\r\n";

            TB_Staus.AppendText(sText);
        }

        private void axCooMonitorMain_PanelStatusEx(object sender, AxIPModuleLib._ICooMonitorEvents_PanelStatusExEvent e)
        {
            int nId = listViewMain.Items.IndexOfKey(e.strMac);
            if (nId == -1)
            {
                return;
            }

            listViewMain.Items[nId].SubItems[5].Text = "状态查询结果EX";
            String sText = DateTime.Now.ToString() + "主机" + listViewMain.Items[nId].Name + "状态查询结果EX：" + "\r\n";
            sText += "状态发生时间：" + e.strTime.ToString() + "\r\n";
            sText += "lPlayback:" + e.lPlayback.ToString() + "\r\n";
            sText += "AlarmBit：" + e.alarmBit.ToString() + "\r\n";
            sText += "FaultBit:" + e.faultBit.ToString() + "\r\n";
            sText += "TroubleBit：" + e.troubleBit.ToString() + "\r\n";
            sText += "BypassBit:" + e.byPassedBit.ToString() + "\r\n";
            TB_Staus.AppendText(sText);
            switch (e.alarmBit)
            {
                case 2: 
                    label17.Text = "防区2：异常";
                    this.label17.ForeColor = Color.Red;
                    break;
                case 4: 
                    label18.Text = "防区3：异常";
                    this.label18.ForeColor = Color.Red;
                    break;
                case 6:  
                    label17.Text = "防区2：异常";
                    label18.Text = "防区3：异常";
                    this.label17.ForeColor = Color.Red;
                    this.label18.ForeColor = Color.Red;
                    break;
                default:
                    label17.Text = "防区2：正常";
                    label18.Text = "防区3：正常";
                    this.label17.ForeColor = Color.Black;
                    this.label18.ForeColor = Color.Black;
                    break;
            }
            
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)  //点击框图选择报警器
        {
            String PanelType = "middlestat";
            if (listViewMain.SelectedItems.Count > 0)
                PanelType = this.listViewMain.SelectedItems[0].SubItems[4].Text;


            /*  PT_23 = 0,
              PT_Vista = 1,
              PT_MCM23 = 2,
              PT_MCMVista = 3,
              PT_FullControl23 = 4,
              PT_FullControlMCM23 = 5,
              PT_IPMPRO_Vista = 6,
              PT_IPM_Vista_SuperII = 7,
              PT_Compact4 = 8,
              PT_Victrix = 48,
              PT_Victrix_6 = 49,
              PT_Victrix_2 = 50,
              PT_IPRELAY = 250,
              PT_Unknown = 255,*/
            switch (PanelType)
            {
                case "PT_FullControl23":  //!!
                    {
                        //dsMaster.SelectTab("tab23Super");
                        TB_Staus.AppendText("当前选定主机类型：23Super\r\n");      
                        //panel1.Enabled = true;
                        //tabVista.Cursor = System.Windows.Forms.Cursors.No;
                        //tab23Plus.Cursor = System.Windows.Forms.Cursors.No;
                        break;
                    }



                //default:
                //    {
                //        TB_Staus.AppendText("目前SDK不提供此主机类型！\r\n");
                //        MessageBox.Show("目前SDK不提供此主机类型！\r\n");
                //        break;
                //    }

            }
        }

        private void BT_StartProG_Click(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                String strc = TB_SetupPassWord.Text;
                axCooMonitorMain.FCSendCtrlCmd(listViewMain.Items[0].Name, FC_Ctrl_Type.FC_CTRL_PROGRAM, strc);
                TB_ProGAddr.Enabled = true;
                TB_ProGData.Enabled = true;                
                BT_ExitProG.Enabled = true;
                button3.Enabled = true;
                BT_StartProG.Enabled = false;
                listViewMain.Items[i].SubItems[5].Text = "进入编程";
                String sText = "主机" + listViewMain.Items[i].Name + "进入编程：" + strc + "\r\n";
                TB_Staus.AppendText(sText);


            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
            WorkStaus();
        }

        private void BT_ExitProG_Click(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                String strc = TB_SetupPassWord.Text;
                axCooMonitorMain.FCSendCtrlCmd(listViewMain.Items[0].Name, FC_Ctrl_Type.FC_CTRL_UNPROGRAM, strc);
                TB_ProGAddr.Enabled = false;
                TB_ProGData.Enabled = false;
                BT_ExitProG.Enabled = false;
                button3.Enabled = false;
                BT_StartProG.Enabled = true;
                listViewMain.Items[i].SubItems[5].Text = "退出编程";
                String sText = "主机" + listViewMain.Items[i].Name + "退出编程：" + strc + "\r\n";
                TB_Staus.AppendText(sText);


            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
            WorkStaus();
        }

        private void BT_ClearArmMemory_Click(object sender, EventArgs e)
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                String strc = "";
                axCooMonitorMain.FCSendCtrlCmd(listViewMain.Items[0].Name, FC_Ctrl_Type.FC_CTRL_CLEARALARM, strc);
                listViewMain.Items[i].SubItems[5].Text = "清除警报记忆";
                String sText = "主机" + listViewMain.Items[i].Name + "清除警报记忆" + "\r\n";
                TB_Staus.AppendText(sText);
                label19.Text = "紧急报警：正常";
                label19.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }

        private void BT_ArmMayday_Click(object sender, EventArgs e) //紧急报警
        {
            if (listViewMain.SelectedItems.Count > 0)
            {
                int i = listViewMain.SelectedItems[0].Index;
                String strc = "";
                if (MessageBox.Show("是否启动紧急报警", "确认报警", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {                    
                    axCooMonitorMain.FCSendCtrlCmd(listViewMain.Items[0].Name, FC_Ctrl_Type.FC_CTRL_PANIC_ALARM, strc);
                    listViewMain.Items[i].SubItems[5].Text = "启动紧急报警";
                    String sText = "主机" + listViewMain.Items[i].Name + "启动紧急报警" + "\r\n";
                    TB_Staus.AppendText(sText);
                    label19.Text = "紧急报警：异常";
                    label19.ForeColor = Color.Red;
                }

                
            }
            else
            {
                MessageBox.Show("请在主机选择区选择一个主机！");
            }
        }

        #endregion


        #region  监控器部分

        
        private uint iLastErr = 0;
        private Int32 m_lUserID = -1;
        private bool m_bInitSDK = false;
        private bool m_bRecord = false;
        private bool m_bTalk = false;
        private Int32 m_lRealHandle = -1;
        private int lVoiceComHandle = -1;
        private string str;
        private int m_LoginStaus;

        CHCNetSDK.REALDATACALLBACK RealData = null;
        CHCNetSDK.LOGINRESULTCALLBACK LoginCallBack = null;
        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;
        public CHCNetSDK.NET_DVR_USER_LOGIN_INFO struLogInfo;
        public CHCNetSDK.NET_DVR_DEVICEINFO_V40 DeviceInfo;

        public delegate void UpdateTextStatusCallback(string strLogStatus, IntPtr lpDeviceInfo);


        public void UpdateClientList(string strLogStatus, IntPtr lpDeviceInfo)
        {
            //列表新增报警信息
            labelLogin.Text = "登录状态（异步）：" + strLogStatus;
        }

        

        public void cbLoginCallBack(int lUserID, int dwResult, IntPtr lpDeviceInfo, IntPtr pUser)
        {
            string strLoginCallBack = "登录设备，lUserID：" + lUserID + "，dwResult：" + dwResult;

            if (dwResult == 0)
            {
                uint iErrCode = CHCNetSDK.NET_DVR_GetLastError();
                strLoginCallBack = strLoginCallBack + "，错误号:" + iErrCode;
            }

            //下面代码注释掉也会崩溃
            if (InvokeRequired)
            {
                object[] paras = new object[2];
                paras[0] = strLoginCallBack;
                paras[1] = lpDeviceInfo;
                labelLogin.BeginInvoke(new UpdateTextStatusCallback(UpdateClientList), paras);
            }
            else
            {
                //创建该控件的主线程直接更新信息列表 
                UpdateClientList(strLoginCallBack, lpDeviceInfo);
            }

        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            if (TB_IP.Text == "" || TB_MonPort.Text == "" || TB_UserName.Text == "" || TB_MonPassWord.Text == "")
            {
                MessageBox.Show("请输入您使用的摄像头的IP地址，端口号，用户名或密码");
                return;
            }

            if (m_lUserID < 0) 
            {
                struLogInfo = new CHCNetSDK.NET_DVR_USER_LOGIN_INFO();

                //设备IP地址或者域名
                byte[] byIP = System.Text.Encoding.Default.GetBytes(TB_IP.Text);
                struLogInfo.sDeviceAddress = new byte[129];
                byIP.CopyTo(struLogInfo.sDeviceAddress, 0);

                //设备用户名
                byte[] byUserName = System.Text.Encoding.Default.GetBytes(TB_UserName.Text);
                struLogInfo.sUserName = new byte[64];
                byUserName.CopyTo(struLogInfo.sUserName, 0);

                //设备密码
                byte[] byPassword = System.Text.Encoding.Default.GetBytes(TB_MonPassWord.Text);
                struLogInfo.sPassword = new byte[64];
                byPassword.CopyTo(struLogInfo.sPassword, 0);

                struLogInfo.wPort = ushort.Parse(TB_MonPort.Text);//设备服务端口号

                if (LoginCallBack == null)
                {
                    LoginCallBack = new CHCNetSDK.LOGINRESULTCALLBACK(cbLoginCallBack);//注册回调函数                    
                }
                struLogInfo.cbLoginResult = LoginCallBack;
                struLogInfo.bUseAsynLogin = false; //是否异步登录：0- 否，1- 是 

                DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V40();

                //登录设备 Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V40(ref struLogInfo, ref DeviceInfo);
                if (m_lUserID < 0)
                {   //登录失败事件
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "登录失败，错误代码：" + Environment.NewLine + "NET_DVR_Login_V40 failed,error code= " + iLastErr; //登录失败，输出错误号
                    MessageBox.Show(str,"警告");
                    m_LoginStaus = 0;
                    WorkStaus();
                    label_Monitor.Text = "监控：未登录";
                    return;
                }
                else
                {   //登录成功事件
                    MessageBox.Show("登录成功");
                    BT_Login.Text = "登出";
                    m_LoginStaus = 1;
                    WorkStaus();
                    label_Monitor.Text = "监控：已登录";

                    #region 启动监控
                    
                    if (m_lRealHandle < 0) 
                    {
                        CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                        lpPreviewInfo.hPlayWnd = RealPlayWnd.Handle;//预览窗口
                        lpPreviewInfo.lChannel = 1;//预te览的设备通道
                        lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                        lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                        lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                        lpPreviewInfo.dwDisplayBufNum = 1; //播放库播放缓冲区最大缓冲帧数
                        lpPreviewInfo.byProtoType = 0;
                        lpPreviewInfo.byPreviewMode = 0;

                        if (RealData == null)
                        {
                            RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数
                        }

                        IntPtr pUser = new IntPtr(); //用户数据

                        m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser); //打开预览

                        if (m_lRealHandle < 0) //验证是否预览
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "预览失败,错误代码：" + Environment.NewLine + "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr;
                            MessageBox.Show(str, "警告");
                            return;
                        }

                    } //打开监控
                    else
                    {
                        string sText = "监控已打开";
                        TB_Staus.AppendText(sText);
                    }

                    

                    #endregion
                }
            }
            else
            {
                //注销登录 Logout the device
                if (m_lRealHandle >= 0)  //若摄像头已经在运作 则需先关闭进程
                {
                    if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "预览失败,错误代码：" + Environment.NewLine + "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr;
                        MessageBox.Show(str, "警告");
                        return;
                    }
                    m_lRealHandle = -1;
                    m_LoginStaus = 0;
                    //BT_Login.Text = "登录";
                    string sText = "监控已关闭";
                    TB_Staus.AppendText(sText);
                    //return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    m_LoginStaus = 0;
                    WorkStaus();
                    return;
                }
                WorkStaus();
                m_lUserID = -1;
                BT_Login.Text = "登录";
            }

            return;
        }

        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
            if (dwBufSize > 0)
            {
                byte[] sData = new byte[dwBufSize];
                //Marshal.Copy(pBuffer, sData, 0, (Int32)dwBufSize);

                string str = "实时流数据.ps";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sData, 0, iLen);
                fs.Close();
            }
        }


        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("README.txt");
        }

       

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label_Emergency_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}