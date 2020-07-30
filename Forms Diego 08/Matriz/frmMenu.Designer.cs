namespace Forms_Diego_08
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnMatriz = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnDedos = new System.Windows.Forms.Button();
            this.lblFormFase2 = new System.Windows.Forms.Label();
            this.lblFormFase1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMatriz
            // 
            this.btnMatriz.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(68, 133);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(239, 103);
            this.btnMatriz.TabIndex = 0;
            this.btnMatriz.Text = "Calculadora de Matriz";
            this.btnMatriz.UseVisualStyleBackColor = false;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Location = new System.Drawing.Point(203, 264);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(239, 103);
            this.btnSobre.TabIndex = 1;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnDedos
            // 
            this.btnDedos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDedos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDedos.Location = new System.Drawing.Point(343, 133);
            this.btnDedos.Name = "btnDedos";
            this.btnDedos.Size = new System.Drawing.Size(239, 103);
            this.btnDedos.TabIndex = 2;
            this.btnDedos.Text = "Jogo: Dedos";
            this.btnDedos.UseVisualStyleBackColor = false;
            this.btnDedos.Click += new System.EventHandler(this.btnDedos_Click);
            // 
            // lblFormFase2
            // 
            this.lblFormFase2.AutoSize = true;
            this.lblFormFase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormFase2.Location = new System.Drawing.Point(384, 89);
            this.lblFormFase2.Name = "lblFormFase2";
            this.lblFormFase2.Size = new System.Drawing.Size(164, 32);
            this.lblFormFase2.TabIndex = 3;
            this.lblFormFase2.Text = "Form fase 2";
            // 
            // lblFormFase1
            // 
            this.lblFormFase1.AutoSize = true;
            this.lblFormFase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormFase1.Location = new System.Drawing.Point(106, 89);
            this.lblFormFase1.Name = "lblFormFase1";
            this.lblFormFase1.Size = new System.Drawing.Size(164, 32);
            this.lblFormFase1.TabIndex = 4;
            this.lblFormFase1.Text = "Form fase 1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.lblFormFase1);
            this.Controls.Add(this.lblFormFase2);
            this.Controls.Add(this.btnDedos);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnMatriz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnDedos;
        private System.Windows.Forms.Label lblFormFase2;
        private System.Windows.Forms.Label lblFormFase1;
    }
}