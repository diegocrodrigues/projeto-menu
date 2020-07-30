namespace Forms_Diego_08
{
    partial class frmIntroDedos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntroDedos));
            this.lblMensagem1 = new System.Windows.Forms.Label();
            this.lblMensagem2 = new System.Windows.Forms.Label();
            this.lblMensagem3 = new System.Windows.Forms.Label();
            this.lblMensagem4 = new System.Windows.Forms.Label();
            this.openFileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirFoto = new System.Windows.Forms.Button();
            this.btnLimparFoto = new System.Windows.Forms.Button();
            this.btnPróximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEscolhaFoto = new System.Windows.Forms.Label();
            this.lblEscolhaProfessor = new System.Windows.Forms.Label();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picProfessor = new System.Windows.Forms.PictureBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblAnterior = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDigiteNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem1
            // 
            this.lblMensagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem1.Location = new System.Drawing.Point(12, 25);
            this.lblMensagem1.Name = "lblMensagem1";
            this.lblMensagem1.Size = new System.Drawing.Size(817, 27);
            this.lblMensagem1.TabIndex = 0;
            this.lblMensagem1.Text = "O jogo consiste em adivinhações precisas sobre a somatória das mãos de cada parti" +
    "cipante. ";
            this.lblMensagem1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMensagem2
            // 
            this.lblMensagem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem2.Location = new System.Drawing.Point(12, 52);
            this.lblMensagem2.Name = "lblMensagem2";
            this.lblMensagem2.Size = new System.Drawing.Size(817, 25);
            this.lblMensagem2.TabIndex = 1;
            this.lblMensagem2.Text = "Para cada acerto, o professor sortudo acumula 1 ponto.";
            this.lblMensagem2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensagem3
            // 
            this.lblMensagem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem3.Location = new System.Drawing.Point(12, 81);
            this.lblMensagem3.Name = "lblMensagem3";
            this.lblMensagem3.Size = new System.Drawing.Size(817, 25);
            this.lblMensagem3.TabIndex = 2;
            this.lblMensagem3.Text = "Vence o professor que acumular 3 pontos primeiro.";
            this.lblMensagem3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensagem4
            // 
            this.lblMensagem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem4.Location = new System.Drawing.Point(12, 109);
            this.lblMensagem4.Name = "lblMensagem4";
            this.lblMensagem4.Size = new System.Drawing.Size(817, 25);
            this.lblMensagem4.TabIndex = 3;
            this.lblMensagem4.Text = "Divirta-se!";
            this.lblMensagem4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialogFoto
            // 
            this.openFileDialogFoto.FileName = "openFileDialog1";
            // 
            // btnAbrirFoto
            // 
            this.btnAbrirFoto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbrirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFoto.Location = new System.Drawing.Point(174, 437);
            this.btnAbrirFoto.Name = "btnAbrirFoto";
            this.btnAbrirFoto.Size = new System.Drawing.Size(170, 35);
            this.btnAbrirFoto.TabIndex = 5;
            this.btnAbrirFoto.Text = "&Carregar Foto";
            this.btnAbrirFoto.UseVisualStyleBackColor = false;
            this.btnAbrirFoto.Click += new System.EventHandler(this.btnAbrirFoto_Click);
            // 
            // btnLimparFoto
            // 
            this.btnLimparFoto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimparFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFoto.Location = new System.Drawing.Point(174, 470);
            this.btnLimparFoto.Name = "btnLimparFoto";
            this.btnLimparFoto.Size = new System.Drawing.Size(170, 37);
            this.btnLimparFoto.TabIndex = 6;
            this.btnLimparFoto.Text = "&Limpar Foto";
            this.btnLimparFoto.UseVisualStyleBackColor = false;
            this.btnLimparFoto.Click += new System.EventHandler(this.btnLimparFoto_Click);
            // 
            // btnPróximo
            // 
            this.btnPróximo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPróximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPróximo.Location = new System.Drawing.Point(579, 474);
            this.btnPróximo.Name = "btnPróximo";
            this.btnPróximo.Size = new System.Drawing.Size(80, 37);
            this.btnPróximo.TabIndex = 8;
            this.btnPróximo.Text = ">";
            this.btnPróximo.UseVisualStyleBackColor = false;
            this.btnPróximo.Click += new System.EventHandler(this.btnPróximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(483, 475);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(85, 37);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Green;
            this.lblNome.Location = new System.Drawing.Point(483, 210);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(176, 37);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Bicudo";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEscolhaFoto
            // 
            this.lblEscolhaFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaFoto.ForeColor = System.Drawing.Color.Red;
            this.lblEscolhaFoto.Location = new System.Drawing.Point(174, 159);
            this.lblEscolhaFoto.Name = "lblEscolhaFoto";
            this.lblEscolhaFoto.Size = new System.Drawing.Size(170, 50);
            this.lblEscolhaFoto.TabIndex = 11;
            this.lblEscolhaFoto.Text = "Escolha sua Foto:";
            this.lblEscolhaFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEscolhaProfessor
            // 
            this.lblEscolhaProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaProfessor.ForeColor = System.Drawing.Color.Red;
            this.lblEscolhaProfessor.Location = new System.Drawing.Point(478, 159);
            this.lblEscolhaProfessor.Name = "lblEscolhaProfessor";
            this.lblEscolhaProfessor.Size = new System.Drawing.Size(181, 51);
            this.lblEscolhaProfessor.TabIndex = 12;
            this.lblEscolhaProfessor.Text = "Escolha seu professor:";
            this.lblEscolhaProfessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.Location = new System.Drawing.Point(716, 508);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(104, 45);
            this.btnAvancar.TabIndex = 13;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.BackColor = System.Drawing.Color.White;
            this.txtNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeJogador.ForeColor = System.Drawing.Color.Green;
            this.txtNomeJogador.Location = new System.Drawing.Point(174, 211);
            this.txtNomeJogador.MaxLength = 8;
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(170, 36);
            this.txtNomeJogador.TabIndex = 15;
            this.txtNomeJogador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeJogador.Click += new System.EventHandler(this.txtNomeJogador_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 508);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 45);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picProfessor
            // 
            this.picProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfessor.Image = global::Forms_Diego_08.Properties.Resources.bicudo2;
            this.picProfessor.Location = new System.Drawing.Point(483, 253);
            this.picProfessor.Name = "picProfessor";
            this.picProfessor.Size = new System.Drawing.Size(176, 179);
            this.picProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfessor.TabIndex = 7;
            this.picProfessor.TabStop = false;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.White;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::Forms_Diego_08.Properties.Resources.unknown_avatar_icon_21;
            this.picFoto.Location = new System.Drawing.Point(174, 253);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(170, 179);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 4;
            this.picFoto.TabStop = false;
            // 
            // lblAnterior
            // 
            this.lblAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnterior.ForeColor = System.Drawing.Color.Black;
            this.lblAnterior.Location = new System.Drawing.Point(483, 438);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(85, 34);
            this.lblAnterior.TabIndex = 17;
            this.lblAnterior.Text = "anterior";
            this.lblAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(577, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "próximo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDigiteNome
            // 
            this.lblDigiteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteNome.ForeColor = System.Drawing.Color.Black;
            this.lblDigiteNome.Location = new System.Drawing.Point(85, 212);
            this.lblDigiteNome.Name = "lblDigiteNome";
            this.lblDigiteNome.Size = new System.Drawing.Size(83, 37);
            this.lblDigiteNome.TabIndex = 19;
            this.lblDigiteNome.Text = "Digite:";
            this.lblDigiteNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIntroDedos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 565);
            this.Controls.Add(this.lblDigiteNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnterior);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.lblEscolhaProfessor);
            this.Controls.Add(this.lblEscolhaFoto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPróximo);
            this.Controls.Add(this.picProfessor);
            this.Controls.Add(this.btnLimparFoto);
            this.Controls.Add(this.btnAbrirFoto);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.lblMensagem4);
            this.Controls.Add(this.lblMensagem3);
            this.Controls.Add(this.lblMensagem2);
            this.Controls.Add(this.lblMensagem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIntroDedos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introdução: Dedos";
            ((System.ComponentModel.ISupportInitialize)(this.picProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem1;
        private System.Windows.Forms.Label lblMensagem2;
        private System.Windows.Forms.Label lblMensagem3;
        private System.Windows.Forms.Label lblMensagem4;
        private System.Windows.Forms.OpenFileDialog openFileDialogFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnAbrirFoto;
        private System.Windows.Forms.Button btnLimparFoto;
        private System.Windows.Forms.PictureBox picProfessor;
        private System.Windows.Forms.Button btnPróximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEscolhaFoto;
        private System.Windows.Forms.Label lblEscolhaProfessor;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDigiteNome;
    }
}