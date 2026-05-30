using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalleresGuate
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturaciones_Click(object sender, EventArgs e)
        {
            // Instancia del formulario
            FacturacionesForm frmFacturaciones = new FacturacionesForm();

            // Mostrar el formulario
            frmFacturaciones.ShowDialog();
        }

        private void btnTipoServicio_Click(object sender, EventArgs e)
        {
            // Instancia del formulario
            TipoServiciosForm frmServicios = new TipoServiciosForm();

            // Mostrar el formulario
            frmServicios.ShowDialog();
        }

        private void btnDetalleFactura_Click(object sender, EventArgs e)
        {
            // Instancia del formulario
            DetalleFacturasForm frmDetalleFacturas = new DetalleFacturasForm();

            // Mostrar el formulario
            frmDetalleFacturas.ShowDialog();
        }

        private void btnPlanillas_Click(object sender, EventArgs e)
        {
            // Instancia del formulario
            PlanillasForm frmPlanillas = new PlanillasForm();
            frmPlanillas.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
