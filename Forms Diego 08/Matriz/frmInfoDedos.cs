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
    public partial class frmInfoDedos : Form
    {
        public frmInfoDedos(string nomeJogador, int prof)
        {
            InitializeComponent();
            lblInfo1.Text = "Nome do jogador: " + nomeJogador;
            if (prof == 1)
                lblInfo2.Text = "Professor representante: Bicudo";
            if(prof == 2)    
                lblInfo2.Text = "Professor representante: Vitão";
            if(prof == 3)    
                lblInfo2.Text = "Professor representante: Castro";
            if(prof == 4)    
                lblInfo2.Text = "Professor representante: Flash";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
