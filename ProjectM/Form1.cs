using System;
using System.Windows.Forms;

namespace ProjectM
{
    public partial class Form1 : Form
    {
        private short item = 10;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            item--;

            if (item is 0)
            {   
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();

                timer1.Stop();
                GC.Collect();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
