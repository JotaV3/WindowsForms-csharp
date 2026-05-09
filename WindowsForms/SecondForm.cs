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
        public string Message { get; private set; }

        public SecondForm()
        {
            InitializeComponent();
        }
        
        public SecondForm(string message)
        {
            InitializeComponent();

            Message = message;
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            txtBoxMessage.Text = Message;
        }

        private void btnMainFormThread_Click(object sender, EventArgs e)
        {
            Close();

            Thread mainFormThread = new Thread(() => Application.Run(new MainForm()));
            mainFormThread.Start();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxMessage.Text))
            {
                Message = null;
            }
            else
            {
                Message = txtBoxMessage.Text;
            }

            Close();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Message = null;

            Close();
        }
    }
}
