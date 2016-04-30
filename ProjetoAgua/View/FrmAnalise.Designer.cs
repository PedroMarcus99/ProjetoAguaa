namespace ProjetoAgua.View
{
    partial class FrmAnalise
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumRestante = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblConsumosRestantes = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(51, 90);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 22);
            this.txtConsumo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumRestante);
            this.groupBox1.Controls.Add(this.lblMedia);
            this.groupBox1.Controls.Add(this.lblConsumosRestantes);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtConsumo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Análise de Consumo";
            // 
            // lblNumRestante
            // 
            this.lblNumRestante.AutoSize = true;
            this.lblNumRestante.Location = new System.Drawing.Point(180, 29);
            this.lblNumRestante.Name = "lblNumRestante";
            this.lblNumRestante.Size = new System.Drawing.Size(0, 14);
            this.lblNumRestante.TabIndex = 5;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(152, 148);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(11, 14);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "-";
            // 
            // lblConsumosRestantes
            // 
            this.lblConsumosRestantes.AutoSize = true;
            this.lblConsumosRestantes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumosRestantes.Location = new System.Drawing.Point(6, 29);
            this.lblConsumosRestantes.Name = "lblConsumosRestantes";
            this.lblConsumosRestantes.Size = new System.Drawing.Size(197, 14);
            this.lblConsumosRestantes.TabIndex = 3;
            this.lblConsumosRestantes.Text = "Consumos restantes para análise: ";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(209, 89);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAnalise";
            this.Text = "FormAnalise";
            this.Load += new System.EventHandler(this.FormAnalise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConsumosRestantes;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblNumRestante;
    }
}