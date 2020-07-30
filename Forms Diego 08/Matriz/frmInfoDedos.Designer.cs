namespace Forms_Diego_08
{
    partial class frmInfoDedos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoDedos));
            this.lblInfo0 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo0
            // 
            this.lblInfo0.AutoSize = true;
            this.lblInfo0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo0.Location = new System.Drawing.Point(148, 29);
            this.lblInfo0.Name = "lblInfo0";
            this.lblInfo0.Size = new System.Drawing.Size(150, 26);
            this.lblInfo0.TabIndex = 48;
            this.lblInfo0.Text = "Informações:";
            // 
            // lblInfo3
            // 
            this.lblInfo3.BackColor = System.Drawing.Color.White;
            this.lblInfo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblInfo3.Location = new System.Drawing.Point(11, 152);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(441, 36);
            this.lblInfo3.TabIndex = 47;
            this.lblInfo3.Text = "[Cor verde]";
            // 
            // lblInfo2
            // 
            this.lblInfo2.BackColor = System.Drawing.Color.White;
            this.lblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblInfo2.Location = new System.Drawing.Point(11, 117);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(441, 36);
            this.lblInfo2.TabIndex = 46;
            this.lblInfo2.Text = "Professor representante: aaaaaa";
            // 
            // lblInfo1
            // 
            this.lblInfo1.BackColor = System.Drawing.Color.White;
            this.lblInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblInfo1.Location = new System.Drawing.Point(11, 78);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(441, 40);
            this.lblInfo1.TabIndex = 45;
            this.lblInfo1.Text = "Nome do Jogador: aaaaaaaaaa";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(344, 232);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 33);
            this.btnSair.TabIndex = 49;
            this.btnSair.Text = "&Sair da Info";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmInfoDedos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 277);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInfo0);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInfoDedos";
            this.Text = "Informações - Dedos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo0;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Button btnSair;
    }
}