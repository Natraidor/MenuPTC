using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            DiseñoPropio();
        }


        private void DiseñoPropio()
        {
            panelAdministracion.Visible = false;
            panelAdministracion2.Visible = false;
            panelAdministracion3.Visible= false;
        }

        private void ocultarPanel()
        {
            if (panelAdministracion.Visible == true)
            {
                panelAdministracion.Visible =false;
            }

            if (panelAdministracion2.Visible == true)
            {
                panelAdministracion2.Visible=false;
            }

            if (panelAdministracion3.Visible==true)
            {
                panelAdministracion3.Visible =false;
            }
        }

        private void mostrarMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarPanel();
                subMenu.Visible = true;
            }

            else
            {
                subMenu.Visible = false;
            }

        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            mostrarMenu(panelAdministracion2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            mostrarMenu(panelAdministracion);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            // el primero es aqui//
            abrirPanelContenedor(new frmEmpleados());
            ocultarPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultarPanel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ocultarPanel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            ocultarPanel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            abrirPanelContenedor(new frmFacturas());
            ocultarPanel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ocultarPanel();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ocultarPanel();
        }

        private void btnAdministracion3_Click(object sender, EventArgs e)
        {
            mostrarMenu(panelAdministracion3);
        }


        private Form activeForm = null;


        private void abrirPanelContenedor(Form contenedor)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = contenedor;
            contenedor.TopLevel = false;
            contenedor.FormBorderStyle = FormBorderStyle.None;
            contenedor.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(contenedor);
            panelContenedor.Tag = contenedor;
            contenedor.BringToFront();
            contenedor.Show();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            abrirPanelContenedor(new frmProductos());
            ocultarPanel();
        }

        private void btnAgregarProveedor(object sender, EventArgs e)
        {

            abrirPanelContenedor(new frmProveedores());
            ocultarPanel();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason== CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
