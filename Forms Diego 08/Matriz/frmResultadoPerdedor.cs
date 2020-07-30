using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Forms_Diego_08
{
    public partial class frmResultadoPerdedor : Form
    {
        public frmResultadoPerdedor(string nomePlayer, Image imgJogador, int profJogador, Image imgFotoProfessorVencedor, string nomeProfessorVencedor, string lblRodadasNum, string lblBicudoPontuacao, string lblCastroPontuacao, string lblFlashPontuacao, string lblVitaoPontuacao)
        {
            InitializeComponent();
            lblNomeJogador.Text = nomePlayer;
            lblNomeProfessorVencedor.Text = nomeProfessorVencedor;
            picFotoJogador.Image = imgJogador;
            picFotoProfessorVencedor.Image = imgFotoProfessorVencedor;
            lblRodadas.Text = "Rodadas: " + lblRodadasNum;
            if (profJogador == 1)
            {
                lblNomeProfessor.Text = "Bicudo";
                picFotoProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\bicudo.jpg");
                if(nomeProfessorVencedor == "Castro")
                {
                    lblPlacar.Text = lblBicudoPontuacao + " x 3";
                }
                else if (nomeProfessorVencedor == "Flash")
                {
                    lblPlacar.Text = lblBicudoPontuacao + " x 3";
                }
                else
                {
                    lblPlacar.Text = lblBicudoPontuacao + " x 3";
                }
            }
            else if (profJogador == 2)
            {
                lblNomeProfessor.Text = "Vitão";
                picFotoProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\vitao.jpg");
                if (nomeProfessorVencedor == "Castro")
                {
                    lblPlacar.Text = lblVitaoPontuacao + " x 3";
                }
                else if (nomeProfessorVencedor == "Bicudo")
                {
                    lblPlacar.Text = lblVitaoPontuacao + " x 3";
                }
                else if (nomeProfessorVencedor == "Flash")
                {
                    lblPlacar.Text = lblVitaoPontuacao + " x 3";
                }
            }
            else if (profJogador == 3)
            {
                lblNomeProfessor.Text = "Castro";
                picFotoProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\castro.jpg");
                if (nomeProfessorVencedor == "Bicudo")
                {
                    lblPlacar.Text = lblCastroPontuacao + " x 3";
                }
                else if (nomeProfessorVencedor == "Flash")
                {
                    lblPlacar.Text = lblCastroPontuacao + " x 3";
                }
                else
                {
                    lblPlacar.Text = lblCastroPontuacao + " x 3";
                }
            }
            else if (profJogador == 4)
            {
                lblNomeProfessor.Text = "Flash";
                picFotoProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\flash.jpg");
                if (nomeProfessorVencedor == "Bicudo")
                {
                    lblPlacar.Text = lblFlashPontuacao + " x 3";
                }
                else if (nomeProfessorVencedor == "Castro")
                {
                    lblPlacar.Text = lblFlashPontuacao + " x 3";
                }
                else
                {
                    lblPlacar.Text = lblFlashPontuacao + " x 3";
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
