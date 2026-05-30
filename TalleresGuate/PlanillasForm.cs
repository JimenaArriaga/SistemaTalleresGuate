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
    public partial class PlanillasForm : Form
    {
        //Instancia
        ConexionDatos connDatos = new ConexionDatos();
        public PlanillasForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Botón para cerrar el formulario
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        // Metodo de carga inicial del formulario
        private void PlanillasForm_Load(object sender, EventArgs e)
        {
            MtdCrudConsultar();
            MtdCargarEmpleados();

            // Controla el data grid view
            dgvPlanillas.Enabled = false;
            dgvPlanillas.ReadOnly = true;
            dgvPlanillas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlanillas.MultiSelect = false;
            dgvPlanillas.AllowUserToAddRows = false;
            dgvPlanillas.ClearSelection();

            // Bloquear únicamente los campos editables al iniciar la pantalla
            cboxCodigoEmpleado.Enabled = false;
            nudHorasTrabajadas.Enabled = false;
            dtpFechaPago.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            // Control de estado de los botones
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
                                            FROM TBL_Planillas
                                            ORDER BY CodigoPlanilla ASC;
                                        ";

                SqlDataAdapter adaptador = new SqlDataAdapter(QueryConsultar, conn);

                DataTable dt = new DataTable();

                adaptador.Fill(dt);

                dgvPlanillas.DataSource = dt;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                                            INSERT INTO TBL_Planillas
                                            (CodigoEmpleado, SalarioBase, HorasTrabajadas, PagoHorasExtra, Igss, Isr, TotalPago, FechaPago, Estado, UsuarioSistema, FechaSistema, HoraSistema)
                                            VALUES 
                                            (@CodigoEmpleado, @SalarioBase, @HorasTrabajadas, @PagoHorasExtra, @Igss, @Isr, @TotalPago, @FechaPago, @Estado, @UsuarioSistema, @FechaSistema, @HoraSistema);
                                        ";

                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);

                // Mapeo de parámetros con conversión de tipos según la BD
                if (cboxCodigoEmpleado.SelectedValue != null && int.TryParse(cboxCodigoEmpleado.SelectedValue.ToString(), out int idEmp))
                {
                    cmd.Parameters.AddWithValue("@CodigoEmpleado", idEmp);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CodigoEmpleado", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@SalarioBase", Convert.ToDecimal(txtSalarioBase.Text));
                cmd.Parameters.AddWithValue("@HorasTrabajadas", Convert.ToInt32(nudHorasTrabajadas.Value));
                cmd.Parameters.AddWithValue("@PagoHorasExtra", Convert.ToDecimal(txtPagoHorasExtra.Text));
                cmd.Parameters.AddWithValue("@Igss", Convert.ToDecimal(txtIGSS.Text));
                cmd.Parameters.AddWithValue("@Isr", Convert.ToDecimal(txtISR.Text));
                cmd.Parameters.AddWithValue("@TotalPago", Convert.ToDecimal(txtTotalPago.Text));
                cmd.Parameters.AddWithValue("@FechaPago", dtpFechaPago.Value.Date);

                if (rdbActivo.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@Estado", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Estado", false);
                }

                // Campos de auditoría automática
                cmd.Parameters.AddWithValue("@UsuarioSistema", "Milagros Arriaga");
                cmd.Parameters.AddWithValue("@FechaSistema", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@HoraSistema", DateTime.Now.TimeOfDay);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Planilla agregada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MtdCrudConsultar();

                // Bloquear campos editables tras guardar exitosamente
                cboxCodigoEmpleado.Enabled = false;
                nudHorasTrabajadas.Enabled = false;
                dtpFechaPago.Enabled = false;
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

        // Botón Nuevo para activar campos de entrada
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Activar únicamente los campos requeridos para la entrada de datos
            cboxCodigoEmpleado.Enabled = true;
            nudHorasTrabajadas.Enabled = true;
            dtpFechaPago.Enabled = true;
            rdbActivo.Enabled = true;
            rdbInactivo.Enabled = true;

            // Gestión de botones
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        // Método para cargar empleados activos en el ComboBox
        public void MtdCargarEmpleados()
        {
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                string query = "SELECT CodigoEmpleado, CONCAT(NombreEmpleado, ' ', ApellidoEmpleado) AS NombreCompleto FROM TBL_Empleados WHERE Estado = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboxCodigoEmpleado.DataSource = dt;
                cboxCodigoEmpleado.DisplayMember = "NombreCompleto";
                cboxCodigoEmpleado.ValueMember = "CodigoEmpleado";
                cboxCodigoEmpleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener el salario base del empleado seleccionado
        public decimal MtdObtenerSalarioBase(int codigoEmpleado)
        {
            decimal salarioBase = 0;
            SqlConnection conn = connDatos.MtdConexionBaseDatos();
            try
            {
                string query = "SELECT SalarioBase FROM TBL_Empleados WHERE CodigoEmpleado = @CodigoEmpleado";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);

                conn.Open();
                object resultado = cmd.ExecuteScalar();
                if (resultado != null && resultado != DBNull.Value)
                {
                    salarioBase = Convert.ToDecimal(resultado);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener salario base: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salarioBase;
        }

        // Botón Cancelar para limpiar campos y bloquear entradas
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Bloquear los campos correspondientes
            cboxCodigoEmpleado.Enabled = false;
            txtSalarioBase.Enabled = false;
            nudHorasTrabajadas.Enabled = false;
            dtpFechaPago.Enabled = false;
            rdbActivo.Enabled = false;
            rdbInactivo.Enabled = false;

            // Gestión de botones
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            MtdLimpiaCampos();
        }

        // Limpiar campos de entrada
        private void MtdLimpiaCampos()
        {
            // Limpieza completa de los controles 
            txtCodigoPlanilla.Clear();
            //cboxCodigoEmpleado.Text = "";
            cboxCodigoEmpleado.SelectedIndex = -1;
            txtSalarioBase.Clear();
            nudHorasTrabajadas.Value = 0;
            txtPagoHorasExtra.Clear();
            txtIGSS.Clear();
            txtISR.Clear();
            txtTotalPago.Clear();
            dtpFechaPago.Value = DateTime.Now;
            rdbActivo.Checked = false;
            rdbInactivo.Checked = false;
        }

        // Botón Guardar 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Llamar al metodo
            MtdCrudAgregar();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // Metodo para calcular el pago de horas extra       
        public decimal MtdCalcularPagoHorasExtra(int horasTrabajadas)
        {
            if (horasTrabajadas > 150)
            {
                decimal pagoHorasExtra = (horasTrabajadas - 150) * 30;
                return pagoHorasExtra;
            }
            else
            {
                return 0;
            }
        }

        // Metodo para calcular IGSS
        public decimal MtdCalcularIGSS(decimal salarioBase, decimal pagoHorasExtra)
        {
            decimal igss = (salarioBase + pagoHorasExtra) * 0.0483m;
            return igss;
        }

        // Metodo para calcular ISR
        public decimal MtdCalcularISR(decimal salarioBase, decimal pagoHorasExtra)
        {
            decimal isr = (salarioBase + pagoHorasExtra) * 0.05m;
            return isr;
        }

        // metodo para calcular el total a pagar al empleado
        public decimal MtdCalcularTotalPago(decimal salarioBase, decimal pagoHorasExtra, decimal igss, decimal isr)
        {
            decimal totalPago = (salarioBase + pagoHorasExtra) - igss - isr;
            return totalPago;
        }

        // Método para procesar todos los cálculos de la planilla 
        public void MtdProcesarCalculosPlanilla()
        {
            try
            {
                // 1. Recuperar los valores base de la pantalla de forma segura
                decimal salarioBase = string.IsNullOrEmpty(txtSalarioBase.Text) ? 0 : Convert.ToDecimal(txtSalarioBase.Text);
                int horasTrabajadas = Convert.ToInt32(nudHorasTrabajadas.Value);

                // 2. Ejecutar tus métodos de cálculo en orden secuencial
                decimal pagoHorasExtra = MtdCalcularPagoHorasExtra(horasTrabajadas);
                decimal igss = MtdCalcularIGSS(salarioBase, pagoHorasExtra);
                decimal isr = MtdCalcularISR(salarioBase, pagoHorasExtra);
                decimal totalPago = MtdCalcularTotalPago(salarioBase, pagoHorasExtra, igss, isr);

                // 3. Imprimir los resultados en los TextBox formateados a 2 decimales
                txtPagoHorasExtra.Text = pagoHorasExtra.ToString("N2");
                txtIGSS.Text = igss.ToString("N2");
                txtISR.Text = isr.ToString("N2");
                txtTotalPago.Text = totalPago.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los cálculos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para actualizar el salario base al seleccionar un empleado y recalcular la planilla
        private void cboxCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validar  que el valor seleccionado sea un número entero válido
            if (cboxCodigoEmpleado.SelectedValue != null && int.TryParse(cboxCodigoEmpleado.SelectedValue.ToString(), out int idEmpleado))
            {
                // Obtener el salario base usando el método
                decimal salario = MtdObtenerSalarioBase(idEmpleado);
                txtSalarioBase.Text = salario.ToString("F2"); // "F2" evita conflictos de caracteres de moneda al reconvertir

                // Mandar a llamar al metodo para que actualice la pantalla
                MtdProcesarCalculosPlanilla();
            }
        }

        // Evento para recalcular la planilla cada vez que se modifiquen las horas trabajadas
        private void nudHorasTrabajadas_ValueChanged(object sender, EventArgs e)
        {
            MtdProcesarCalculosPlanilla();
        }

        // Evento para habilitar o deshabilitar el DataGridView según el estado del CheckBox
        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked == true)
            {
                // Habilitar DataGridView
                dgvPlanillas.Enabled = true;
                dgvPlanillas.ClearSelection();
            }
            else
            {
                // Bloquear DataGridView
                dgvPlanillas.Enabled = false;
                dgvPlanillas.ClearSelection();

                // Bloquear los campos correspondientes
                cboxCodigoEmpleado.Enabled = false;
                txtSalarioBase.Enabled = false;
                nudHorasTrabajadas.Enabled = false;
                dtpFechaPago.Enabled = false;
                rdbActivo.Enabled = false;
                rdbInactivo.Enabled = false;

                // Gestión de botones
                btnNuevo.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;

                // Limpiar valores en controles
                MtdLimpiaCampos();
            }
        }

        // Evento para cargar los datos de la fila seleccionada en el DataGridView a los controles de entrada
        private void dgvPlanillas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Enviar los valores de la fila a los controles de Gestión de Planillas
            txtCodigoPlanilla.Text = dgvPlanillas.CurrentRow.Cells["CodigoPlanilla"].Value.ToString();
            if (dgvPlanillas.CurrentRow.Cells["CodigoEmpleado"].Value != DBNull.Value && dgvPlanillas.CurrentRow.Cells["CodigoEmpleado"].Value != null)
            {
                cboxCodigoEmpleado.SelectedValue = Convert.ToInt32(dgvPlanillas.CurrentRow.Cells["CodigoEmpleado"].Value);
            }
            else
            {
                cboxCodigoEmpleado.SelectedIndex = -1;
            }
            txtSalarioBase.Text = Convert.ToDecimal(dgvPlanillas.CurrentRow.Cells["SalarioBase"].Value).ToString("N2");
            nudHorasTrabajadas.Value = Convert.ToInt32(dgvPlanillas.CurrentRow.Cells["HorasTrabajadas"].Value);
            txtPagoHorasExtra.Text = Convert.ToDecimal(dgvPlanillas.CurrentRow.Cells["PagoHorasExtra"].Value).ToString("N2");
            txtIGSS.Text = Convert.ToDecimal(dgvPlanillas.CurrentRow.Cells["Igss"].Value).ToString("N2");
            txtISR.Text = Convert.ToDecimal(dgvPlanillas.CurrentRow.Cells["Isr"].Value).ToString("N2");
            txtTotalPago.Text = Convert.ToDecimal(dgvPlanillas.CurrentRow.Cells["TotalPago"].Value).ToString("N2");
            dtpFechaPago.Value = Convert.ToDateTime(dgvPlanillas.CurrentRow.Cells["FechaPago"].Value);

            bool Estado = bool.Parse(dgvPlanillas.CurrentRow.Cells["Estado"].Value.ToString());

            if (Estado == true)
            {
                rdbActivo.Checked = true;
            }
            else
            {
                rdbInactivo.Checked = true;
            }

            // habilitar controles
            cboxCodigoEmpleado.Enabled = true;
            nudHorasTrabajadas.Enabled = true;
            dtpFechaPago.Enabled = true;
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
                string QueryAgregar = @"    UPDATE TBL_Planillas
                                             SET CodigoEmpleado = @CodigoEmpleado,
                                                 SalarioBase = @SalarioBase,
                                                 HorasTrabajadas = @HorasTrabajadas,
                                                 PagoHorasExtra = @PagoHorasExtra,
                                                 Igss = @Igss,
                                                 Isr = @Isr,
                                                 TotalPago = @TotalPago,
                                                 FechaPago = @FechaPago,
                                                 Estado = @Estado,
                                                 UsuarioSistema = @UsuarioSistema,
                                                 FechaSistema = @FechaSistema,
                                                 HoraSistema = @HoraSistema
                                             WHERE CodigoPlanilla = @CodigoPlanilla;
										  ";
                SqlCommand cmd = new SqlCommand(QueryAgregar, conn);
                cmd.Parameters.AddWithValue("@CodigoPlanilla", txtCodigoPlanilla.Text);
                cmd.Parameters.AddWithValue("@CodigoEmpleado", cboxCodigoEmpleado.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@SalarioBase", Convert.ToDecimal(txtSalarioBase.Text));
                cmd.Parameters.AddWithValue("@HorasTrabajadas", Convert.ToInt32(nudHorasTrabajadas.Value));
                cmd.Parameters.AddWithValue("@PagoHorasExtra", Convert.ToDecimal(txtPagoHorasExtra.Text));
                cmd.Parameters.AddWithValue("@Igss", Convert.ToDecimal(txtIGSS.Text));
                cmd.Parameters.AddWithValue("@Isr", Convert.ToDecimal(txtISR.Text));
                cmd.Parameters.AddWithValue("@TotalPago", Convert.ToDecimal(txtTotalPago.Text));
                cmd.Parameters.AddWithValue("@FechaPago", dtpFechaPago.Value.Date);

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

                MessageBox.Show("Planilla editada correctamente", "Confirmacíón", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (txtCodigoPlanilla.Text == "")
            {
                MessageBox.Show("Debe seleccionar una planilla");

                return;
            }

            SqlConnection conn = connDatos.MtdConexionBaseDatos();

            try
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea eliminar la planilla?",
                                            "Eliminar",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    conn.Open();

                    string eliminar = "DELETE FROM TBL_Planillas " +
                                      "WHERE CodigoPlanilla = @CodigoPlanilla";


                    SqlCommand cmd = new SqlCommand(eliminar, conn);

                    cmd.Parameters.AddWithValue("@CodigoPlanilla", txtCodigoPlanilla.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Planilla eliminada correctamente");

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
            // Llamar al método
            MtdCrudEliminar();
        }
    }
}
