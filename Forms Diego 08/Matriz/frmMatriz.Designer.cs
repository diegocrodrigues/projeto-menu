namespace Forms_Diego_08
{
    partial class frmMatriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatriz));
            this.txtNum11 = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtNum21 = new System.Windows.Forms.TextBox();
            this.txtNum12 = new System.Windows.Forms.TextBox();
            this.txtNum22 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.rad3x3 = new System.Windows.Forms.RadioButton();
            this.rad2x2 = new System.Windows.Forms.RadioButton();
            this.rad4x4 = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtNum31 = new System.Windows.Forms.TextBox();
            this.txtNum32 = new System.Windows.Forms.TextBox();
            this.txtNum33 = new System.Windows.Forms.TextBox();
            this.txtNum23 = new System.Windows.Forms.TextBox();
            this.txtNum13 = new System.Windows.Forms.TextBox();
            this.txtNum34 = new System.Windows.Forms.TextBox();
            this.txtNum24 = new System.Windows.Forms.TextBox();
            this.txtNum14 = new System.Windows.Forms.TextBox();
            this.txtNum44 = new System.Windows.Forms.TextBox();
            this.txtNum43 = new System.Windows.Forms.TextBox();
            this.txtNum42 = new System.Windows.Forms.TextBox();
            this.txtNum41 = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblDet = new System.Windows.Forms.Label();
            this.lblDeterm = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblConceitoMatriz = new System.Windows.Forms.Label();
            this.imgLine = new System.Windows.Forms.PictureBox();
            this.imgConceito = new System.Windows.Forms.PictureBox();
            this.imgChaveDir = new System.Windows.Forms.PictureBox();
            this.imgChaveEsq = new System.Windows.Forms.PictureBox();
            this.lbl2x2 = new System.Windows.Forms.Label();
            this.lbl4x4 = new System.Windows.Forms.Label();
            this.lbl3x3 = new System.Windows.Forms.Label();
            this.lblDuvidas = new System.Windows.Forms.Label();
            this.grpboxPassoAPasso = new System.Windows.Forms.GroupBox();
            this.btnNumRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConceito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChaveDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChaveEsq)).BeginInit();
            this.grpboxPassoAPasso.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum11
            // 
            this.txtNum11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum11.Location = new System.Drawing.Point(532, 103);
            this.txtNum11.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum11.Name = "txtNum11";
            this.txtNum11.Size = new System.Drawing.Size(72, 37);
            this.txtNum11.TabIndex = 0;
            this.txtNum11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum11_KeyPress);
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcula.Location = new System.Drawing.Point(424, 324);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(105, 39);
            this.btnCalcula.TabIndex = 5;
            this.btnCalcula.Text = "&CALCULA";
            this.btnCalcula.UseVisualStyleBackColor = false;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtNum21
            // 
            this.txtNum21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum21.Location = new System.Drawing.Point(532, 149);
            this.txtNum21.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum21.Name = "txtNum21";
            this.txtNum21.Size = new System.Drawing.Size(72, 37);
            this.txtNum21.TabIndex = 4;
            this.txtNum21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum21_KeyPress);
            // 
            // txtNum12
            // 
            this.txtNum12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum12.Location = new System.Drawing.Point(613, 103);
            this.txtNum12.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum12.Name = "txtNum12";
            this.txtNum12.Size = new System.Drawing.Size(72, 37);
            this.txtNum12.TabIndex = 3;
            this.txtNum12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum12_KeyPress);
            // 
            // txtNum22
            // 
            this.txtNum22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum22.Location = new System.Drawing.Point(613, 149);
            this.txtNum22.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum22.Name = "txtNum22";
            this.txtNum22.Size = new System.Drawing.Size(72, 37);
            this.txtNum22.TabIndex = 1;
            this.txtNum22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum22_KeyPress);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(779, 370);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 60);
            this.lblResult.TabIndex = 16;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(424, 370);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 39);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "&NOVO";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // rad3x3
            // 
            this.rad3x3.AutoSize = true;
            this.rad3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad3x3.Location = new System.Drawing.Point(649, 15);
            this.rad3x3.Margin = new System.Windows.Forms.Padding(4);
            this.rad3x3.Name = "rad3x3";
            this.rad3x3.Size = new System.Drawing.Size(65, 29);
            this.rad3x3.TabIndex = 23;
            this.rad3x3.Text = "3x3";
            this.rad3x3.UseVisualStyleBackColor = true;
            this.rad3x3.CheckedChanged += new System.EventHandler(this.rad3x3_CheckedChanged);
            // 
            // rad2x2
            // 
            this.rad2x2.AutoSize = true;
            this.rad2x2.Checked = true;
            this.rad2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad2x2.Location = new System.Drawing.Point(572, 15);
            this.rad2x2.Margin = new System.Windows.Forms.Padding(4);
            this.rad2x2.Name = "rad2x2";
            this.rad2x2.Size = new System.Drawing.Size(65, 29);
            this.rad2x2.TabIndex = 22;
            this.rad2x2.TabStop = true;
            this.rad2x2.Text = "2x2";
            this.rad2x2.UseVisualStyleBackColor = true;
            this.rad2x2.CheckedChanged += new System.EventHandler(this.rad2x2_CheckedChanged);
            // 
            // rad4x4
            // 
            this.rad4x4.AutoSize = true;
            this.rad4x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad4x4.Location = new System.Drawing.Point(727, 15);
            this.rad4x4.Margin = new System.Windows.Forms.Padding(4);
            this.rad4x4.Name = "rad4x4";
            this.rad4x4.Size = new System.Drawing.Size(65, 29);
            this.rad4x4.TabIndex = 24;
            this.rad4x4.Text = "4x4";
            this.rad4x4.UseVisualStyleBackColor = true;
            this.rad4x4.CheckedChanged += new System.EventHandler(this.rad4x4_CheckedChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(512, 15);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 25);
            this.lblTipo.TabIndex = 25;
            this.lblTipo.Text = "tipo:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(424, 417);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 39);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "&VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtNum31
            // 
            this.txtNum31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum31.Location = new System.Drawing.Point(532, 149);
            this.txtNum31.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum31.Name = "txtNum31";
            this.txtNum31.Size = new System.Drawing.Size(72, 37);
            this.txtNum31.TabIndex = 27;
            this.txtNum31.Visible = false;
            this.txtNum31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum31_KeyPress);
            // 
            // txtNum32
            // 
            this.txtNum32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum32.Location = new System.Drawing.Point(731, 149);
            this.txtNum32.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum32.Name = "txtNum32";
            this.txtNum32.Size = new System.Drawing.Size(72, 37);
            this.txtNum32.TabIndex = 28;
            this.txtNum32.Visible = false;
            this.txtNum32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum32_KeyPress);
            // 
            // txtNum33
            // 
            this.txtNum33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum33.Location = new System.Drawing.Point(731, 170);
            this.txtNum33.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum33.Name = "txtNum33";
            this.txtNum33.Size = new System.Drawing.Size(72, 37);
            this.txtNum33.TabIndex = 31;
            this.txtNum33.Visible = false;
            this.txtNum33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum33_KeyPress);
            // 
            // txtNum23
            // 
            this.txtNum23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum23.Location = new System.Drawing.Point(731, 103);
            this.txtNum23.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum23.Name = "txtNum23";
            this.txtNum23.Size = new System.Drawing.Size(72, 37);
            this.txtNum23.TabIndex = 30;
            this.txtNum23.Visible = false;
            this.txtNum23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum23_KeyPress);
            // 
            // txtNum13
            // 
            this.txtNum13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum13.Location = new System.Drawing.Point(731, 58);
            this.txtNum13.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum13.Name = "txtNum13";
            this.txtNum13.Size = new System.Drawing.Size(72, 37);
            this.txtNum13.TabIndex = 29;
            this.txtNum13.Visible = false;
            this.txtNum13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum13_KeyPress);
            // 
            // txtNum34
            // 
            this.txtNum34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum34.Location = new System.Drawing.Point(812, 149);
            this.txtNum34.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum34.Name = "txtNum34";
            this.txtNum34.Size = new System.Drawing.Size(72, 37);
            this.txtNum34.TabIndex = 34;
            this.txtNum34.Visible = false;
            this.txtNum34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum34_KeyPress);
            // 
            // txtNum24
            // 
            this.txtNum24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum24.Location = new System.Drawing.Point(812, 103);
            this.txtNum24.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum24.Name = "txtNum24";
            this.txtNum24.Size = new System.Drawing.Size(72, 37);
            this.txtNum24.TabIndex = 33;
            this.txtNum24.Visible = false;
            this.txtNum24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum24_KeyPress);
            // 
            // txtNum14
            // 
            this.txtNum14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum14.Location = new System.Drawing.Point(812, 58);
            this.txtNum14.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum14.Name = "txtNum14";
            this.txtNum14.Size = new System.Drawing.Size(72, 37);
            this.txtNum14.TabIndex = 32;
            this.txtNum14.Visible = false;
            this.txtNum14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum14_KeyPress);
            // 
            // txtNum44
            // 
            this.txtNum44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum44.Location = new System.Drawing.Point(812, 194);
            this.txtNum44.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum44.Name = "txtNum44";
            this.txtNum44.Size = new System.Drawing.Size(72, 37);
            this.txtNum44.TabIndex = 38;
            this.txtNum44.Visible = false;
            this.txtNum44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum44_KeyPress);
            // 
            // txtNum43
            // 
            this.txtNum43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum43.Location = new System.Drawing.Point(731, 194);
            this.txtNum43.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum43.Name = "txtNum43";
            this.txtNum43.Size = new System.Drawing.Size(72, 37);
            this.txtNum43.TabIndex = 37;
            this.txtNum43.Visible = false;
            this.txtNum43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum43_KeyPress);
            // 
            // txtNum42
            // 
            this.txtNum42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum42.Location = new System.Drawing.Point(649, 194);
            this.txtNum42.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum42.Name = "txtNum42";
            this.txtNum42.Size = new System.Drawing.Size(72, 37);
            this.txtNum42.TabIndex = 36;
            this.txtNum42.Visible = false;
            this.txtNum42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum42_KeyPress);
            // 
            // txtNum41
            // 
            this.txtNum41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum41.Location = new System.Drawing.Point(568, 194);
            this.txtNum41.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum41.Name = "txtNum41";
            this.txtNum41.Size = new System.Drawing.Size(72, 37);
            this.txtNum41.TabIndex = 35;
            this.txtNum41.Visible = false;
            this.txtNum41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum41_KeyPress);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(645, 333);
            this.lblR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(158, 36);
            this.lblR.TabIndex = 39;
            this.lblR.Text = "Resultado:";
            // 
            // lblDet
            // 
            this.lblDet.AutoSize = true;
            this.lblDet.BackColor = System.Drawing.Color.White;
            this.lblDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDet.Location = new System.Drawing.Point(636, 370);
            this.lblDet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDet.Name = "lblDet";
            this.lblDet.Padding = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.lblDet.Size = new System.Drawing.Size(143, 60);
            this.lblDet.TabIndex = 40;
            this.lblDet.Text = "det(A) = ";
            this.lblDet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeterm
            // 
            this.lblDeterm.AutoSize = true;
            this.lblDeterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeterm.Location = new System.Drawing.Point(371, 128);
            this.lblDeterm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeterm.Name = "lblDeterm";
            this.lblDeterm.Size = new System.Drawing.Size(98, 29);
            this.lblDeterm.TabIndex = 43;
            this.lblDeterm.Text = "det(A) =";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(881, 466);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 38);
            this.btnHelp.TabIndex = 44;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblConceitoMatriz
            // 
            this.lblConceitoMatriz.AutoSize = true;
            this.lblConceitoMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceitoMatriz.Location = new System.Drawing.Point(89, 14);
            this.lblConceitoMatriz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConceitoMatriz.Name = "lblConceitoMatriz";
            this.lblConceitoMatriz.Size = new System.Drawing.Size(175, 25);
            this.lblConceitoMatriz.TabIndex = 56;
            this.lblConceitoMatriz.Text = "Conceito de Matriz";
            // 
            // imgLine
            // 
            this.imgLine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.imgLine.Image = global::Forms_Diego_08.Properties.Resources.line2;
            this.imgLine.Location = new System.Drawing.Point(376, 270);
            this.imgLine.Margin = new System.Windows.Forms.Padding(4);
            this.imgLine.Name = "imgLine";
            this.imgLine.Size = new System.Drawing.Size(537, 12);
            this.imgLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLine.TabIndex = 57;
            this.imgLine.TabStop = false;
            // 
            // imgConceito
            // 
            this.imgConceito.Image = global::Forms_Diego_08.Properties.Resources.Matriz_organizacao_300x223;
            this.imgConceito.Location = new System.Drawing.Point(13, 42);
            this.imgConceito.Margin = new System.Windows.Forms.Padding(4);
            this.imgConceito.Name = "imgConceito";
            this.imgConceito.Size = new System.Drawing.Size(343, 217);
            this.imgConceito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgConceito.TabIndex = 52;
            this.imgConceito.TabStop = false;
            // 
            // imgChaveDir
            // 
            this.imgChaveDir.Image = global::Forms_Diego_08.Properties.Resources.chave_dir;
            this.imgChaveDir.Location = new System.Drawing.Point(695, 76);
            this.imgChaveDir.Margin = new System.Windows.Forms.Padding(4);
            this.imgChaveDir.Name = "imgChaveDir";
            this.imgChaveDir.Size = new System.Drawing.Size(44, 132);
            this.imgChaveDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgChaveDir.TabIndex = 42;
            this.imgChaveDir.TabStop = false;
            // 
            // imgChaveEsq
            // 
            this.imgChaveEsq.Image = global::Forms_Diego_08.Properties.Resources.chave_esq;
            this.imgChaveEsq.Location = new System.Drawing.Point(468, 76);
            this.imgChaveEsq.Margin = new System.Windows.Forms.Padding(4);
            this.imgChaveEsq.Name = "imgChaveEsq";
            this.imgChaveEsq.Size = new System.Drawing.Size(60, 132);
            this.imgChaveEsq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgChaveEsq.TabIndex = 41;
            this.imgChaveEsq.TabStop = false;
            // 
            // lbl2x2
            // 
            this.lbl2x2.AutoSize = true;
            this.lbl2x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2x2.Location = new System.Drawing.Point(8, 32);
            this.lbl2x2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2x2.Name = "lbl2x2";
            this.lbl2x2.Size = new System.Drawing.Size(263, 25);
            this.lbl2x2.TabIndex = 58;
            this.lbl2x2.Text = " 2x2:   (a11*a22) - (a12*a21)";
            // 
            // lbl4x4
            // 
            this.lbl4x4.AutoSize = true;
            this.lbl4x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4x4.Location = new System.Drawing.Point(12, 130);
            this.lbl4x4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4x4.Name = "lbl4x4";
            this.lbl4x4.Size = new System.Drawing.Size(300, 25);
            this.lbl4x4.TabIndex = 61;
            this.lbl4x4.Text = "4x4:   Utilizar teorema de Laplace";
            // 
            // lbl3x3
            // 
            this.lbl3x3.AutoSize = true;
            this.lbl3x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3x3.Location = new System.Drawing.Point(12, 81);
            this.lbl3x3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3x3.Name = "lbl3x3";
            this.lbl3x3.Size = new System.Drawing.Size(244, 25);
            this.lbl3x3.TabIndex = 59;
            this.lbl3x3.Text = "3x3:   Utilizar Lei de Sarrus";
            // 
            // lblDuvidas
            // 
            this.lblDuvidas.AutoSize = true;
            this.lblDuvidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuvidas.Location = new System.Drawing.Point(637, 472);
            this.lblDuvidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuvidas.Name = "lblDuvidas";
            this.lblDuvidas.Size = new System.Drawing.Size(236, 25);
            this.lblDuvidas.TabIndex = 62;
            this.lblDuvidas.Text = "Dúvidas? Clique no botão";
            // 
            // grpboxPassoAPasso
            // 
            this.grpboxPassoAPasso.Controls.Add(this.lbl2x2);
            this.grpboxPassoAPasso.Controls.Add(this.lbl3x3);
            this.grpboxPassoAPasso.Controls.Add(this.lbl4x4);
            this.grpboxPassoAPasso.Location = new System.Drawing.Point(16, 304);
            this.grpboxPassoAPasso.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxPassoAPasso.Name = "grpboxPassoAPasso";
            this.grpboxPassoAPasso.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxPassoAPasso.Size = new System.Drawing.Size(340, 193);
            this.grpboxPassoAPasso.TabIndex = 63;
            this.grpboxPassoAPasso.TabStop = false;
            // 
            // btnNumRandom
            // 
            this.btnNumRandom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNumRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumRandom.Location = new System.Drawing.Point(376, 198);
            this.btnNumRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnNumRandom.Name = "btnNumRandom";
            this.btnNumRandom.Size = new System.Drawing.Size(93, 64);
            this.btnNumRandom.TabIndex = 64;
            this.btnNumRandom.Text = "Gerar valores aleatórios";
            this.btnNumRandom.UseVisualStyleBackColor = false;
            this.btnNumRandom.Click += new System.EventHandler(this.btnNumRandom_Click);
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btnNumRandom);
            this.Controls.Add(this.grpboxPassoAPasso);
            this.Controls.Add(this.lblDuvidas);
            this.Controls.Add(this.imgLine);
            this.Controls.Add(this.lblConceitoMatriz);
            this.Controls.Add(this.imgConceito);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblDeterm);
            this.Controls.Add(this.imgChaveDir);
            this.Controls.Add(this.imgChaveEsq);
            this.Controls.Add(this.lblDet);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtNum44);
            this.Controls.Add(this.txtNum43);
            this.Controls.Add(this.txtNum42);
            this.Controls.Add(this.txtNum41);
            this.Controls.Add(this.txtNum34);
            this.Controls.Add(this.txtNum24);
            this.Controls.Add(this.txtNum14);
            this.Controls.Add(this.txtNum33);
            this.Controls.Add(this.txtNum23);
            this.Controls.Add(this.txtNum13);
            this.Controls.Add(this.txtNum32);
            this.Controls.Add(this.txtNum31);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.rad4x4);
            this.Controls.Add(this.rad3x3);
            this.Controls.Add(this.rad2x2);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNum22);
            this.Controls.Add(this.txtNum12);
            this.Controls.Add(this.txtNum21);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtNum11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMatriz";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Matriz";
            ((System.ComponentModel.ISupportInitialize)(this.imgLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConceito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChaveDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChaveEsq)).EndInit();
            this.grpboxPassoAPasso.ResumeLayout(false);
            this.grpboxPassoAPasso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum11;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtNum21;
        private System.Windows.Forms.TextBox txtNum12;
        private System.Windows.Forms.TextBox txtNum22;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.RadioButton rad3x3;
        private System.Windows.Forms.RadioButton rad2x2;
        private System.Windows.Forms.RadioButton rad4x4;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtNum31;
        private System.Windows.Forms.TextBox txtNum32;
        private System.Windows.Forms.TextBox txtNum33;
        private System.Windows.Forms.TextBox txtNum23;
        private System.Windows.Forms.TextBox txtNum13;
        private System.Windows.Forms.TextBox txtNum34;
        private System.Windows.Forms.TextBox txtNum24;
        private System.Windows.Forms.TextBox txtNum14;
        private System.Windows.Forms.TextBox txtNum44;
        private System.Windows.Forms.TextBox txtNum43;
        private System.Windows.Forms.TextBox txtNum42;
        private System.Windows.Forms.TextBox txtNum41;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblDet;
        private System.Windows.Forms.PictureBox imgChaveEsq;
        private System.Windows.Forms.PictureBox imgChaveDir;
        private System.Windows.Forms.Label lblDeterm;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox imgConceito;
        private System.Windows.Forms.Label lblConceitoMatriz;
        private System.Windows.Forms.PictureBox imgLine;
        private System.Windows.Forms.Label lbl2x2;
        private System.Windows.Forms.Label lbl4x4;
        private System.Windows.Forms.Label lbl3x3;
        private System.Windows.Forms.Label lblDuvidas;
        private System.Windows.Forms.GroupBox grpboxPassoAPasso;
        private System.Windows.Forms.Button btnNumRandom;
    }
}

