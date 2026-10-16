using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace minhabibliotecap2.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.ShowAsync();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao logar: " +
                    ex.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
