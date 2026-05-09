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

        private void btnSecondForm_Click(object sender, EventArgs e)
        {
            Hide();

            SecondForm secondForm = new SecondForm();
            secondForm.ShowDialog();

            Show();
        }

        private void btnSecondFormThread_Click(object sender, EventArgs e)
        {
            Close();

            Thread secondFormThread = new Thread(() => Application.Run(new SecondForm()));
            secondFormThread.Start();
        }
    }
}
