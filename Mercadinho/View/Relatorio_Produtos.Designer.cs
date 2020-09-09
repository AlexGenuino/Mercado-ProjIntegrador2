namespace Mercadinho.View
{
    partial class Relatorio_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_Produtos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalvarRP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltarRP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanitdade_estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Agregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 14);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(35, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 123);
            this.panel3.TabIndex = 17;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Relatório de Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Barras,
            this.Nomee,
            this.Preco_Compra,
            this.Preco_Venda,
            this.Quanitdade_estoque,
            this.Valor_Agregado});
            this.dataGridView1.Location = new System.Drawing.Point(175, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 325);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnSalvarRP
            // 
            this.btnSalvarRP.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvarRP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarRP.FlatAppearance.BorderSize = 0;
            this.btnSalvarRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRP.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarRP.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarRP.Image")));
            this.btnSalvarRP.Location = new System.Drawing.Point(108, 368);
            this.btnSalvarRP.Name = "btnSalvarRP";
            this.btnSalvarRP.Size = new System.Drawing.Size(43, 36);
            this.btnSalvarRP.TabIndex = 135;
            this.btnSalvarRP.UseVisualStyleBackColor = false;
            this.btnSalvarRP.Click += new System.EventHandler(this.btnSalvarRP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 137;
            this.label3.Text = "Salvar";
            // 
            // btnVoltarRP
            // 
            this.btnVoltarRP.FlatAppearance.BorderSize = 0;
            this.btnVoltarRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarRP.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarRP.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarRP.Image")));
            this.btnVoltarRP.Location = new System.Drawing.Point(12, 368);
            this.btnVoltarRP.Name = "btnVoltarRP";
            this.btnVoltarRP.Size = new System.Drawing.Size(43, 36);
            this.btnVoltarRP.TabIndex = 138;
            this.btnVoltarRP.UseVisualStyleBackColor = true;
            this.btnVoltarRP.Click += new System.EventHandler(this.btnVoltarRP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Voltar";
            // 
            // Codigo_Barras
            // 
            this.Codigo_Barras.HeaderText = "Código de Barras";
            this.Codigo_Barras.Name = "Codigo_Barras";
            // 
            // Nomee
            // 
            this.Nomee.HeaderText = "Nome";
            this.Nomee.Name = "Nomee";
            // 
            // Preco_Compra
            // 
            this.Preco_Compra.HeaderText = "Preço da Compra";
            this.Preco_Compra.Name = "Preco_Compra";
            // 
            // Preco_Venda
            // 
            this.Preco_Venda.HeaderText = "Preço da Venda";
            this.Preco_Venda.Name = "Preco_Venda";
            // 
            // Quanitdade_estoque
            // 
            this.Quanitdade_estoque.HeaderText = "Quantidade no Estoque";
            this.Quanitdade_estoque.Name = "Quanitdade_estoque";
            // 
            // Valor_Agregado
            // 
            this.Valor_Agregado.HeaderText = "Valor Agregado";
            this.Valor_Agregado.Name = "Valor_Agregado";
            // 
            // Relatorio_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltarRP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvarRP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorio_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio_Produtos";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvarRP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltarRP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanitdade_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Agregado;
    }
}