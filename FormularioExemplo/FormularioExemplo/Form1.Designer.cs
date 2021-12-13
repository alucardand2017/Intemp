
namespace FormularioExemplo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.btnInserirPlanilhaPadrao = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserirPlanilha = new System.Windows.Forms.Button();
            this.btnIVerificarAtualizar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nupIntemperismo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtbData = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ltvValores = new System.Windows.Forms.ListView();
            this.txtbNovoLocal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNovoLocal = new System.Windows.Forms.Button();
            this.lblStatusPrograma = new System.Windows.Forms.Label();
            this.lblLocalAtual = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIntemperismo)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 29);
            this.button1.TabIndex = 109;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(-83, 389);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(27, 20);
            this.lblCaminho.TabIndex = 106;
            this.lblCaminho.Text = "---";
            // 
            // btnInserirPlanilhaPadrao
            // 
            this.btnInserirPlanilhaPadrao.Location = new System.Drawing.Point(534, 374);
            this.btnInserirPlanilhaPadrao.Name = "btnInserirPlanilhaPadrao";
            this.btnInserirPlanilhaPadrao.Size = new System.Drawing.Size(165, 35);
            this.btnInserirPlanilhaPadrao.TabIndex = 102;
            this.btnInserirPlanilhaPadrao.Text = "Inserir na Planilha";
            this.btnInserirPlanilhaPadrao.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(-3, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(142, 36);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(-3, 39);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(142, 36);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-217, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 77);
            this.panel1.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(3, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-138, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 77);
            this.panel2.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelefone.Location = new System.Drawing.Point(-185, 45);
            this.txtTelefone.Mask = "(000) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(1, 27);
            this.txtTelefone.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Celular";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 77);
            this.panel3.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtNome.Location = new System.Drawing.Point(-733, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(499, 27);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInserir);
            this.panel4.Controls.Add(this.btnRemover);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(49, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 94);
            this.panel4.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(-83, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(27, 20);
            this.lblStatus.TabIndex = 107;
            this.lblStatus.Text = "---";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15585F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.84415F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(717, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 29);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Status:";
            // 
            // btnInserirPlanilha
            // 
            this.btnInserirPlanilha.Location = new System.Drawing.Point(10, 7);
            this.btnInserirPlanilha.Name = "btnInserirPlanilha";
            this.btnInserirPlanilha.Size = new System.Drawing.Size(135, 29);
            this.btnInserirPlanilha.TabIndex = 0;
            this.btnInserirPlanilha.Text = "Enviar Valor";
            this.btnInserirPlanilha.UseVisualStyleBackColor = true;
            this.btnInserirPlanilha.Click += new System.EventHandler(this.btnInserirPlanilha_Click);
            // 
            // btnIVerificarAtualizar
            // 
            this.btnIVerificarAtualizar.Location = new System.Drawing.Point(852, 377);
            this.btnIVerificarAtualizar.Name = "btnIVerificarAtualizar";
            this.btnIVerificarAtualizar.Size = new System.Drawing.Size(138, 63);
            this.btnIVerificarAtualizar.TabIndex = 4;
            this.btnIVerificarAtualizar.Text = "Verificar Atualização";
            this.btnIVerificarAtualizar.UseVisualStyleBackColor = true;
            this.btnIVerificarAtualizar.Click += new System.EventHandler(this.btnIVerificarAtualizar_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.nupIntemperismo);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(552, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 77);
            this.panel5.TabIndex = 2;
            // 
            // nupIntemperismo
            // 
            this.nupIntemperismo.Location = new System.Drawing.Point(201, 42);
            this.nupIntemperismo.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupIntemperismo.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nupIntemperismo.Name = "nupIntemperismo";
            this.nupIntemperismo.Size = new System.Drawing.Size(56, 27);
            this.nupIntemperismo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Intemperismo";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.txtbData);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(355, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 77);
            this.panel6.TabIndex = 1;
            // 
            // txtbData
            // 
            this.txtbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbData.BackColor = System.Drawing.SystemColors.Info;
            this.txtbData.Location = new System.Drawing.Point(43, 42);
            this.txtbData.Mask = "00/00/0000 90:00";
            this.txtbData.Name = "txtbData";
            this.txtbData.Size = new System.Drawing.Size(145, 27);
            this.txtbData.TabIndex = 0;
            this.txtbData.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data e hora";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.txtbNome);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(346, 77);
            this.panel7.TabIndex = 0;
            // 
            // txtbNome
            // 
            this.txtbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNome.BackColor = System.Drawing.SystemColors.Info;
            this.txtbNome.Location = new System.Drawing.Point(3, 42);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(340, 27);
            this.txtbNome.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Operador";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnInserirPlanilha);
            this.panel8.Controls.Add(this.btnLimparTudo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(818, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(159, 77);
            this.panel8.TabIndex = 3;
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparTudo.Location = new System.Drawing.Point(15, 40);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(135, 29);
            this.btnLimparTudo.TabIndex = 1;
            this.btnLimparTudo.Text = "Limpar";
            this.btnLimparTudo.UseVisualStyleBackColor = true;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 107;
            this.label8.Text = "Local Atual:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.15585F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.84415F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(980, 83);
            this.tableLayoutPanel2.TabIndex = 105;
            // 
            // ltvValores
            // 
            this.ltvValores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvValores.BackColor = System.Drawing.SystemColors.Info;
            this.ltvValores.GridLines = true;
            this.ltvValores.HideSelection = false;
            this.ltvValores.Location = new System.Drawing.Point(13, 129);
            this.ltvValores.Name = "ltvValores";
            this.ltvValores.Size = new System.Drawing.Size(980, 242);
            this.ltvValores.TabIndex = 108;
            this.ltvValores.TabStop = false;
            this.ltvValores.UseCompatibleStateImageBehavior = false;
            // 
            // txtbNovoLocal
            // 
            this.txtbNovoLocal.Location = new System.Drawing.Point(10, 381);
            this.txtbNovoLocal.Name = "txtbNovoLocal";
            this.txtbNovoLocal.Size = new System.Drawing.Size(433, 27);
            this.txtbNovoLocal.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(746, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 111;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNovoLocal
            // 
            this.btnNovoLocal.Location = new System.Drawing.Point(717, 377);
            this.btnNovoLocal.Name = "btnNovoLocal";
            this.btnNovoLocal.Size = new System.Drawing.Size(129, 29);
            this.btnNovoLocal.TabIndex = 6;
            this.btnNovoLocal.Text = "...";
            this.btnNovoLocal.UseVisualStyleBackColor = true;
            this.btnNovoLocal.Click += new System.EventHandler(this.btnNovoLocal_Click);
            // 
            // lblStatusPrograma
            // 
            this.lblStatusPrograma.AutoSize = true;
            this.lblStatusPrograma.Location = new System.Drawing.Point(512, 381);
            this.lblStatusPrograma.Name = "lblStatusPrograma";
            this.lblStatusPrograma.Size = new System.Drawing.Size(27, 20);
            this.lblStatusPrograma.TabIndex = 113;
            this.lblStatusPrograma.Text = "---";
            // 
            // lblLocalAtual
            // 
            this.lblLocalAtual.AutoSize = true;
            this.lblLocalAtual.Location = new System.Drawing.Point(108, 421);
            this.lblLocalAtual.Name = "lblLocalAtual";
            this.lblLocalAtual.Size = new System.Drawing.Size(27, 20);
            this.lblLocalAtual.TabIndex = 114;
            this.lblLocalAtual.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(881, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 115;
            this.label11.Text = "Ultimos Valores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.btnIVerificarAtualizar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLocalAtual);
            this.Controls.Add(this.lblStatusPrograma);
            this.Controls.Add(this.btnNovoLocal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbNovoLocal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ltvValores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIntemperismo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Button btnInserirPlanilhaPadrao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserirPlanilha;
        private System.Windows.Forms.Button btnIVerificarAtualizar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nupIntemperismo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView ltvValores;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.MaskedTextBox txtbData;
        private System.Windows.Forms.TextBox txtbNovoLocal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNovoLocal;
        private System.Windows.Forms.Label lblStatusPrograma;
        private System.Windows.Forms.Label lblLocalAtual;
        private System.Windows.Forms.Label label11;
    }
}

