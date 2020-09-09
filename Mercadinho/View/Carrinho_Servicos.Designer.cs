namespace Mercadinho.View
{
    partial class Carrinho_Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrinho_Servicos));
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewservios = new System.Windows.Forms.DataGridView();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelclienteserv = new System.Windows.Forms.Label();
            this.cpfclienteserv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelvalorparcelas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CodBarrasProdutoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.formadepagamento = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarinho = new System.Windows.Forms.Button();
            this.btnTP_Carrinho = new System.Windows.Forms.Button();
            this.btnServico_Carrinho = new System.Windows.Forms.Button();
            this.btnProduto_Carrinho = new System.Windows.Forms.Button();
            this.btnCliente_Carrinho = new System.Windows.Forms.Button();
            this.btnSair_Carrinho = new System.Windows.Forms.Button();
            this.btnRelatorio_Carrinho = new System.Windows.Forms.Button();
            this.qtdparcelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewservios)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(287, 31);
            this.label11.TabIndex = 100;
            this.label11.Text = "Carrinho de Serviços";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(563, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 101;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(631, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 37);
            this.button2.TabIndex = 102;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewservios
            // 
            this.dataGridViewservios.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridViewservios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewservios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Preco,
            this.IdServico,
            this.Descricao});
            this.dataGridViewservios.Location = new System.Drawing.Point(90, 193);
            this.dataGridViewservios.Name = "dataGridViewservios";
            this.dataGridViewservios.Size = new System.Drawing.Size(374, 279);
            this.dataGridViewservios.TabIndex = 103;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço Serviço";
            this.Preco.Name = "Preco";
            // 
            // IdServico
            // 
            this.IdServico.HeaderText = "IdServico";
            this.IdServico.Name = "IdServico";
            this.IdServico.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(534, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 43);
            this.button3.TabIndex = 106;
            this.button3.Text = "Finalizar Compra";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(613, 381);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(107, 31);
            this.LabelTotal.TabIndex = 111;
            this.LabelTotal.Text = "TOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 31);
            this.label5.TabIndex = 110;
            this.label5.Text = "R$";
            // 
            // labelclienteserv
            // 
            this.labelclienteserv.AutoSize = true;
            this.labelclienteserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclienteserv.Location = new System.Drawing.Point(328, 84);
            this.labelclienteserv.Name = "labelclienteserv";
            this.labelclienteserv.Size = new System.Drawing.Size(0, 18);
            this.labelclienteserv.TabIndex = 112;
            // 
            // cpfclienteserv
            // 
            this.cpfclienteserv.AutoSize = true;
            this.cpfclienteserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfclienteserv.Location = new System.Drawing.Point(328, 135);
            this.cpfclienteserv.Name = "cpfclienteserv";
            this.cpfclienteserv.Size = new System.Drawing.Size(0, 18);
            this.cpfclienteserv.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 31);
            this.label4.TabIndex = 119;
            this.label4.Text = "R$";
            // 
            // labelvalorparcelas
            // 
            this.labelvalorparcelas.AutoSize = true;
            this.labelvalorparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalorparcelas.Location = new System.Drawing.Point(614, 179);
            this.labelvalorparcelas.Name = "labelvalorparcelas";
            this.labelvalorparcelas.Size = new System.Drawing.Size(0, 29);
            this.labelvalorparcelas.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 138;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 140;
            this.label2.Text = " Serviço";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 14);
            this.panel2.TabIndex = 141;
            // 
            // CodBarrasProdutoLabel
            // 
            this.CodBarrasProdutoLabel.AutoSize = true;
            this.CodBarrasProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodBarrasProdutoLabel.Location = new System.Drawing.Point(251, 85);
            this.CodBarrasProdutoLabel.Name = "CodBarrasProdutoLabel";
            this.CodBarrasProdutoLabel.Size = new System.Drawing.Size(72, 24);
            this.CodBarrasProdutoLabel.TabIndex = 142;
            this.CodBarrasProdutoLabel.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 143;
            this.label7.Text = "CPF:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(328, 158);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(136, 1);
            this.panel8.TabIndex = 144;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(328, 107);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(136, 1);
            this.panel10.TabIndex = 145;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(100, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 123);
            this.panel3.TabIndex = 146;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrange;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(3, 25);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(103, 76);
            this.button4.TabIndex = 10;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(563, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 1);
            this.panel4.TabIndex = 147;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 151;
            this.label9.Text = "Parcela:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 150;
            this.label8.Text = "Pagamento:";
            // 
            // formadepagamento
            // 
            this.formadepagamento.BackColor = System.Drawing.Color.White;
            this.formadepagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formadepagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formadepagamento.FormattingEnabled = true;
            this.formadepagamento.Items.AddRange(new object[] {
            "Boleto",
            "Crédito",
            "Á Vista"});
            this.formadepagamento.Location = new System.Drawing.Point(618, 244);
            this.formadepagamento.Name = "formadepagamento";
            this.formadepagamento.Size = new System.Drawing.Size(80, 28);
            this.formadepagamento.TabIndex = 148;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnCarinho);
            this.panel1.Controls.Add(this.btnTP_Carrinho);
            this.panel1.Controls.Add(this.btnServico_Carrinho);
            this.panel1.Controls.Add(this.btnProduto_Carrinho);
            this.panel1.Controls.Add(this.btnCliente_Carrinho);
            this.panel1.Controls.Add(this.btnSair_Carrinho);
            this.panel1.Controls.Add(this.btnRelatorio_Carrinho);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 488);
            this.panel1.TabIndex = 152;
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
            // btnTP_Carrinho
            // 
            this.btnTP_Carrinho.FlatAppearance.BorderSize = 0;
            this.btnTP_Carrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTP_Carrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTP_Carrinho.ForeColor = System.Drawing.Color.White;
            this.btnTP_Carrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnTP_Carrinho.Image")));
            this.btnTP_Carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTP_Carrinho.Location = new System.Drawing.Point(3, 193);
            this.btnTP_Carrinho.Name = "btnTP_Carrinho";
            this.btnTP_Carrinho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTP_Carrinho.Size = new System.Drawing.Size(46, 45);
            this.btnTP_Carrinho.TabIndex = 41;
            this.btnTP_Carrinho.UseVisualStyleBackColor = true;
            this.btnTP_Carrinho.Click += new System.EventHandler(this.btnTP_Carrinho_Click);
            // 
            // btnServico_Carrinho
            // 
            this.btnServico_Carrinho.FlatAppearance.BorderSize = 0;
            this.btnServico_Carrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico_Carrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico_Carrinho.ForeColor = System.Drawing.Color.White;
            this.btnServico_Carrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnServico_Carrinho.Image")));
            this.btnServico_Carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServico_Carrinho.Location = new System.Drawing.Point(3, 141);
            this.btnServico_Carrinho.Name = "btnServico_Carrinho";
            this.btnServico_Carrinho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServico_Carrinho.Size = new System.Drawing.Size(46, 45);
            this.btnServico_Carrinho.TabIndex = 13;
            this.btnServico_Carrinho.UseVisualStyleBackColor = true;
            this.btnServico_Carrinho.Click += new System.EventHandler(this.btnServico_Carrinho_Click);
            // 
            // btnProduto_Carrinho
            // 
            this.btnProduto_Carrinho.FlatAppearance.BorderSize = 0;
            this.btnProduto_Carrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto_Carrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto_Carrinho.ForeColor = System.Drawing.Color.White;
            this.btnProduto_Carrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto_Carrinho.Image")));
            this.btnProduto_Carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto_Carrinho.Location = new System.Drawing.Point(3, 88);
            this.btnProduto_Carrinho.Name = "btnProduto_Carrinho";
            this.btnProduto_Carrinho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProduto_Carrinho.Size = new System.Drawing.Size(46, 45);
            this.btnProduto_Carrinho.TabIndex = 12;
            this.btnProduto_Carrinho.UseVisualStyleBackColor = true;
            this.btnProduto_Carrinho.Click += new System.EventHandler(this.btnProduto_Carrinho_Click);
            // 
            // btnCliente_Carrinho
            // 
            this.btnCliente_Carrinho.FlatAppearance.BorderSize = 0;
            this.btnCliente_Carrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente_Carrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente_Carrinho.ForeColor = System.Drawing.Color.White;
            this.btnCliente_Carrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente_Carrinho.Image")));
            this.btnCliente_Carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente_Carrinho.Location = new System.Drawing.Point(3, 37);
            this.btnCliente_Carrinho.Name = "btnCliente_Carrinho";
            this.btnCliente_Carrinho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCliente_Carrinho.Size = new System.Drawing.Size(46, 45);
            this.btnCliente_Carrinho.TabIndex = 11;
            this.btnCliente_Carrinho.UseVisualStyleBackColor = true;
            this.btnCliente_Carrinho.Click += new System.EventHandler(this.btnCliente_Carrinho_Click);
            // 
            // btnSair_Carrinho
            // 
            this.btnSair_Carrinho.FlatAppearance.BorderSize = 0;
            this.btnSair_Carrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair_Carrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair_Carrinho.ForeColor = System.Drawing.Color.White;
            this.btnSair_Carrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnSair_Carrinho.Image")));
            this.btnSair_Carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair_Carrinho.Location = new System.Drawing.Point(4, 429);
            this.btnSair_Carrinho.Name = "btnSair_Carrinho";
            this.btnSair_Carrinho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair_Carrinho.Size = new System.Drawing.Size(46, 45);
            this.btnSair_Carrinho.TabIndex = 9;
            this.btnSair_Carrinho.UseVisualStyleBackColor = true;
            this.btnSair_Carrinho.Click += new System.EventHandler(this.btnSair_Carrinho_Click);
            // 
            // btnRelatorio_Carrinho
            // 
            this.btnRelatorio_Carrinho.FlatAppearance.BorderSize = 0;
            this.btnRelatorio_Carrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio_Carrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio_Carrinho.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio_Carrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio_Carrinho.Image")));
            this.btnRelatorio_Carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio_Carrinho.Location = new System.Drawing.Point(3, 336);
            this.btnRelatorio_Carrinho.Name = "btnRelatorio_Carrinho";
            this.btnRelatorio_Carrinho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRelatorio_Carrinho.Size = new System.Drawing.Size(46, 45);
            this.btnRelatorio_Carrinho.TabIndex = 8;
            this.btnRelatorio_Carrinho.UseVisualStyleBackColor = true;
            this.btnRelatorio_Carrinho.Click += new System.EventHandler(this.btnRelatorio_Carrinho_Click);
            // 
            // qtdparcelas
            // 
            this.qtdparcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qtdparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdparcelas.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.qtdparcelas.Location = new System.Drawing.Point(657, 293);
            this.qtdparcelas.Name = "qtdparcelas";
            this.qtdparcelas.Size = new System.Drawing.Size(41, 28);
            this.qtdparcelas.TabIndex = 149;
            this.qtdparcelas.SelectedValueChanged += new System.EventHandler(this.qtdparcelas_SelectedValueChanged_1);
            // 
            // Carrinho_Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qtdparcelas);
            this.Controls.Add(this.formadepagamento);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CodBarrasProdutoLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelvalorparcelas);
            this.Controls.Add(this.cpfclienteserv);
            this.Controls.Add(this.labelclienteserv);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridViewservios);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrinho_Servicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho_Servicos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewservios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewservios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelclienteserv;
        private System.Windows.Forms.Label cpfclienteserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelvalorparcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CodBarrasProdutoLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox formadepagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarinho;
        private System.Windows.Forms.Button btnTP_Carrinho;
        private System.Windows.Forms.Button btnServico_Carrinho;
        private System.Windows.Forms.Button btnProduto_Carrinho;
        private System.Windows.Forms.Button btnCliente_Carrinho;
        private System.Windows.Forms.Button btnSair_Carrinho;
        private System.Windows.Forms.Button btnRelatorio_Carrinho;
        private System.Windows.Forms.ComboBox qtdparcelas;
    }
}