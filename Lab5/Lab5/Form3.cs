using Lab3;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form3 : Form
    {
        List<AbstractTransport> transport;
        public Form3(List<AbstractTransport> transportInList)
        {
            InitializeComponent();
            transport = transportInList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || numericUpDown1.Text == "0" || numericUpDown2.Text == "0" || comboBox1.Text == "")
                return;
            AddTransport(comboBox1.Text, textBox1.Text, int.Parse(numericUpDown1.Text), int.Parse(numericUpDown2.Text));
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddTransport(string transportType, string name, int farePerKilometer, int reachedDistance)
        {
            AbstractTransport newTransport = new AbstractTransport();
            if (transportType == "Bus")
            {
                newTransport = new Bus();
            }
            else if (transportType == "Train")
            {
                newTransport = new Train();
            }
            else if (transportType == "Tram")
            {
                newTransport = new Tram();
            }
            else if (transportType == "Taxi")
            {
                newTransport = new Taxi();
            }
            else if (transportType == "Ferry")
            {
                newTransport = new Ferry();
            }
            else if (transportType == "Ship")
            {
                newTransport = new Ship();
            }
            else if (transportType == "Liner")
            {
                newTransport = new Liner();
            }
            else if (transportType == "Helicopter")
            {
                newTransport = new Helicopter();
            }
            else if (transportType == "Airplane")
            {
                newTransport = new Airplane();
            }
            newTransport.name = name;
            newTransport.farePerKilometer = farePerKilometer;
            newTransport.reachedDistance = reachedDistance;
            transport.Add(newTransport);
        }
    }
}
