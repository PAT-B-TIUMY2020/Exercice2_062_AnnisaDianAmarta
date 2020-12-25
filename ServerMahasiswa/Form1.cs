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
using WcfServiceMahasiswa;

namespace ServerMahasiswa
{
    public partial class Form1 : Form
    {
        ServiceHost hostobjek = null;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            btnON.Enabled = true;
            btnOff.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Text = "Server OFF!";
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            btnON.Enabled = false;
            btnOff.Enabled = true;
            hostobjek = new ServiceHost(typeof(Service1));
            hostobjek.Open();
            textBox1.Text = "Server ON!";
            hostobjek.Close();

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnON.Enabled = true;
            btnOff.Enabled = false;
            hostobjek = null;
            textBox1.Text = "Server OFF!";

        }
    }
}
