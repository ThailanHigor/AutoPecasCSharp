namespace CRUDEstagio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripCadastrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripPesquisa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbHora1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlCadastrar = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.TbPreco = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TbDistribuidor = new System.Windows.Forms.TextBox();
            this.TbCadPreco = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbCodigoBarras = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TbMarca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TbCodigoPeca = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.DgEdit = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbCodigoUnico = new System.Windows.Forms.TextBox();
            this.LbCodigounico = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TbEditDistribuidor = new System.Windows.Forms.TextBox();
            this.TbEditPreco = new System.Windows.Forms.TextBox();
            this.TbEditNome = new System.Windows.Forms.TextBox();
            this.TbEditCodBarras = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbEditMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TbEditCodPeca = new System.Windows.Forms.TextBox();
            this.tabPageExcluir = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.DgExcluir = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbExcluir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPagePesquisa = new System.Windows.Forms.TabPage();
            this.GbPesquisa = new System.Windows.Forms.GroupBox();
            this.TbPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DgPesquisa = new System.Windows.Forms.DataGridView();
            this.GbFiltroPesquisa = new System.Windows.Forms.GroupBox();
            this.RbCodigoUnico = new System.Windows.Forms.RadioButton();
            this.RbCodigoPeca = new System.Windows.Forms.RadioButton();
            this.RbPorNome = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlCadastrar.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.TbPreco.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgEdit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPageExcluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgExcluir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPagePesquisa.SuspendLayout();
            this.GbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPesquisa)).BeginInit();
            this.GbFiltroPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(811, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 427);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCadastrar,
            this.toolStripEdit,
            this.toolStripExcluir,
            this.toolStripPesquisa,
            this.toolStripSeparator1,
            this.toolStripSair});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(13, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 392);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripCadastrar
            // 
            this.toolStripCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCadastrar.Image")));
            this.toolStripCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCadastrar.Name = "toolStripCadastrar";
            this.toolStripCadastrar.Size = new System.Drawing.Size(53, 54);
            this.toolStripCadastrar.Text = "toolStripButton1";
            this.toolStripCadastrar.ToolTipText = "Finalizar  Novo Cadastro";
            this.toolStripCadastrar.Click += new System.EventHandler(this.toolStripCadastrar_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(53, 54);
            this.toolStripEdit.Text = "toolStripButton2";
            this.toolStripEdit.ToolTipText = "Finalizar Edição";
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // toolStripExcluir
            // 
            this.toolStripExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripExcluir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExcluir.Image")));
            this.toolStripExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExcluir.Name = "toolStripExcluir";
            this.toolStripExcluir.Size = new System.Drawing.Size(53, 54);
            this.toolStripExcluir.Text = "toolStripButton3";
            this.toolStripExcluir.ToolTipText = "Finalizar e Excluir";
            this.toolStripExcluir.Click += new System.EventHandler(this.toolStripExcluir_Click);
            // 
            // toolStripPesquisa
            // 
            this.toolStripPesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPesquisa.Image")));
            this.toolStripPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPesquisa.Name = "toolStripPesquisa";
            this.toolStripPesquisa.Size = new System.Drawing.Size(53, 54);
            this.toolStripPesquisa.Text = "toolStripButton4";
            this.toolStripPesquisa.ToolTipText = "Pesquisar";
            this.toolStripPesquisa.Click += new System.EventHandler(this.toolStripPesquisa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(53, 6);
            // 
            // toolStripSair
            // 
            this.toolStripSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSair.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSair.Image")));
            this.toolStripSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSair.Margin = new System.Windows.Forms.Padding(0, 100, 0, 2);
            this.toolStripSair.Name = "toolStripSair";
            this.toolStripSair.Size = new System.Drawing.Size(53, 54);
            this.toolStripSair.Text = "toolStripButton5";
            this.toolStripSair.ToolTipText = "Sair da Aplicação";
            this.toolStripSair.Click += new System.EventHandler(this.toolStripSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LbHora,
            this.LbHora1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // LbHora
            // 
            this.LbHora.BackColor = System.Drawing.Color.Transparent;
            this.LbHora.Name = "LbHora";
            this.LbHora.Size = new System.Drawing.Size(0, 17);
            // 
            // LbHora1
            // 
            this.LbHora1.Name = "LbHora1";
            this.LbHora1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tabControlCadastrar);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 425);
            this.panel2.TabIndex = 1;
            // 
            // tabControlCadastrar
            // 
            this.tabControlCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCadastrar.Controls.Add(this.tabPageCadastro);
            this.tabControlCadastrar.Controls.Add(this.tabPageEdit);
            this.tabControlCadastrar.Controls.Add(this.tabPageExcluir);
            this.tabControlCadastrar.Controls.Add(this.tabPagePesquisa);
            this.tabControlCadastrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCadastrar.Location = new System.Drawing.Point(0, 0);
            this.tabControlCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlCadastrar.Name = "tabControlCadastrar";
            this.tabControlCadastrar.SelectedIndex = 0;
            this.tabControlCadastrar.Size = new System.Drawing.Size(812, 399);
            this.tabControlCadastrar.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.TbPreco);
            this.tabPageCadastro.Controls.Add(this.TbDistribuidor);
            this.tabPageCadastro.Controls.Add(this.TbCadPreco);
            this.tabPageCadastro.Controls.Add(this.TbNome);
            this.tabPageCadastro.Controls.Add(this.TbCodigoBarras);
            this.tabPageCadastro.Controls.Add(this.label13);
            this.tabPageCadastro.Controls.Add(this.TbMarca);
            this.tabPageCadastro.Controls.Add(this.label14);
            this.tabPageCadastro.Controls.Add(this.label15);
            this.tabPageCadastro.Controls.Add(this.label16);
            this.tabPageCadastro.Controls.Add(this.label17);
            this.tabPageCadastro.Controls.Add(this.label18);
            this.tabPageCadastro.Controls.Add(this.TbCodigoPeca);
            this.tabPageCadastro.Controls.Add(this.groupBox4);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabPageCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCadastro.Size = new System.Drawing.Size(804, 370);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastrar Peças";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // TbPreco
            // 
            this.TbPreco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TbPreco.BackgroundImage")));
            this.TbPreco.Controls.Add(this.groupBox3);
            this.TbPreco.Location = new System.Drawing.Point(0, 0);
            this.TbPreco.Name = "TbPreco";
            this.TbPreco.Size = new System.Drawing.Size(804, 202);
            this.TbPreco.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 159);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // TbDistribuidor
            // 
            this.TbDistribuidor.Location = new System.Drawing.Point(643, 266);
            this.TbDistribuidor.Name = "TbDistribuidor";
            this.TbDistribuidor.Size = new System.Drawing.Size(130, 22);
            this.TbDistribuidor.TabIndex = 20;
            // 
            // TbCadPreco
            // 
            this.TbCadPreco.Location = new System.Drawing.Point(643, 312);
            this.TbCadPreco.Name = "TbCadPreco";
            this.TbCadPreco.Size = new System.Drawing.Size(130, 22);
            this.TbCadPreco.TabIndex = 18;
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(127, 260);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(100, 22);
            this.TbNome.TabIndex = 21;
            // 
            // TbCodigoBarras
            // 
            this.TbCodigoBarras.Location = new System.Drawing.Point(374, 263);
            this.TbCodigoBarras.Name = "TbCodigoBarras";
            this.TbCodigoBarras.Size = new System.Drawing.Size(137, 22);
            this.TbCodigoBarras.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(562, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Distribuidor:";
            // 
            // TbMarca
            // 
            this.TbMarca.Location = new System.Drawing.Point(374, 313);
            this.TbMarca.Name = "TbMarca";
            this.TbMarca.Size = new System.Drawing.Size(137, 22);
            this.TbMarca.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(593, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Preço:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nome da Peça:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(255, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Codigo de Barras:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(316, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Marca:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 310);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Código da Peça:";
            // 
            // TbCodigoPeca
            // 
            this.TbCodigoPeca.Location = new System.Drawing.Point(127, 307);
            this.TbCodigoPeca.Name = "TbCodigoPeca";
            this.TbCodigoPeca.Size = new System.Drawing.Size(100, 22);
            this.TbCodigoPeca.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Location = new System.Drawing.Point(3, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(801, 159);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Cadastrais";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.DgEdit);
            this.tabPageEdit.Controls.Add(this.groupBox2);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageEdit.Size = new System.Drawing.Size(804, 370);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Editar Peças";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            this.tabPageEdit.Enter += new System.EventHandler(this.tabPageEdit_Enter_1);
            // 
            // DgEdit
            // 
            this.DgEdit.AllowUserToAddRows = false;
            this.DgEdit.AllowUserToDeleteRows = false;
            this.DgEdit.BackgroundColor = System.Drawing.Color.White;
            this.DgEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEdit.Location = new System.Drawing.Point(3, 184);
            this.DgEdit.Name = "DgEdit";
            this.DgEdit.ReadOnly = true;
            this.DgEdit.Size = new System.Drawing.Size(801, 186);
            this.DgEdit.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbCodigoUnico);
            this.groupBox2.Controls.Add(this.LbCodigounico);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TbEditDistribuidor);
            this.groupBox2.Controls.Add(this.TbEditPreco);
            this.groupBox2.Controls.Add(this.TbEditNome);
            this.groupBox2.Controls.Add(this.TbEditCodBarras);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TbEditMarca);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TbEditCodPeca);
            this.groupBox2.Location = new System.Drawing.Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 187);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atualizar Dados";
            // 
            // TbCodigoUnico
            // 
            this.TbCodigoUnico.Location = new System.Drawing.Point(85, 84);
            this.TbCodigoUnico.Name = "TbCodigoUnico";
            this.TbCodigoUnico.Size = new System.Drawing.Size(100, 22);
            this.TbCodigoUnico.TabIndex = 16;
            // 
            // LbCodigounico
            // 
            this.LbCodigounico.AutoSize = true;
            this.LbCodigounico.Location = new System.Drawing.Point(0, 86);
            this.LbCodigounico.Name = "LbCodigounico";
            this.LbCodigounico.Size = new System.Drawing.Size(85, 16);
            this.LbCodigounico.TabIndex = 15;
            this.LbCodigounico.Text = "Código Único:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(711, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 81);
            this.label12.TabIndex = 14;
            this.label12.Text = "Clique no Icone de Editar para concluir a edição";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbEditDistribuidor
            // 
            this.TbEditDistribuidor.Location = new System.Drawing.Point(591, 85);
            this.TbEditDistribuidor.Name = "TbEditDistribuidor";
            this.TbEditDistribuidor.Size = new System.Drawing.Size(100, 22);
            this.TbEditDistribuidor.TabIndex = 7;
            // 
            // TbEditPreco
            // 
            this.TbEditPreco.Location = new System.Drawing.Point(591, 136);
            this.TbEditPreco.Name = "TbEditPreco";
            this.TbEditPreco.Size = new System.Drawing.Size(100, 22);
            this.TbEditPreco.TabIndex = 6;
            // 
            // TbEditNome
            // 
            this.TbEditNome.Location = new System.Drawing.Point(316, 29);
            this.TbEditNome.Name = "TbEditNome";
            this.TbEditNome.Size = new System.Drawing.Size(100, 22);
            this.TbEditNome.TabIndex = 7;
            // 
            // TbEditCodBarras
            // 
            this.TbEditCodBarras.Location = new System.Drawing.Point(316, 136);
            this.TbEditCodBarras.Name = "TbEditCodBarras";
            this.TbEditCodBarras.Size = new System.Drawing.Size(100, 22);
            this.TbEditCodBarras.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(510, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Distribuidor:";
            // 
            // TbEditMarca
            // 
            this.TbEditMarca.Location = new System.Drawing.Point(591, 30);
            this.TbEditMarca.Name = "TbEditMarca";
            this.TbEditMarca.Size = new System.Drawing.Size(100, 22);
            this.TbEditMarca.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Preço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nome da Peça:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Codigo de Barras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Marca:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Código da Peça:";
            // 
            // TbEditCodPeca
            // 
            this.TbEditCodPeca.Location = new System.Drawing.Point(316, 86);
            this.TbEditCodPeca.Name = "TbEditCodPeca";
            this.TbEditCodPeca.Size = new System.Drawing.Size(100, 22);
            this.TbEditCodPeca.TabIndex = 0;
            // 
            // tabPageExcluir
            // 
            this.tabPageExcluir.Controls.Add(this.label4);
            this.tabPageExcluir.Controls.Add(this.DgExcluir);
            this.tabPageExcluir.Controls.Add(this.groupBox1);
            this.tabPageExcluir.Controls.Add(this.panel4);
            this.tabPageExcluir.Location = new System.Drawing.Point(4, 25);
            this.tabPageExcluir.Name = "tabPageExcluir";
            this.tabPageExcluir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExcluir.Size = new System.Drawing.Size(804, 370);
            this.tabPageExcluir.TabIndex = 2;
            this.tabPageExcluir.Text = "Excluir Peças";
            this.tabPageExcluir.UseVisualStyleBackColor = true;
            this.tabPageExcluir.Enter += new System.EventHandler(this.tabPageExcluir_Enter);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(668, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Clique no Icone de Exclusão para Excluir";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgExcluir
            // 
            this.DgExcluir.AllowUserToAddRows = false;
            this.DgExcluir.AllowUserToDeleteRows = false;
            this.DgExcluir.BackgroundColor = System.Drawing.Color.White;
            this.DgExcluir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgExcluir.Location = new System.Drawing.Point(0, 195);
            this.DgExcluir.Name = "DgExcluir";
            this.DgExcluir.ReadOnly = true;
            this.DgExcluir.Size = new System.Drawing.Size(804, 175);
            this.DgExcluir.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbExcluir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(255, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir";
            // 
            // TbExcluir
            // 
            this.TbExcluir.Location = new System.Drawing.Point(163, 51);
            this.TbExcluir.Name = "TbExcluir";
            this.TbExcluir.Size = new System.Drawing.Size(182, 22);
            this.TbExcluir.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código Único da Peça:";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(14, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 158);
            this.panel4.TabIndex = 10;
            // 
            // tabPagePesquisa
            // 
            this.tabPagePesquisa.Controls.Add(this.GbPesquisa);
            this.tabPagePesquisa.Controls.Add(this.panel3);
            this.tabPagePesquisa.Controls.Add(this.label2);
            this.tabPagePesquisa.Controls.Add(this.DgPesquisa);
            this.tabPagePesquisa.Controls.Add(this.GbFiltroPesquisa);
            this.tabPagePesquisa.Location = new System.Drawing.Point(4, 25);
            this.tabPagePesquisa.Name = "tabPagePesquisa";
            this.tabPagePesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisa.Size = new System.Drawing.Size(804, 370);
            this.tabPagePesquisa.TabIndex = 3;
            this.tabPagePesquisa.Text = "Pesquisar Peças";
            this.tabPagePesquisa.UseVisualStyleBackColor = true;
            // 
            // GbPesquisa
            // 
            this.GbPesquisa.Controls.Add(this.TbPesquisa);
            this.GbPesquisa.Controls.Add(this.label1);
            this.GbPesquisa.Location = new System.Drawing.Point(244, 33);
            this.GbPesquisa.Name = "GbPesquisa";
            this.GbPesquisa.Size = new System.Drawing.Size(323, 136);
            this.GbPesquisa.TabIndex = 9;
            this.GbPesquisa.TabStop = false;
            this.GbPesquisa.Text = "Pesquisa";
            // 
            // TbPesquisa
            // 
            this.TbPesquisa.Location = new System.Drawing.Point(108, 64);
            this.TbPesquisa.Name = "TbPesquisa";
            this.TbPesquisa.Size = new System.Drawing.Size(182, 22);
            this.TbPesquisa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o valor:";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(8, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 158);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clique no Icone de Pesquisa para buscar";
            // 
            // DgPesquisa
            // 
            this.DgPesquisa.AllowUserToAddRows = false;
            this.DgPesquisa.AllowUserToDeleteRows = false;
            this.DgPesquisa.BackgroundColor = System.Drawing.Color.White;
            this.DgPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPesquisa.Location = new System.Drawing.Point(0, 208);
            this.DgPesquisa.Name = "DgPesquisa";
            this.DgPesquisa.ReadOnly = true;
            this.DgPesquisa.Size = new System.Drawing.Size(804, 162);
            this.DgPesquisa.TabIndex = 1;
            // 
            // GbFiltroPesquisa
            // 
            this.GbFiltroPesquisa.Controls.Add(this.RbCodigoUnico);
            this.GbFiltroPesquisa.Controls.Add(this.RbCodigoPeca);
            this.GbFiltroPesquisa.Controls.Add(this.RbPorNome);
            this.GbFiltroPesquisa.Location = new System.Drawing.Point(573, 33);
            this.GbFiltroPesquisa.Name = "GbFiltroPesquisa";
            this.GbFiltroPesquisa.Size = new System.Drawing.Size(200, 136);
            this.GbFiltroPesquisa.TabIndex = 10;
            this.GbFiltroPesquisa.TabStop = false;
            this.GbFiltroPesquisa.Text = "Filtro de Pesquisa";
            // 
            // RbCodigoUnico
            // 
            this.RbCodigoUnico.AutoSize = true;
            this.RbCodigoUnico.Location = new System.Drawing.Point(18, 99);
            this.RbCodigoUnico.Name = "RbCodigoUnico";
            this.RbCodigoUnico.Size = new System.Drawing.Size(120, 20);
            this.RbCodigoUnico.TabIndex = 6;
            this.RbCodigoUnico.Text = "Por Código Único";
            this.RbCodigoUnico.UseVisualStyleBackColor = true;
            // 
            // RbCodigoPeca
            // 
            this.RbCodigoPeca.AutoSize = true;
            this.RbCodigoPeca.Location = new System.Drawing.Point(18, 67);
            this.RbCodigoPeca.Name = "RbCodigoPeca";
            this.RbCodigoPeca.Size = new System.Drawing.Size(130, 20);
            this.RbCodigoPeca.TabIndex = 6;
            this.RbCodigoPeca.Text = "Por Código da Peça";
            this.RbCodigoPeca.UseVisualStyleBackColor = true;
            // 
            // RbPorNome
            // 
            this.RbPorNome.AutoSize = true;
            this.RbPorNome.Checked = true;
            this.RbPorNome.Location = new System.Drawing.Point(18, 32);
            this.RbPorNome.Name = "RbPorNome";
            this.RbPorNome.Size = new System.Drawing.Size(77, 20);
            this.RbPorNome.TabIndex = 5;
            this.RbPorNome.TabStop = true;
            this.RbPorNome.Text = "Por Nome";
            this.RbPorNome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(888, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema CRUD - Cadastro de Peças";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControlCadastrar.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.TbPreco.ResumeLayout(false);
            this.tabPageEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgEdit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageExcluir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgExcluir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagePesquisa.ResumeLayout(false);
            this.tabPagePesquisa.PerformLayout();
            this.GbPesquisa.ResumeLayout(false);
            this.GbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPesquisa)).EndInit();
            this.GbFiltroPesquisa.ResumeLayout(false);
            this.GbFiltroPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel LbHora;
        private System.Windows.Forms.TabControl tabControlCadastrar;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.TabPage tabPageExcluir;
        private System.Windows.Forms.TabPage tabPagePesquisa;
        private System.Windows.Forms.ToolStripButton toolStripCadastrar;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripStatusLabel LbHora1;
        private System.Windows.Forms.ToolStripButton toolStripExcluir;
        private System.Windows.Forms.ToolStripButton toolStripPesquisa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSair;
        private System.Windows.Forms.RadioButton RbCodigoPeca;
        private System.Windows.Forms.RadioButton RbPorNome;
        private System.Windows.Forms.TextBox TbPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox GbPesquisa;
        private System.Windows.Forms.GroupBox GbFiltroPesquisa;
        private System.Windows.Forms.DataGridView DgExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbEditNome;
        private System.Windows.Forms.TextBox TbEditCodBarras;
        private System.Windows.Forms.TextBox TbEditMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbEditDistribuidor;
        private System.Windows.Forms.TextBox TbEditPreco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbEditCodPeca;
        private System.Windows.Forms.Panel TbPreco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TbDistribuidor;
        private System.Windows.Forms.TextBox TbCadPreco;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbCodigoBarras;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TbMarca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TbCodigoPeca;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RbCodigoUnico;
        private System.Windows.Forms.TextBox TbCodigoUnico;
        private System.Windows.Forms.Label LbCodigounico;
    }
}

