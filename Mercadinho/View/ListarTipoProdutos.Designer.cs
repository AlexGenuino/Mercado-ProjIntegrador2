namespace Mercadinho.View
{
    partial class ListarTipoProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarTipoProdutos));
            this.dataGridViewtipoproduto = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarRC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipoproduto)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewtipoproduto
            // 
            this.dataGridViewtipoproduto.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewtipoproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtipoproduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.NomeTipo});
            this.dataGridViewtipoproduto.Location = new System.Drawing.Point(184, 134);
            this.dataGridViewtipoproduto.Name = "dataGridViewtipoproduto";
            this.dataGridViewtipoproduto.Size = new System.Drawing.Size(278, 194);
            this.dataGridViewtipoproduto.TabIndex = 69;
            this.dataGridViewtipoproduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtipoproduto_CellClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 31);
            this.label2.TabIndex = 70;
            this.label2.Text = "Lista Tipo de Produtos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 14);
            this.panel2.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(35, 1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 137;
            this.label1.Text = "Voltar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVoltarRC
            // 
            this.btnVoltarRC.FlatAppearance.BorderSize = 0;
            this.btnVoltarRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarRC.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarRC.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarRC.Image")));
            this.btnVoltarRC.Location = new System.Drawing.Point(12, 281);
            this.btnVoltarRC.Name = "btnVoltarRC";
            this.btnVoltarRC.Size = new System.Drawing.Size(43, 36);
            this.btnVoltarRC.TabIndex = 136;
            this.btnVoltarRC.UseVisualStyleBackColor = true;
            this.btnVoltarRC.Click += new System.EventHandler(this.btnVoltarRC_Click);
            // 
            // ListarTipoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltarRC);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewtipoproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarTipoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Tipos";
            this.Load += new System.EventHandler(this.ListarTipoProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtipoproduto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewtipoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarRC;
    }
}