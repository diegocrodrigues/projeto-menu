using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Diego_08
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            frmMatriz matriz = new frmMatriz();
            this.Hide();
            matriz.ShowDialog();
            this.Show();
        }

        private void btnDedos_Click(object sender, EventArgs e)
        {
            frmIntroDedos introDedos = new frmIntroDedos();
            this.Hide();
            introDedos.ShowDialog();
            this.Show();
            
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            this.Hide();
            sobre.ShowDialog();
            this.Show();
        }
    }
}
