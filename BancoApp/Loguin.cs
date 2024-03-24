using System;
using System.Windows.Forms;

namespace BancoApp
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Register register = new Register();
            register.Show();    
        }

        private void NextBoton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaldoConsig saldo = new SaldoConsig();
            saldo.Show();
        }

        private void btnLoguin_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView();
            userView.Show();
        }
    }
}
