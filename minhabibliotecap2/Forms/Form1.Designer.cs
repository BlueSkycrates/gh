namespace minhabibliotecap2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoLivroToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            buscarLivrosToolStripMenuItem = new ToolStripMenuItem();
            deletarLivrosToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            bancoDeDadosToolStripMenuItem = new ToolStripMenuItem();
            impressorasToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            novoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            gerenciadorDeUsuToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 737);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, buscarToolStripMenuItem, configuraçõesToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1240, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoLivroToolStripMenuItem, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoLivroToolStripMenuItem
            // 
            novoLivroToolStripMenuItem.Name = "novoLivroToolStripMenuItem";
            novoLivroToolStripMenuItem.Size = new Size(180, 22);
            novoLivroToolStripMenuItem.Text = "Novo Livro";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarLivrosToolStripMenuItem, deletarLivrosToolStripMenuItem });
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(54, 20);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // buscarLivrosToolStripMenuItem
            // 
            buscarLivrosToolStripMenuItem.Name = "buscarLivrosToolStripMenuItem";
            buscarLivrosToolStripMenuItem.Size = new Size(180, 22);
            buscarLivrosToolStripMenuItem.Text = "Buscar Livros";
            // 
            // deletarLivrosToolStripMenuItem
            // 
            deletarLivrosToolStripMenuItem.Name = "deletarLivrosToolStripMenuItem";
            deletarLivrosToolStripMenuItem.Size = new Size(180, 22);
            deletarLivrosToolStripMenuItem.Text = "Deletar Livros";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bancoDeDadosToolStripMenuItem, impressorasToolStripMenuItem, usuáriosToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            bancoDeDadosToolStripMenuItem.Size = new Size(180, 22);
            bancoDeDadosToolStripMenuItem.Text = "Banco de dados";
            // 
            // impressorasToolStripMenuItem
            // 
            impressorasToolStripMenuItem.Name = "impressorasToolStripMenuItem";
            impressorasToolStripMenuItem.Size = new Size(180, 22);
            impressorasToolStripMenuItem.Text = "Impressoras";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoUsuárioToolStripMenuItem, gerenciadorDeUsuToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(158, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            novoUsuárioToolStripMenuItem.Size = new Size(180, 22);
            novoUsuárioToolStripMenuItem.Text = "Novo usuário";
            // 
            // gerenciadorDeUsuToolStripMenuItem
            // 
            gerenciadorDeUsuToolStripMenuItem.Name = "gerenciadorDeUsuToolStripMenuItem";
            gerenciadorDeUsuToolStripMenuItem.Size = new Size(201, 22);
            gerenciadorDeUsuToolStripMenuItem.Text = "Gerenciador de usuários";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 761);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minha Biblioteca";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoLivroToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem buscarLivrosToolStripMenuItem;
        private ToolStripMenuItem deletarLivrosToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private ToolStripMenuItem impressorasToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private ToolStripMenuItem gerenciadorDeUsuToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}
