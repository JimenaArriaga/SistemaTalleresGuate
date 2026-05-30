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
    public partial class TipoServiciosForm : Form
    {
        //Instancia
        ConexionDatos connDatos = new ConexionDatos();
        public TipoServiciosForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        // Evento Load del formulario para cargar datos al iniciar
        private void TipoServiciosForm_Load(object sender, EventArgs e)
        {
            MtdCrudConsultar();

            // Controla el data grid view
            dgvTipoServicios.Enabled = false;
            dgvTipoServicios.ReadOnly = true;
            dgvTipoServicios.SelectionMode = dgvTipoServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipoServicios.MultiSelect = false;
            dgvTipoServicios.AllowUserToAddRows = false;
            dgvTipoServicios.ClearSelection();

            // Bloquear campos al iniciar la pantalla
            txtCodigoTipoServicio.Enabled = false; // Es Autoincrementable
            cboxNombreServicio.Enabled = false;
            txtDescripcionServicio.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            // Estado de los botones al iniciar
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
                                            FROM TBL_TipoServicios
                                            ORDER BY CodigoTipoServicio ASC;
                                        ";

                SqlDataAdapter adaptador = new SqlDataAdapter(QueryConsultar, conn);

                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                dgvTipoServicios.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
                throw;
            }
        }

        private void txtCostoBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                                            INSERT INTO TBL_TipoServicios
                                            (NombreServicio, CostoBase, RecargoServicio, TotalServicio, DescripcionServicio, Estado, UsuarioSistema, FechaSistema, HoraSistema)
                                            VALUES  
                                            (@NombreServicio, @CostoBase, @RecargoServicio, @TotalServicio, @DescripcionServicio, @Estado, @UsuarioSistema, @FechaSistema, @HoraSistema);";

                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);

                // Conversión segura de valores numéricos
                decimal costoBase = Convert.ToDecimal(txtCostoBase.Text);
                decimal recargo = Convert.ToDecimal(txtRecargoServicio.Text);
                decimal total = costoBase + recargo; // Cálculo automático del total
                txtTotalServicio.Text = total.ToString();

                cmd.Parameters.AddWithValue("@NombreServicio", cboxNombreServicio.SelectedItem?.ToString() ?? cboxNombreServicio.Text);
                cmd.Parameters.AddWithValue("@CostoBase", costoBase);
                cmd.Parameters.AddWithValue("@RecargoServicio", recargo);
                cmd.Parameters.AddWithValue("@TotalServicio", total);

                cmd.Parameters.AddWithValue("@DescripcionServicio", txtDescripcionServicio.Text);

                if (rdbActivo.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Estado", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Estado", false);
                }

                // Auditoría
                cmd.Parameters.AddWithValue("@UsuarioSistema", "Milagros Arriaga");
                cmd.Parameters.AddWithValue("@FechaSistema", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@HoraSistema", DateTime.Now.TimeOfDay);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Tipo de servicio agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la tabla de la UI
                MtdCrudConsultar();

                txtCodigoTipoServicio.Enabled = false;
                cboxNombreServicio.Enabled = false;
                txtDescripcionServicio.Enabled = false;
                rdbActivo.Enabled = false;
                rdbInactivo.Enabled = false;

                btnNuevo.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                MtdLimpiaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tipo de servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        // Botón Nuevo 
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Habilitar campos para la edición
            cboxNombreServicio.Enabled = true;
            cboxNombreServicio.Enabled = true;
            txtDescripcionServicio.Enabled = true;
            rdbActivo.Enabled = true;
            rdbInactivo.Enabled = true;

            // Control de botones
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        // Botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigoTipoServicio.Enabled = false;
            cboxNombreServicio.Enabled = false;
            txtDescripcionServicio.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            MtdLimpiaCampos();
        }

        // Método para limpiar los campos del formulario
        private void MtdLimpiaCampos()
        {
            txtCodigoTipoServicio.Clear();
            cboxNombreServicio.SelectedIndex = -1;
            cboxNombreServicio.Text = "";
            txtCostoBase.Clear();
            txtRecargoServicio.Clear();
            txtTotalServicio.Clear();
            txtDescripcionServicio.Clear();
            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;
        }

        // Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MtdCrudAgregar();
        }

        // Método para obtener el Costo Base según el servicio seleccionado
        private decimal MtdCalcularCostoBase(string servicio)
        {
            switch (servicio)
            {
                case "Mecánica": return 1000;
                case "Electricidad": return 1200;
                case "Enderezado": return 5000;
                case "Balanceo": return 350;
                case "Diagnostico": return 500;
                default: return 0;
            }
        }

        // Método para obtener el Recargo según el servicio y su costo base
        private decimal MtdCalcularRecargoServicio(string servicio, decimal costoBase)
        {
            switch (servicio)
            {
                case "Electricidad": return costoBase * 0.20m;
                case "Enderezado": return costoBase * 0.30m;
                case "Mecánica": return costoBase * 0.10m;
                default: return 0; // Balanceo, Diagnostico o cualquier otro no tiene recargo
            }
        }

        // calcular el total 
        private decimal MtdCalcularTotal(decimal costoBase, decimal recargo)
        {
            return costoBase + recargo;
        }

        // Evento para actualizar los montos al seleccionar un servicio
        private void cboxNombreServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que haya una opción seleccionada
            if (cboxNombreServicio.SelectedItem != null)
            {
                string servicioSeleccionado = cboxNombreServicio.SelectedItem.ToString().Trim();

                // Calcular y mostrar Costo Base
                decimal costoBase = MtdCalcularCostoBase(servicioSeleccionado);
                txtCostoBase.Text = costoBase.ToString("F2");

                // Calcular y mostrar Recargo
                decimal recargo = MtdCalcularRecargoServicio(servicioSeleccionado, costoBase);
                txtRecargoServicio.Text = recargo.ToString("F2");

                // Calcular y mostrar el Total de forma directa
                decimal total = MtdCalcularTotal(costoBase, recargo);
                txtTotalServicio.Text = total.ToString("F2");
            }
            else
            {
                // Si no hay selección, limpiar los campos de montos
                txtCostoBase.Clear();
                txtRecargoServicio.Clear();
                txtTotalServicio.Clear();
            }
        }

        // Evento para habilitar o deshabilitar el DataGridView según el estado del checkbox
        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked == true)
            {
                // Habilitar DataGridView
                dgvTipoServicios.Enabled = true;
                dgvTipoServicios.ClearSelection();
            }
            else
            {
                // Bloquear DataGridView
                dgvTipoServicios.Enabled = false;
                dgvTipoServicios.ClearSelection();

                // Bloquear campos al iniciar la pantalla
                txtCodigoTipoServicio.Enabled = false; // Es Identity (Autoincrementable)
                cboxNombreServicio.Enabled = false;
                txtDescripcionServicio.Enabled = false;
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

        // Evento para cargar los datos del registro seleccionado en el DataGridView a los controles de edición
        private void dgvTipoServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Enviar los valore de la fila a los controles de Gestion
            txtCodigoTipoServicio.Text = dgvTipoServicios.CurrentRow.Cells["CodigoTipoServicio"].Value.ToString();
            cboxNombreServicio.Text = dgvTipoServicios.CurrentRow.Cells["NombreServicio"].Value.ToString();
            txtCostoBase.Text = dgvTipoServicios.CurrentRow.Cells["CostoBase"].Value.ToString();
            txtRecargoServicio.Text = dgvTipoServicios.CurrentRow.Cells["RecargoServicio"].Value.ToString();
            txtTotalServicio.Text = dgvTipoServicios.CurrentRow.Cells["TotalServicio"].Value.ToString();
            txtDescripcionServicio.Text = dgvTipoServicios.CurrentRow.Cells["DescripcionServicio"].Value.ToString();

            bool Estado = bool.Parse(dgvTipoServicios.CurrentRow.Cells["Estado"].Value.ToString());

            if (Estado == true)
            {
                rdbActivo.Checked = true;
            }
            else
            {
                rdbInactivo.Checked = true;
            }

            // habilitar controles
            txtCodigoTipoServicio.Enabled = false; // Es Identity (Autoincrementable)
            cboxNombreServicio.Enabled = true;
            txtCostoBase.Enabled = true;
            txtRecargoServicio.Enabled = true;
            txtDescripcionServicio.Enabled = true;
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
                string QueryAgregar = @"    UPDATE TBL_TipoServicios
                                            SET NombreServicio = @NombreServicio,
                                                CostoBase = @CostoBase,
                                                RecargoServicio = @RecargoServicio,
                                                TotalServicio = @TotalServicio,
                                                DescripcionServicio = @DescripcionServicio,
                                                Estado = @Estado,
                                                UsuarioSistema = @UsuarioSistema,
                                                FechaSistema = @FechaSistema,
                                                HoraSistema = @HoraSistema
                                            WHERE CodigoTipoServicio = @CodigoTipoServicio;
										  ";
                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);
                cmd.Parameters.AddWithValue("@CodigoTipoServicio", txtCodigoTipoServicio.Text);
                cmd.Parameters.AddWithValue("@NombreServicio", cboxNombreServicio.Text);
                cmd.Parameters.AddWithValue("@CostoBase", txtCostoBase.Text);
                cmd.Parameters.AddWithValue("@RecargoServicio", txtRecargoServicio.Text);
                cmd.Parameters.AddWithValue("@TotalServicio", txtTotalServicio.Text);
                cmd.Parameters.AddWithValue("@DescripcionServicio", txtDescripcionServicio.Text);

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

                MessageBox.Show("Tipo de servicio editado correctamente", "Confirmacíón", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // Botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MtdCrudEditar();
        }

        // Metodo CRUD para Eliminar
        public void MtdCrudEliminar()
        {
            if (txtCodigoTipoServicio.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de servicio");

                return;
            }

            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea eliminar el tipo de servicio?",
                                            "Eliminar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    conn.Open();

                    string eliminar = "DELETE FROM TBL_TipoServicios " +
                                      "WHERE CodigoTipoServicio = @CodigoTipoServicio";


                    SqlCommand cmd = new SqlCommand(eliminar, conn);

                    cmd.Parameters.AddWithValue("@CodigoTipoServicio", txtCodigoTipoServicio.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tipo de servicio eliminado correctamente");

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

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MtdCrudEliminar();
        }
    }
}


