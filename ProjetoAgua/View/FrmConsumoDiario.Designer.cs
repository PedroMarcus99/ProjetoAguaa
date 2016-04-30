namespace ProjetoAgua.View
{
    partial class FrmConsumoDiario
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
            this.components = new System.ComponentModel.Container();
            this.txtDescarga = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTorneira = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChuveiro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.lbNivel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblVezes = new System.Windows.Forms.Label();
            this.udSegChuveiro = new System.Windows.Forms.DomainUpDown();
            this.udHrChuveiro = new System.Windows.Forms.DomainUpDown();
            this.udMinChuveiro = new System.Windows.Forms.DomainUpDown();
            this.udVezes = new System.Windows.Forms.DomainUpDown();
            this.cbBanheiro = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.udKgRoupas = new System.Windows.Forms.DomainUpDown();
            this.lblMaquinaKG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDescargaClean = new System.Windows.Forms.Button();
            this.btnTorneiraClean = new System.Windows.Forms.Button();
            this.btnMaquinaClean = new System.Windows.Forms.Button();
            this.btnChuveiroClean = new System.Windows.Forms.Button();
            this.btnAllClean = new System.Windows.Forms.Button();
            this.btnBaldeClean = new System.Windows.Forms.Button();
            this.btnMangueiraCarClean = new System.Windows.Forms.Button();
            this.txtBalde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMangueiraCar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFluxoAgua = new System.Windows.Forms.ComboBox();
            this.lblFluxoAgua = new System.Windows.Forms.Label();
            this.btnMangueiraPlantasClean = new System.Windows.Forms.Button();
            this.txtMangueiraPlanta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPessoas = new System.Windows.Forms.ComboBox();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aguaaDataSet = new ProjetoAgua.aguaaDataSet();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new ProjetoAgua.aguaaDataSetTableAdapters.PessoaTableAdapter();
            this.orderToolStrip = new System.Windows.Forms.ToolStrip();
            this.orderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aguaaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.orderToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescarga
            // 
            this.txtDescarga.BackColor = System.Drawing.Color.White;
            this.txtDescarga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDescarga.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescarga.Location = new System.Drawing.Point(231, 116);
            this.txtDescarga.MaxLength = 16;
            this.txtDescarga.Name = "txtDescarga";
            this.txtDescarga.ReadOnly = true;
            this.txtDescarga.Size = new System.Drawing.Size(118, 23);
            this.txtDescarga.TabIndex = 157;
            this.txtDescarga.Text = "0";
            this.txtDescarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(228, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 156;
            this.label13.Text = "Descarga";
            // 
            // txtTorneira
            // 
            this.txtTorneira.BackColor = System.Drawing.Color.White;
            this.txtTorneira.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTorneira.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTorneira.Location = new System.Drawing.Point(390, 116);
            this.txtTorneira.MaxLength = 16;
            this.txtTorneira.Name = "txtTorneira";
            this.txtTorneira.ReadOnly = true;
            this.txtTorneira.Size = new System.Drawing.Size(118, 23);
            this.txtTorneira.TabIndex = 146;
            this.txtTorneira.Text = "0";
            this.txtTorneira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 145;
            this.label8.Text = "Torneira";
            // 
            // txtChuveiro
            // 
            this.txtChuveiro.BackColor = System.Drawing.Color.White;
            this.txtChuveiro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtChuveiro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuveiro.Location = new System.Drawing.Point(231, 160);
            this.txtChuveiro.MaxLength = 16;
            this.txtChuveiro.Name = "txtChuveiro";
            this.txtChuveiro.ReadOnly = true;
            this.txtChuveiro.Size = new System.Drawing.Size(118, 23);
            this.txtChuveiro.TabIndex = 133;
            this.txtChuveiro.Text = "0";
            this.txtChuveiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 132;
            this.label7.Text = "Chuveiro";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Tomato;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(12, 272);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(154, 25);
            this.btnEnviar.TabIndex = 131;
            this.btnEnviar.Text = "Calcular";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviarChv_Click);
            // 
            // cbNivel
            // 
            this.cbNivel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbNivel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Alto",
            "Médio",
            "Baixo",
            "Extra Baixo"});
            this.cbNivel.Location = new System.Drawing.Point(93, 154);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(78, 21);
            this.cbNivel.TabIndex = 130;
            this.cbNivel.Text = "Extra Baixo";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivel.Location = new System.Drawing.Point(8, 157);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(80, 15);
            this.lbNivel.TabIndex = 129;
            this.lbNivel.Text = "Nível de Água";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(8, 217);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(188, 15);
            this.lblTime.TabIndex = 127;
            this.lblTime.Text = "Tempo de utilização (HH:MM:SS) :";
            // 
            // lblVezes
            // 
            this.lblVezes.AutoSize = true;
            this.lblVezes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVezes.Location = new System.Drawing.Point(12, 101);
            this.lblVezes.Name = "lblVezes";
            this.lblVezes.Size = new System.Drawing.Size(87, 15);
            this.lblVezes.TabIndex = 125;
            this.lblVezes.Text = "Vezes utilizado";
            // 
            // udSegChuveiro
            // 
            this.udSegChuveiro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udSegChuveiro.Items.Add("60");
            this.udSegChuveiro.Items.Add("59");
            this.udSegChuveiro.Items.Add("58");
            this.udSegChuveiro.Items.Add("57");
            this.udSegChuveiro.Items.Add("56");
            this.udSegChuveiro.Items.Add("55");
            this.udSegChuveiro.Items.Add("54");
            this.udSegChuveiro.Items.Add("53");
            this.udSegChuveiro.Items.Add("52");
            this.udSegChuveiro.Items.Add("51");
            this.udSegChuveiro.Items.Add("50");
            this.udSegChuveiro.Items.Add("49");
            this.udSegChuveiro.Items.Add("48");
            this.udSegChuveiro.Items.Add("47");
            this.udSegChuveiro.Items.Add("46");
            this.udSegChuveiro.Items.Add("45");
            this.udSegChuveiro.Items.Add("44");
            this.udSegChuveiro.Items.Add("43");
            this.udSegChuveiro.Items.Add("42");
            this.udSegChuveiro.Items.Add("41");
            this.udSegChuveiro.Items.Add("40");
            this.udSegChuveiro.Items.Add("39");
            this.udSegChuveiro.Items.Add("38");
            this.udSegChuveiro.Items.Add("37");
            this.udSegChuveiro.Items.Add("36");
            this.udSegChuveiro.Items.Add("35");
            this.udSegChuveiro.Items.Add("34");
            this.udSegChuveiro.Items.Add("33");
            this.udSegChuveiro.Items.Add("32");
            this.udSegChuveiro.Items.Add("31");
            this.udSegChuveiro.Items.Add("30");
            this.udSegChuveiro.Items.Add("29");
            this.udSegChuveiro.Items.Add("28");
            this.udSegChuveiro.Items.Add("27");
            this.udSegChuveiro.Items.Add("26");
            this.udSegChuveiro.Items.Add("25");
            this.udSegChuveiro.Items.Add("24");
            this.udSegChuveiro.Items.Add("23");
            this.udSegChuveiro.Items.Add("22");
            this.udSegChuveiro.Items.Add("21");
            this.udSegChuveiro.Items.Add("20");
            this.udSegChuveiro.Items.Add("19");
            this.udSegChuveiro.Items.Add("18");
            this.udSegChuveiro.Items.Add("17");
            this.udSegChuveiro.Items.Add("16");
            this.udSegChuveiro.Items.Add("15");
            this.udSegChuveiro.Items.Add("14");
            this.udSegChuveiro.Items.Add("13");
            this.udSegChuveiro.Items.Add("12");
            this.udSegChuveiro.Items.Add("11");
            this.udSegChuveiro.Items.Add("10");
            this.udSegChuveiro.Items.Add("09");
            this.udSegChuveiro.Items.Add("08");
            this.udSegChuveiro.Items.Add("07");
            this.udSegChuveiro.Items.Add("06");
            this.udSegChuveiro.Items.Add("05");
            this.udSegChuveiro.Items.Add("04");
            this.udSegChuveiro.Items.Add("03");
            this.udSegChuveiro.Items.Add("02");
            this.udSegChuveiro.Items.Add("01");
            this.udSegChuveiro.Items.Add("00");
            this.udSegChuveiro.Location = new System.Drawing.Point(123, 243);
            this.udSegChuveiro.Name = "udSegChuveiro";
            this.udSegChuveiro.Size = new System.Drawing.Size(46, 23);
            this.udSegChuveiro.TabIndex = 124;
            this.udSegChuveiro.Text = "00";
            this.udSegChuveiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // udHrChuveiro
            // 
            this.udHrChuveiro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udHrChuveiro.Items.Add("24");
            this.udHrChuveiro.Items.Add("23");
            this.udHrChuveiro.Items.Add("22");
            this.udHrChuveiro.Items.Add("21");
            this.udHrChuveiro.Items.Add("20");
            this.udHrChuveiro.Items.Add("19");
            this.udHrChuveiro.Items.Add("18");
            this.udHrChuveiro.Items.Add("17");
            this.udHrChuveiro.Items.Add("16");
            this.udHrChuveiro.Items.Add("15");
            this.udHrChuveiro.Items.Add("14");
            this.udHrChuveiro.Items.Add("13");
            this.udHrChuveiro.Items.Add("12");
            this.udHrChuveiro.Items.Add("11");
            this.udHrChuveiro.Items.Add("10");
            this.udHrChuveiro.Items.Add("09");
            this.udHrChuveiro.Items.Add("08");
            this.udHrChuveiro.Items.Add("07");
            this.udHrChuveiro.Items.Add("06");
            this.udHrChuveiro.Items.Add("05");
            this.udHrChuveiro.Items.Add("04");
            this.udHrChuveiro.Items.Add("03");
            this.udHrChuveiro.Items.Add("02");
            this.udHrChuveiro.Items.Add("01");
            this.udHrChuveiro.Items.Add("00");
            this.udHrChuveiro.Location = new System.Drawing.Point(8, 243);
            this.udHrChuveiro.Name = "udHrChuveiro";
            this.udHrChuveiro.Size = new System.Drawing.Size(46, 23);
            this.udHrChuveiro.TabIndex = 123;
            this.udHrChuveiro.Text = "00";
            this.udHrChuveiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // udMinChuveiro
            // 
            this.udMinChuveiro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udMinChuveiro.Items.Add("60");
            this.udMinChuveiro.Items.Add("59");
            this.udMinChuveiro.Items.Add("58");
            this.udMinChuveiro.Items.Add("57");
            this.udMinChuveiro.Items.Add("56");
            this.udMinChuveiro.Items.Add("55");
            this.udMinChuveiro.Items.Add("54");
            this.udMinChuveiro.Items.Add("53");
            this.udMinChuveiro.Items.Add("52");
            this.udMinChuveiro.Items.Add("51");
            this.udMinChuveiro.Items.Add("50");
            this.udMinChuveiro.Items.Add("49");
            this.udMinChuveiro.Items.Add("48");
            this.udMinChuveiro.Items.Add("47");
            this.udMinChuveiro.Items.Add("46");
            this.udMinChuveiro.Items.Add("45");
            this.udMinChuveiro.Items.Add("44");
            this.udMinChuveiro.Items.Add("43");
            this.udMinChuveiro.Items.Add("42");
            this.udMinChuveiro.Items.Add("41");
            this.udMinChuveiro.Items.Add("40");
            this.udMinChuveiro.Items.Add("39");
            this.udMinChuveiro.Items.Add("38");
            this.udMinChuveiro.Items.Add("37");
            this.udMinChuveiro.Items.Add("36");
            this.udMinChuveiro.Items.Add("35");
            this.udMinChuveiro.Items.Add("34");
            this.udMinChuveiro.Items.Add("33");
            this.udMinChuveiro.Items.Add("32");
            this.udMinChuveiro.Items.Add("31");
            this.udMinChuveiro.Items.Add("30");
            this.udMinChuveiro.Items.Add("29");
            this.udMinChuveiro.Items.Add("28");
            this.udMinChuveiro.Items.Add("27");
            this.udMinChuveiro.Items.Add("26");
            this.udMinChuveiro.Items.Add("25");
            this.udMinChuveiro.Items.Add("24");
            this.udMinChuveiro.Items.Add("23");
            this.udMinChuveiro.Items.Add("22");
            this.udMinChuveiro.Items.Add("21");
            this.udMinChuveiro.Items.Add("20");
            this.udMinChuveiro.Items.Add("19");
            this.udMinChuveiro.Items.Add("18");
            this.udMinChuveiro.Items.Add("17");
            this.udMinChuveiro.Items.Add("16");
            this.udMinChuveiro.Items.Add("15");
            this.udMinChuveiro.Items.Add("14");
            this.udMinChuveiro.Items.Add("13");
            this.udMinChuveiro.Items.Add("12");
            this.udMinChuveiro.Items.Add("11");
            this.udMinChuveiro.Items.Add("10");
            this.udMinChuveiro.Items.Add("09");
            this.udMinChuveiro.Items.Add("08");
            this.udMinChuveiro.Items.Add("07");
            this.udMinChuveiro.Items.Add("06");
            this.udMinChuveiro.Items.Add("05");
            this.udMinChuveiro.Items.Add("04");
            this.udMinChuveiro.Items.Add("03");
            this.udMinChuveiro.Items.Add("02");
            this.udMinChuveiro.Items.Add("01");
            this.udMinChuveiro.Items.Add("00");
            this.udMinChuveiro.Location = new System.Drawing.Point(69, 243);
            this.udMinChuveiro.Name = "udMinChuveiro";
            this.udMinChuveiro.Size = new System.Drawing.Size(46, 23);
            this.udMinChuveiro.TabIndex = 122;
            this.udMinChuveiro.Text = "00";
            this.udMinChuveiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // udVezes
            // 
            this.udVezes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udVezes.Items.Add("1");
            this.udVezes.Items.Add("2");
            this.udVezes.Items.Add("3");
            this.udVezes.Items.Add("4");
            this.udVezes.Items.Add("5");
            this.udVezes.Items.Add("6");
            this.udVezes.Items.Add("7");
            this.udVezes.Items.Add("8");
            this.udVezes.Items.Add("9");
            this.udVezes.Items.Add("10");
            this.udVezes.Items.Add("11");
            this.udVezes.Items.Add("12");
            this.udVezes.Location = new System.Drawing.Point(127, 99);
            this.udVezes.Name = "udVezes";
            this.udVezes.Size = new System.Drawing.Size(44, 23);
            this.udVezes.TabIndex = 121;
            this.udVezes.Text = "1";
            this.udVezes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbBanheiro
            // 
            this.cbBanheiro.BackColor = System.Drawing.SystemColors.Menu;
            this.cbBanheiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanheiro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBanheiro.FormattingEnabled = true;
            this.cbBanheiro.Items.AddRange(new object[] {
            "Chuveiro",
            "Carro",
            "Máquina de Lavar",
            "Plantas",
            "Torneira do Banheiro",
            "Torneira da Cozinha",
            "Torneira do Quintal",
            "Vaso Sanitário"});
            this.cbBanheiro.Location = new System.Drawing.Point(12, 69);
            this.cbBanheiro.Name = "cbBanheiro";
            this.cbBanheiro.Size = new System.Drawing.Size(154, 23);
            this.cbBanheiro.TabIndex = 213;
            this.cbBanheiro.SelectedIndexChanged += new System.EventHandler(this.cbBanheiro_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(442, 312);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 25);
            this.btnSalvar.TabIndex = 214;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtMaquina
            // 
            this.txtMaquina.BackColor = System.Drawing.Color.White;
            this.txtMaquina.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMaquina.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaquina.Location = new System.Drawing.Point(390, 160);
            this.txtMaquina.MaxLength = 16;
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.ReadOnly = true;
            this.txtMaquina.Size = new System.Drawing.Size(118, 23);
            this.txtMaquina.TabIndex = 216;
            this.txtMaquina.Text = "0";
            this.txtMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 215;
            this.label2.Text = "Maquina de Lavar";
            // 
            // udKgRoupas
            // 
            this.udKgRoupas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udKgRoupas.Items.Add("1");
            this.udKgRoupas.Items.Add("2");
            this.udKgRoupas.Items.Add("3");
            this.udKgRoupas.Items.Add("4");
            this.udKgRoupas.Items.Add("5");
            this.udKgRoupas.Items.Add("6");
            this.udKgRoupas.Items.Add("7");
            this.udKgRoupas.Items.Add("8");
            this.udKgRoupas.Items.Add("9");
            this.udKgRoupas.Items.Add("10");
            this.udKgRoupas.Items.Add("11");
            this.udKgRoupas.Items.Add("12");
            this.udKgRoupas.Items.Add("13");
            this.udKgRoupas.Items.Add("14");
            this.udKgRoupas.Items.Add("15");
            this.udKgRoupas.Items.Add("16");
            this.udKgRoupas.Location = new System.Drawing.Point(127, 125);
            this.udKgRoupas.Name = "udKgRoupas";
            this.udKgRoupas.Size = new System.Drawing.Size(44, 23);
            this.udKgRoupas.TabIndex = 217;
            this.udKgRoupas.Text = "1";
            this.udKgRoupas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaquinaKG
            // 
            this.lblMaquinaKG.AutoSize = true;
            this.lblMaquinaKG.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquinaKG.Location = new System.Drawing.Point(23, 127);
            this.lblMaquinaKG.Name = "lblMaquinaKG";
            this.lblMaquinaKG.Size = new System.Drawing.Size(74, 15);
            this.lblMaquinaKG.TabIndex = 218;
            this.lblMaquinaKG.Text = "Maquina KG";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 69);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label3.Size = new System.Drawing.Size(310, 22);
            this.label3.TabIndex = 220;
            this.label3.Text = "Total Consumidos em Litros em cada Item";
            // 
            // btnDescargaClean
            // 
            this.btnDescargaClean.BackColor = System.Drawing.Color.Teal;
            this.btnDescargaClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargaClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargaClean.ForeColor = System.Drawing.Color.White;
            this.btnDescargaClean.Location = new System.Drawing.Point(355, 115);
            this.btnDescargaClean.Name = "btnDescargaClean";
            this.btnDescargaClean.Size = new System.Drawing.Size(25, 25);
            this.btnDescargaClean.TabIndex = 221;
            this.btnDescargaClean.Text = "C";
            this.btnDescargaClean.UseVisualStyleBackColor = false;
            this.btnDescargaClean.Click += new System.EventHandler(this.btnDescargaClean_Click);
            // 
            // btnTorneiraClean
            // 
            this.btnTorneiraClean.BackColor = System.Drawing.Color.Teal;
            this.btnTorneiraClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorneiraClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorneiraClean.ForeColor = System.Drawing.Color.White;
            this.btnTorneiraClean.Location = new System.Drawing.Point(514, 115);
            this.btnTorneiraClean.Name = "btnTorneiraClean";
            this.btnTorneiraClean.Size = new System.Drawing.Size(25, 25);
            this.btnTorneiraClean.TabIndex = 222;
            this.btnTorneiraClean.Text = "C";
            this.btnTorneiraClean.UseVisualStyleBackColor = false;
            this.btnTorneiraClean.Click += new System.EventHandler(this.btnTorneiraClean_Click);
            // 
            // btnMaquinaClean
            // 
            this.btnMaquinaClean.BackColor = System.Drawing.Color.Teal;
            this.btnMaquinaClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaquinaClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaquinaClean.ForeColor = System.Drawing.Color.White;
            this.btnMaquinaClean.Location = new System.Drawing.Point(514, 159);
            this.btnMaquinaClean.Name = "btnMaquinaClean";
            this.btnMaquinaClean.Size = new System.Drawing.Size(25, 25);
            this.btnMaquinaClean.TabIndex = 224;
            this.btnMaquinaClean.Text = "C";
            this.btnMaquinaClean.UseVisualStyleBackColor = false;
            this.btnMaquinaClean.Click += new System.EventHandler(this.btnMaquinaClean_Click);
            // 
            // btnChuveiroClean
            // 
            this.btnChuveiroClean.BackColor = System.Drawing.Color.Teal;
            this.btnChuveiroClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuveiroClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuveiroClean.ForeColor = System.Drawing.Color.White;
            this.btnChuveiroClean.Location = new System.Drawing.Point(355, 159);
            this.btnChuveiroClean.Name = "btnChuveiroClean";
            this.btnChuveiroClean.Size = new System.Drawing.Size(25, 25);
            this.btnChuveiroClean.TabIndex = 223;
            this.btnChuveiroClean.Text = "C";
            this.btnChuveiroClean.UseVisualStyleBackColor = false;
            this.btnChuveiroClean.Click += new System.EventHandler(this.btnChuveiroClean_Click);
            // 
            // btnAllClean
            // 
            this.btnAllClean.BackColor = System.Drawing.Color.Teal;
            this.btnAllClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllClean.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllClean.ForeColor = System.Drawing.Color.White;
            this.btnAllClean.Location = new System.Drawing.Point(390, 255);
            this.btnAllClean.Name = "btnAllClean";
            this.btnAllClean.Size = new System.Drawing.Size(149, 25);
            this.btnAllClean.TabIndex = 225;
            this.btnAllClean.Text = "Limpar Tudo";
            this.btnAllClean.UseVisualStyleBackColor = false;
            this.btnAllClean.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBaldeClean
            // 
            this.btnBaldeClean.BackColor = System.Drawing.Color.Teal;
            this.btnBaldeClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaldeClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaldeClean.ForeColor = System.Drawing.Color.White;
            this.btnBaldeClean.Location = new System.Drawing.Point(514, 208);
            this.btnBaldeClean.Name = "btnBaldeClean";
            this.btnBaldeClean.Size = new System.Drawing.Size(25, 25);
            this.btnBaldeClean.TabIndex = 231;
            this.btnBaldeClean.Text = "C";
            this.btnBaldeClean.UseVisualStyleBackColor = false;
            this.btnBaldeClean.Click += new System.EventHandler(this.btnBaldeClean_Click);
            // 
            // btnMangueiraCarClean
            // 
            this.btnMangueiraCarClean.BackColor = System.Drawing.Color.Teal;
            this.btnMangueiraCarClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangueiraCarClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangueiraCarClean.ForeColor = System.Drawing.Color.White;
            this.btnMangueiraCarClean.Location = new System.Drawing.Point(355, 208);
            this.btnMangueiraCarClean.Name = "btnMangueiraCarClean";
            this.btnMangueiraCarClean.Size = new System.Drawing.Size(25, 25);
            this.btnMangueiraCarClean.TabIndex = 230;
            this.btnMangueiraCarClean.Text = "C";
            this.btnMangueiraCarClean.UseVisualStyleBackColor = false;
            this.btnMangueiraCarClean.Click += new System.EventHandler(this.btnMangueiraCarClean_Click);
            // 
            // txtBalde
            // 
            this.txtBalde.BackColor = System.Drawing.Color.White;
            this.txtBalde.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBalde.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalde.Location = new System.Drawing.Point(390, 209);
            this.txtBalde.MaxLength = 16;
            this.txtBalde.Name = "txtBalde";
            this.txtBalde.ReadOnly = true;
            this.txtBalde.Size = new System.Drawing.Size(118, 23);
            this.txtBalde.TabIndex = 229;
            this.txtBalde.Text = "0";
            this.txtBalde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 228;
            this.label5.Text = "Balde";
            // 
            // txtMangueiraCar
            // 
            this.txtMangueiraCar.BackColor = System.Drawing.Color.White;
            this.txtMangueiraCar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMangueiraCar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMangueiraCar.Location = new System.Drawing.Point(231, 209);
            this.txtMangueiraCar.MaxLength = 16;
            this.txtMangueiraCar.Name = "txtMangueiraCar";
            this.txtMangueiraCar.ReadOnly = true;
            this.txtMangueiraCar.Size = new System.Drawing.Size(118, 23);
            this.txtMangueiraCar.TabIndex = 227;
            this.txtMangueiraCar.Text = "0";
            this.txtMangueiraCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 226;
            this.label6.Text = "Carro - Mangueira";
            // 
            // cbFluxoAgua
            // 
            this.cbFluxoAgua.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbFluxoAgua.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFluxoAgua.FormattingEnabled = true;
            this.cbFluxoAgua.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbFluxoAgua.Location = new System.Drawing.Point(93, 186);
            this.cbFluxoAgua.Name = "cbFluxoAgua";
            this.cbFluxoAgua.Size = new System.Drawing.Size(79, 21);
            this.cbFluxoAgua.TabIndex = 232;
            this.cbFluxoAgua.Text = "Alta";
            // 
            // lblFluxoAgua
            // 
            this.lblFluxoAgua.AutoSize = true;
            this.lblFluxoAgua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFluxoAgua.Location = new System.Drawing.Point(9, 189);
            this.lblFluxoAgua.Name = "lblFluxoAgua";
            this.lblFluxoAgua.Size = new System.Drawing.Size(83, 15);
            this.lblFluxoAgua.TabIndex = 233;
            this.lblFluxoAgua.Text = "Fluxo de Água";
            // 
            // btnMangueiraPlantasClean
            // 
            this.btnMangueiraPlantasClean.BackColor = System.Drawing.Color.Teal;
            this.btnMangueiraPlantasClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangueiraPlantasClean.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangueiraPlantasClean.ForeColor = System.Drawing.Color.White;
            this.btnMangueiraPlantasClean.Location = new System.Drawing.Point(355, 255);
            this.btnMangueiraPlantasClean.Name = "btnMangueiraPlantasClean";
            this.btnMangueiraPlantasClean.Size = new System.Drawing.Size(25, 25);
            this.btnMangueiraPlantasClean.TabIndex = 236;
            this.btnMangueiraPlantasClean.Text = "C";
            this.btnMangueiraPlantasClean.UseVisualStyleBackColor = false;
            this.btnMangueiraPlantasClean.Click += new System.EventHandler(this.btnMangueiraPlantasClean_Click);
            // 
            // txtMangueiraPlanta
            // 
            this.txtMangueiraPlanta.BackColor = System.Drawing.Color.White;
            this.txtMangueiraPlanta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMangueiraPlanta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMangueiraPlanta.Location = new System.Drawing.Point(231, 256);
            this.txtMangueiraPlanta.MaxLength = 16;
            this.txtMangueiraPlanta.Name = "txtMangueiraPlanta";
            this.txtMangueiraPlanta.ReadOnly = true;
            this.txtMangueiraPlanta.Size = new System.Drawing.Size(118, 23);
            this.txtMangueiraPlanta.TabIndex = 235;
            this.txtMangueiraPlanta.Text = "0";
            this.txtMangueiraPlanta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 234;
            this.label4.Text = "Plantas - Mangueira";
            // 
            // cbPessoas
            // 
            this.cbPessoas.BackColor = System.Drawing.SystemColors.Info;
            this.cbPessoas.DataSource = this.pessoaBindingSource1;
            this.cbPessoas.DisplayMember = "Nome";
            this.cbPessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPessoas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPessoas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbPessoas.FormattingEnabled = true;
            this.cbPessoas.Location = new System.Drawing.Point(232, 314);
            this.cbPessoas.Name = "cbPessoas";
            this.cbPessoas.Size = new System.Drawing.Size(149, 23);
            this.cbPessoas.TabIndex = 237;
            this.cbPessoas.ValueMember = "idPessoa";
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataMember = "Pessoa";
            this.pessoaBindingSource1.DataSource = this.aguaaDataSet;
            // 
            // aguaaDataSet
            // 
            this.aguaaDataSet.DataSetName = "aguaaDataSet";
            this.aguaaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // orderToolStrip
            // 
            this.orderToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.orderToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripButton,
            this.toolStripButton1});
            this.orderToolStrip.Location = new System.Drawing.Point(0, 361);
            this.orderToolStrip.Name = "orderToolStrip";
            this.orderToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.orderToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orderToolStrip.Size = new System.Drawing.Size(568, 25);
            this.orderToolStrip.TabIndex = 238;
            this.orderToolStrip.Text = "orderToolStrip";
            // 
            // orderToolStripButton
            // 
            this.orderToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.orderToolStripButton.Name = "orderToolStripButton";
            this.orderToolStripButton.Size = new System.Drawing.Size(111, 22);
            this.orderToolStripButton.Text = "Ordenar Por Nome";
            this.orderToolStripButton.Click += new System.EventHandler(this.orderToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "Ordernar Padrão";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 239;
            this.label1.Text = "Quem realizou esse consumo?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 28);
            this.panel1.TabIndex = 240;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 28);
            this.label9.TabIndex = 241;
            this.label9.Text = "Nome do Usuário";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(172, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 28);
            this.label10.TabIndex = 242;
            this.label10.Text = "Porcentagem de Gasto";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConsumoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderToolStrip);
            this.Controls.Add(this.cbPessoas);
            this.Controls.Add(this.btnMangueiraPlantasClean);
            this.Controls.Add(this.txtMangueiraPlanta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFluxoAgua);
            this.Controls.Add(this.cbFluxoAgua);
            this.Controls.Add(this.btnBaldeClean);
            this.Controls.Add(this.btnMangueiraCarClean);
            this.Controls.Add(this.txtBalde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMangueiraCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAllClean);
            this.Controls.Add(this.btnMaquinaClean);
            this.Controls.Add(this.btnChuveiroClean);
            this.Controls.Add(this.btnTorneiraClean);
            this.Controls.Add(this.btnDescargaClean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMaquinaKG);
            this.Controls.Add(this.udKgRoupas);
            this.Controls.Add(this.txtMaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbBanheiro);
            this.Controls.Add(this.txtDescarga);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTorneira);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtChuveiro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblVezes);
            this.Controls.Add(this.udSegChuveiro);
            this.Controls.Add(this.udHrChuveiro);
            this.Controls.Add(this.udMinChuveiro);
            this.Controls.Add(this.udVezes);
            this.Name = "FrmConsumoDiario";
            this.Text = "Consumos Diários";
            this.Load += new System.EventHandler(this.FrmConsumoDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aguaaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.orderToolStrip.ResumeLayout(false);
            this.orderToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescarga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTorneira;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChuveiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblVezes;
        private System.Windows.Forms.DomainUpDown udSegChuveiro;
        private System.Windows.Forms.DomainUpDown udHrChuveiro;
        private System.Windows.Forms.DomainUpDown udMinChuveiro;
        private System.Windows.Forms.DomainUpDown udVezes;
        private System.Windows.Forms.ComboBox cbBanheiro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown udKgRoupas;
        private System.Windows.Forms.Label lblMaquinaKG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDescargaClean;
        private System.Windows.Forms.Button btnTorneiraClean;
        private System.Windows.Forms.Button btnMaquinaClean;
        private System.Windows.Forms.Button btnChuveiroClean;
        private System.Windows.Forms.Button btnAllClean;
        private System.Windows.Forms.Button btnBaldeClean;
        private System.Windows.Forms.Button btnMangueiraCarClean;
        private System.Windows.Forms.TextBox txtBalde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMangueiraCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFluxoAgua;
        private System.Windows.Forms.Label lblFluxoAgua;
        private System.Windows.Forms.Button btnMangueiraPlantasClean;
        private System.Windows.Forms.TextBox txtMangueiraPlanta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPessoas;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private aguaaDataSet aguaaDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private aguaaDataSetTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.ToolStrip orderToolStrip;
        private System.Windows.Forms.ToolStripButton orderToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}