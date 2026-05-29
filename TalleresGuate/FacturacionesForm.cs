using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalleresGuate
{
    public partial class FacturacionesForm : Form
    {
        //Instancia
        ConexionDatos connDatos = new ConexionDatos();

        public FacturacionesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FacturacionesForm_Load(object sender, EventArgs e)
        {
            MtdCrudConsultar();
            MtdCargarClientes();
            MtdCargarVehiculos();

            // Controla el data grid view
            dgvFacturaciones.Enabled = false;
            dgvFacturaciones.ReadOnly = true;
            dgvFacturaciones.SelectionMode = dgvFacturaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturaciones.MultiSelect = false;
            dgvFacturaciones.AllowUserToAddRows = false;
            dgvFacturaciones.ClearSelection();

            // Bloquear campos al iniciar la pantalla
            txtNombreFactura.Enabled = false;
            cboxCodigoCliente.Enabled = false;
            cboxCodigoVehículo.Enabled = false;
            dtpFechaFactura.Enabled = false; 
            cboxTipoPago.Enabled = false;
            txtObservaciones.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        // CRUD Consultar
        public void MtdCrudConsultar()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                string QueryConsultar = @"
                                            SELECT *
                                            FROM TBL_Facturaciones
                                            ORDER BY CodigoFactura ASC;
                                        ";

                SqlDataAdapter adaptador = new SqlDataAdapter(QueryConsultar, conn);

                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                dgvFacturaciones.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvFacturaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // CRUD Agregar
        public void MtdCrudAgregar()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                conn.Open();

                string QueryAgregar = @"
                                            INSERT INTO TBL_Facturaciones
                                            (CodigoCliente, CodigoVehiculo, FechaFactura, SubTotal, Descuento, Impuesto, TotalPagar, TipoPago, Observaciones, Estado, UsuarioSistema, FechaSistema, HoraSistema)
                                            VALUES 
                                            (@CodigoCliente, @CodigoVehiculo, @FechaFactura, @SubTotal, @Descuento, @Impuesto, @TotalPagar, @TipoPago, @Observaciones, @Estado, @UsuarioSistema, @FechaSistema, @HoraSistema);
                                            ";

                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);

                // Reemplaza estas dos líneas dentro de tu SqlCommand en MtdCrudAgregar:
                cmd.Parameters.AddWithValue("@CodigoCliente", cboxCodigoCliente.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoVehiculo", cboxCodigoVehículo.SelectedValue ?? DBNull.Value); 
                cmd.Parameters.AddWithValue("@FechaFactura", DateTime.Now);
                cmd.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(txtSubtotal.Text));
                cmd.Parameters.AddWithValue("@Descuento", Convert.ToDecimal(txtDescuento.Text));
                cmd.Parameters.AddWithValue("@Impuesto", Convert.ToDecimal(txtImpuesto.Text));
                cmd.Parameters.AddWithValue("@TotalPagar", Convert.ToDecimal(txtTotalAPagar.Text));
                cmd.Parameters.AddWithValue("@TipoPago", cboxTipoPago.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);

                if (rdbActivo.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Estado", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Estado", false);
                }

                cmd.Parameters.AddWithValue("@UsuarioSistema", "Milagros Arriaga");
                cmd.Parameters.AddWithValue("@FechaSistema", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@HoraSistema", DateTime.Now.TimeOfDay);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Factura agregada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MtdCrudConsultar();

                // Bloquear campos al iniciar la pantalla
                txtNombreFactura.Enabled = false;
                cboxCodigoCliente.Enabled = false;
                cboxCodigoVehículo.Enabled = false;
                dtpFechaFactura.Enabled = false;
                cboxTipoPago.Enabled = false;
                txtObservaciones.Enabled = false;
                rdbActivo.Enabled = false;
                rdbInactivo.Enabled = false;

                btnNuevo.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                MtdLimpiaCampos();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
                conn.Close();
            }
        }

        // Método para cargar los clientes en su ComboBox
        private void MtdCargarClientes()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                // Traemos el ID y una columna descriptiva (por ejemplo, el Nombre Completo)
                // Ojo: Asegúrate de que el nombre de la columna coincida con tu TBL_Clientes (ej. NombreCliente)
                string Query = "SELECT CodigoCliente, NombreCliente FROM TBL_Clientes WHERE Estado = 1 ORDER BY NombreCliente ASC;";

                SqlDataAdapter da = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboxCodigoCliente.DataSource = dt;
                cboxCodigoCliente.DisplayMember = "NombreCliente";  // Lo que el usuario va a VER en la lista
                cboxCodigoCliente.ValueMember = "CodigoCliente";    // El ID real (el INT) que se guardará

                // Dejarlo inicialmente vacío para que no autoseleccione el primero
                cboxCodigoCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar los vehículos en su ComboBox
        private void MtdCargarVehiculos()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                // Traemos el ID y una columna descriptiva (por ejemplo, la Placa del carro)
                string Query = "SELECT CodigoVehiculo, Placa FROM TBL_Vehiculos WHERE Estado = 1;";

                SqlDataAdapter da = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboxCodigoVehículo.DataSource = dt;
                cboxCodigoVehículo.DisplayMember = "Placa";          // Lo que el usuario va a VER
                cboxCodigoVehículo.ValueMember = "CodigoVehiculo";    // El ID real (el INT) que se guardará

                cboxCodigoVehículo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular el Descuento 
        private decimal MtdCalcularDescuento(decimal subtotal)
        {
            if (subtotal > 0 && subtotal <= 1000.00m)
            {
                return subtotal * 0.10m; 
            }
            else if (subtotal > 1000.00m && subtotal <= 2000.00m)
            {
                return subtotal * 0.15m; 
            }
            else if (subtotal > 2000.00m)
            {
                return subtotal * 0.20m; 
            }
            else
            {
                return 0; 
            }
        }

        // Método para calcular el Impuesto 
        private decimal MtdCalcularImpuesto(decimal subtotal, decimal descuento)
        {
            return (subtotal - descuento) * 0.12m;
        }

        // Método para calcular el Total a Pagar
        private decimal MtdCalcularTotalPagar(decimal subtotal, decimal descuento, decimal impuesto)
        {
            return subtotal - descuento + impuesto;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Bloquear campos al iniciar la pantalla
            txtNombreFactura.Enabled = true;
            cboxCodigoCliente.Enabled = true;
            cboxCodigoVehículo.Enabled = true;
            dtpFechaFactura.Enabled = true;
            cboxTipoPago.Enabled = true;
            txtObservaciones.Enabled = true;
            rdbActivo.Enabled = true;
            rdbInactivo.Enabled = true;

            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Bloquear campos al iniciar la pantalla
            txtNombreFactura.Enabled = false;
            cboxCodigoCliente.Enabled = false;
            cboxCodigoVehículo.Enabled = false;
            dtpFechaFactura.Enabled = false;
            cboxTipoPago.Enabled = false;
            txtObservaciones.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            MtdLimpiaCampos();
        }

        private void MtdLimpiaCampos()
        {
            // Limpia valores en controles
            txtCodigoFactura.Text = "";
            txtNombreFactura.Clear();
            cboxCodigoCliente.Text = "";
            cboxCodigoVehículo.Text = "";
            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;

            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtImpuesto.Clear();
            txtTotalAPagar.Clear();
            txtObservaciones.Clear();
            cboxTipoPago.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MtdCrudAgregar();
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked == true)
            {
                // Habilitar DataGridView
                dgvFacturaciones.Enabled = true;
                dgvFacturaciones.ClearSelection();
            }
            else
            {
                // Bloquear DataGridView
                dgvFacturaciones.Enabled = false;
                dgvFacturaciones.ClearSelection();

                // Bloquear campos al iniciar la pantalla
                txtNombreFactura.Enabled = false;
                cboxCodigoCliente.Enabled = false;
                cboxCodigoVehículo.Enabled = false;
                dtpFechaFactura.Enabled = false;
                cboxTipoPago.Enabled = false;
                txtObservaciones.Enabled = false;
                rdbActivo.Enabled = false;
                rdbInactivo.Enabled = false;

                btnNuevo.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                // Limpiar valores en controles
                MtdLimpiaCampos();
            }
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            // 1. Si borras el texto y queda vacío, limpiamos los demás campos a 0
            if (string.IsNullOrEmpty(txtSubtotal.Text.Trim()))
            {
                txtDescuento.Text = "0.00";
                txtImpuesto.Text = "0.00";
                txtTotalAPagar.Text = "0.00";
                return;
            }

            try
            {
                // 2. Convertimos el texto ingresado a decimal
                decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

                // 3. Mandamos a llamar a tus 3 métodos matemáticos
                decimal descuento = MtdCalcularDescuento(subtotal);
                decimal impuesto = MtdCalcularImpuesto(subtotal, descuento);
                decimal totalPagar = MtdCalcularTotalPagar(subtotal, descuento, impuesto);

                // 4. Mostramos los resultados en la pantalla con dos decimales
                txtDescuento.Text = descuento.ToString("F2");
                txtImpuesto.Text = impuesto.ToString("F2");
                txtTotalAPagar.Text = totalPagar.ToString("F2");
            }
            catch
            {
                // Por si escribes una letra por error, para que no se congele el programa
                txtDescuento.Text = "0.00";
                txtImpuesto.Text = "0.00";
                txtTotalAPagar.Text = "0.00";
            }
        }

        private void dgvFacturaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Enviar los valore de la fila a los controles de Gestion
            txtCodigoFactura.Text = dgvFacturaciones.CurrentRow.Cells["CodigoFactura"].Value.ToString();
            // Forzar la conversión 
            if (dgvFacturaciones.CurrentRow.Cells["CodigoCliente"].Value != DBNull.Value)
            {
                cboxCodigoCliente.SelectedValue = Convert.ToInt32(dgvFacturaciones.CurrentRow.Cells["CodigoCliente"].Value);
            }
            else
            {
                cboxCodigoCliente.SelectedIndex = -1;
            }

            if (dgvFacturaciones.CurrentRow.Cells["CodigoVehiculo"].Value != DBNull.Value)
            {
                cboxCodigoVehículo.SelectedValue = Convert.ToInt32(dgvFacturaciones.CurrentRow.Cells["CodigoVehiculo"].Value);
            }
            else
            {
                cboxCodigoVehículo.SelectedIndex = -1;
            }
            dtpFechaFactura.Value = Convert.ToDateTime(dgvFacturaciones.CurrentRow.Cells["FechaFactura"].Value);
            txtSubtotal.Text = dgvFacturaciones.CurrentRow.Cells["SubTotal"].Value.ToString();
            txtDescuento.Text = dgvFacturaciones.CurrentRow.Cells["Descuento"].Value.ToString();
            txtImpuesto.Text = dgvFacturaciones.CurrentRow.Cells["Impuesto"].Value.ToString();
            txtTotalAPagar.Text = dgvFacturaciones.CurrentRow.Cells["TotalPagar"].Value.ToString();
            cboxTipoPago.Text = dgvFacturaciones.CurrentRow.Cells["TipoPago"].Value.ToString();
            txtObservaciones.Text = dgvFacturaciones.CurrentRow.Cells["Observaciones"].Value.ToString();

            bool Estado = bool.Parse(dgvFacturaciones.CurrentRow.Cells["Estado"].Value.ToString());

            if (Estado == true)
            {
                rdbActivo.Checked = true;
            }
            else
            {
                rdbInactivo.Checked = true;
            }

            // habilitar controles
            cboxCodigoCliente.Enabled = true;
            cboxCodigoVehículo.Enabled = true;
            dtpFechaFactura.Enabled = true;
            cboxTipoPago.Enabled = true;
            txtObservaciones.Enabled = true;
            rdbActivo.Enabled = true;
            rdbInactivo.Enabled = true;

            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        // CRUD Editar 
        public void MtdCrudEditar()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                conn.Open();
                string QueryAgregar = @"    UPDATE TBL_Facturaciones
                                            SET CodigoCliente = @CodigoCliente,
                                                CodigoVehiculo = @CodigoVehiculo,
                                                FechaFactura = @FechaFactura,
                                                SubTotal = @SubTotal,
                                                Descuento = @Descuento,
                                                Impuesto = @Impuesto,
                                                TotalPagar = @TotalPagar,
                                                TipoPago = @TipoPago,
                                                Observaciones = @Observaciones,
                                                Estado = @Estado,
                                                UsuarioSistema = @UsuarioSistema,
                                                FechaSistema = @FechaSistema,
                                                HoraSistema = @HoraSistema
                                            WHERE CodigoFactura = @CodigoFactura;
										  ";
                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);
                cmd.Parameters.AddWithValue("@CodigoFactura", Convert.ToInt32(txtCodigoFactura.Text));
                cmd.Parameters.AddWithValue("@CodigoCliente", cboxCodigoCliente.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoVehiculo", cboxCodigoVehículo.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaFactura", dtpFechaFactura.Value.Date);
                cmd.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(txtSubtotal.Text));
                cmd.Parameters.AddWithValue("@Descuento", Convert.ToDecimal(txtDescuento.Text));
                cmd.Parameters.AddWithValue("@Impuesto", Convert.ToDecimal(txtImpuesto.Text));
                cmd.Parameters.AddWithValue("@TotalPagar", Convert.ToDecimal(txtTotalAPagar.Text));
                cmd.Parameters.AddWithValue("@TipoPago", cboxTipoPago.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);

                if (rdbActivo.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Estado", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Estado", false);
                }

                cmd.Parameters.AddWithValue("@UsuarioSistema", "Milagros Arriaga");
                cmd.Parameters.AddWithValue("@FechaSistema", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@HoraSistema", DateTime.Now.TimeOfDay);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Facturación editada correctamente", "Confirmacíón", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MtdCrudConsultar();
                MtdLimpiaCampos();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
                conn.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MtdCrudEditar();
        }

        // Metodo CRUD para Eliminar
        public void MtdCrudEliminar()
        {
            if (txtCodigoFactura.Text == "")
            {
                MessageBox.Show("Debe seleccionar una planilla");

                return;
            }

            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea eliminar la factura?",
                                            "Eliminar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    conn.Open();

                    string eliminar = "DELETE FROM TBL_Facturaciones " +
                                      "WHERE CodigoFactura = @CodigoFactura";


                    SqlCommand cmd = new SqlCommand(eliminar, conn);

                    cmd.Parameters.AddWithValue("@CodigoFactura", txtCodigoFactura.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Factura eliminada correctamente");

                    MtdCrudConsultar();

                    MtdLimpiaCampos();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MtdCrudEliminar();
        }
    }
}
