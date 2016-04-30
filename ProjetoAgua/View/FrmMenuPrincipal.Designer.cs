namespace ProjetoAgua.View
{
    partial class FrmMenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analisarConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumoDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuNovoFamiliar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(153, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL GASTOS EM LITROS D\'ÁGUA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(153, 80);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(420, 36);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "VALOR";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.familiaresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 182);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoConsumoToolStripMenuItem,
            this.analisarConsumoToolStripMenuItem,
            this.consumoDiárioToolStripMenuItem});
            this.abrirToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeyDisplayString = "C";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.abrirToolStripMenuItem.Text = "&Consumos";
            // 
            // novoConsumoToolStripMenuItem
            // 
            this.novoConsumoToolStripMenuItem.Name = "novoConsumoToolStripMenuItem";
            this.novoConsumoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.novoConsumoToolStripMenuItem.Text = "Novo Consumo";
            this.novoConsumoToolStripMenuItem.Click += new System.EventHandler(this.novoConsumoToolStripMenuItem_Click);
            // 
            // analisarConsumoToolStripMenuItem
            // 
            this.analisarConsumoToolStripMenuItem.Name = "analisarConsumoToolStripMenuItem";
            this.analisarConsumoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.analisarConsumoToolStripMenuItem.Text = "Analisar Consumo";
            this.analisarConsumoToolStripMenuItem.Click += new System.EventHandler(this.analisarConsumoToolStripMenuItem_Click);
            // 
            // consumoDiárioToolStripMenuItem
            // 
            this.consumoDiárioToolStripMenuItem.Name = "consumoDiárioToolStripMenuItem";
            this.consumoDiárioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consumoDiárioToolStripMenuItem.Text = "Consumo Diário";
            this.consumoDiárioToolStripMenuItem.Click += new System.EventHandler(this.consumoDiárioToolStripMenuItem_Click);
            // 
            // familiaresToolStripMenuItem
            // 
            this.familiaresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenuNovoFamiliar});
            this.familiaresToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familiaresToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.familiaresToolStripMenuItem.Name = "familiaresToolStripMenuItem";
            this.familiaresToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.familiaresToolStripMenuItem.Text = "&Familiares";
            // 
            // tsmenuNovoFamiliar
            // 
            this.tsmenuNovoFamiliar.Name = "tsmenuNovoFamiliar";
            this.tsmenuNovoFamiliar.Size = new System.Drawing.Size(103, 22);
            this.tsmenuNovoFamiliar.Text = "Novo";
            this.tsmenuNovoFamiliar.Click += new System.EventHandler(this.tsmenuNovoFamiliar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblStatus.Location = new System.Drawing.Point(152, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(420, 36);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 26);
            this.statusStrip1.TabIndex = 242;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(141, 21);
            this.toolStripStatusLabel1.Text = "Nome do Usuário";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(180, 21);
            this.toolStripStatusLabel2.Text = "Porcentagem de Gasto";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(24, 21);
            this.toolStripStatusLabel3.Text = "%";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(634, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 243;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInicio_FormClosed);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoConsumoToolStripMenuItem;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem analisarConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmenuNovoFamiliar;
        private System.Windows.Forms.ToolStripMenuItem consumoDiárioToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button button1;

    }
}