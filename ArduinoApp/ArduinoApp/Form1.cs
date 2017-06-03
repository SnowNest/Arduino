using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            SPort.Open();



            SPort.Write("1");

 

            SPort.Close();

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            SPort.Open();



            SPort.Write("0");



            SPort.Close();
        }
    }
}
