using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistoAcceso_Operador
{
    public partial class CapturaEntrada : Form
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        public bool EsEdicion = false;
        public CapturaEntrada()
        {
            InitializeComponent();            
        }

        internal void EditarGafeteOperador(string GafeteOperador)
        {
            this.Text = "Editar Gafete Operador";
            txtGafete1.Enabled = false;
            txtGafeteAsignado.Enabled = true;
            lblGafeteAnterior.Visible = true;
            txtGafeteAnterior.Visible = true;
            lblGafeteOperador.Text = "Nuevo Gafete Operador";                        
            EsEdicion = true;
            MostrarDatos(GafeteOperador);
        }

        private void MostrarDatos(string GafeteOperador)
        {
            try
            {
                string query = "SELECT " +
                                    " A.AsignacionGafeteID, " +
                                    " ISNULL(A.RegistroAccesoID, 0) RegistroAccesoID, " +
                                    " ISNULL(A.RegistroPersonaID, 0) RegistroPersonasID, " +
                                    " CASE WHEN RS.EsAutobus = 1 THEN 'ES AUTOBUS' WHEN RS.Conductor = RP.Nombre THEN RS.Conductor WHEN RP.Nombre IS NOT NULL THEN RP.Nombre ELSE '' END Nombre, " +
                                    " ISNULL(RS.Placa, 'NA') Placa, " +
                                    " ISNULL(RS.Asunto, 'NA') Asunto, " +
                                    " ISNULL(D.Nombre, 'NA') Departamento, " +
                                    " ISNULL(RS.Comentarios, '') Descripcion,	 " +
                                    " A.Gafete1,	 " +
                                    " A.Gafete2,	 " +
                                    " A.FechaAsignacion FechaEntrada " +
                                " FROM " +
                                    " AsignacionGafete A " +
                                    " INNER JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = A.RegistroAccesoID AND RS.TieneSalida = 0 AND RS.Activo = 1 " +
                                    " INNER JOIN RegistroAccesoPersonas RP ON RP.RegistroPersonasID = A.RegistroPersonaID AND RP.Salida = 0 AND RP.Activo = 1 " +                                    
                                    " INNER JOIN [IBIX].[IBIXLocal].dbo.tblDepto D ON D.Depto = RS.DepartamentoID AND D.Activo = 1 AND D.Emp = 1 AND D.Nombre <> '' " +
                                " WHERE " +
                                    " A.Gafete2 = '" + GafeteOperador.Trim().ToUpper() + "' AND A.TieneSalida = 0 AND A.Activo = 1";
                SqlCommand cmd = new SqlCommand(query, conexion);
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtAsignacionGafeteID.Text = reader["AsignacionGafeteID"].ToString();
                    txtRegistroAccesoID.Text = reader["RegistroAccesoID"].ToString();
                    txtRegistroPersonaID.Text = reader["RegistroPersonasID"].ToString();
                    txtGafete1.Text = reader["Gafete1"].ToString();//Gafete Administrador
                    txtGafeteAnterior.Text = reader["Gafete2"].ToString();//Gafete Operador                
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtAsunto.Text = reader["Asunto"].ToString();
                    txtDepartamento.Text = reader["Departamento"].ToString();
                    txtDescripcion.Text = reader["Descripcion"].ToString();
                    txtFechaEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());
                    txtHoraEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());                    
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Mostrando Información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                            
        }

        private void MuestraInformacion(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if(txtGafete1.Text != "")
                    {
                        if (!GafeteOriginalTieneAsignacion(txtGafete1.Text.Trim().ToUpper()))
                        {
                            string query = " SELECT " +
                                                " P.RegistroPersonasID, " +
                                                " ISNULL(RS.RegistroAccesoID, 0) RegistroAccesoID, " +
                                                " P.Nombre, " +
                                                " ISNULL(RS.Asunto, 'NA') Asunto, " +
                                                " ISNULL(D.Nombre, 'NA') Departamento, " +
                                                " ISNULL(RS.Comentarios, 'NA') Descripcion, " +
                                                " P.FechaEntrada " +
                                            " FROM " +
                                                " RegistroAccesoPersonas P " +
                                                " INNER JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = P.RegistroAccesoID AND RS.TieneSalida = 0 AND RS.Activo = 1 " +                                                
                                                " INNER JOIN [IBIX].[IBIXLocal].dbo.tblDepto D ON D.Depto = RS.DepartamentoID AND D.Emp = 1 AND D.Nombre <> '' " +
                                            " WHERE " +
                                                " P.Gafete = '" + txtGafete1.Text.Trim().ToUpper() + "' AND P.Salida = 0 AND P.Activo = 1 ";                            
                            SqlCommand cmd = new SqlCommand(query, conexion);
                            if (conexion.State == ConnectionState.Closed)
                                conexion.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                txtNombre.Text = reader["Nombre"].ToString();
                                txtAsunto.Text = reader["Asunto"].ToString();
                                txtDepartamento.Text = reader["Departamento"].ToString();
                                txtDescripcion.Text = reader["Descripcion"].ToString();
                                txtRegistroPersonaID.Text = reader["RegistroPersonasID"].ToString();
                                txtRegistroAccesoID.Text = reader["RegistroAccesoID"].ToString();
                                txtFechaEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());
                                txtHoraEntrada.Value = Convert.ToDateTime(reader["FechaEntrada"].ToString());
                                txtGafeteAsignado.Enabled = true;
                                txtGafeteAsignado.Focus();
                            }
                            else
                            {
                                MessageBox.Show("No se Encontro Información con este número de gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtGafete1.Text = "";
                                txtGafete1.Focus();
                            }
                            reader.Close();
                            conexion.Close();
                        }
                        else
                        {
                            MessageBox.Show("Este Gafete ya tiene Asignación activa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGafete1.Text = "";
                            txtGafete1.Focus();
                        }                        
                    }else
                    {
                        MessageBox.Show("Por favor ingrese numero de gafete", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCampos();
                        txtGafeteAsignado.Enabled = false;
                        txtGafete1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Mostrando Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                    txtGafeteAsignado.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (EsEdicion)
                {
                    if(txtGafeteAsignado.Text.Trim().ToUpper() != "")
                    {
                        if (CodigoGafeteCorrecto(txtGafeteAsignado.Text.Trim().ToUpper()))
                        {
                            if (YaExisteGafeteOperador())
                            {
                                MessageBox.Show("Este Gafete Ya Está Asignado A Otra Persona, Por Favor Verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtGafeteAsignado.Text = "";
                                txtGafeteAsignado.Focus();
                            }
                            else
                            {                                
                                string query = "UPDATE AsignacionGafete SET Gafete2 = '" + txtGafeteAsignado.Text.Trim().ToUpper() + "' WHERE AsignacionGafeteID = " + txtAsignacionGafeteID.Text + " AND TieneSalida = 0 AND Activo = 1";
                                if (conexion.State == ConnectionState.Closed)
                                    conexion.Open();
                                SqlCommand cmd = new SqlCommand(query, conexion);
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("Gafete Actualizado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error Actualizando Gafete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                conexion.Close();
                            }                            
                        }else
                        {
                            MessageBox.Show("Codigo De Gafete Incorrecto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGafeteAsignado.Text = "";
                            txtGafeteAsignado.Focus();
                        }
                    }else
                    {
                        MessageBox.Show("El Campo de Nuevo Gafete De Operador No Debe Estar Vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGafeteAsignado.Text = "";
                        txtGafeteAsignado.Focus();
                    }
                }else
                {
                    if (txtGafete1.Text.Trim().ToUpper() != "")
                    {
                        if (txtGafeteAsignado.Text.Trim().ToUpper() != "")
                        {
                            if (CodigoGafeteCorrecto(txtGafeteAsignado.Text.Trim().ToUpper()))
                            {
                                if (!ExisteGafeteAsignado(txtGafeteAsignado.Text.Trim().ToUpper())) //Verifico que el gafete a asignar no este ligado a otro gafete de vigilancia
                                {
                                    if (!ExisteAsignacion(txtGafete1.Text.Trim().ToUpper(), txtGafeteAsignado.Text.Trim().ToUpper())) //Verifico que no exista la asginacion del gafete 1 con el asignado
                                    {
                                        string query = "INSERT INTO AsignacionGafete VALUES ( " +
                                       " '" + txtGafete1.Text.Trim().ToUpper() + "', " +
                                       " '" + txtGafeteAsignado.Text.Trim().ToUpper() + "', " +
                                       " '" + txtRegistroPersonaID.Text.Trim() + "', " +
                                       " '" + txtRegistroAccesoID.Text.Trim() + "', " +
                                       " GETDATE(), " +
                                       " GETDATE(), " +
                                       " null, 0, 1 ); ";
                                        SqlCommand cmd = new SqlCommand(query, conexion);
                                        if (conexion.State == ConnectionState.Closed)
                                            conexion.Open();
                                        int rowAffected = cmd.ExecuteNonQuery();
                                        if (rowAffected > 0)
                                        {
                                            MessageBox.Show("Asignacíon Correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al guardar datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ya Existe una Asignacion Con estos Gafetes, se limpiara la pantalla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        LimpiarCampos();

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Este Gafete ya esta asignado a otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtGafeteAsignado.Enabled = true;
                                    this.txtGafeteAsignado.Focus();
                                    this.txtGafeteAsignado.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Codigo De Gafete Incorrecto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtGafeteAsignado.Text = "";
                                txtGafeteAsignado.Focus();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Gafete Operador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGafeteAsignado.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Gafete Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCampos();
                        txtGafeteAsignado.Enabled = false;
                        txtGafete1.Focus();
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerificarGafeteAsignado(string gafete)
        {
            bool OK = false;
            try
            {               
                
                string _sql = "SELECT COUNT(*) Total FROM RegistroAccesoPersonas WHERE Gafete = '" + gafete + "' AND Salida = 0 AND Activo = 1";
                SqlCommand cmd = new SqlCommand(_sql, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (int.Parse(reader["Total"].ToString()) > 0)
                    {
                        OK = true;
                    }
                }
                reader.Close();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OK;
        }

        private bool ExisteGafeteAsignado(string gafeteAsignado)
        {
            bool existe = false;
            try
            {

                string _sql = "SELECT COUNT(*) Total FROM AsignacionGafete WHERE Gafete2 = '" + gafeteAsignado + "' AND TieneSalida = 0 AND Activo = 1";
                SqlCommand cmd = new SqlCommand(_sql, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (int.Parse(reader["Total"].ToString()) > 0)
                    {
                        existe = true;
                    }
                }
                reader.Close();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existe;
        }

        private bool ExisteAsignacion(string Gafete1, string Gafete2)
        {
            bool existe = false;
            try
            {

                string _sql = "SELECT COUNT(*) Total FROM AsignacionGafete WHERE (Gafete1 = '" + Gafete1 + "' AND Gafete2 = '" + Gafete2 + "') AND TieneSalida = 0 AND Activo = 1";
                SqlCommand cmd = new SqlCommand(_sql, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (int.Parse(reader["Total"].ToString()) > 0)
                    {
                        existe = true;
                    }
                }
                reader.Close();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existe;
        }
        private bool GafeteOriginalTieneAsignacion(string Gafete1) //Verifica que este gafete no tenga asignacion con ningun otro de la caseta de operador
        {
            bool existe = false;
            try
            {

                string _sql = "SELECT COUNT(*) Total FROM AsignacionGafete WHERE Gafete1 = '" + Gafete1 + "' AND TieneSalida = 0 AND Gafete2 IS NOT NULL AND Activo = 1";
                SqlCommand cmd = new SqlCommand(_sql, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (int.Parse(reader["Total"].ToString()) > 0)
                    {
                        existe = true;
                    }
                }
                reader.Close();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return existe;
        }

        private void LimpiarCampos()
        {
            txtGafete1.Text = "";
            txtGafeteAsignado.Text = "";
            txtNombre.Text = "";
            txtAsunto.Text = "";
            txtDepartamento.Text = "";
            txtDescripcion.Text = "";
            txtGafete1.Focus();       
        }

        private void AsignarGafeteOperador(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (EsEdicion)
                    {
                        if (txtGafeteAsignado.Text != "")
                        {
                            if (CodigoGafeteCorrecto(txtGafeteAsignado.Text.Trim().ToUpper()))
                            {
                                if (YaExisteGafeteOperador())
                                {
                                    MessageBox.Show("Este Gafete Ya Está Asignado A Otra Persona, Por Favor Verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtGafeteAsignado.Text = "";
                                    txtGafeteAsignado.Focus();
                                }
                                else
                                {
                                    string query = "UPDATE AsignacionGafete SET Gafete2 = '" + txtGafeteAsignado.Text.Trim().ToUpper() + "' WHERE AsignacionGafeteID = " + txtAsignacionGafeteID.Text + " AND TieneSalida = 0 AND Activo = 1";
                                    if (conexion.State == ConnectionState.Closed)
                                        conexion.Open();
                                    SqlCommand cmd = new SqlCommand(query, conexion);
                                    int result = cmd.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        MessageBox.Show("Gafete Actualizado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Actualizando Gafete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    conexion.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Codigo De Gafete Incorrecto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtGafeteAsignado.Text = "";
                                txtGafeteAsignado.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El Campo de Nuevo Gafete De Operador No Debe Estar Vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGafeteAsignado.Text = "";
                            txtGafeteAsignado.Focus();
                        }
                    }
                    else
                    {
                        if (txtGafete1.Text != "")
                        {
                            if (txtGafeteAsignado.Text != "")
                            {
                                if (CodigoGafeteCorrecto(txtGafeteAsignado.Text.Trim().ToUpper()))
                                {
                                    if (!ExisteGafeteAsignado(txtGafeteAsignado.Text.Trim().ToUpper())) //Verifico que el gafete a asignar no este ligado a otro gafete de vigilancia
                                    {
                                        if (!ExisteAsignacion(txtGafete1.Text.Trim().ToUpper(), txtGafeteAsignado.Text.Trim().ToUpper())) //Verifico que no exista la asginacion del gafete 1 con el asignado
                                        {
                                            string query = "INSERT INTO AsignacionGafete VALUES ( " +
                                           " '" + txtGafete1.Text.Trim().ToUpper() + "', " +
                                           " '" + txtGafeteAsignado.Text.Trim().ToUpper() + "', " +
                                           " '" + txtRegistroPersonaID.Text.Trim() + "', " +
                                           " '" + txtRegistroAccesoID.Text.Trim() + "', " +
                                           " GETDATE(), " +
                                           " GETDATE(), " +
                                           " null, 0, 1 ); ";
                                            SqlCommand cmd = new SqlCommand(query, conexion);
                                            if (conexion.State == ConnectionState.Closed)
                                                conexion.Open();
                                            int rowAffected = cmd.ExecuteNonQuery();
                                            if (rowAffected > 0)
                                            {
                                                MessageBox.Show("Asignacíon Correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error al guardar datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ya Existe una Asignacion Con estos Gafetes, se limpiara la pantalla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            LimpiarCampos();

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Este Gafete ya esta asignado a otra persona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtGafeteAsignado.Enabled = true;
                                        this.txtGafeteAsignado.Focus();
                                        this.txtGafeteAsignado.Text = "";
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Codigo De Gafete Incorrecto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtGafeteAsignado.Text = "";
                                    txtGafeteAsignado.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ingrese Gafete Operador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtGafeteAsignado.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Gafete Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            LimpiarCampos();
                            txtGafeteAsignado.Enabled = false;
                            txtGafete1.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool YaExisteGafeteOperador()
        {
            bool res = false;
            try
            {
                string query = "SELECT COUNT(*) Total FROM AsignacionGafete WHERE Gafete2 = '" + txtGafeteAsignado.Text.Trim().ToUpper() + "' AND AsignacionGafeteID <> " + txtAsignacionGafeteID.Text + " AND TieneSalida = 0 AND Activo = 1";
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["Total"].ToString()) > 0) { res = true; }
                }
                reader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Validando Nuevo Gafete Operador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            return res;
        }
        private bool CodigoGafeteCorrecto(string gafete)
        {
            bool status = true;
            string Leyenda = "OP-";
            try
            {
                if (gafete != "")
                {
                    if (!gafete.Trim().ToUpper().StartsWith(Leyenda))
                        status = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Validando Codigo de Gafete: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        private void ValidarSintaxisGafete(object sender, KeyEventArgs e)
        {         
            BeginInvoke(new Action(delegate {
                if (txtGafeteAsignado.Text.Contains("\'"))
                {
                    txtGafeteAsignado.Text = txtGafeteAsignado.Text.Trim().Replace("\'", "-");
                    txtGafeteAsignado.SelectionStart = txtGafeteAsignado.Text.Length;
                    txtGafeteAsignado.ScrollToCaret();
                }
            }));        
        }
    }
}
