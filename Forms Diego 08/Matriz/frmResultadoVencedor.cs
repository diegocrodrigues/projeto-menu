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
    public partial class frmResultadoVencedor : Form
    {
        public frmResultadoVencedor(string nomePlayer, Image imgJogador, int profJogador, Image imgFotoProfessor, string lblRodadasNum)
        {
            InitializeComponent();
            lblNomeJogador.Text = nomePlayer;
            picFotoJogador.Image = imgJogador;
            lblRodadas.Text = "Rodadas: " + lblRodadasNum;
            if (profJogador == 1)
                lblNomeProfessor.Text = "Bicudo";
            else if (profJogador == 2)
                lblNomeProfessor.Text = "Vitão";
            else if (profJogador == 3)
                lblNomeProfessor.Text = "Castro";
            else if (profJogador == 4)
                lblNomeProfessor.Text = "Flash";
            picFotoProfessor.Image = imgFotoProfessor;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResultadoVencedor_Load(object sender, EventArgs e)
        {

        }
    }
}
