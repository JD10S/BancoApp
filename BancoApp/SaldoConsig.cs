using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoApp
{
    public partial class SaldoConsig : Form
    {
        public SaldoConsig()
        {
            InitializeComponent();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            panelRetirar.Visible = false;
            PanelConsignar.Visible = false;
            panelSaldo.Visible = false;

            panelRetirar.Visible = true;
        }

        private void BtnConsignar_Click(object sender, EventArgs e)
        {
            panelRetirar.Visible = false;
            PanelConsignar.Visible = false;
            panelSaldo.Visible = false;

            PanelConsignar.Visible = true;
        }


        private void BtnSaldo_Click(object sender, EventArgs e)
        {
            panelRetirar.Visible = false;
            PanelConsignar.Visible = false;
            panelSaldo.Visible = false;

            panelSaldo.Visible=true;
        }
    }
}
