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
    public partial class frmMatriz : Form
    {
        Random sorteio = new Random();

        public frmMatriz()
        {
            InitializeComponent();
            txtNum11.Focus();
            txtNum11.TabIndex = 1;
            txtNum12.TabIndex = 2;
            txtNum21.TabIndex = 3;
            txtNum22.TabIndex = 4;
            btnCalcula.TabIndex = 5;
            btnNovo.TabIndex = 6;
            btnVoltar.TabIndex = 7;
        }

        private void txtNum11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;  
            }
        }

        private void txtNum12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum41_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum42_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum43_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtNum44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            double num11 = 0;
            if (txtNum11.Text != "")
                num11 = double.Parse(txtNum11.Text);
            double num12 = 0;
            if (txtNum12.Text != "")
                num12 = double.Parse(txtNum12.Text); 
            double num13 = 0;
            if (txtNum13.Text != "")
                num13 = double.Parse(txtNum13.Text); 
            double num14 = 0;
            if (txtNum14.Text != "")
                num14 = double.Parse(txtNum14.Text); 
            double num21 = 0;
            if (txtNum21.Text != "")
                num21 = double.Parse(txtNum21.Text); 
            double num22 = 0;
            if (txtNum22.Text != "")
                num22 = double.Parse(txtNum22.Text); 
            double num23 = 0;
            if (txtNum23.Text != "")
                num23 = double.Parse(txtNum23.Text); 
            double num24 = 0;
            if (txtNum24.Text != "")
                num24 = double.Parse(txtNum24.Text); 
            double num31 = 0;
            if (txtNum31.Text != "")
                num31 = double.Parse(txtNum31.Text); 
            double num32 = 0;
            if (txtNum32.Text != "")
                num32 = double.Parse(txtNum32.Text); 
            double num33 = 0;
            if (txtNum33.Text != "")
                num33 = double.Parse(txtNum33.Text); 
            double num34 = 0;
            if (txtNum34.Text != "")
                num34 = double.Parse(txtNum34.Text); 
            double num41 = 0;
            if (txtNum41.Text != "")
                num41 = double.Parse(txtNum41.Text); 
            double num42 = 0;
            if (txtNum42.Text != "")
                num42 = double.Parse(txtNum42.Text); 
            double num43 = 0;
            if (txtNum43.Text != "")
                num43 = double.Parse(txtNum43.Text); 
            double num44 = 0;
            if (txtNum44.Text != "")
                num44 = double.Parse(txtNum44.Text);

            if (rad2x2.Checked)
            {
                if (txtNum11.Text == "" || txtNum12.Text == "" || txtNum21.Text == "" || txtNum22.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou 1 (ou mais) campos sem preencher. Gostaria que eu atribuisse a TODOS esses campos o valor 0?", "Calculadora de Determinante - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtNum11.Text == "")
                            txtNum11.Text = "0";
                        if (txtNum12.Text == "")
                            txtNum12.Text = "0";
                        if (txtNum21.Text == "")
                            txtNum21.Text = "0";
                        if (txtNum22.Text == "")
                            txtNum22.Text = "0";
                    }
                }
                double calcula2x2 = (num11 * num22) - (num21 * num12);
                lblResult.Text = calcula2x2.ToString();
            }

            if (rad3x3.Checked)
            {
                if (txtNum11.Text == "" || txtNum12.Text == "" || txtNum21.Text == "" || txtNum22.Text == "" || txtNum13.Text == "" || txtNum23.Text == "" || txtNum31.Text == "" || txtNum32.Text == "" || txtNum33.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou 1 (ou mais) campos sem preencher. Gostaria que eu atribuisse a TODOS esses campos o valor 0?", "Calculadora de Determinante - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtNum11.Text == "")
                            txtNum11.Text = "0";
                        if (txtNum12.Text == "")
                            txtNum12.Text = "0";
                        if (txtNum13.Text == "")
                            txtNum13.Text = "0";
                        if (txtNum21.Text == "")
                            txtNum21.Text = "0";
                        if (txtNum22.Text == "")
                            txtNum22.Text = "0";
                        if (txtNum23.Text == "")
                            txtNum23.Text = "0";
                        if (txtNum31.Text == "")
                            txtNum31.Text = "0";
                        if (txtNum32.Text == "")
                            txtNum32.Text = "0";
                        if (txtNum33.Text == "")
                            txtNum33.Text = "0";
                    }
                }
                double calcula3x3 = ((num11 * num22 * num33) + (num12 * num23 * num31) +
                                        (num13 * num21 * num32)) - ((num12 * num21 * num33) +
                                        (num11 * num23 * num32) + (num13 * num22 * num31));
                lblResult.Text = calcula3x3.ToString();
                btnNovo.Focus();
            }
            if (rad4x4.Checked)
            {
                if (txtNum11.Text == "" || txtNum12.Text == "" || txtNum21.Text == "" || txtNum22.Text == "" || txtNum13.Text == "" || txtNum23.Text == "" || txtNum31.Text == "" || txtNum32.Text == "" || txtNum33.Text == "" || txtNum34.Text == "" || txtNum41.Text == "" || txtNum42.Text == "" || txtNum43.Text == "" || txtNum44.Text == "" || txtNum14.Text == "" || txtNum24.Text == "")
                {
                    resposta = MessageBox.Show("Percebi que você deixou 1 (ou mais) campos sem preencher. Gostaria que eu atribuisse a TODOS esses campos o valor 0?", "Calculadora de Determinante - Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        if (txtNum11.Text == "")
                            txtNum11.Text = "0";
                        if (txtNum12.Text == "")
                            txtNum12.Text = "0";
                        if (txtNum13.Text == "")
                            txtNum13.Text = "0";
                        if (txtNum14.Text == "")
                            txtNum14.Text = "0";
                        if (txtNum21.Text == "")
                            txtNum21.Text = "0";
                        if (txtNum22.Text == "")
                            txtNum22.Text = "0";
                        if (txtNum23.Text == "")
                            txtNum23.Text = "0";
                        if (txtNum24.Text == "")
                            txtNum24.Text = "0";
                        if (txtNum31.Text == "")
                            txtNum31.Text = "0";
                        if (txtNum32.Text == "")
                            txtNum32.Text = "0";
                        if (txtNum33.Text == "")
                            txtNum33.Text = "0";
                        if (txtNum34.Text == "")
                            txtNum34.Text = "0";
                        if (txtNum41.Text == "")
                            txtNum41.Text = "0";
                        if (txtNum42.Text == "")
                            txtNum42.Text = "0";
                        if (txtNum43.Text == "")
                            txtNum43.Text = "0";
                        if (txtNum44.Text == "")
                            txtNum44.Text = "0";
                    }
                }

                // 22 23 24 | 22 23
                // 32 33 34 | 32 33
                // 42 43 44 | 42 43
                double D11 = ((num22 * num33 * num44) + (num23 * num34 * num42) +
                             (num24 * num32 * num43)) - ((num23 * num32 * num44) +
                             (num22 * num34 * num43) + (num24 * num33 * num42));

                // 12 13 14 | 12 13
                // 32 33 34 | 32 33
                // 42 43 44 | 42 43
                double D21 = ((num12 * num33 * num44) + (num13 * num34 * num42) +
                             (num14 * num32 * num43)) - ((num13 * num32 * num44) +
                             (num12 * num34 * num43) + (num14 * num33 * num42));

                // 12 13 14 | 12 13
                // 22 23 24 | 22 23
                // 42 43 44 | 42 43
                double D31 = ((num12 * num23 * num44) + (num13 * num24 * num42) +
                             (num14 * num22 * num43)) - ((num13 * num22 * num44) +
                             (num12 * num24 * num43) + (num14 * num23 * num42));

                // 12 13 14 | 12 13
                // 22 23 24 | 22 23
                // 32 33 34 | 32 33
                double D41 = ((num12 * num23 * num34) + (num13 * num24 * num32) +
                             (num14 * num22 * num33)) - ((num13 * num22 * num34) +
                             (num12 * num24 * num33) + (num14 * num23 * num32));

                double A11 = Math.Pow((-1), 1 + 1) * D11;
                double A21 = Math.Pow((-1), 2 + 1) * D21;
                double A31 = Math.Pow((-1), 3 + 1) * D31;
                double A41 = Math.Pow((-1), 4 + 1) * D41;

                double calcula4x4 = double.Parse(txtNum11.Text) * A11 +
                                    double.Parse(txtNum21.Text) * A21 +
                                    double.Parse(txtNum31.Text) * A31 +
                                    double.Parse(txtNum41.Text) * A41;
                lblResult.Text = calcula4x4.ToString();
                btnNovo.Focus();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNum11.Clear();
            txtNum12.Clear();
            txtNum13.Clear();
            txtNum14.Clear();
            txtNum21.Clear();
            txtNum22.Clear();
            txtNum23.Clear();
            txtNum24.Clear();
            txtNum31.Clear();
            txtNum32.Clear();
            txtNum33.Clear();
            txtNum34.Clear();
            txtNum41.Clear();
            txtNum42.Clear();
            txtNum43.Clear();
            txtNum44.Clear();
            txtNum11.Focus();
            lblResult.Text = "";
        }

        private void rad2x2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2x2.Checked)
            {
                txtNum11.Focus();
                Size size = imgChaveEsq.Size;
                size.Height = 107;
                size.Width = 45;
                imgChaveEsq.Size = size;
                imgChaveEsq.Location = new Point(378 - 27, 62);

                size = imgChaveDir.Size;
                size.Height = 107;
                size.Width = 33;
                imgChaveDir.Size = size;
                imgChaveDir.Location = new Point(548 - 27, 62);

                txtNum11.Location = new Point(426 - 27, 84);
                txtNum12.Location = new Point(487 - 27, 84);
                txtNum21.Location = new Point(426 - 27, 121);
                txtNum22.Location = new Point(487 - 27, 121);

                txtNum11.TabIndex = 1;
                txtNum12.TabIndex = 2;
                txtNum21.TabIndex = 3;
                txtNum22.TabIndex = 4;
                btnCalcula.TabIndex = 5;
                btnNovo.TabIndex = 6;
                btnVoltar.TabIndex = 7;

                txtNum13.Visible = false;
                txtNum14.Visible = false;
                txtNum23.Visible = false;
                txtNum24.Visible = false;
                txtNum31.Visible = false;
                txtNum32.Visible = false;
                txtNum33.Visible = false;
                txtNum34.Visible = false;
                txtNum41.Visible = false;
                txtNum42.Visible = false;
                txtNum43.Visible = false;
                txtNum44.Visible = false;
            }
        }

        private void rad3x3_CheckedChanged(object sender, EventArgs e)
        {
            if(rad3x3.Checked)
            {
                txtNum11.Focus();
                Size size = imgChaveEsq.Size;
                size.Height = 148;
                size.Width = 45;
                imgChaveEsq.Size = size;
                imgChaveEsq.Location = new Point(378 - 27, 47);

                size = imgChaveDir.Size;
                size.Height = 148;
                size.Width = 33;
                imgChaveDir.Size = size;
                imgChaveDir.Location = new Point(609 - 27, 47);

                txtNum11.Location = new Point(426 - 27, 72);
                txtNum12.Location = new Point(487 - 27, 72);
                txtNum13.Location = new Point(548 - 27, 72);
                txtNum21.Location = new Point(426 - 27, 109);
                txtNum22.Location = new Point(487 - 27, 109);
                txtNum23.Location = new Point(548 - 27, 109);
                txtNum31.Location = new Point(426 - 27, 146);
                txtNum32.Location = new Point(487 - 27, 146);
                txtNum33.Location = new Point(548 - 27, 146);

                txtNum11.TabIndex = 1;
                txtNum12.TabIndex = 2;
                txtNum13.TabIndex = 3;
                txtNum21.TabIndex = 4;
                txtNum22.TabIndex = 5;
                txtNum23.TabIndex = 6;
                txtNum31.TabIndex = 7;
                txtNum32.TabIndex = 8;
                txtNum33.TabIndex = 9;
                btnCalcula.TabIndex = 10;
                btnNovo.TabIndex = 11; 
                btnVoltar.TabIndex = 12;

                txtNum13.Visible = true;
                txtNum14.Visible = false;
                txtNum23.Visible = true;
                txtNum24.Visible = false;
                txtNum31.Visible = true;
                txtNum32.Visible = true;
                txtNum33.Visible = true;
                txtNum34.Visible = false;
                txtNum41.Visible = false;
                txtNum42.Visible = false;
                txtNum43.Visible = false;
                txtNum44.Visible = false;
            }
        }

        private void rad4x4_CheckedChanged(object sender, EventArgs e)
        {
            if (rad4x4.Checked)
            {
                txtNum11.Focus();
                Size size = imgChaveEsq.Size;
                size.Height = 192;
                size.Width = 45;
                imgChaveEsq.Size = size;
                imgChaveEsq.Location = new Point(378 - 27, 19 + 17);

                size = imgChaveDir.Size;
                size.Height = 192;
                size.Width = 33;
                imgChaveDir.Size = size;
                imgChaveDir.Location = new Point(670 - 27, 19 + 17);

                txtNum11.Location = new Point(426 - 27, 47 + 17);
                txtNum12.Location = new Point(487 - 27, 47 + 17);
                txtNum13.Location = new Point(548 - 27, 47 + 17);
                txtNum14.Location = new Point(609 - 27, 47 + 17);
                txtNum21.Location = new Point(426 - 27, 84 + 17);
                txtNum22.Location = new Point(487 - 27, 84 + 17);
                txtNum23.Location = new Point(548 - 27, 84 + 17);
                txtNum24.Location = new Point(609 - 27, 84 + 17);
                txtNum31.Location = new Point(426 - 27, 121 + 17);
                txtNum32.Location = new Point(487 - 27, 121 + 17);
                txtNum33.Location = new Point(548 - 27, 121 + 17);
                txtNum34.Location = new Point(609 - 27, 121 + 17);
                txtNum41.Location = new Point(426 - 27, 158 + 17);
                txtNum42.Location = new Point(487 - 27, 158 + 17);
                txtNum43.Location = new Point(548 - 27, 158 + 17);
                txtNum44.Location = new Point(609 - 27, 158 + 17);

                txtNum11.TabIndex = 1;
                txtNum12.TabIndex = 2;
                txtNum13.TabIndex = 3;
                txtNum14.TabIndex = 4;
                txtNum21.TabIndex = 5;
                txtNum22.TabIndex = 6;
                txtNum23.TabIndex = 7;
                txtNum24.TabIndex = 8;
                txtNum31.TabIndex = 9;
                txtNum32.TabIndex = 10;
                txtNum33.TabIndex = 11;
                txtNum34.TabIndex = 12;
                txtNum41.TabIndex = 13;
                txtNum42.TabIndex = 14;
                txtNum43.TabIndex = 15;
                txtNum44.TabIndex = 16;
                btnCalcula.TabIndex = 17;
                btnNovo.TabIndex = 18;
                btnVoltar.TabIndex = 19;

                txtNum13.Visible = true;
                txtNum14.Visible = true;
                txtNum23.Visible = true;
                txtNum24.Visible = true;
                txtNum31.Visible = true;
                txtNum32.Visible = true;
                txtNum33.Visible = true;
                txtNum34.Visible = true;
                txtNum41.Visible = true;
                txtNum42.Visible = true;
                txtNum43.Visible = true;
                txtNum44.Visible = true;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instruções de uso: \n\n1) selecione o tipo de matriz " +
                "que deseja calcular o determinante: " +
                "\n   '2x2', '3x3' ou '4x4';" + 
                "\n\n2) para calcular, clique no botão 'Calcular' ou ALT+C;" +
                "\n\n3) para limpar os valores da tela, clique no botão 'Novo' ou ALT+N" +
                "\n\n4) para sair, clique no botão 'Sair' ou ALT+R ou no X vermelho " +
                "\n   (canto superior direito)" +
                "\n\n\nPara matriz 2x2: Multiplicar as diagonais, depois subtrair os resultados." +
                "\nexemplo) det(A) = |a11 a12|" +
                "\n                               |a21 a22|" +
                "\n\n                det(A) = (a11*a22) - (a12*a21)" +
                "\n\n\nPara matriz 3x3: Utilizar a regra de Sarrus." +
                "\nexemplo) det(A) = |a11 a12 a13|| a11 a12" +
                "\n                               |a21 a22 a23|| a21 a22" +
                "\n                               |a31 a32 a33|| a31 a32" +
                "\n\n                det(A) =  ((a11*a22*a33) + (a12*a23*a31) + (a13*a21*a32))" +
                "\n                               - ((a12*a21*a33) + (a11*a23**a32) + (a13*a22*a31)) " +
                "\n\n\nPara matriz 4x4: Utilizar o teorema de Laplace." +
                "\nexemplo) det(A) = |a11 a12 a13 a14|" +
                "\n                               |a21 a22 a23 a24|" +
                "\n                               |a31 a32 a33 a34|" +
                "\n                               |a41 a42 a43 a44|" +
                "\n\n                det(A) =  a11(((a22*a33*a44) + (a32*a43*a24) + (a42*a23*a34))" +
                "\n                               - ((a24*a33*42) + (a22*a43**a34) + (a23*a32*a44))) " +
                "\n                               - a12(((a21*a33*a44) + (a31*a43*a24) + (a41*a23*a34))" +
                "\n                               - ((a24*a33*41) + (a34*a43*a21) + (a44*a31*a23))) " +
                "\n                               + a13(((a21*a31*a44) + (a31*a42*a24) + (a41*a22*a34))" +
                "\n                               - ((a24*a33*a41) + (a34*a42*a21) + (a44*a31*a22))) " +
                "\n                               - a14(((a21*a32*a43) + (a31*a42*a23) + (a41*a22*a33))" +
                "\n                               - ((a23*a32*a41) + (a33*a42*a21) + (a43*a31*a22))) " +
                "\n\n\nObrigado por utilizar minha Calculadora de Determinante!" +
                "\nDeveloped by: Dieguito (72B - 2020)   -->   (14)99101-5057 ", "Ajuda do desenvolvedor");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNumRandom_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            
            int n11 = sorteio.Next(-10, 15);
            int n12 = sorteio.Next(-10, 15);
            int n13 = sorteio.Next(-10, 15);
            int n14 = sorteio.Next(-10, 15);

            int n21 = sorteio.Next(-10, 15);
            int n22 = sorteio.Next(-10, 15);
            int n23 = sorteio.Next(-10, 15);
            int n24 = sorteio.Next(-10, 15);

            int n31 = sorteio.Next(-10, 15);
            int n32 = sorteio.Next(-10, 15);
            int n33 = sorteio.Next(-10, 15);
            int n34 = sorteio.Next(-10, 15);

            int n41 = sorteio.Next(-10, 15);
            int n42 = sorteio.Next(-10, 15);
            int n43 = sorteio.Next(-10, 15);
            int n44 = sorteio.Next(-10, 15);

            txtNum11.Text = n11.ToString();
            txtNum12.Text = n12.ToString();
            txtNum13.Text = n13.ToString();
            txtNum14.Text = n14.ToString();

            txtNum21.Text = n21.ToString();
            txtNum22.Text = n22.ToString();
            txtNum23.Text = n23.ToString();
            txtNum24.Text = n24.ToString();

            txtNum31.Text = n31.ToString();
            txtNum32.Text = n32.ToString();
            txtNum33.Text = n33.ToString();
            txtNum34.Text = n34.ToString();

            txtNum41.Text = n41.ToString();
            txtNum42.Text = n42.ToString();
            txtNum43.Text = n43.ToString();
            txtNum44.Text = n44.ToString();

            btnNumRandom.Focus();
        }
    }
}
