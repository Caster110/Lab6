using Lab3;
using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        AbstractTransport transport;
        public Form2(AbstractTransport transportInProcess)
        {
            InitializeComponent();
            transport = transportInProcess;
            textBox1.Text = transport.name;
            numericUpDown1.Text = transport.farePerKilometer.ToString();
            numericUpDown2.Text = transport.reachedDistance.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || numericUpDown1.Text == "0" || numericUpDown2.Text == "0")
                return;
            EditTransport(transport);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EditTransport(AbstractTransport transport)
        {
            transport.name = textBox1.Text;
            transport.farePerKilometer = int.Parse(numericUpDown1.Text);
            transport.reachedDistance = int.Parse(numericUpDown2.Text);
        }
    }
}
