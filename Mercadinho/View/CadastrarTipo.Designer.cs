namespace Mercadinho.View
{
    partial class CadastrarTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarTipo));
            this.label11 = new System.Windows.Forms.Label();
            this.ftftipo = new System.Windows.Forms.TextBox();
            this.bttipoproduto = new System.Windows.Forms.Button();
            this.AlterarTipoProduto = new System.Windows.Forms.Button();
            this.ExcluirTipoProduto = new System.Windows.Forms.Button();
            this.dataGridViewtipoproduto = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelidTipo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarinho = new System.Windows.Forms.Button();
            this.btnRelatorio_TP = new System.Windows.Forms.Button();
            this.btnTipo_TP = new System.Windows.Forms.Button();
            this.btnServ_TP = new System.Windows.Forms.Button();
            this.btnProduto_TP = new System.Windows.Forms.Button();
            this.btnCad_TP = new System.Windows.Forms.Button();
            this.btnSair_TP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipoproduto)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 32);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tipo Produto";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // ftftipo
            // 
            this.ftftipo.BackColor = System.Drawing.Color.White;
            this.ftftipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftftipo.ForeColor = System.Drawing.Color.Black;
            this.ftftipo.Location = new System.Drawing.Point(187, 142);
            this.ftftipo.Name = "ftftipo";
            this.ftftipo.Size = new System.Drawing.Size(157, 26);
            this.ftftipo.TabIndex = 24;
            this.ftftipo.Text = "Cadastrar";
            this.ftftipo.Click += new System.EventHandler(this.ftftipo_Click);
            // 
            // bttipoproduto
            // 
            this.bttipoproduto.FlatAppearance.BorderSize = 0;
            this.bttipoproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttipoproduto.Image = ((System.Drawing.Image)(resources.GetObject("bttipoproduto.Image")));
            this.bttipoproduto.Location = new System.Drawing.Point(381, 342);
            this.bttipoproduto.Name = "bttipoproduto";
            this.bttipoproduto.Size = new System.Drawing.Size(35, 28);
            this.bttipoproduto.TabIndex = 25;
            this.bttipoproduto.UseVisualStyleBackColor = false;
            this.bttipoproduto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AlterarTipoProduto
            // 
            this.AlterarTipoProduto.FlatAppearance.BorderSize = 0;
            this.AlterarTipoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlterarTipoProduto.Image = ((System.Drawing.Image)(resources.GetObject("AlterarTipoProduto.Image")));
            this.AlterarTipoProduto.Location = new System.Drawing.Point(424, 342);
            this.AlterarTipoProduto.Name = "AlterarTipoProduto";
            this.AlterarTipoProduto.Size = new System.Drawing.Size(35, 28);
            this.AlterarTipoProduto.TabIndex = 27;
            this.AlterarTipoProduto.UseVisualStyleBackColor = false;
            this.AlterarTipoProduto.Click += new System.EventHandler(this.AlterarTipoProduto_Click);
            // 
            // ExcluirTipoProduto
            // 
            this.ExcluirTipoProduto.FlatAppearance.BorderSize = 0;
            this.ExcluirTipoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirTipoProduto.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirTipoProduto.Image")));
            this.ExcluirTipoProduto.Location = new System.Drawing.Point(463, 342);
            this.ExcluirTipoProduto.Name = "ExcluirTipoProduto";
            this.ExcluirTipoProduto.Size = new System.Drawing.Size(35, 28);
            this.ExcluirTipoProduto.TabIndex = 28;
            this.ExcluirTipoProduto.UseVisualStyleBackColor = false;
            this.ExcluirTipoProduto.Click += new System.EventHandler(this.ExcluirTipoProduto_Click);
            // 
            // dataGridViewtipoproduto
            // 
            this.dataGridViewtipoproduto.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewtipoproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtipoproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.NomeTipo});
            this.dataGridViewtipoproduto.Location = new System.Drawing.Point(71, 174);
            this.dataGridViewtipoproduto.Name = "dataGridViewtipoproduto";
            this.dataGridViewtipoproduto.Size = new System.Drawing.Size(296, 196);
            this.dataGridViewtipoproduto.TabIndex = 68;
            this.dataGridViewtipoproduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtipoproduto_CellClick);
            this.dataGridViewtipoproduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtipoproduto_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "IdTipo";
            this.Nome.Name = "Nome";
            // 
            // NomeTipo
            // 
            this.NomeTipo.HeaderText = "Nome";
            this.NomeTipo.MaxInputLength = 33000;
            this.NomeTipo.Name = "NomeTipo";
            this.NomeTipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LabelidTipo
            // 
            this.LabelidTipo.AutoSize = true;
            this.LabelidTipo.Location = new System.Drawing.Point(36, 56);
            this.LabelidTipo.Name = "LabelidTipo";
            this.LabelidTipo.Size = new System.Drawing.Size(0, 13);
            this.LabelidTipo.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 15);
            this.panel2.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(100, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 123);
            this.panel3.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel1.Controls.Add(this.btnRelatorio_TP);
            this.panel1.Controls.Add(this.btnTipo_TP);
            this.panel1.Controls.Add(this.btnServ_TP);
            this.panel1.Controls.Add(this.btnProduto_TP);
            this.panel1.Controls.Add(this.btnCad_TP);
            this.panel1.Controls.Add(this.btnSair_TP);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 394);
            this.panel1.TabIndex = 72;
            // 
            // btnCarinho
            // 
            this.btnCarinho.FlatAppearance.BorderSize = 0;
            this.btnCarinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarinho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarinho.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCarinho.Image = ((System.Drawing.Image)(resources.GetObject("btnCarinho.Image")));
            this.btnCarinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarinho.Location = new System.Drawing.Point(3, 197);
            this.btnCarinho.Name = "btnCarinho";
            this.btnCarinho.Size = new System.Drawing.Size(46, 45);
            this.btnCarinho.TabIndex = 61;
            this.btnCarinho.UseVisualStyleBackColor = true;
            this.btnCarinho.Click += new System.EventHandler(this.btnCarinho_Click);
            // 
            // btnRelatorio_TP
            // 
            this.btnRelatorio_TP.FlatAppearance.BorderSize = 0;
            this.btnRelatorio_TP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio_TP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio_TP.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio_TP.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio_TP.Image")));
            this.btnRelatorio_TP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio_TP.Location = new System.Drawing.Point(4, 253);
            this.btnRelatorio_TP.Name = "btnRelatorio_TP";
            this.btnRelatorio_TP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRelatorio_TP.Size = new System.Drawing.Size(46, 45);
            this.btnRelatorio_TP.TabIndex = 60;
            this.btnRelatorio_TP.UseVisualStyleBackColor = true;
            this.btnRelatorio_TP.Click += new System.EventHandler(this.btnRelatorio_TP_Click);
            // 
            // btnTipo_TP
            // 
            this.btnTipo_TP.FlatAppearance.BorderSize = 0;
            this.btnTipo_TP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipo_TP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipo_TP.ForeColor = System.Drawing.Color.White;
            this.btnTipo_TP.Image = ((System.Drawing.Image)(resources.GetObject("btnTipo_TP.Image")));
            this.btnTipo_TP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipo_TP.Location = new System.Drawing.Point(3, 152);
            this.btnTipo_TP.Name = "btnTipo_TP";
            this.btnTipo_TP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTipo_TP.Size = new System.Drawing.Size(46, 45);
            this.btnTipo_TP.TabIndex = 15;
            this.btnTipo_TP.UseVisualStyleBackColor = true;
            this.btnTipo_TP.Click += new System.EventHandler(this.btnTipo_TP_Click);
            // 
            // btnServ_TP
            // 
            this.btnServ_TP.FlatAppearance.BorderSize = 0;
            this.btnServ_TP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServ_TP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServ_TP.ForeColor = System.Drawing.Color.White;
            this.btnServ_TP.Image = ((System.Drawing.Image)(resources.GetObject("btnServ_TP.Image")));
            this.btnServ_TP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServ_TP.Location = new System.Drawing.Point(3, 108);
            this.btnServ_TP.Name = "btnServ_TP";
            this.btnServ_TP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServ_TP.Size = new System.Drawing.Size(46, 45);
            this.btnServ_TP.TabIndex = 14;
            this.btnServ_TP.UseVisualStyleBackColor = true;
            this.btnServ_TP.Click += new System.EventHandler(this.btnServ_TP_Click);
            // 
            // btnProduto_TP
            // 
            this.btnProduto_TP.FlatAppearance.BorderSize = 0;
            this.btnProduto_TP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto_TP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto_TP.ForeColor = System.Drawing.Color.White;
            this.btnProduto_TP.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto_TP.Image")));
            this.btnProduto_TP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduto_TP.Location = new System.Drawing.Point(3, 58);
            this.btnProduto_TP.Name = "btnProduto_TP";
            this.btnProduto_TP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProduto_TP.Size = new System.Drawing.Size(46, 45);
            this.btnProduto_TP.TabIndex = 13;
            this.btnProduto_TP.UseVisualStyleBackColor = true;
            this.btnProduto_TP.Click += new System.EventHandler(this.btnProduto_TP_Click);
            // 
            // btnCad_TP
            // 
            this.btnCad_TP.FlatAppearance.BorderSize = 0;
            this.btnCad_TP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad_TP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad_TP.ForeColor = System.Drawing.Color.White;
            this.btnCad_TP.Image = ((System.Drawing.Image)(resources.GetObject("btnCad_TP.Image")));
            this.btnCad_TP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCad_TP.Location = new System.Drawing.Point(3, 12);
            this.btnCad_TP.Name = "btnCad_TP";
            this.btnCad_TP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCad_TP.Size = new System.Drawing.Size(46, 45);
            this.btnCad_TP.TabIndex = 12;
            this.btnCad_TP.UseVisualStyleBackColor = true;
            this.btnCad_TP.Click += new System.EventHandler(this.btnCad_TP_Click);
            // 
            // btnSair_TP
            // 
            this.btnSair_TP.FlatAppearance.BorderSize = 0;
            this.btnSair_TP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair_TP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair_TP.ForeColor = System.Drawing.Color.White;
            this.btnSair_TP.Image = ((System.Drawing.Image)(resources.GetObject("btnSair_TP.Image")));
            this.btnSair_TP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair_TP.Location = new System.Drawing.Point(5, 336);
            this.btnSair_TP.Name = "btnSair_TP";
            this.btnSair_TP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair_TP.Size = new System.Drawing.Size(46, 45);
            this.btnSair_TP.TabIndex = 9;
            this.btnSair_TP.UseVisualStyleBackColor = true;
            this.btnSair_TP.Click += new System.EventHandler(this.btnSair_TP_Click);
            // 
            // CadastrarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LabelidTipo);
            this.Controls.Add(this.dataGridViewtipoproduto);
            this.Controls.Add(this.ExcluirTipoProduto);
            this.Controls.Add(this.AlterarTipoProduto);
            this.Controls.Add(this.bttipoproduto);
            this.Controls.Add(this.ftftipo);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarTipo";
            this.Load += new System.EventHandler(this.CadastrarTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipoproduto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ftftipo;
        private System.Windows.Forms.Button bttipoproduto;
        private System.Windows.Forms.Button AlterarTipoProduto;
        private System.Windows.Forms.Button ExcluirTipoProduto;
        private System.Windows.Forms.DataGridView dataGridViewtipoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTipo;
        private System.Windows.Forms.Label LabelidTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarinho;
        private System.Windows.Forms.Button btnRelatorio_TP;
        private System.Windows.Forms.Button btnTipo_TP;
        private System.Windows.Forms.Button btnServ_TP;
        private System.Windows.Forms.Button btnProduto_TP;
        private System.Windows.Forms.Button btnCad_TP;
        private System.Windows.Forms.Button btnSair_TP;
    }
}