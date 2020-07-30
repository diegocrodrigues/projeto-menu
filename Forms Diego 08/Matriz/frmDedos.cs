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
    public partial class frmDedos : Form
    {
        Random sorteio = new Random();

        int rodadas = 0;

        // valores randômicos e a soma deles
        int valorMao1;
        int valorMao2;
        int valorMao3;
        int valorMao4;
        int valorSomaMaos;

        // valores para o chute de cada professor sobre a somatória
        int numCastro;
        int numFlash;
        int numBicudo;
        int numVitao;

        // valores referentes a pontuação de cada professor
        int castroPontuacao = 0;
        int flashPontuacao = 0;
        int bicudoPontuacao = 0;
        int vitaoPontuacao = 0;

        Image imgJogador;
        int profJogador;
        string nomePlayer;

        public frmDedos(Image picFoto, TextBox nomeJogador, int professor)
        {
            InitializeComponent();
            analisaDadosEnviados(picFoto, nomeJogador, professor);
            btnJogar.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            rodadas++;
            lblRodadasNum.Text = rodadas.ToString();
            numCastro = sorteio.Next(0, 20);
            numFlash = 0;
            do
            {
                numFlash = sorteio.Next(0, 20);
                if (numFlash != numCastro)
                   break;
            } while (true);
            numBicudo = 0;
            do
            {
                numBicudo = sorteio.Next(0, 20);
                if (numBicudo != numCastro && numBicudo != numFlash)
                    break;
            } while (true);
            numVitao = 0;
            do
            {
                numVitao = sorteio.Next(0, 20);
                if (numVitao != numCastro && numVitao != numFlash && numVitao != numBicudo)
                    break;
            } while (true);

            lblNumCastro.Text = numCastro.ToString();
            lblNumFlash.Text = numFlash.ToString();
            lblNumBicudo.Text = numBicudo.ToString();
            lblNumVitao.Text = numVitao.ToString();
            
            mostraMaos(imgMaoCastro, imgMaoFlash, imgMaoBicudo, imgMaoVitao);

            validaGanhadorDaRodada();
            validaGanhadorDoJogo();
        }

        private void validaGanhadorDoJogo()
        {
            if (castroPontuacao == 3)
            {
                castroPontuacao = 0;
                bicudoPontuacao = 0;
                flashPontuacao = 0;
                vitaoPontuacao = 0;

                if(profJogador == 3)
                {
                    frmResultadoVencedor resultado = new frmResultadoVencedor(nomePlayer, imgJogador, profJogador, imgFotoCastro.Image, lblRodadasNum.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                else
                {
                    frmResultadoPerdedor resultado = new frmResultadoPerdedor(nomePlayer, imgJogador, profJogador, imgFotoCastro.Image, lblCastroNome.Text, lblRodadasNum.Text, lblBicudoPontuacao.Text, lblCastroPontuacao.Text, lblFlashPontuacao.Text, lblVitaoPontuacao.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                this.Close();
            }
            else  if (flashPontuacao == 3)
            {
                castroPontuacao = 0;
                bicudoPontuacao = 0;
                flashPontuacao = 0;
                vitaoPontuacao = 0;

                if (profJogador == 4)
                {
                    frmResultadoVencedor resultado = new frmResultadoVencedor(nomePlayer, imgJogador, profJogador, imgFotoFlash.Image, lblRodadasNum.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                else
                {
                    frmResultadoPerdedor resultado = new frmResultadoPerdedor(nomePlayer, imgJogador, profJogador, imgFotoFlash.Image, lblFlashNome.Text, lblRodadasNum.Text, lblBicudoPontuacao.Text, lblCastroPontuacao.Text, lblFlashPontuacao.Text, lblVitaoPontuacao.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                this.Close();
            }
            else if (bicudoPontuacao == 3)
            {
                castroPontuacao = 0;
                bicudoPontuacao = 0;
                flashPontuacao = 0;
                vitaoPontuacao = 0;

                if (profJogador == 1)
                {
                    frmResultadoVencedor resultado = new frmResultadoVencedor(nomePlayer, imgJogador, profJogador, imgFotoBicudo.Image, lblRodadasNum.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                else
                {
                    frmResultadoPerdedor resultado = new frmResultadoPerdedor(nomePlayer, imgJogador, profJogador, imgFotoBicudo.Image, lblBicudoNome.Text, lblRodadasNum.Text, lblBicudoPontuacao.Text, lblCastroPontuacao.Text, lblFlashPontuacao.Text, lblVitaoPontuacao.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                this.Close();
            }
            else if (vitaoPontuacao == 3)
            {
                castroPontuacao = 0;
                bicudoPontuacao = 0;
                flashPontuacao = 0;
                vitaoPontuacao = 0;

                if (profJogador == 2)
                {
                    frmResultadoVencedor resultado = new frmResultadoVencedor(nomePlayer, imgJogador, profJogador, imgFotoVitao.Image, lblRodadasNum.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                else
                {
                    frmResultadoPerdedor resultado = new frmResultadoPerdedor(nomePlayer, imgJogador, profJogador, imgFotoVitao.Image, lblVitaoNome.Text, lblRodadasNum.Text, lblBicudoPontuacao.Text, lblCastroPontuacao.Text, lblFlashPontuacao.Text, lblVitaoPontuacao.Text);
                    this.Hide();
                    resultado.ShowDialog();
                }
                this.Close();
            }
        }

        private void mostraMaos(PictureBox imgMaoCastro, PictureBox imgMaoFlash, PictureBox imgMaoBicudo, PictureBox imgMaoVitao)
        {
            valorMao1 = sorteio.Next(0, 5);
            valorMao2 = sorteio.Next(0, 5);
            valorMao3 = sorteio.Next(0, 5);
            valorMao4 = sorteio.Next(0, 5);
            valorSomaMaos = valorMao1 + valorMao2 + valorMao3 + valorMao4;

            imgMaoCastro.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Castro\\mao" + valorMao1 + ".jpg");
            imgMaoFlash.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Flash\\mao" + valorMao2 + ".jpg");
            imgMaoBicudo.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Bicudo\\mao" + valorMao3 + ".jpg");
            imgMaoVitao.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\imagens\\Vitao\\mao" + valorMao4 + ".jpg");

            imgMaoCastro.Tag = valorMao1;
            imgMaoFlash.Tag = valorMao2;
            imgMaoBicudo.Tag = valorMao3;
            imgMaoVitao.Tag = valorMao4;
        }

        private void validaGanhadorDaRodada()
        {
            if (valorSomaMaos == numCastro)
            {
                lblResultado.Text = "Castro é o ganhador da \nrodada " + rodadas.ToString() + "! \nPonto pro ele!";
                castroPontuacao++;
            }
            else if (valorSomaMaos == numFlash)
            {
                lblResultado.Text = "Flash é o ganhador da \nrodada " + rodadas.ToString() + "! \nPonto pra ele!";
                flashPontuacao++;
            }
            else if (valorSomaMaos == numBicudo)
            {
                lblResultado.Text = "Bicudo é o ganhador da \nrodada " + rodadas.ToString() + "! \nPonto pro ele!";
                bicudoPontuacao++;
            }
            else if (valorSomaMaos == numVitao)
            {
                lblResultado.Text = "Vitor é o ganhador da \nrodada " + rodadas.ToString() + "! \nPonto pro ele!";
                vitaoPontuacao++;
            }
            else
            {
                lblResultado.Text = "Ninguém acertou nessa rodada. Mais sorte na próxima vez!";
            }
            lblCastroPontuacao.Text = castroPontuacao.ToString();
            lblBicudoPontuacao.Text = bicudoPontuacao.ToString();
            lblFlashPontuacao.Text = flashPontuacao.ToString();
            lblVitaoPontuacao.Text = vitaoPontuacao.ToString();
        }

        private void imgMaoFlash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Flash colocou " + imgMaoFlash.Tag + "dedo(s)");
        }

        private void imgMaoBicudo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Bicudo colocou " + imgMaoBicudo.Tag + "dedo(s)");
        }

        private void imgMaoVitao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Vitao colocou " + imgMaoVitao.Tag + "dedo(s)");
        }

        private void imgMaoCastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Castro colocou " + imgMaoCastro.Tag + "dedo(s)");
        }

        private void frmDedos_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void analisaDadosEnviados(Image picFoto, TextBox nomeJogador, int professor)
        {
            imgJogador = picFoto;
            if (nomeJogador.Text == "")
            {
                nomeJogador.Text = "Unknown";
            }
            nomePlayer = nomeJogador.Text;
            profJogador = professor;
            

            if (professor == 1)
            {
                lblBicudoNome.ForeColor = Color.Green;
                lblBicudoNome.Text = "Bicudo (" + nomeJogador.Text + ")";
                lblBicudoPlacarNome.ForeColor = Color.Lime;
                lblBicudoPontuacao.ForeColor = Color.Lime;
                
            }
            else if (professor == 2)
            {
                lblVitaoNome.ForeColor = Color.Green;
                lblVitaoNome.Text = "Vitão (" + nomeJogador.Text + ")";
                lblVitaoPlacarNome.ForeColor = Color.Lime;
                lblVitaoPontuacao.ForeColor = Color.Lime;
            }
            else if (professor == 3)
            {
                lblCastroNome.ForeColor = Color.Green;
                lblCastroNome.Text = "Castro (" + nomeJogador.Text + ")";
                lblCastroPlacarNome.ForeColor = Color.Lime;
                lblCastroPontuacao.ForeColor = Color.Lime;
            }
            else if (professor == 4)
            {
                lblFlashNome.ForeColor = Color.Green;
                lblFlashNome.Text = "Flash (" + nomeJogador.Text + ")";
                lblFlashPlacarNome.ForeColor = Color.Lime;
                lblFlashPontuacao.ForeColor = Color.Lime;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfoDedos info = new frmInfoDedos(nomePlayer, profJogador);
            info.ShowDialog();
        }
    }
}
