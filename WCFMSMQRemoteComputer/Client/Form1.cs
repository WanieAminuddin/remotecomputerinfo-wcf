using System;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace Client
{
    public partial class Form1 : Form
    {
        string data;
        Proxy.ServerClient Send2Server = new Proxy.ServerClient();

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            comboBoxWin32.Items.Add("Computer Hardware Information");
            foreach (string stringWin32class in stringWin32classes)
            {
                comboBoxWin32.Items.Add(stringWin32class);
            }
            comboBoxWin32.SelectedIndex = 0;       
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textName.Text = Environment.MachineName;
            textComputerInfo.Enabled = false;
        }
        public string DeviceInformation(string stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            try
            {
                ManagementClass ManagementClass1 = new ManagementClass(stringIn);
                //Create a ManagementObjectCollection to loop through
                ManagementObjectCollection ManagemenobjCol = ManagementClass1.GetInstances();
                //Get the properties in the class
                PropertyDataCollection properties = ManagementClass1.Properties;
                foreach (ManagementObject obj in ManagemenobjCol)
                {
                    foreach (PropertyData property in properties)
                    {
                        try
                        {
                            StringBuilder1.AppendLine(property.Name + ":  " + obj.Properties[property.Name].Value.ToString());
                        }
                        catch
                        {
                            //Add codes to manage more informations
                        }
                    }
                    StringBuilder1.AppendLine();
                }
            }
            catch
            {
                //Win 32 Classes Which are not defined on client system
            }
            return StringBuilder1.ToString();
        }

        private void comboBoxWin32_SelectedIndexChanged(object sender, EventArgs e)
        {
            textComputerInfo.Enabled = true;
            textComputerInfo.Clear();
            textComputerInfo.Text += Environment.MachineName + Environment.NewLine + DateTime.Now + Environment.NewLine + DeviceInformation(comboBoxWin32.SelectedItem.ToString());
            data = textComputerInfo.Text;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send2Server.Receive(data);
        }

        string[] stringWin32classes = {"Win32_Binary",
        "Win32_BIOS",
        "Win32_Bus",
        "Win32_CacheMemory",
        "Win32_CDROMDrive",
        "Win32_Desktop",
        "Win32_DesktopMonitor",
        "Win32_DeviceBus",
        "Win32_DeviceMemoryAddress",
        "Win32_Keyboard",
        "Win32_LocalTime",
        "Win32_LoggedOnUser",
        "Win32_LogicalDisk",
        "Win32_LogicalDiskRootDirectory",
        "Win32_MemoryArray",
        "Win32_MemoryArrayLocation",
        "Win32_MemoryDevice",
        "Win32_MemoryDeviceArray",
        "Win32_MemoryDeviceLocation",
        "Win32_PhysicalMemory",
        "Win32_PhysicalMemoryArray",
        "Win32_Printer",
        "Win32_PrinterConfiguration",
        "Win32_PrinterController",
        "Win32_PrinterDriver",
        "Win32_Processor",
        "Win32_Product",
        "Win32_SerialPort",
        "Win32_SerialPortConfiguration",
        "Win32_SerialPortSetting",
        "Win32_SystemAccount",
        "Win32_SystemBIOS",
        "Win32_SystemServices",
        "Win32_UserAccount",
        "Win32_UserDesktop",
        "Win32_UserInDomain",
        "Win32_UTCTime",
        "Win32_VideoController",
        "Win32_VideoSettings"};

        private void textComputerInfo_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
