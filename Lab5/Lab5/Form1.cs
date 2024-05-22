using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab5
{
    using Lab3;
    public partial class Form1 : Form
    {
        CostCalculator calculator = new CostCalculator();
        List<AbstractTransport> transport = new List<AbstractTransport>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Form3(transport).ShowDialog();
            label2.Text = calculator.GetCost(transport).ToString();
            listBox1.Items.Clear();
            foreach (AbstractTransport transport in transport)
                listBox1.Items.Add(transport.name + " (" + transport.ToString() + ") - " + transport.farePerKilometer * transport.reachedDistance);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || transport.Count == 0)
                return;
            new Form2(transport[listBox1.SelectedIndex]).ShowDialog(); 
            label2.Text = calculator.GetCost(transport).ToString();
            listBox1.Items.Clear();
            foreach (AbstractTransport transport in transport)
                listBox1.Items.Add(transport.name + " (" + transport.ToString() + ") - " + transport.farePerKilometer * transport.reachedDistance);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1 || transport.Count == 0)
                return;
            transport.Remove(transport[listBox1.SelectedIndex]);
            //listBox1.Items.Clear();                                !!!!!!!!!!
            label2.Text = calculator.GetCost(transport).ToString();
            foreach (AbstractTransport transport in transport)
                listBox1.Items.Add(transport.name + " (" + transport.ToString() + ") - " + transport.farePerKilometer * transport.reachedDistance);
        }
    }
}
