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
            this.mainLabel = new System.Windows.Forms.Label();
            this.btnSecondForm = new System.Windows.Forms.Button();
            this.btnSecondFormThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(776, 125);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Principal";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSecondForm
            // 
            this.btnSecondForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondForm.Location = new System.Drawing.Point(19, 356);
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
            this.btnSecondFormThread.Location = new System.Drawing.Point(259, 356);
            this.btnSecondFormThread.Name = "btnSecondFormThread";
            this.btnSecondFormThread.Size = new System.Drawing.Size(208, 72);
            this.btnSecondFormThread.TabIndex = 2;
            this.btnSecondFormThread.Text = "Segundo Formulário Thread";
            this.btnSecondFormThread.UseVisualStyleBackColor = true;
            this.btnSecondFormThread.Click += new System.EventHandler(this.btnSecondFormThread_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSecondFormThread);
            this.Controls.Add(this.btnSecondForm);
            this.Controls.Add(this.mainLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button btnSecondForm;
        private System.Windows.Forms.Button btnSecondFormThread;
    }
}

