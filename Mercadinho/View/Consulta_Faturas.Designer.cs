namespace Mercadinho.View
{
    partial class Consulta_Faturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Faturas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Fatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Carrinho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomecliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcpfcliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumerodavenda = new System.Windows.Forms.Label();
            this.txtpagamento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdatavencimento = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumerofatura = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarinho = new System.Windows.Forms.Button();
            this.btnTP_ConsFatura = new System.Windows.Forms.Button();
            this.btnServico_ConsFatura = new System.Windows.Forms.Button();
            this.btnProduto_ConsFatura = new System.Windows.Forms.Button();
            this.btnCliente_ConsFatura = new System.Windows.Forms.Button();
            this.btnSair_ConsFatura = new System.Windows.Forms.Button();
            this.btnRelatorio_ConsFatura = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.datapagamentotexbox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Fatura,
            this.CPF,
            this.Nome,
            this.Id_Carrinho,
            this.Data_Vencimento,
            this.Column1,
            this.EstaPago,
            this.Valor_Total});
            this.dataGridView1.Location = new System.Drawing.Point(59, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id_Fatura
            // 
            this.Id_Fatura.HeaderText = "Numero da Fatura";
            this.Id_Fatura.Name = "Id_Fatura";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF Cliente";
            this.CPF.Name = "CPF";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Cliente";
            this.Nome.Name = "Nome";
            // 
            // Id_Carrinho
            // 
            this.Id_Carrinho.HeaderText = "Numero Venda";
            this.Id_Carrinho.Name = "Id_Carrinho";
            // 
            // Data_Vencimento
            // 
            this.Data_Vencimento.HeaderText = "Data de Vencimento";
            this.Data_Vencimento.Name = "Data_Vencimento";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data Pagamento";
            this.Column1.Name = "Column1";
            // 
            // EstaPago
            // 
            this.EstaPago.HeaderText = "Pagamento Efetuado";
            this.EstaPago.Name = "EstaPago";
            this.EstaPago.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor Fatura";
            this.Valor_Total.Name = "Valor_Total";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(808, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(540, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Faturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // txtnomecliente
            // 
            this.txtnomecliente.AutoSize = true;
            this.txtnomecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecliente.Location = new System.Drawing.Point(125, 384);
            this.txtnomecliente.Name = "txtnomecliente";
            this.txtnomecliente.Size = new System.Drawing.Size(0, 20);
            this.txtnomecliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // txtcpfcliente
            // 
            this.txtcpfcliente.AutoSize = true;
            this.txtcpfcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpfcliente.Location = new System.Drawing.Point(113, 416);
            this.txtcpfcliente.Name = "txtcpfcliente";
            this.txtcpfcliente.Size = new System.Drawing.Size(0, 20);
            this.txtcpfcliente.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pagamento Efetuado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Número da Venda:";
            // 
            // txtnumerodavenda
            // 
            this.txtnumerodavenda.AutoSize = true;
            this.txtnumerodavenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerodavenda.Location = new System.Drawing.Point(223, 348);
            this.txtnumerodavenda.Name = "txtnumerodavenda";
            this.txtnumerodavenda.Size = new System.Drawing.Size(0, 20);
            this.txtnumerodavenda.TabIndex = 11;
            // 
            // txtpagamento
            // 
            this.txtpagamento.AutoSize = true;
            this.txtpagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagamento.Location = new System.Drawing.Point(243, 448);
            this.txtpagamento.Name = "txtpagamento";
            this.txtpagamento.Size = new System.Drawing.Size(0, 20);
            this.txtpagamento.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(442, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Data de Vencimento:";
            // 
            // txtdatavencimento
            // 
            this.txtdatavencimento.AutoSize = true;
            this.txtdatavencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatavencimento.Location = new System.Drawing.Point(620, 422);
            this.txtdatavencimento.Name = "txtdatavencimento";
            this.txtdatavencimento.Size = new System.Drawing.Size(0, 20);
            this.txtdatavencimento.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(332, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Filtro Nome Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Número da Fatura:";
            // 
            // txtnumerofatura
            // 
            this.txtnumerofatura.AutoSize = true;
            this.txtnumerofatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerofatura.Location = new System.Drawing.Point(753, 353);
            this.txtnumerofatura.Name = "txtnumerofatura";
            this.txtnumerofatura.Size = new System.Drawing.Size(0, 18);
            this.txtnumerofatura.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 14);
            this.panel2.TabIndex = 122;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(100, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 123);
            this.panel3.TabIndex = 138;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 25);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(103, 76);
            this.button3.TabIndex = 10;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnCarinho);
            this.panel1.Controls.Add(this.btnTP_ConsFatura);
            this.panel1.Controls.Add(this.btnServico_ConsFatura);
            this.panel1.Controls.Add(this.btnProduto_ConsFatura);
            this.panel1.Controls.Add(this.btnCliente_ConsFatura);
            this.panel1.Controls.Add(this.btnSair_ConsFatura);
            this.panel1.Controls.Add(this.btnRelatorio_ConsFatura);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 488);
            this.panel1.TabIndex = 151;
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
            // btnTP_ConsFatura
            // 
            this.btnTP_ConsFatura.FlatAppearance.BorderSize = 0;
            this.btnTP_ConsFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTP_ConsFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTP_ConsFatura.ForeColor = System.Drawing.Color.White;
            this.btnTP_ConsFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnTP_ConsFatura.Image")));
            this.btnTP_ConsFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTP_ConsFatura.Location = new System.Drawing.Point(3, 193);
            this.btnTP_ConsFatura.Name = "btnTP_ConsFatura";
            this.btnTP_ConsFatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTP_ConsFatura.Size = new System.Drawing.Size(46, 45);
            this.btnTP_ConsFatura.TabIndex = 41;
            this.btnTP_ConsFatura.UseVisualStyleBackColor = true;
            this.btnTP_ConsFatura.Click += new System.EventHandler(this.btnTP_ConsFatura_Click);
            // 
            // btnServico_ConsFatura
            // 
            this.btnServico_ConsFatura.FlatAppearance.BorderSize = 0;
            this.btnServico_ConsFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico_ConsFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico_ConsFatura.ForeColor = System.Drawing.Color.White;
            this.btnServico_ConsFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnServico_ConsFatura.Image")));
            this.btnServico_ConsFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServico_ConsFatura.Location = new System.Drawing.Point(3, 141);
            this.btnServico_ConsFatura.Name = "btnServico_ConsFatura";
            this.btnServico_ConsFatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServico_ConsFatura.Size = new System.Drawing.Size(46, 45);
            this.btnServico_ConsFatura.TabIndex = 13;
            this.btnServico_ConsFatura.UseVisualStyleBackColor = true;
            this.btnServico_ConsFatura.Click += new System.EventHandler(this.btnServico_ConsFatura_Click);
            // 
            // btnProduto_ConsFatura
            // 
            this.btnProduto_ConsFatura.FlatAppearance.BorderSize = 0;
            this.btnProduto_ConsFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto_ConsFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto_ConsFatura.ForeColor = System.Drawing.Color.White;
            this.btnProduto_ConsFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto_ConsFatura.Image")));
            this.btnProduto_ConsFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto_ConsFatura.Location = new System.Drawing.Point(3, 88);
            this.btnProduto_ConsFatura.Name = "btnProduto_ConsFatura";
            this.btnProduto_ConsFatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProduto_ConsFatura.Size = new System.Drawing.Size(46, 45);
            this.btnProduto_ConsFatura.TabIndex = 12;
            this.btnProduto_ConsFatura.UseVisualStyleBackColor = true;
            this.btnProduto_ConsFatura.Click += new System.EventHandler(this.btnProduto_ConsFatura_Click);
            // 
            // btnCliente_ConsFatura
            // 
            this.btnCliente_ConsFatura.FlatAppearance.BorderSize = 0;
            this.btnCliente_ConsFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente_ConsFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente_ConsFatura.ForeColor = System.Drawing.Color.White;
            this.btnCliente_ConsFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente_ConsFatura.Image")));
            this.btnCliente_ConsFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente_ConsFatura.Location = new System.Drawing.Point(3, 37);
            this.btnCliente_ConsFatura.Name = "btnCliente_ConsFatura";
            this.btnCliente_ConsFatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCliente_ConsFatura.Size = new System.Drawing.Size(46, 45);
            this.btnCliente_ConsFatura.TabIndex = 11;
            this.btnCliente_ConsFatura.UseVisualStyleBackColor = true;
            this.btnCliente_ConsFatura.Click += new System.EventHandler(this.btnCliente_ConsFatura_Click);
            // 
            // btnSair_ConsFatura
            // 
            this.btnSair_ConsFatura.FlatAppearance.BorderSize = 0;
            this.btnSair_ConsFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair_ConsFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair_ConsFatura.ForeColor = System.Drawing.Color.White;
            this.btnSair_ConsFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnSair_ConsFatura.Image")));
            this.btnSair_ConsFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair_ConsFatura.Location = new System.Drawing.Point(4, 429);
            this.btnSair_ConsFatura.Name = "btnSair_ConsFatura";
            this.btnSair_ConsFatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair_ConsFatura.Size = new System.Drawing.Size(46, 45);
            this.btnSair_ConsFatura.TabIndex = 9;
            this.btnSair_ConsFatura.UseVisualStyleBackColor = true;
            this.btnSair_ConsFatura.Click += new System.EventHandler(this.btnSair_ConsFatura_Click);
            // 
            // btnRelatorio_ConsFatura
            // 
            this.btnRelatorio_ConsFatura.FlatAppearance.BorderSize = 0;
            this.btnRelatorio_ConsFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio_ConsFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio_ConsFatura.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio_ConsFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio_ConsFatura.Image")));
            this.btnRelatorio_ConsFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio_ConsFatura.Location = new System.Drawing.Point(3, 336);
            this.btnRelatorio_ConsFatura.Name = "btnRelatorio_ConsFatura";
            this.btnRelatorio_ConsFatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRelatorio_ConsFatura.Size = new System.Drawing.Size(46, 45);
            this.btnRelatorio_ConsFatura.TabIndex = 8;
            this.btnRelatorio_ConsFatura.UseVisualStyleBackColor = true;
            this.btnRelatorio_ConsFatura.Click += new System.EventHandler(this.btnRelatorio_ConsFatura_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 152;
            this.label8.Text = "Data de Pagamento:";
            // 
            // datapagamentotexbox
            // 
            this.datapagamentotexbox.Location = new System.Drawing.Point(624, 454);
            this.datapagamentotexbox.Name = "datapagamentotexbox";
            this.datapagamentotexbox.Size = new System.Drawing.Size(73, 20);
            this.datapagamentotexbox.TabIndex = 154;
            // 
            // Consulta_Faturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 486);
            this.Controls.Add(this.datapagamentotexbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtnumerofatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdatavencimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpagamento);
            this.Controls.Add(this.txtnumerodavenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcpfcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnomecliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta_Faturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_Faturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtnomecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtcpfcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtnumerodavenda;
        private System.Windows.Forms.Label txtpagamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtdatavencimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtnumerofatura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarinho;
        private System.Windows.Forms.Button btnTP_ConsFatura;
        private System.Windows.Forms.Button btnServico_ConsFatura;
        private System.Windows.Forms.Button btnProduto_ConsFatura;
        private System.Windows.Forms.Button btnCliente_ConsFatura;
        private System.Windows.Forms.Button btnSair_ConsFatura;
        private System.Windows.Forms.Button btnRelatorio_ConsFatura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox datapagamentotexbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Fatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Carrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
    }
}