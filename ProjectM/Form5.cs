using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.Reflection.Emit;

namespace ProjectM
{
    public partial class Form5 : Form
    {
        private Random random = new Random();
        private Color[] colors = new Color[]
        {
            Color.Pink,
            Color.Gray,
            Color.Orange,
            Color.Silver,
            Color.Green,
            Color.Red,
            Color.Purple,
            Color.Blue,
            Color.Gold ,
            Color.Aqua,
            Color.Magenta,
            Color.Beige,
            Color.AliceBlue, 
            Color.Orchid,
        };

        private short item6 = 10;
        private short item5 = 10;
        private short item4 = 10;
        private short item3 = 10;
        private short item2 = 100;
        private short item = 10;

        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            timer4.Start();
            timer4.Interval = 800;

            timer2.Interval = 300;
            timer2.Enabled = true;
            timer2.Start();

            label1.ForeColor = Color.White;
            label4.ForeColor = Color.White;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamWriter = new StreamWriter(ConfigurationManager.ConnectionStrings[name: "AppTextWrite"].ConnectionString,true))
            {
                streamWriter.WriteLine(richTextBox1.Text);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            using (StreamReader stream = new StreamReader(ConfigurationManager.ConnectionStrings[name: "AppTextWrite"].ConnectionString, true))
            {
                richTextBox1.Text += " " + stream.ReadLine() + " ";
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            File.Delete(ConfigurationManager.ConnectionStrings[name: "AppTextWrite"].ConnectionString);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            this.Home.Show();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            this.Home.Show();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            item--;

            if (item < 10 && item > 0)
            {
                label1.ForeColor = colors[random.Next(0, colors.Length)];
            }
            if (item < 10 && item > 5)
            {
                label1.Left += 1;
            }
            if (item < 5 && item > 0)
            {
                label1.Left -= 1;
            }
            if (item == 0)
            {
                item += 10;
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            item2--;

            if (item2 < 100 && item2 > 70)
            {
                pictureBox1.Image = ProjectM.Properties.Resources.large_images;
            }
            if (item2 < 70 && item2 > 40)
            {
                pictureBox1.Image = ProjectM.Properties.Resources.WS2300701_l;
            }
            if (item2 < 40 && item2 > 10)
            {
                pictureBox1.Image = ProjectM.Properties.Resources.imagespho;
            }
            if (item2 == 5)
            {
                item2 += 95;
            }
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            item3--;

            if (item3 < 10 && item3 > 0)
            {
                label4.ForeColor = colors[random.Next(0, colors.Length)];
            }
            if (item3 < 10 && item3 > 5)
            {
                label4.Left += 1;
            }
            if (item3 < 5 && item3 > 0)
            {
                label4.Left -= 1;
            }
            if (item3 == 0)
            {
                item3 += 10;
            }
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            item4--;

            if (item4 < 10 && item4 > 8)
            {
                timer6.Interval = 100;
                timer6.Enabled = true;
                timer6.Start();
            }
            if (item4 < 8 && item4 > 6)
            {
                timer5.Interval = 100;
                timer5.Enabled = true;
                timer5.Start();
            }
            if (item4 < 6 && item4 > 4)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
                timer1.Start();
            }
            if (item4 < 4 && item4 > 2)
            {
                timer3.Interval = 100;
                timer3.Enabled = true;
                timer3.Start();
            }
        }
        private void Timer5_Tick(object sender, EventArgs e)
        {
            item5--;

            if (item5 < 10 && item5 > 0)
            {
                label2.ForeColor = colors[random.Next(0, colors.Length)];
            }
            if (item5 < 10 && item5 > 5)
            {
                label2.Top += 1;
            }
            if (item5 < 5 && item5 > 0)
            {
                label2.Top -= 1;
            }
            if (item5 == 0)
            {
                item5 += 10;
            }
        }
        private void Timer6_Tick(object sender, EventArgs e)
        {
            item6--;

            if (item6 < 10 && item6 > 0)
            {
                label5.ForeColor = colors[random.Next(0, colors.Length)];
            }
            if (item6 < 10 && item6 > 5)
            {
                label5.Left += 1;         
                label5.Size += new Size(width: 70,height: 15);
            }
            if (item6 < 10 && item6 > 7)
            {
                label5.ForeColor = Color.White;
            }
            if (item6 < 5 && item6 > 0)
            {
                label5.Left -= 1;
                label5.Size += new Size(width: 150, height: 30);
            }
            if (item6 == 0)
            {
                item6 += 10;
            }
        }
    }
}
