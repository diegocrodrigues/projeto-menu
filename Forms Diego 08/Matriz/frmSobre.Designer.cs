namespace Forms_Diego_08
{
    partial class frmSobre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblBotaoDedos = new System.Windows.Forms.Label();
            this.lblNomeDiego = new System.Windows.Forms.Label();
            this.lblNomeBicudo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCTI = new System.Windows.Forms.Label();
            this.imgBicudo = new System.Windows.Forms.PictureBox();
            this.imgDiego = new System.Windows.Forms.PictureBox();
            this.lblBotaoCalcMatriz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBicudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDiego)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(57, 9);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(776, 93);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Esse formulário foi desenvolvido pelo aluno Diego Carvalho Rodrigues (08), do 72B" +
    ", no ano de 2020. O professor da disciplina de C# é o André Luís Bicudo";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBotaoDedos
            // 
            this.lblBotaoDedos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotaoDedos.Location = new System.Drawing.Point(37, 380);
            this.lblBotaoDedos.Name = "lblBotaoDedos";
            this.lblBotaoDedos.Size = new System.Drawing.Size(796, 79);
            this.lblBotaoDedos.TabIndex = 6;
            this.lblBotaoDedos.Text = resources.GetString("lblBotaoDedos.Text");
            this.lblBotaoDedos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeDiego
            // 
            this.lblNomeDiego.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDiego.ForeColor = System.Drawing.Color.Red;
            this.lblNomeDiego.Location = new System.Drawing.Point(163, 255);
            this.lblNomeDiego.Name = "lblNomeDiego";
            this.lblNomeDiego.Size = new System.Drawing.Size(153, 43);
            this.lblNomeDiego.TabIndex = 12;
            this.lblNomeDiego.Text = "Diego Carvalho Rodrigues";
            this.lblNomeDiego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeDiego.UseCompatibleTextRendering = true;
            // 
            // lblNomeBicudo
            // 
            this.lblNomeBicudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBicudo.ForeColor = System.Drawing.Color.Red;
            this.lblNomeBicudo.Location = new System.Drawing.Point(526, 255);
            this.lblNomeBicudo.Name = "lblNomeBicudo";
            this.lblNomeBicudo.Size = new System.Drawing.Size(153, 43);
            this.lblNomeBicudo.TabIndex = 13;
            this.lblNomeBicudo.Text = "André Luís Bicudo";
            this.lblNomeBicudo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeBicudo.UseCompatibleTextRendering = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(747, 476);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 44);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCTI
            // 
            this.lblCTI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTI.ForeColor = System.Drawing.Color.Red;
            this.lblCTI.Location = new System.Drawing.Point(360, 486);
            this.lblCTI.Name = "lblCTI";
            this.lblCTI.Size = new System.Drawing.Size(160, 24);
            this.lblCTI.TabIndex = 15;
            this.lblCTI.Text = "CTI Unesp 2020";
            this.lblCTI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCTI.UseCompatibleTextRendering = true;
            // 
            // imgBicudo
            // 
            this.imgBicudo.Image = global::Forms_Diego_08.Properties.Resources.bicudo;
            this.imgBicudo.Location = new System.Drawing.Point(526, 105);
            this.imgBicudo.Name = "imgBicudo";
            this.imgBicudo.Size = new System.Drawing.Size(153, 147);
            this.imgBicudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBicudo.TabIndex = 11;
            this.imgBicudo.TabStop = false;
            // 
            // imgDiego
            // 
            this.imgDiego.Image = global::Forms_Diego_08.Properties.Resources.diego;
            this.imgDiego.Location = new System.Drawing.Point(163, 105);
            this.imgDiego.Name = "imgDiego";
            this.imgDiego.Size = new System.Drawing.Size(153, 147);
            this.imgDiego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDiego.TabIndex = 10;
            this.imgDiego.TabStop = false;
            // 
            // lblBotaoCalcMatriz
            // 
            this.lblBotaoCalcMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotaoCalcMatriz.Location = new System.Drawing.Point(37, 315);
            this.lblBotaoCalcMatriz.Name = "lblBotaoCalcMatriz";
            this.lblBotaoCalcMatriz.Size = new System.Drawing.Size(796, 49);
            this.lblBotaoCalcMatriz.TabIndex = 16;
            this.lblBotaoCalcMatriz.Text = "Ao clicar no botão CALCULADORA DE MATRIZ, o usuário é direcionado ao formulário q" +
    "ue calcula o determinante de uma matriz (seja ela 2x2, 3x3 ou 4,4)";
            this.lblBotaoCalcMatriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 532);
            this.Controls.Add(this.lblBotaoCalcMatriz);
            this.Controls.Add(this.lblCTI);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblNomeBicudo);
            this.Controls.Add(this.lblNomeDiego);
            this.Controls.Add(this.imgBicudo);
            this.Controls.Add(this.imgDiego);
            this.Controls.Add(this.lblBotaoDedos);
            this.Controls.Add(this.lblIntro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.imgBicudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDiego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblBotaoDedos;
        private System.Windows.Forms.PictureBox imgDiego;
        private System.Windows.Forms.PictureBox imgBicudo;
        private System.Windows.Forms.Label lblNomeDiego;
        private System.Windows.Forms.Label lblNomeBicudo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCTI;
        private System.Windows.Forms.Label lblBotaoCalcMatriz;
    }
}