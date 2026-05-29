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
    public partial class DetalleFacturasForm : Form
    {
        //Instancia
        ConexionDatos connDatos = new ConexionDatos();

        public DetalleFacturasForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            MtdCalcularTotales();
        }

        private void DetalleFacturasForm_Load(object sender, EventArgs e)
        {
            MtdCrudConsultar();
            MtdCargarFacturas();
            MtdCargarTipoServicios();
            MtdCargarInventario();

            // Controla el data grid view
            dgvDetalleFacturas.Enabled = false;
            dgvDetalleFacturas.ReadOnly = true;
            dgvDetalleFacturas.SelectionMode = dgvDetalleFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleFacturas.MultiSelect = false;
            dgvDetalleFacturas.AllowUserToAddRows = false;
            dgvDetalleFacturas.ClearSelection();

            // Bloquear campos al iniciar la pantalla (El campo CodigoDetalle no se activa por ser IDENTITY)
            cboxCodigoFactura.Enabled = false;
            cboxCodigoInventario.Enabled = false;
            cboxCodigoTipoServicio.Enabled = false;
            nudCantidad.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            // Control de Botones
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // CRUD Consultar
        public void MtdCrudConsultar()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                string QueryConsultar = @"
                                            SELECT *
                                            FROM TBL_DetalleFacturas
                                            ORDER BY CodigoDetalle ASC;
                                        ";

                SqlDataAdapter adaptador = new SqlDataAdapter(QueryConsultar, conn);

                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                dgvDetalleFacturas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        // CRUD AGREGAR
        public void MtdCrudAgregar()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                conn.Open();

                string QueryAgregar = @"
                                            INSERT INTO TBL_DetalleFacturas
                                            (CodigoFactura, CodigoInventario, CodigoTipoServicio, Cantidad, PrecioUnitario, SubTotal, Impuesto, TotalDetalle, Estado, UsuarioSistema, FechaSistema, HoraSistema)
                                            VALUES 
                                            (@CodigoFactura, @CodigoInventario, @CodigoTipoServicio, @Cantidad, @PrecioUnitario, @SubTotal, @Impuesto, @TotalDetalle, @Estado, @UsuarioSistema, @FechaSistema, @HoraSistema);
                                        ";

                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);

                // Mapeo de parámetros según tu base de datos y diseño
                cmd.Parameters.AddWithValue("@CodigoFactura", cboxCodigoFactura.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoInventario", cboxCodigoInventario.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoTipoServicio", cboxCodigoTipoServicio.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(nudCantidad.Value));
                cmd.Parameters.AddWithValue("@PrecioUnitario", Convert.ToDecimal(txtPrecioUnitario.Text));
                cmd.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(txtSubtotal.Text));
                cmd.Parameters.AddWithValue("@Impuesto", Convert.ToDecimal(txtImpuesto.Text));
                cmd.Parameters.AddWithValue("@TotalDetalle", Convert.ToDecimal(txtTotalDetalle.Text));

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

                MessageBox.Show("Detalle de factura agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MtdCrudConsultar();

                // Bloquear campos tras guardar exitosamente
                cboxCodigoFactura.Enabled = false;
                cboxCodigoInventario.Enabled = false;
                cboxCodigoTipoServicio.Enabled = false;
                nudCantidad.Enabled = false;
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Habilitar campos para el ingreso 
            cboxCodigoFactura.Enabled = true;
            cboxCodigoInventario.Enabled = true;
            cboxCodigoTipoServicio.Enabled = true;
            nudCantidad.Enabled = true;
            rdbActivo.Enabled = true;
            rdbInactivo.Enabled = true;

            // Control de Botones
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Bloquear campos
            cboxCodigoFactura.Enabled = false;
            cboxCodigoInventario.Enabled = false;
            cboxCodigoTipoServicio.Enabled = false;
            nudCantidad.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            // Control de Botones
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            // Limpiar valores en controles
            MtdLimpiaCampos();
        }

        // Método para cargar las Facturaciones 
        public void MtdCargarFacturas()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                // Traemos el ID y una descripción (Fecha) para que el usuario se guíe
                string query = "SELECT CodigoFactura, CONCAT('Factura #', CodigoFactura, ' - ', FechaFactura) AS InfoFactura FROM TBL_Facturaciones WHERE Estado = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboxCodigoFactura.DataSource = dt;
                cboxCodigoFactura.DisplayMember = "InfoFactura"; // Lo que ve el usuario
                cboxCodigoFactura.ValueMember = "CodigoFactura";   // El valor real (ID)
                cboxCodigoFactura.SelectedIndex = -1;             // Iniciar vacío
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar el Inventario en el ComboBox
        public void MtdCargarInventario()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                string query = "SELECT CodigoInventario, NombreProducto FROM TBL_Inventarios WHERE Estado = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboxCodigoInventario.DataSource = dt;
                cboxCodigoInventario.DisplayMember = "NombreProducto";
                cboxCodigoInventario.ValueMember = "CodigoInventario";
                cboxCodigoInventario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar los Tipos de Servicio en el ComboBox
        public void MtdCargarTipoServicios()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                string query = "SELECT CodigoTipoServicio, NombreServicio FROM TBL_TipoServicios WHERE Estado = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboxCodigoTipoServicio.DataSource = dt;
                cboxCodigoTipoServicio.DisplayMember = "NombreServicio";
                cboxCodigoTipoServicio.ValueMember = "CodigoTipoServicio";
                cboxCodigoTipoServicio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar servicios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 1. Método para obtener el PrecioVenta desde TBL_Inventarios
        public decimal MtdObtenerPrecioUnitario(int codigoInventario)
        {
            decimal precioVenta = 0;
            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                string query = "SELECT PrecioVenta FROM TBL_Inventarios WHERE CodigoInventario = @CodigoInventario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoInventario", codigoInventario);

                conn.Open();
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    precioVenta = Convert.ToDecimal(resultado);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener precio unitario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return precioVenta;
        }

        // 2. Método para obtener TotalServicio desde TBL_TipoServicios
        public decimal MtdObtenerTotalServicio(int codigoTipoServicio)
        {
            decimal totalServicio = 0;
            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                string query = "SELECT TotalServicio FROM TBL_TipoServicios WHERE CodigoTipoServicio = @CodigoTipoServicio";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoTipoServicio", codigoTipoServicio);

                conn.Open();
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    totalServicio = Convert.ToDecimal(resultado);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener costo del servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalServicio;
        }

        // 3. Método maestro que procesa el SubTotal, Impuesto y TotalDetalle
        public void MtdCalcularTotales()
        {
            try
            {
                // Validar que tengamos una cantidad válida y un precio cargado
                int cantidad = Convert.ToInt32(nudCantidad.Value);
                decimal precioUnitario = string.IsNullOrEmpty(txtPrecioUnitario.Text) ? 0 : Convert.ToDecimal(txtPrecioUnitario.Text);

                // Obtener el costo del servicio si hay uno seleccionado, si no, es 0
                decimal totalServicio = 0;
                if (cboxCodigoTipoServicio.SelectedValue != null && int.TryParse(cboxCodigoTipoServicio.SelectedValue.ToString(), out int idServicio))
                {
                    totalServicio = MtdObtenerTotalServicio(idServicio);
                }

                // Lógica: SubTotal = (Cantidad * PrecioUnitario) + TotalServicio
                decimal subTotal = (cantidad * precioUnitario) + totalServicio;

                // Lógica: Impuesto = SubTotal * 0.12
                decimal impuesto = subTotal * 0.12m;

                // Lógica: TotalDetalle = SubTotal + Impuesto
                decimal totalDetalle = subTotal + impuesto;

                // Mostrar los resultados formateados con 2 decimales en los TextBox
                txtSubtotal.Text = subTotal.ToString("N2");
                txtImpuesto.Text = impuesto.ToString("N2");
                txtTotalDetalle.Text = totalDetalle.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular totales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MtdCrudAgregar();
        }

        private void MtdLimpiaCampos()
        {
            txtCodigoDetalleFactura.Text = "";
            cboxCodigoFactura.Text = "";
            cboxCodigoInventario.Text = "";
            cboxCodigoTipoServicio.Text = "";
            nudCantidad.Value = 0;
            txtPrecioUnitario.Clear();
            txtSubtotal.Clear();
            txtImpuesto.Clear();
            txtTotalDetalle.Clear();
            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked == true)
            {
                // Habilitar DataGridView
                dgvDetalleFacturas.Enabled = true;
                dgvDetalleFacturas.ClearSelection();
            }
            else
            {
                // Bloquear DataGridView
                dgvDetalleFacturas.Enabled = false;
                dgvDetalleFacturas.ClearSelection();

                // Bloquear campos al iniciar la pantalla
                dgvDetalleFacturas.Enabled = false; 
                dgvDetalleFacturas.Enabled = false;
                dgvDetalleFacturas.Enabled = false;
                rdbActivo.Enabled = false;
                rdbInactivo.Enabled = false;

                // Estado de los botones al iniciar
                btnNuevo.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                // Limpiar valores en controles
                MtdLimpiaCampos();
            }
        }

        private void cboxCodigoInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que sea una selección válida y contenga el ID numérico
            if (cboxCodigoInventario.SelectedValue != null && int.TryParse(cboxCodigoInventario.SelectedValue.ToString(), out int idInventario))
            {
                decimal precio = MtdObtenerPrecioUnitario(idInventario);
                txtPrecioUnitario.Text = precio.ToString("N2");

                // Al cambiar el precio, recalculamos los totales
                MtdCalcularTotales();
            }
        }

        private void cboxCodigoTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cada vez que cambie el servicio, se vuelven a procesar los totales
            MtdCalcularTotales();
        }

        private void dgvDetalleFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Enviar los valore de la fila a los controles de Gestion
            txtCodigoDetalleFactura.Text = dgvDetalleFacturas.CurrentRow.Cells["CodigoDetalle"].Value.ToString();
            cboxCodigoFactura.SelectedValue = dgvDetalleFacturas.CurrentRow.Cells["CodigoFactura"].Value;
            cboxCodigoInventario.SelectedValue = dgvDetalleFacturas.CurrentRow.Cells["CodigoInventario"].Value;
            cboxCodigoTipoServicio.SelectedValue = dgvDetalleFacturas.CurrentRow.Cells["CodigoTipoServicio"].Value;
            nudCantidad.Value = Convert.ToInt32(dgvDetalleFacturas.CurrentRow.Cells["Cantidad"].Value);
            txtPrecioUnitario.Text = Convert.ToDecimal(dgvDetalleFacturas.CurrentRow.Cells["PrecioUnitario"].Value).ToString("N2");
            txtSubtotal.Text = Convert.ToDecimal(dgvDetalleFacturas.CurrentRow.Cells["SubTotal"].Value).ToString("N2");
            txtImpuesto.Text = Convert.ToDecimal(dgvDetalleFacturas.CurrentRow.Cells["Impuesto"].Value).ToString("N2");
            txtTotalDetalle.Text = Convert.ToDecimal(dgvDetalleFacturas.CurrentRow.Cells["TotalDetalle"].Value).ToString("N2");

            bool Estado = bool.Parse(dgvDetalleFacturas.CurrentRow.Cells["Estado"].Value.ToString());

            if (Estado == true)
            {
                rdbActivo.Checked = true;
            }
            else
            {
                rdbInactivo.Checked = true;
            }

            // habilitar controles
            cboxCodigoFactura.Enabled = true;
            cboxCodigoInventario.Enabled = true;
            cboxCodigoTipoServicio.Enabled = true;
            nudCantidad.Enabled = true;
            rdbActivo.Enabled = true;
            rdbInactivo.Enabled = true;

            // Estado de los botones al iniciar
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
                string QueryAgregar = @"    UPDATE TBL_DetalleFacturas
                                            SET CodigoFactura = @CodigoFactura,
                                                CodigoInventario = @CodigoInventario,
                                                CodigoTipoServicio = @CodigoTipoServicio,
                                                Cantidad = @Cantidad,
                                                PrecioUnitario = @PrecioUnitario,
                                                SubTotal = @SubTotal,
                                                Impuesto = @Impuesto,
                                                TotalDetalle = @TotalDetalle,
                                                Estado = @Estado,
                                                UsuarioSistema = @UsuarioSistema,
                                                FechaSistema = @FechaSistema,
                                                HoraSistema = @HoraSistema
                                            WHERE CodigoDetalle = @CodigoDetalle;
										  ";
                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);
                cmd.Parameters.AddWithValue("@CodigoDetalle", txtCodigoDetalleFactura.Text);
                cmd.Parameters.AddWithValue("@CodigoFactura", cboxCodigoFactura.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoInventario", cboxCodigoInventario.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoTipoServicio", cboxCodigoTipoServicio.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(nudCantidad.Value));
                cmd.Parameters.AddWithValue("@PrecioUnitario", Convert.ToDecimal(txtPrecioUnitario.Text));
                cmd.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(txtSubtotal.Text));
                cmd.Parameters.AddWithValue("@Impuesto", Convert.ToDecimal(txtImpuesto.Text));
                cmd.Parameters.AddWithValue("@TotalDetalle", Convert.ToDecimal(txtTotalDetalle.Text));

                if (rdbActivo.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Estado", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Estado", false);
                }

                cmd.Parameters.AddWithValue("@UsuarioSistema", "Emorales");
                cmd.Parameters.AddWithValue("@FechaSistema", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@HoraSistema", DateTime.Now.TimeOfDay);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Detalle de la factura editado correctamente", "Confirmacíón", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (txtCodigoDetalleFactura.Text == "")
            {
                MessageBox.Show("Debe seleccionar un detalle de factura");

                return;
            }

            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea eliminar el detalle de factura?",
                                            "Eliminar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    conn.Open();

                    string eliminar = "DELETE FROM TBL_DetalleFacturas " +
                                      "WHERE CodigoDetalle = @CodigoDetalle";


                    SqlCommand cmd = new SqlCommand(eliminar, conn);

                    cmd.Parameters.AddWithValue("@CodigoDetalle", txtCodigoDetalleFactura.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Detalle de factura eliminado correctamente");

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

        // Llama al método crud eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MtdCrudEliminar();
        }
    }
}
