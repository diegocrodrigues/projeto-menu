namespace Forms_Diego_08
{
    partial class frmResultadoVencedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadoVencedor));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblVencedores = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.imgCoroa2 = new System.Windows.Forms.PictureBox();
            this.imgCoroa1 = new System.Windows.Forms.PictureBox();
            this.picFotoProfessor = new System.Windows.Forms.PictureBox();
            this.picFotoJogador = new System.Windows.Forms.PictureBox();
            this.lblRodadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoroa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoroa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(30, -3);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(741, 150);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Parabéns!!! Você e seu professor venceram o jogo! Obrigado por jogar meu jogo, at" +
    "é a próxima aplicação!";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVencedores
            // 
            this.lblVencedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencedores.ForeColor = System.Drawing.Color.Green;
            this.lblVencedores.Location = new System.Drawing.Point(127, 147);
            this.lblVencedores.Name = "lblVencedores";
            this.lblVencedores.Size = new System.Drawing.Size(553, 29);
            this.lblVencedores.TabIndex = 1;
            this.lblVencedores.Text = "Vencedores:";
            this.lblVencedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(122, 440);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(158, 29);
            this.lblNomeJogador.TabIndex = 4;
            this.lblNomeJogador.Text = "Jogador";
            this.lblNomeJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(522, 440);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(158, 29);
            this.lblNomeProfessor.TabIndex = 5;
            this.lblNomeProfessor.Text = "Professor";
            this.lblNomeProfessor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(703, 498);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 33);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // imgCoroa2
            // 
            this.imgCoroa2.Image = global::Forms_Diego_08.Properties.Resources.crown1;
            this.imgCoroa2.Location = new System.Drawing.Point(553, 183);
            this.imgCoroa2.Name = "imgCoroa2";
            this.imgCoroa2.Size = new System.Drawing.Size(97, 68);
            this.imgCoroa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCoroa2.TabIndex = 8;
            this.imgCoroa2.TabStop = false;
            // 
            // imgCoroa1
            // 
            this.imgCoroa1.Image = global::Forms_Diego_08.Properties.Resources.crown1;
            this.imgCoroa1.Location = new System.Drawing.Point(153, 183);
            this.imgCoroa1.Name = "imgCoroa1";
            this.imgCoroa1.Size = new System.Drawing.Size(97, 68);
            this.imgCoroa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCoroa1.TabIndex = 7;
            this.imgCoroa1.TabStop = false;
            // 
            // picFotoProfessor
            // 
            this.picFotoProfessor.BackColor = System.Drawing.Color.White;
            this.picFotoProfessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoProfessor.Location = new System.Drawing.Point(527, 255);
            this.picFotoProfessor.Name = "picFotoProfessor";
            this.picFotoProfessor.Size = new System.Drawing.Size(153, 173);
            this.picFotoProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoProfessor.TabIndex = 3;
            this.picFotoProfessor.TabStop = false;
            // 
            // picFotoJogador
            // 
            this.picFotoJogador.BackColor = System.Drawing.Color.White;
            this.picFotoJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoJogador.Location = new System.Drawing.Point(127, 255);
            this.picFotoJogador.Name = "picFotoJogador";
            this.picFotoJogador.Size = new System.Drawing.Size(153, 173);
            this.picFotoJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoJogador.TabIndex = 2;
            this.picFotoJogador.TabStop = false;
            // 
            // lblRodadas
            // 
            this.lblRodadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodadas.ForeColor = System.Drawing.Color.Green;
            this.lblRodadas.Location = new System.Drawing.Point(286, 315);
            this.lblRodadas.Name = "lblRodadas";
            this.lblRodadas.Size = new System.Drawing.Size(235, 29);
            this.lblRodadas.TabIndex = 9;
            this.lblRodadas.Text = "Rodadas:";
            this.lblRodadas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmResultadoVencedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.lblRodadas);
            this.Controls.Add(this.imgCoroa2);
            this.Controls.Add(this.imgCoroa1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblNomeProfessor);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.picFotoProfessor);
            this.Controls.Add(this.picFotoJogador);
            this.Controls.Add(this.lblVencedores);
            this.Controls.Add(this.lblMensagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResultadoVencedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado do Jogo - Dedos";
            this.Load += new System.EventHandler(this.frmResultadoVencedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCoroa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCoroa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblVencedores;
        private System.Windows.Forms.PictureBox picFotoJogador;
        private System.Windows.Forms.PictureBox picFotoProfessor;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox imgCoroa1;
        private System.Windows.Forms.PictureBox imgCoroa2;
        private System.Windows.Forms.Label lblRodadas;
    }
}