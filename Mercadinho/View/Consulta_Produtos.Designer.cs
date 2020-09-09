namespace Mercadinho
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.ExcluirProdutoButton = new System.Windows.Forms.Button();
            this.AlterarProdutoButton = new System.Windows.Forms.Button();
            this.CodigoBarrasProduto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoProduto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarinho = new System.Windows.Forms.Button();
            this.btnTP_ConsProduto = new System.Windows.Forms.Button();
            this.btnServico_ConsProduto = new System.Windows.Forms.Button();
            this.btnProduto_ConsProduto = new System.Windows.Forms.Button();
            this.btnCliente_ConsProduto = new System.Windows.Forms.Button();
            this.btnSair_ConsProduto = new System.Windows.Forms.Button();
            this.btnRelatorio_ConsProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.QuantidadeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.DataProdutoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PreçoCompraProdutoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PreçoVendaProdutoTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExcluirProdutoButton
            // 
            this.ExcluirProdutoButton.FlatAppearance.BorderSize = 0;
            this.ExcluirProdutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirProdutoButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirProdutoButton.Image")));
            this.ExcluirProdutoButton.Location = new System.Drawing.Point(826, 406);
            this.ExcluirProdutoButton.Name = "ExcluirProdutoButton";
            this.ExcluirProdutoButton.Size = new System.Drawing.Size(43, 36);
            this.ExcluirProdutoButton.TabIndex = 61;
            this.ExcluirProdutoButton.UseVisualStyleBackColor = true;
            this.ExcluirProdutoButton.Click += new System.EventHandler(this.ExcluirProdutoButton_Click);
            // 
            // AlterarProdutoButton
            // 
            this.AlterarProdutoButton.FlatAppearance.BorderSize = 0;
            this.AlterarProdutoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlterarProdutoButton.Image = ((System.Drawing.Image)(resources.GetObject("AlterarProdutoButton.Image")));
            this.AlterarProdutoButton.Location = new System.Drawing.Point(777, 406);
            this.AlterarProdutoButton.Name = "AlterarProdutoButton";
            this.AlterarProdutoButton.Size = new System.Drawing.Size(43, 36);
            this.AlterarProdutoButton.TabIndex = 59;
            this.AlterarProdutoButton.UseVisualStyleBackColor = true;
            this.AlterarProdutoButton.Click += new System.EventHandler(this.AlterarProdutoButton_Click);
            // 
            // CodigoBarrasProduto
            // 
            this.CodigoBarrasProduto.AutoSize = true;
            this.CodigoBarrasProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoBarrasProduto.Location = new System.Drawing.Point(129, 197);
            this.CodigoBarrasProduto.Name = "CodigoBarrasProduto";
            this.CodigoBarrasProduto.Size = new System.Drawing.Size(0, 18);
            this.CodigoBarrasProduto.TabIndex = 66;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.precocompra,
            this.precovenda,
            this.estoque,
            this.contato,
            this.IdTipo,
            this.Tipo,
            this.DataVencimento});
            this.dataGridView1.Location = new System.Drawing.Point(237, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 212);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // precocompra
            // 
            this.precocompra.HeaderText = "Preço Compra";
            this.precocompra.Name = "precocompra";
            // 
            // precovenda
            // 
            this.precovenda.HeaderText = "Preço Venda";
            this.precovenda.Name = "precovenda";
            // 
            // estoque
            // 
            this.estoque.HeaderText = "Estoque";
            this.estoque.Name = "estoque";
            // 
            // contato
            // 
            this.contato.HeaderText = "Codigo de Barras";
            this.contato.Name = "contato";
            // 
            // IdTipo
            // 
            this.IdTipo.HeaderText = "IdTipo";
            this.IdTipo.Name = "IdTipo";
            this.IdTipo.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // DataVencimento
            // 
            this.DataVencimento.HeaderText = "Data de Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataVencimento.Visible = false;
            // 
            // IdTipoProduto
            // 
            this.IdTipoProduto.AutoSize = true;
            this.IdTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTipoProduto.Location = new System.Drawing.Point(129, 273);
            this.IdTipoProduto.Name = "IdTipoProduto";
            this.IdTipoProduto.Size = new System.Drawing.Size(0, 18);
            this.IdTipoProduto.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 14);
            this.panel2.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(100, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 123);
            this.panel3.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 25);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(103, 76);
            this.button1.TabIndex = 10;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnCarinho);
            this.panel1.Controls.Add(this.btnTP_ConsProduto);
            this.panel1.Controls.Add(this.btnServico_ConsProduto);
            this.panel1.Controls.Add(this.btnProduto_ConsProduto);
            this.panel1.Controls.Add(this.btnCliente_ConsProduto);
            this.panel1.Controls.Add(this.btnSair_ConsProduto);
            this.panel1.Controls.Add(this.btnRelatorio_ConsProduto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 457);
            this.panel1.TabIndex = 118;
            // 
            // btnCarinho
            // 
            this.btnCarinho.FlatAppearance.BorderSize = 0;
            this.btnCarinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarinho.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCarinho.Image = ((System.Drawing.Image)(resources.GetObject("btnCarinho.Image")));
            this.btnCarinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarinho.Location = new System.Drawing.Point(3, 244);
            this.btnCarinho.Name = "btnCarinho";
            this.btnCarinho.Size = new System.Drawing.Size(46, 45);
            this.btnCarinho.TabIndex = 63;
            this.btnCarinho.UseVisualStyleBackColor = true;
            this.btnCarinho.Click += new System.EventHandler(this.btnCarinho_Click);
            // 
            // btnTP_ConsProduto
            // 
            this.btnTP_ConsProduto.FlatAppearance.BorderSize = 0;
            this.btnTP_ConsProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTP_ConsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTP_ConsProduto.ForeColor = System.Drawing.Color.White;
            this.btnTP_ConsProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnTP_ConsProduto.Image")));
            this.btnTP_ConsProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTP_ConsProduto.Location = new System.Drawing.Point(3, 193);
            this.btnTP_ConsProduto.Name = "btnTP_ConsProduto";
            this.btnTP_ConsProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTP_ConsProduto.Size = new System.Drawing.Size(46, 45);
            this.btnTP_ConsProduto.TabIndex = 41;
            this.btnTP_ConsProduto.UseVisualStyleBackColor = true;
            this.btnTP_ConsProduto.Click += new System.EventHandler(this.btnTP_ConsProduto_Click);
            // 
            // btnServico_ConsProduto
            // 
            this.btnServico_ConsProduto.FlatAppearance.BorderSize = 0;
            this.btnServico_ConsProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico_ConsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico_ConsProduto.ForeColor = System.Drawing.Color.White;
            this.btnServico_ConsProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnServico_ConsProduto.Image")));
            this.btnServico_ConsProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServico_ConsProduto.Location = new System.Drawing.Point(3, 141);
            this.btnServico_ConsProduto.Name = "btnServico_ConsProduto";
            this.btnServico_ConsProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServico_ConsProduto.Size = new System.Drawing.Size(46, 45);
            this.btnServico_ConsProduto.TabIndex = 13;
            this.btnServico_ConsProduto.UseVisualStyleBackColor = true;
            this.btnServico_ConsProduto.Click += new System.EventHandler(this.btnServico_ConsProduto_Click);
            // 
            // btnProduto_ConsProduto
            // 
            this.btnProduto_ConsProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto_ConsProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto_ConsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto_ConsProduto.ForeColor = System.Drawing.Color.White;
            this.btnProduto_ConsProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto_ConsProduto.Image")));
            this.btnProduto_ConsProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto_ConsProduto.Location = new System.Drawing.Point(3, 88);
            this.btnProduto_ConsProduto.Name = "btnProduto_ConsProduto";
            this.btnProduto_ConsProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProduto_ConsProduto.Size = new System.Drawing.Size(46, 45);
            this.btnProduto_ConsProduto.TabIndex = 12;
            this.btnProduto_ConsProduto.UseVisualStyleBackColor = true;
            this.btnProduto_ConsProduto.Click += new System.EventHandler(this.btnProduto_ConsProduto_Click);
            // 
            // btnCliente_ConsProduto
            // 
            this.btnCliente_ConsProduto.FlatAppearance.BorderSize = 0;
            this.btnCliente_ConsProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente_ConsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente_ConsProduto.ForeColor = System.Drawing.Color.White;
            this.btnCliente_ConsProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente_ConsProduto.Image")));
            this.btnCliente_ConsProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente_ConsProduto.Location = new System.Drawing.Point(3, 37);
            this.btnCliente_ConsProduto.Name = "btnCliente_ConsProduto";
            this.btnCliente_ConsProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCliente_ConsProduto.Size = new System.Drawing.Size(46, 45);
            this.btnCliente_ConsProduto.TabIndex = 11;
            this.btnCliente_ConsProduto.UseVisualStyleBackColor = true;
            this.btnCliente_ConsProduto.Click += new System.EventHandler(this.btnCliente_ConsProduto_Click);
            // 
            // btnSair_ConsProduto
            // 
            this.btnSair_ConsProduto.FlatAppearance.BorderSize = 0;
            this.btnSair_ConsProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair_ConsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair_ConsProduto.ForeColor = System.Drawing.Color.White;
            this.btnSair_ConsProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnSair_ConsProduto.Image")));
            this.btnSair_ConsProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair_ConsProduto.Location = new System.Drawing.Point(3, 404);
            this.btnSair_ConsProduto.Name = "btnSair_ConsProduto";
            this.btnSair_ConsProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair_ConsProduto.Size = new System.Drawing.Size(46, 45);
            this.btnSair_ConsProduto.TabIndex = 9;
            this.btnSair_ConsProduto.UseVisualStyleBackColor = true;
            this.btnSair_ConsProduto.Click += new System.EventHandler(this.btnSair_ConsProduto_Click);
            // 
            // btnRelatorio_ConsProduto
            // 
            this.btnRelatorio_ConsProduto.FlatAppearance.BorderSize = 0;
            this.btnRelatorio_ConsProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio_ConsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio_ConsProduto.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio_ConsProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio_ConsProduto.Image")));
            this.btnRelatorio_ConsProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio_ConsProduto.Location = new System.Drawing.Point(3, 316);
            this.btnRelatorio_ConsProduto.Name = "btnRelatorio_ConsProduto";
            this.btnRelatorio_ConsProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRelatorio_ConsProduto.Size = new System.Drawing.Size(46, 45);
            this.btnRelatorio_ConsProduto.TabIndex = 8;
            this.btnRelatorio_ConsProduto.UseVisualStyleBackColor = true;
            this.btnRelatorio_ConsProduto.Click += new System.EventHandler(this.btnRelatorio_ConsProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 119;
            this.label1.Text = "Consulta de Produtos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 120;
            this.label3.Text = "Código de Barras";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(73, 219);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(136, 1);
            this.panel10.TabIndex = 121;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 122;
            this.label6.Text = "ID Tipo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(73, 292);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 1);
            this.panel4.TabIndex = 122;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(94, 369);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 1);
            this.panel5.TabIndex = 125;
            // 
            // NomeProdutoTextBox
            // 
            this.NomeProdutoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NomeProdutoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomeProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProdutoTextBox.ForeColor = System.Drawing.Color.Black;
            this.NomeProdutoTextBox.Location = new System.Drawing.Point(94, 344);
            this.NomeProdutoTextBox.Name = "NomeProdutoTextBox";
            this.NomeProdutoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NomeProdutoTextBox.Size = new System.Drawing.Size(136, 17);
            this.NomeProdutoTextBox.TabIndex = 124;
            this.NomeProdutoTextBox.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 123;
            this.label2.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 126;
            this.label4.Text = "Tipo";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(268, 369);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(136, 1);
            this.panel9.TabIndex = 129;
            // 
            // QuantidadeProdutoTextBox
            // 
            this.QuantidadeProdutoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.QuantidadeProdutoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantidadeProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeProdutoTextBox.ForeColor = System.Drawing.Color.Black;
            this.QuantidadeProdutoTextBox.Location = new System.Drawing.Point(268, 344);
            this.QuantidadeProdutoTextBox.Name = "QuantidadeProdutoTextBox";
            this.QuantidadeProdutoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuantidadeProdutoTextBox.Size = new System.Drawing.Size(136, 17);
            this.QuantidadeProdutoTextBox.TabIndex = 128;
            this.QuantidadeProdutoTextBox.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 127;
            this.label8.Text = "Quantidade";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(442, 369);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 1);
            this.panel6.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 130;
            this.label5.Text = "Preço da Compra";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(442, 438);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(136, 1);
            this.panel7.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 133;
            this.label7.Text = "Preço da Venda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(649, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 24);
            this.label9.TabIndex = 136;
            this.label9.Text = "Data de Vencimento";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Black;
            this.panel15.Location = new System.Drawing.Point(684, 369);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(136, 1);
            this.panel15.TabIndex = 138;
            // 
            // DataProdutoTextBox
            // 
            this.DataProdutoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DataProdutoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataProdutoTextBox.Location = new System.Drawing.Point(684, 351);
            this.DataProdutoTextBox.Name = "DataProdutoTextBox";
            this.DataProdutoTextBox.PromptChar = '0';
            this.DataProdutoTextBox.Size = new System.Drawing.Size(136, 17);
            this.DataProdutoTextBox.TabIndex = 139;
            this.DataProdutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataProdutoTextBox.Click += new System.EventHandler(this.DataProdutoTextBox_Click);
            // 
            // PreçoCompraProdutoTextBox
            // 
            this.PreçoCompraProdutoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PreçoCompraProdutoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreçoCompraProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreçoCompraProdutoTextBox.Location = new System.Drawing.Point(442, 348);
            this.PreçoCompraProdutoTextBox.Name = "PreçoCompraProdutoTextBox";
            this.PreçoCompraProdutoTextBox.PromptChar = '0';
            this.PreçoCompraProdutoTextBox.Size = new System.Drawing.Size(136, 17);
            this.PreçoCompraProdutoTextBox.TabIndex = 140;
            this.PreçoCompraProdutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PreçoCompraProdutoTextBox.Click += new System.EventHandler(this.PreçoCompraProdutoTextBox_Click);
            // 
            // PreçoVendaProdutoTextBox
            // 
            this.PreçoVendaProdutoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PreçoVendaProdutoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreçoVendaProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreçoVendaProdutoTextBox.Location = new System.Drawing.Point(442, 417);
            this.PreçoVendaProdutoTextBox.Name = "PreçoVendaProdutoTextBox";
            this.PreçoVendaProdutoTextBox.PromptChar = '0';
            this.PreçoVendaProdutoTextBox.Size = new System.Drawing.Size(136, 17);
            this.PreçoVendaProdutoTextBox.TabIndex = 141;
            this.PreçoVendaProdutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PreçoVendaProdutoTextBox.Click += new System.EventHandler(this.PreçoVendaProdutoTextBox_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 452);
            this.Controls.Add(this.PreçoVendaProdutoTextBox);
            this.Controls.Add(this.PreçoCompraProdutoTextBox);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.DataProdutoTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.QuantidadeProdutoTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.NomeProdutoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.IdTipoProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CodigoBarrasProduto);
            this.Controls.Add(this.ExcluirProdutoButton);
            this.Controls.Add(this.AlterarProdutoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExcluirProdutoButton;
        private System.Windows.Forms.Button AlterarProdutoButton;
        private System.Windows.Forms.Label CodigoBarrasProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IdTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarinho;
        private System.Windows.Forms.Button btnTP_ConsProduto;
        private System.Windows.Forms.Button btnServico_ConsProduto;
        private System.Windows.Forms.Button btnProduto_ConsProduto;
        private System.Windows.Forms.Button btnCliente_ConsProduto;
        private System.Windows.Forms.Button btnSair_ConsProduto;
        private System.Windows.Forms.Button btnRelatorio_ConsProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox NomeProdutoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox QuantidadeProdutoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.MaskedTextBox DataProdutoTextBox;
        private System.Windows.Forms.MaskedTextBox PreçoCompraProdutoTextBox;
        private System.Windows.Forms.MaskedTextBox PreçoVendaProdutoTextBox;
    }
}