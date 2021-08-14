using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TwitchCommandSpam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string commandToRun = commandBox.Text;
            string[] runCommandFor = parameterBox.Text.Split('\n');
            bool initialWait = true;
            foreach(string command in runCommandFor){
                if(initialWait == true){
                    Thread.Sleep(5000);
                }
                Thread.Sleep(1000);
                SendKeys.Send(commandToRun + " " + command);
                SendKeys.Send("{Enter}");
                initialWait = false;
            }
            initialWait = true;
        }
    }
}
