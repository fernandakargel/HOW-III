
namespace pagina_inicio
{
    partial class pag_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pag_inicio));
            this.btn_cad = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menu_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadcleinte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cadprod = new System.Windows.Forms.Button();
            this.btn_conscliente = new System.Windows.Forms.Button();
            this.btn_consestq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cad
            // 
            this.btn_cad.AllowDrop = true;
            this.btn_cad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad.Image = ((System.Drawing.Image)(resources.GetObject("btn_cad.Image")));
            this.btn_cad.Location = new System.Drawing.Point(34, 68);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(208, 219);
            this.btn_cad.TabIndex = 0;
            this.btn_cad.Text = "CADASTRAR NOVO CLIENTE";
            this.btn_cad.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_novo,
            this.consultarToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(838, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menu_novo
            // 
            this.menu_novo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadcleinte,
            this.toolStripMenuItem4});
            this.menu_novo.Name = "menu_novo";
            this.menu_novo.Size = new System.Drawing.Size(48, 20);
            this.menu_novo.Text = "Novo";
            this.menu_novo.Click += new System.EventHandler(this.menu_novo_Click);
            // 
            // menu_cadcleinte
            // 
            this.menu_cadcleinte.Name = "menu_cadcleinte";
            this.menu_cadcleinte.Size = new System.Drawing.Size(170, 22);
            this.menu_cadcleinte.Text = "Cadastrar Cliente";
            this.menu_cadcleinte.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem4.Text = "Cadastrar Produto";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem5.Text = "Consultar Clientes";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem6.Text = "Consultar Estoque";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem2.Text = "Sair";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btn_cadprod
            // 
            this.btn_cadprod.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadprod.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadprod.Image")));
            this.btn_cadprod.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadprod.Location = new System.Drawing.Point(263, 68);
            this.btn_cadprod.Name = "btn_cadprod";
            this.btn_cadprod.Size = new System.Drawing.Size(215, 219);
            this.btn_cadprod.TabIndex = 2;
            this.btn_cadprod.Text = "CADASTRAR NOVO PRODUTO";
            this.btn_cadprod.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cadprod.UseVisualStyleBackColor = true;
            this.btn_cadprod.Click += new System.EventHandler(this.btn_cadprod_Click);
            // 
            // btn_conscliente
            // 
            this.btn_conscliente.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conscliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_conscliente.Image")));
            this.btn_conscliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_conscliente.Location = new System.Drawing.Point(34, 305);
            this.btn_conscliente.Name = "btn_conscliente";
            this.btn_conscliente.Size = new System.Drawing.Size(208, 217);
            this.btn_conscliente.TabIndex = 3;
            this.btn_conscliente.Text = "LISTA DE CLIENTES";
            this.btn_conscliente.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_conscliente.UseVisualStyleBackColor = true;
            this.btn_conscliente.Click += new System.EventHandler(this.btn_conscliente_Click);
            // 
            // btn_consestq
            // 
            this.btn_consestq.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consestq.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_consestq.Image = ((System.Drawing.Image)(resources.GetObject("btn_consestq.Image")));
            this.btn_consestq.Location = new System.Drawing.Point(263, 305);
            this.btn_consestq.Name = "btn_consestq";
            this.btn_consestq.Size = new System.Drawing.Size(215, 217);
            this.btn_consestq.TabIndex = 4;
            this.btn_consestq.Text = "CONSULTAR ESTOQUE";
            this.btn_consestq.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_consestq.UseVisualStyleBackColor = true;
            this.btn_consestq.Click += new System.EventHandler(this.btn_consestq_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "PROJETO INTEGRADOR ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "HANDS ON WORK III";
            // 
            // pag_inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consestq);
            this.Controls.Add(this.btn_conscliente);
            this.Controls.Add(this.btn_cadprod);
            this.Controls.Add(this.btn_cad);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.Name = "pag_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOJA HOW3";
            this.TransparencyKey = System.Drawing.SystemColors.WindowFrame;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pag_inicio_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_cliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menu_novo;
        private System.Windows.Forms.ToolStripMenuItem menu_cadcleinte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btn_cadprod;
        private System.Windows.Forms.Button btn_conscliente;
        private System.Windows.Forms.Button btn_consestq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

