using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;


namespace _3OLIDST_JulianCastro_07
{
    public partial class Form1 : Form
    {
        public System.IO.Ports.SerialPort Arduino;
        public Form1()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM7";
            Arduino.BaudRate = 9600;
            Arduino.Open();
        }

        private void btnApagado_Click(object sender, EventArgs e)
        {
            if (!Arduino.IsOpen)
            {
                Arduino.Open();
            }
            Arduino.Write("1");
            imgFocoEncendido.Visible = true;
            imgFocoApagado.Visible = false;
            btnEncendido.Visible = true;
            btnApagado.Visible = false;
        }

        private void btnEncendido_Click(object sender, EventArgs e)
        {
            if (!Arduino.IsOpen)
            {
                Arduino.Open();
            }
            Arduino.Write("0");
            imgFocoEncendido.Visible = false;
            imgFocoApagado.Visible=true;
            btnEncendido.Visible = false;
            btnApagado.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Arduino.Write("0");
            Arduino.Close();
        }
    }
}
