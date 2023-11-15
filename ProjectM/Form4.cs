using ProjectM.controller;
using ProjectM.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace ProjectM
{
    public partial class Form4 : Form
    {
        private readonly ErrorProvider _errorProvider;
        public Form4(ErrorProvider _errorProvider)
        {
            this._errorProvider = _errorProvider;

            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            HashSet<UsersModel<string>> usersModels = new HashSet<UsersModel<string>>
            {
                new UsersModel<string>()
                {
                    Username = textBox1.Text,
                    Password = textBox2.Text,
                    RepeatPassword = textBox3.Text
                }
            };
            using (var test = new UsersController<string>())
            {
                foreach (var item in usersModels)
                {
                    var context = new ValidationContext(item);
                    var results = new List<ValidationResult>();

                    if (Validator.TryValidateObject(item, context, results, true))
                    {
                        test.Users.Add(item);

                        test.SaveChanges();
                        
                        button1.ForeColor = Color.Green;

                        MessageBox.Show("Added");

                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.ShowDialog();
                    }
                    else
                    {
                        foreach (var error in results)
                        {
                            if (error.ErrorMessage.StartsWith("Username"))
                            {
                                _errorProvider.SetError(textBox1, error.ErrorMessage);
                            }
                            if (error.ErrorMessage.StartsWith("Password"))
                            {
                                _errorProvider.SetError(textBox2, error.ErrorMessage);
                            }
                            if (error.ErrorMessage.StartsWith("Repeat"))
                            {
                                _errorProvider.SetError(textBox3, error.ErrorMessage);
                            }
                        }
                    }
                }
            }
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GC.Collect();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
