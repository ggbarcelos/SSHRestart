using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSHRestart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Ip = textIP.Text;
            var User = textUser.Text;
            var Password = textPass.Text;
            using (var client = new SshClient(Ip, User, Password))
            {
                client.Connect();
                //Aqui tu coloca o comando que tu quer executar
                client.RunCommand("etc/init.d/networking restart");
                client.Disconnect();
            }
        }
    }
}
