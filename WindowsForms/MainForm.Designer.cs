namespace WindowsForms
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSecondForm = new System.Windows.Forms.Button();
            this.btnSecondFormThread = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAboutDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAboutVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menuTxtBox = new System.Windows.Forms.ToolStripTextBox();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(776, 125);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Principal";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSecondForm
            // 
            this.btnSecondForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondForm.Location = new System.Drawing.Point(176, 356);
            this.btnSecondForm.Name = "btnSecondForm";
            this.btnSecondForm.Size = new System.Drawing.Size(208, 72);
            this.btnSecondForm.TabIndex = 1;
            this.btnSecondForm.Text = "Segundo Formulário";
            this.btnSecondForm.UseVisualStyleBackColor = true;
            this.btnSecondForm.Click += new System.EventHandler(this.btnSecondForm_Click);
            // 
            // btnSecondFormThread
            // 
            this.btnSecondFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondFormThread.Location = new System.Drawing.Point(416, 356);
            this.btnSecondFormThread.Name = "btnSecondFormThread";
            this.btnSecondFormThread.Size = new System.Drawing.Size(208, 72);
            this.btnSecondFormThread.TabIndex = 2;
            this.btnSecondFormThread.Text = "Segundo Formulário Thread";
            this.btnSecondFormThread.UseVisualStyleBackColor = true;
            this.btnSecondFormThread.Click += new System.EventHandler(this.btnSecondFormThread_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.menuComboBox,
            this.menuTxtBox});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 27);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator1,
            this.menuFileLeave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(61, 23);
            this.menuFile.Text = "Arquivo";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(180, 22);
            this.menuFileNew.Text = "Novo";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.menuFileOpen.Text = "Abrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuFileLeave
            // 
            this.menuFileLeave.Name = "menuFileLeave";
            this.menuFileLeave.Size = new System.Drawing.Size(180, 22);
            this.menuFileLeave.Text = "Sair";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(50, 23);
            this.menuHelp.Text = "Ajuda";
            // 
            // menuAbout
            // 
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAboutDeveloper,
            this.menuHelpAboutVersion});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(180, 22);
            this.menuAbout.Text = "Sobre";
            // 
            // menuHelpAboutDeveloper
            // 
            this.menuHelpAboutDeveloper.Name = "menuHelpAboutDeveloper";
            this.menuHelpAboutDeveloper.Size = new System.Drawing.Size(180, 22);
            this.menuHelpAboutDeveloper.Text = "Desenvolvedor";
            // 
            // menuHelpAboutVersion
            // 
            this.menuHelpAboutVersion.Name = "menuHelpAboutVersion";
            this.menuHelpAboutVersion.Size = new System.Drawing.Size(180, 22);
            this.menuHelpAboutVersion.Text = "Versão";
            // 
            // menuComboBox
            // 
            this.menuComboBox.Items.AddRange(new object[] {
            "Português",
            "Inglês"});
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.Size = new System.Drawing.Size(121, 23);
            this.menuComboBox.Text = "Idioma";
            // 
            // menuTxtBox
            // 
            this.menuTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuTxtBox.Name = "menuTxtBox";
            this.menuTxtBox.Size = new System.Drawing.Size(100, 23);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSecondFormThread);
            this.Controls.Add(this.btnSecondForm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSecondForm;
        private System.Windows.Forms.Button btnSecondFormThread;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileLeave;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAboutDeveloper;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAboutVersion;
        private System.Windows.Forms.ToolStripComboBox menuComboBox;
        private System.Windows.Forms.ToolStripTextBox menuTxtBox;
    }
}

