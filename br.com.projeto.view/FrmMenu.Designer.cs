namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionarios,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVenda,
            this.menuConfiguracoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.consultaDeClientesToolStripMenuItem});
            this.menuCliente.Image = global::Projeto_Controle_Vendas.Properties.Resources.clientes;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(123, 52);
            this.menuCliente.Text = "Clientes";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // consultaDeClientesToolStripMenuItem
            // 
            this.consultaDeClientesToolStripMenuItem.Name = "consultaDeClientesToolStripMenuItem";
            this.consultaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.consultaDeClientesToolStripMenuItem.Text = "Consulta de Clientes";
            this.consultaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeClientesToolStripMenuItem_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuFuncionarios.Image = global::Projeto_Controle_Vendas.Properties.Resources.funcionarios;
            this.menuFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(154, 52);
            this.menuFuncionarios.Text = "Funcionários";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(259, 26);
            this.toolStripMenuItem2.Text = "Cadastro de Funcionários";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(259, 26);
            this.toolStripMenuItem3.Text = "Consulta de Funcionários";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFornecedoresToolStripMenuItem,
            this.consultaDeFornecedoresToolStripMenuItem});
            this.menuFornecedores.Image = global::Projeto_Controle_Vendas.Properties.Resources.fornecedores;
            this.menuFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(160, 52);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // cadastroDeFornecedoresToolStripMenuItem
            // 
            this.cadastroDeFornecedoresToolStripMenuItem.Name = "cadastroDeFornecedoresToolStripMenuItem";
            this.cadastroDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.cadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro de Fornecedores";
            this.cadastroDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFornecedoresToolStripMenuItem_Click);
            // 
            // consultaDeFornecedoresToolStripMenuItem
            // 
            this.consultaDeFornecedoresToolStripMenuItem.Name = "consultaDeFornecedoresToolStripMenuItem";
            this.consultaDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.consultaDeFornecedoresToolStripMenuItem.Text = "Consulta de Fornecedores";
            this.consultaDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.consultaDeFornecedoresToolStripMenuItem_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroProdutos,
            this.consultaDeProdutosToolStripMenuItem});
            this.menuProdutos.Image = global::Projeto_Controle_Vendas.Properties.Resources.produtos;
            this.menuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(130, 52);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroProdutos
            // 
            this.menuCadastroProdutos.Name = "menuCadastroProdutos";
            this.menuCadastroProdutos.Size = new System.Drawing.Size(235, 26);
            this.menuCadastroProdutos.Text = "Cadastro de Produtos";
            this.menuCadastroProdutos.Click += new System.EventHandler(this.menuCadastroProdutos_Click);
            // 
            // consultaDeProdutosToolStripMenuItem
            // 
            this.consultaDeProdutosToolStripMenuItem.Name = "consultaDeProdutosToolStripMenuItem";
            this.consultaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultaDeProdutosToolStripMenuItem.Text = "Consulta de Produtos";
            this.consultaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProdutosToolStripMenuItem_Click);
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.menuHistorico});
            this.menuVenda.Image = global::Projeto_Controle_Vendas.Properties.Resources.vendas;
            this.menuVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(118, 52);
            this.menuVenda.Text = "Vendas";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // menuHistorico
            // 
            this.menuHistorico.Name = "menuHistorico";
            this.menuHistorico.Size = new System.Drawing.Size(224, 26);
            this.menuHistorico.Text = "Histórico de Vendas";
            this.menuHistorico.Click += new System.EventHandler(this.menuHistorico_Click);
            // 
            // menuConfiguracoes
            // 
            this.menuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarDeUsuárioToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.menuConfiguracoes.Image = global::Projeto_Controle_Vendas.Properties.Resources.configuracoes;
            this.menuConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConfiguracoes.Name = "menuConfiguracoes";
            this.menuConfiguracoes.Size = new System.Drawing.Size(166, 52);
            this.menuConfiguracoes.Text = "Configurações";
            // 
            // trocarDeUsuárioToolStripMenuItem
            // 
            this.trocarDeUsuárioToolStripMenuItem.Name = "trocarDeUsuárioToolStripMenuItem";
            this.trocarDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trocarDeUsuárioToolStripMenuItem.Text = "Trocar de usuário";
            this.trocarDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarDeUsuárioToolStripMenuItem_Click);
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 20);
            this.toolStripStatusLabel1.Text = "Data atual:";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(95, 20);
            this.txtdata.Text = "17/08/2022";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(82, 20);
            this.toolStripStatusLabel3.Text = "Hora atual:";
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabel5.Text = "Usuário logado:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(112, 20);
            this.txtusuario.Text = "Caio Malheiros";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Controle_Vendas.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "Menu Principal - Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProdutos;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtdata;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txthora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuHistorico;
        public System.Windows.Forms.ToolStripStatusLabel txtusuario;
        private System.Windows.Forms.Timer timer1;
    }
}