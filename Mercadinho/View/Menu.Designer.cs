namespace Mercadinho
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCadastarcliente = new System.Windows.Forms.Button();
            this.btnCadastrarproduto = new System.Windows.Forms.Button();
            this.btnCadastrarservico = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btncadastrartipo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarinho = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastarcliente
            // 
            this.btnCadastarcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnCadastarcliente.FlatAppearance.BorderSize = 0;
            this.btnCadastarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastarcliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastarcliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastarcliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastarcliente.Image")));
            this.btnCadastarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastarcliente.Location = new System.Drawing.Point(5, 33);
            this.btnCadastarcliente.Name = "btnCadastarcliente";
            this.btnCadastarcliente.Size = new System.Drawing.Size(161, 45);
            this.btnCadastarcliente.TabIndex = 0;
            this.btnCadastarcliente.Text = "Cliente";
            this.btnCadastarcliente.UseVisualStyleBackColor = true;
            this.btnCadastarcliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCadastrarproduto
            // 
            this.btnCadastrarproduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnCadastrarproduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarproduto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarproduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarproduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarproduto.Image")));
            this.btnCadastrarproduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarproduto.Location = new System.Drawing.Point(2, 84);
            this.btnCadastrarproduto.Name = "btnCadastrarproduto";
            this.btnCadastrarproduto.Size = new System.Drawing.Size(161, 45);
            this.btnCadastrarproduto.TabIndex = 1;
            this.btnCadastrarproduto.Text = "Produto";
            this.btnCadastrarproduto.UseVisualStyleBackColor = false;
            this.btnCadastrarproduto.Click += new System.EventHandler(this.btnCadastrarproduto_Click);
            // 
            // btnCadastrarservico
            // 
            this.btnCadastrarservico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnCadastrarservico.FlatAppearance.BorderSize = 0;
            this.btnCadastrarservico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarservico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarservico.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarservico.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarservico.Image")));
            this.btnCadastrarservico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarservico.Location = new System.Drawing.Point(5, 135);
            this.btnCadastrarservico.Name = "btnCadastrarservico";
            this.btnCadastrarservico.Size = new System.Drawing.Size(161, 45);
            this.btnCadastrarservico.TabIndex = 2;
            this.btnCadastrarservico.Text = "Serviços";
            this.btnCadastrarservico.UseVisualStyleBackColor = true;
            this.btnCadastrarservico.Click += new System.EventHandler(this.btnCadastrarservico_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 313);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(161, 45);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btncadastrartipo
            // 
            this.btncadastrartipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btncadastrartipo.FlatAppearance.BorderSize = 0;
            this.btncadastrartipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrartipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrartipo.ForeColor = System.Drawing.Color.White;
            this.btncadastrartipo.Image = ((System.Drawing.Image)(resources.GetObject("btncadastrartipo.Image")));
            this.btncadastrartipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastrartipo.Location = new System.Drawing.Point(4, 189);
            this.btncadastrartipo.Name = "btncadastrartipo";
            this.btncadastrartipo.Size = new System.Drawing.Size(161, 45);
            this.btncadastrartipo.TabIndex = 4;
            this.btncadastrartipo.Text = "Tipo de Produto";
            this.btncadastrartipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncadastrartipo.UseVisualStyleBackColor = true;
            this.btncadastrartipo.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 14);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 438);
            this.panel1.TabIndex = 55;
            // 
            // btnCarinho
            // 
            this.btnCarinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnCarinho.FlatAppearance.BorderSize = 0;
            this.btnCarinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarinho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarinho.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCarinho.Image = ((System.Drawing.Image)(resources.GetObject("btnCarinho.Image")));
            this.btnCarinho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarinho.Location = new System.Drawing.Point(4, 240);
            this.btnCarinho.Name = "btnCarinho";
            this.btnCarinho.Size = new System.Drawing.Size(161, 45);
            this.btnCarinho.TabIndex = 59;
            this.btnCarinho.Text = "Carrinho";
            this.btnCarinho.UseVisualStyleBackColor = false;
            this.btnCarinho.Click += new System.EventHandler(this.btnCarinho_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(2, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(164, 45);
            this.btnSair.TabIndex = 60;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(225, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 123);
            this.panel3.TabIndex = 61;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 76);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 437);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCarinho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncadastrartipo);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnCadastrarservico);
            this.Controls.Add(this.btnCadastrarproduto);
            this.Controls.Add(this.btnCadastarcliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btcadastrarcliente;
        private System.Windows.Forms.Button btcadastrarproduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadastarcliente;
        public System.Windows.Forms.Button btncadastrartipo;
        public System.Windows.Forms.Button btnCadastrarproduto;
        public System.Windows.Forms.Button btnCadastrarservico;
        public System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarinho;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
    }
}

