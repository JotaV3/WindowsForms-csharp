using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void btnMainFormThread_Click(object sender, EventArgs e)
        {
            Close();

            Thread mainFormThread = new Thread(() => Application.Run(new MainForm()));
            mainFormThread.Start();
        }
    }
}
