namespace Mercadinho.View
{
    partial class ListarServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarServico));
            this.dataGridView1servicos = new System.Windows.Forms.DataGridView();
            this.PrecoServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarRC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1servicos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1servicos
            // 
            this.dataGridView1servicos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1servicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrecoServ,
            this.Descricao,
            this.Id_Servico});
            this.dataGridView1servicos.Location = new System.Drawing.Point(184, 134);
            this.dataGridView1servicos.Name = "dataGridView1servicos";
            this.dataGridView1servicos.Size = new System.Drawing.Size(278, 194);
            this.dataGridView1servicos.TabIndex = 0;
            this.dataGridView1servicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1servicos_CellClick);
            // 
            // PrecoServ
            // 
            this.PrecoServ.HeaderText = "Preço";
            this.PrecoServ.Name = "PrecoServ";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição do Serviço";
            this.Descricao.Name = "Descricao";
            // 
            // Id_Servico
            // 
            this.Id_Servico.HeaderText = "Id_Servico";
            this.Id_Servico.Name = "Id_Servico";
            this.Id_Servico.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 14);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(35, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 123);
            this.panel3.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista de Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 314);
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
            this.btnVoltarRC.Location = new System.Drawing.Point(23, 279);
            this.btnVoltarRC.Name = "btnVoltarRC";
            this.btnVoltarRC.Size = new System.Drawing.Size(43, 36);
            this.btnVoltarRC.TabIndex = 136;
            this.btnVoltarRC.UseVisualStyleBackColor = true;
            this.btnVoltarRC.Click += new System.EventHandler(this.btnVoltarRC_Click);
            // 
            // ListarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltarRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1servicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarServico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1servicos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1servicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Servico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarRC;
    }
}