using MENU2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOG_IN
{
    public partial class frmLogin : Form
    {
        private frmMenu frmMenu;

        public frmLogin()
        {


            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (frmMenu==null || frmMenu.IsDisposed)
            {
                frmMenu = new frmMenu();
                frmMenu.FormClosing += frmMenu_FormClosing;
            }

            frmMenu f1 = new frmMenu();
            f1.Show();

            f1.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
