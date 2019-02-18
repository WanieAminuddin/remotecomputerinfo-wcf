using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Server;

namespace HOST
{
    public partial class Form1 : Form
    {
        ServiceHost host;       
        bool blnStartStop;
        QueueService QS = new QueueService();

        public Form1()
        {
            InitializeComponent();
            blnStartStop = true;
        }

        
        private void btnHost_Click(object sender, EventArgs e)
        {
            if (blnStartStop)
            {
                host = new ServiceHost(typeof(Server.QueueService));
                host.Open();
                btnHost.Text = "Stop Service";
                textData.Text += System.Environment.NewLine + QS.getComputerInfo() + System.Environment.NewLine;
            }
            else
            {
                host.Close();
                textData.Clear();
                btnHost.Text = "Start";
            }

            blnStartStop = !blnStartStop;
        }

        private void textData_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
