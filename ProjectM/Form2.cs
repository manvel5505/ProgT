using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjectM
{
    public partial class Form2 : Form
    {
        private short item2 = 150;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 80;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            item2--;

            if (item2 < 150 && item2 > 115)
            {
                pictureBox1.Left -= 2;
                pictureBox1.Top -= 3;
            }
            if (item2 < 115 && item2 > 80)
            {
                pictureBox1.Left -= 2;
                pictureBox1.Top += 3;
            }
            if (item2 < 80 && item2 > 45)
            {
                pictureBox1.Left += 2;
                pictureBox1.Top -= 3;
            }
            if (item2 < 45 && item2 > 10)
            {
                pictureBox1.Left += 2;
                pictureBox1.Top += 3;
            }
            if (item2 == 5)
            {
                item2 += 145;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Stop();
            GC.Collect();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
