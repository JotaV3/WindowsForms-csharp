using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeMenuText
            (
                // menu file
                string txtFile, string txtNew, string txtOpen, string txtLeave,
                // menu help
                string txtHelp, string txtHelpAbout, string txtHelpAboutDeveloper, string txtHelpAboutVersion,
                // menu combo box language
                string txtLanguage
            )
        {
            #region menu file
            menuFile.Text = txtFile;
            menuFileNew.Text = txtNew;
            menuFileOpen.Text = txtOpen;
            menuFileLeave.Text = txtLeave;
            #endregion

            #region menu help
            menuHelp.Text = txtHelp;
            menuHelpAbout.Text = txtHelpAbout;
            menuHelpAboutDeveloper.Text = txtHelpAboutDeveloper;
            menuHelpAboutVersion.Text = txtHelpAboutVersion;
            #endregion

            menuComboBoxLanguage.Text = txtLanguage;
        }

        #region buttons
        private void btnSecondForm_Click(object sender, EventArgs e)
        {
            Hide();

            SecondForm secondForm = new SecondForm("Olá, Mundo!");
            secondForm.ShowDialog();

            if (secondForm.Message != null)
            {
                lblTitle.Text = secondForm.Message;
            }

            Show();
        }

        private void btnSecondFormThread_Click(object sender, EventArgs e)
        {
            Close();

            Thread secondFormThread = new Thread(() => Application.Run(new SecondForm()));
            secondFormThread.Start();
        }
        #endregion

        #region menu actions
        private void menuComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string INGLES = "Inglês";
            const string PORTUGUES = "Português";

            switch (menuComboBoxLanguage.SelectedItem.ToString())
            {
                case INGLES:

                    ChangeMenuText
                        (
                            // menu file
                            "File", "New", "Open", "Leave", 
                            // menu help
                            "Help", "About", "Developer", "Version",
                            // menu combo box language
                            "Language"
                        );   

                    btnSecondForm.Text = "Second Form";
                    btnSecondFormThread.Text = "Second Form Thread";

                    break;

                case PORTUGUES:
                    ChangeMenuText
                        (
                            // menu file
                            "Arquivo", "Novo", "Abrir", "Sair",
                            // menu help
                            "Ajuda", "Sobre", "Desenvolvedor", "Versão",
                            // menu combo box language
                            "Idioma"
                        );

                    btnSecondForm.Text = "Segundo Formulário";
                    btnSecondFormThread.Text = "Segundo Formulário Thread";

                    break;

                default:
                    goto case PORTUGUES;
            }
        }

        private void menuHelpAboutVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0.0");
        }

        private void menuHelpAboutDeveloper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("João Victor Matos de Oliveira");
        }

        private void menuTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                lblTitle.Text = menuTxtBox.Text;
                menuTxtBox.Text = string.Empty;
            }
        }

        private void menuFileLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            Hide();

            SecondForm secondForm = new SecondForm();
            secondForm.ShowDialog();

            Show();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            Close();

            Thread mainFormThread = new Thread(() => Application.Run(new MainForm()));
            mainFormThread.Start();
        }
        #endregion
    }
}
