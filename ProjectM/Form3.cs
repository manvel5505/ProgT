using ProjectM.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ProjectM.controller;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.SqlClient;
using System.Threading;

namespace ProjectM
{
    public partial class Form3 : Form
    {
        private UsersController<string> Collection { get; set; } = new UsersController<string>();
        public Form3()
        {
            InitializeComponent();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4(new ErrorProvider());
            this.Hide();
            form4.Show();
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            foreach (var item in Collection.Users)
            {
                if (textName.Text != "" && textPass.Text != "")
                {
                    if (item.Username.Equals(textName.Text) && item.Password.Equals(textPass.Text))
                    {
                        button1.ForeColor = Color.Green;
                        label5.Text = "";

                        Form5 form5 = new Form5();
                        this.Close();
                        GC.Collect();
                        form5.Show();
                    }
                    else
                    {
                        label5.Text = "Username or Password is not Exsist!";
                    }
                }
                else
                {
                    label5.Text = "       Write Information!";
                }
            }
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textPass.PasswordChar = '\0';

            if (checkBox1.Checked)
            {
                textPass.PasswordChar = '\0';
            }
            else
            {
                textPass.PasswordChar = '*';               
            }
        }
    }
}
