using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_PA
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            //Crear Serial Port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM7"; //Checar en el equipo
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            //vincular Eventos
            this.FormClosing += CerrandoForm1;
            this.btnApgar.Click += btnApgar_Click;
            this.btnEncender.Click += btnEncender_Click;
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void btnApgar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void CerrandoForm1(object sender, EventArgs e)
        {
            //Cerrando Puerto 
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
    }
}
