using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistoAcceso_Operador
{
    public partial class CapturaSalida : Form
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        public bool EsSalida = false;
        public CapturaSalida()
        {
            InitializeComponent();            
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            dtFechaSalida.Value = DateTime.Now;
            dtHoraSalida.Value = DateTime.Now;
        }
       
        private void MuestraInformacion(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (txtGafeteAsignado.Text != "")
                    {
                        string query = "SELECT " +
                                            " A.AsignacionGafeteID, " +
                                            " ISNULL(A.RegistroAccesoID, 0) RegistroAccesoID, " +
                                            " ISNULL(A.RegistroPersonaID, 0) RegistroPersonasID, " +
                                            " CASE WHEN RS.EsAutobus = 1 THEN 'ES AUTOBUS' WHEN RS.Conductor = RP.Nombre THEN RS.Conductor WHEN RP.Nombre IS NOT NULL THEN RP.Nombre ELSE '' END Nombre, " +
                                            " ISNULL(RS.Placa, 'NA') Placa, " +
                                            " ISNULL(RS.Asunto, '') Asunto, " +
                                            " ISNULL(D.Nombre, '') Departamento, " +
                                            " ISNULL(RS.Comentarios, '') Descripcion,	 " +
                                            " A.FechaAsignacion FechaEntrada " +                                            
                                        " FROM " +
                                            " AsignacionGafete A " +
                                            " INNER JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = A.RegistroAccesoID AND RS.TieneSalida = 0 AND RS.Activo = 1 " +
                                            " INNER JOIN RegistroAccesoPersonas RP ON RP.RegistroPersonasID = A.RegistroPersonaID AND RP.Salida = 0 AND RP.Activo = 1 " +                                            
                                            " INNER JOIN [IBIX].[IBIXLocal].dbo.tblDepto D ON D.Depto = RS.DepartamentoID AND D.Activo = 1 AND D.Emp = 1 AND D.Nombre <> '' " +
                                        " WHERE " +
                                            " A.Gafete2 = '" + txtGafeteAsignado.Text.Trim().ToUpper() + "' AND A.TieneSalida = 0 AND A.Activo = 1";                        
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        if (conexion.State == ConnectionState.Closed)
                            conexion.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtAsignacionGafeteID.Text = reader["AsignacionGafeteID"].ToString();
                            txtRegistroAccesoID.Text = reader["RegistroAccesoID"].ToString();
                            txtRegistroPersonaID.Text = reader["RegistroPersonasID"].ToString();
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtPlaca.Text = reader["Placa"].ToString();
                            txtAsunto.Text = reader["Asunto"].ToString();                            
                            txtDepartamento.Text = reader["Departamento"].ToString();
                            txtDescripcion.Text = reader["Descripcion"].ToString();                            
                            txtFechaEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());
                            txtHoraEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());
                            btnGuardar.Focus();                       
                        }
                        else
                        {
                            MessageBox.Show("No se Encontro Información con este numero de gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LimpiarCampos();
                        }
                        reader.Close();
                        conexion.Close();                        
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese numero de gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Mostrando Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
        }

        internal void MostrarDatosDeSalida(int AsignacionGafeteID)
        {
            LimpiarCampos();
            EsSalida = true;
            txtGafeteAsignado.Enabled = false;            
            ShowInfo(AsignacionGafeteID);
        }

        private void ShowInfo(int AsignacionGafeteID)
        {
            try
            {
                string sql = "SELECT " +
                                    " A.AsignacionGafeteID, " +
                                    " ISNULL(A.RegistroAccesoID, 0) RegistroAccesoID, " +
                                    " ISNULL(A.RegistroPersonaID, 0) RegistroPersonasID, " +
                                    " CASE WHEN RS.EsAutobus = 1 THEN 'ES AUTOBUS' WHEN RS.Conductor = RP.Nombre THEN RS.Conductor WHEN RP.Nombre IS NOT NULL THEN RP.Nombre ELSE '' END Nombre, " +
                                    " ISNULL(RS.Placa, 'NA') Placa, " +
                                    " ISNULL(RS.Asunto, 'NA') Asunto, " +
                                    " ISNULL(D.Nombre, 'NA') Departamento, " +
                                    " ISNULL(RS.Comentarios, '') Comentarios,	 " +
                                    " A.Gafete1,	 " +
                                    " A.Gafete2,	 " +
                                    " A.FechaAsignacion FechaEntrada " +
                                " FROM " +
                                    " AsignacionGafete A " +
                                    " INNER JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = A.RegistroAccesoID AND RS.TieneSalida = 0 AND RS.Activo = 1 " +
                                    " INNER JOIN RegistroAccesoPersonas RP ON RP.RegistroPersonasID = A.RegistroPersonaID AND RP.Salida = 0 AND RP.Activo = 1 " +                                    
                                    " INNER JOIN [IBIX].[IBIXLocal].dbo.tblDepto D ON D.Depto = RS.DepartamentoID AND D.Activo = 1 AND D.Emp = 1 AND D.Nombre <> '' " +
                                " WHERE " +
                                    " A.AsignacionGafeteID = " + AsignacionGafeteID + " AND A.TieneSalida = 0 AND A.Activo = 1";

                SqlCommand cmd = new SqlCommand(sql, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    txtAsignacionGafeteID.Text = leer["AsignacionGafeteID"].ToString();
                    txtGafeteAsignado.Text = leer["Gafete2"].ToString();
                    txtRegistroAccesoID.Text = leer["RegistroAccesoID"].ToString();
                    txtRegistroPersonaID.Text = leer["RegistroPersonasID"].ToString();
                    txtNombre.Text = leer["Nombre"].ToString();
                    txtPlaca.Text = leer["Placa"].ToString();
                    txtAsunto.Text = leer["Asunto"].ToString();
                    txtDepartamento.Text = leer["Departamento"].ToString();
                    txtDescripcion.Text = leer["Comentarios"].ToString();
                    txtFechaEntrada.Value = Convert.ToDateTime(leer["FechaEntrada"].ToString());
                    txtHoraEntrada.Value = Convert.ToDateTime(leer["FechaEntrada"].ToString());
                }
                leer.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Mostrando Datos De Salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtGafeteAsignado.Text.Trim().ToUpper() != "")
            {
                try
                {
                    if(txtAsignacionGafeteID.Text.Trim() != "")
                    {
                        string query = "UPDATE AsignacionGafete SET TieneSalida = 1, FechaSalida = '" + dtFechaSalida.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE AsignacionGafeteID = " + txtAsignacionGafeteID.Text;
                        SqlCommand cmd = new SqlCommand(query, conexion);
                        if (conexion.State == ConnectionState.Closed)
                            conexion.Open();
                        int rowAffected = cmd.ExecuteNonQuery();
                        if(rowAffected > 0)
                        {
                            MessageBox.Show("Salida Guardada Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);                                                       
                            this.Close();                            
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error al guardar la salida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LimpiarCampos();
                        }
                        conexion.Close();
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Guardar Salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }else
            {
                MessageBox.Show("Ingrese Gafete Operador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtAsignacionGafeteID.Text = "";
            txtRegistroAccesoID.Text = "";
            txtRegistroPersonaID.Text = "";
            txtGafeteAsignado.Text = "";
            txtNombre.Text = "";
            txtPlaca.Text = "";
            txtAsunto.Text = "";
            txtDepartamento.Text = "";
            txtDescripcion.Text = "";
            txtFechaEntrada.Text = "";
            txtHoraEntrada.Text = "";            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
