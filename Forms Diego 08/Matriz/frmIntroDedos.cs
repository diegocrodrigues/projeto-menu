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
    public partial class frmIntroDedos : Form
    {
        int aux_professor = 1;
        public frmIntroDedos()
        {
            InitializeComponent();
            picFoto.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\unknown.png");
            txtNomeJogador.Text = "seu Nome";
        }

        private void btnAbrirFoto_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Title = "Escolha uma foto do aluno";
            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Load(openFileDialogFoto.FileName);
            }
        }

        private void btnLimparFoto_Click(object sender, EventArgs e)
        {
            picFoto.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\unknown.png"); ;
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            aux_professor++;
            if(aux_professor == 1) // Bicudo
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\bicudo.jpg");
                lblNome.Text = "Bicudo";
            }
            else if(aux_professor == 2) // Vitao
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\vitao.jpg");
                lblNome.Text = "Vitão";
            }
            else if(aux_professor == 3) // Castro
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\castro.jpg");
                lblNome.Text = "Castro";
            }
            else if(aux_professor == 4) // Flash
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\flash.jpg");
                lblNome.Text = "Flash";
            }
            else if (aux_professor == 5)
            {
                aux_professor = 1;
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\bicudo.jpg");
                lblNome.Text = "Bicudo";
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (txtNomeJogador.Text == "seu Nome")
                txtNomeJogador.Text = "Unknown";
            frmDedos dedos = new frmDedos(picFoto.Image, txtNomeJogador, aux_professor);
            this.Hide();
            dedos.ShowDialog();
            this.Show();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            aux_professor--;
            if (aux_professor == 1) // Bicudo
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\bicudo.jpg");
                lblNome.Text = "Bicudo";
            }
            else if (aux_professor == 2) // Vitao
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\vitao.jpg");
                lblNome.Text = "Vitão";
            }
            else if (aux_professor == 3) // Castro
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\castro.jpg");
                lblNome.Text = "Castro";
            }
            else if (aux_professor == 4) // Flash
            {
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\flash.jpg");
                lblNome.Text = "Flash";
            }
            else if(aux_professor == 0)
            {
                aux_professor = 4;
                picProfessor.Image = null;
                picProfessor.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Professores\\flash.jpg");
                lblNome.Text = "Flash";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeJogador_Click(object sender, EventArgs e)
        {
            txtNomeJogador.Clear();
        }
    }
}
