namespace Forms_Diego_08
{
    partial class frmResultadoPerdedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadoPerdedor));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.picFotoProfessor = new System.Windows.Forms.PictureBox();
            this.picFotoJogador = new System.Windows.Forms.PictureBox();
            this.picCoroa = new System.Windows.Forms.PictureBox();
            this.lblNomeProfessorVencedor = new System.Windows.Forms.Label();
            this.picFotoProfessorVencedor = new System.Windows.Forms.PictureBox();
            this.lblParticipacão = new System.Windows.Forms.Label();
            this.lblRodadas = new System.Windows.Forms.Label();
            this.lblPlacar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoroa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProfessorVencedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(922, 542);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 33);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(310, 494);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(158, 29);
            this.lblNomeProfessor.TabIndex = 14;
            this.lblNomeProfessor.Text = "Professor";
            this.lblNomeProfessor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(107, 494);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(158, 29);
            this.lblNomeJogador.TabIndex = 13;
            this.lblNomeJogador.Text = "Jogador";
            this.lblNomeJogador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVencedor
            // 
            this.lblVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencedor.ForeColor = System.Drawing.Color.Green;
            this.lblVencedor.Location = new System.Drawing.Point(746, 194);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(153, 29);
            this.lblVencedor.TabIndex = 10;
            this.lblVencedor.Text = "Vencedor:";
            this.lblVencedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(61, 31);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(902, 150);
            this.lblMensagem.TabIndex = 9;
            this.lblMensagem.Text = "Que pena! Infelizmente você e seu professor não venceram o jogo. Obrigado por jog" +
    "ar meu jogo, até a próxima aplicação!";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFotoProfessor
            // 
            this.picFotoProfessor.BackColor = System.Drawing.Color.White;
            this.picFotoProfessor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoProfessor.Location = new System.Drawing.Point(315, 309);
            this.picFotoProfessor.Name = "picFotoProfessor";
            this.picFotoProfessor.Size = new System.Drawing.Size(153, 173);
            this.picFotoProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoProfessor.TabIndex = 12;
            this.picFotoProfessor.TabStop = false;
            // 
            // picFotoJogador
            // 
            this.picFotoJogador.BackColor = System.Drawing.Color.White;
            this.picFotoJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoJogador.Location = new System.Drawing.Point(112, 309);
            this.picFotoJogador.Name = "picFotoJogador";
            this.picFotoJogador.Size = new System.Drawing.Size(153, 173);
            this.picFotoJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoJogador.TabIndex = 11;
            this.picFotoJogador.TabStop = false;
            // 
            // picCoroa
            // 
            this.picCoroa.Image = global::Forms_Diego_08.Properties.Resources.crown1;
            this.picCoroa.Location = new System.Drawing.Point(772, 237);
            this.picCoroa.Name = "picCoroa";
            this.picCoroa.Size = new System.Drawing.Size(97, 68);
            this.picCoroa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoroa.TabIndex = 20;
            this.picCoroa.TabStop = false;
            // 
            // lblNomeProfessorVencedor
            // 
            this.lblNomeProfessorVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessorVencedor.Location = new System.Drawing.Point(741, 494);
            this.lblNomeProfessorVencedor.Name = "lblNomeProfessorVencedor";
            this.lblNomeProfessorVencedor.Size = new System.Drawing.Size(158, 29);
            this.lblNomeProfessorVencedor.TabIndex = 19;
            this.lblNomeProfessorVencedor.Text = "Professor";
            this.lblNomeProfessorVencedor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picFotoProfessorVencedor
            // 
            this.picFotoProfessorVencedor.BackColor = System.Drawing.Color.White;
            this.picFotoProfessorVencedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFotoProfessorVencedor.Location = new System.Drawing.Point(746, 309);
            this.picFotoProfessorVencedor.Name = "picFotoProfessorVencedor";
            this.picFotoProfessorVencedor.Size = new System.Drawing.Size(153, 173);
            this.picFotoProfessorVencedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoProfessorVencedor.TabIndex = 18;
            this.picFotoProfessorVencedor.TabStop = false;
            // 
            // lblParticipacão
            // 
            this.lblParticipacão.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipacão.ForeColor = System.Drawing.Color.Green;
            this.lblParticipacão.Location = new System.Drawing.Point(112, 194);
            this.lblParticipacão.Name = "lblParticipacão";
            this.lblParticipacão.Size = new System.Drawing.Size(356, 29);
            this.lblParticipacão.TabIndex = 21;
            this.lblParticipacão.Text = "Participantes:";
            this.lblParticipacão.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRodadas
            // 
            this.lblRodadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodadas.ForeColor = System.Drawing.Color.Green;
            this.lblRodadas.Location = new System.Drawing.Point(474, 194);
            this.lblRodadas.Name = "lblRodadas";
            this.lblRodadas.Size = new System.Drawing.Size(266, 29);
            this.lblRodadas.TabIndex = 22;
            this.lblRodadas.Text = "Rodadas:";
            this.lblRodadas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlacar
            // 
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.ForeColor = System.Drawing.Color.Red;
            this.lblPlacar.Location = new System.Drawing.Point(474, 358);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(266, 87);
            this.lblPlacar.TabIndex = 23;
            this.lblPlacar.Text = "0 x 0";
            this.lblPlacar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmResultadoPerdedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 587);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.lblRodadas);
            this.Controls.Add(this.lblParticipacão);
            this.Controls.Add(this.picCoroa);
            this.Controls.Add(this.lblNomeProfessorVencedor);
            this.Controls.Add(this.picFotoProfessorVencedor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblNomeProfessor);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.picFotoProfessor);
            this.Controls.Add(this.picFotoJogador);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.lblMensagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResultadoPerdedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado do Jogo - Dedos";
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoroa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoProfessorVencedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.PictureBox picFotoProfessor;
        private System.Windows.Forms.PictureBox picFotoJogador;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox picCoroa;
        private System.Windows.Forms.Label lblNomeProfessorVencedor;
        private System.Windows.Forms.PictureBox picFotoProfessorVencedor;
        private System.Windows.Forms.Label lblParticipacão;
        private System.Windows.Forms.Label lblRodadas;
        private System.Windows.Forms.Label lblPlacar;
    }
}