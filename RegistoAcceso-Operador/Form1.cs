using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistoAcceso_Operador
{
    public partial class Form1 : Form
    {
        //SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionproyectoid);        
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionControlAcceso"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
            this.txtGafeteBuscar.Focus();
            LlenarGrid();            
        }

        private void btnNuevaEntrada_Click(object sender, EventArgs e)
        {
            CapturaEntrada FormCapturaEntrada = new CapturaEntrada();
            FormCapturaEntrada.ShowDialog();
            LlenarGrid();
            HistoricoSalidas();
        }

        public void LlenarGrid()
       {
            try
            {       
                string query = "SELECT " +
                                    " A.AsignacionGafeteID, " +
                                    " ISNULL(RS.RegistroAccesoID, 0) RegistroAccesoID, " +
                                    " ISNULL(RP.RegistroPersonasID, 0) RegistroPersonasID, " +
                                    " CASE WHEN RS.EsAutobus = 1 THEN 'ES AUTOBUS' WHEN RP.Nombre = RS.Conductor THEN RS.Conductor WHEN RP.Nombre IS NOT NULL AND RS.TieneSalida = 0 THEN RP.Nombre ELSE 'NA' END Nombre, " +
                                    " ISNULL(RP.Gafete, '-') Gafete1, " +
                                    " A.Gafete2, " +
                                    " ISNULL(RS.Placa, 'NA') Placa, " +
                                    " ISNULL(CONVERT(VARCHAR(30), A.FechaAsignacion, 103), 'NA') FechaEntrada, " +
                                    " RIGHT(ISNULL(CONVERT(VARCHAR, A.FechaAsignacion, 100), 'NA'), 7)  HoraEntrada, " +
                                    " ISNULL(RS.Asunto, 'NA') Asunto, " +
                                    " ISNULL(D.Nombre, 'NA') Departamento " +
                                " FROM " +
                                    " AsignacionGafete A WITH(NOLOCK) " +
                                    " LEFT JOIN RegistroAccesoPersonas RP WITH(NOLOCK) ON RP.RegistroPersonasID = A.RegistroPersonaID AND RP.Activo = 1 " +
                                    " LEFT JOIN RegistroAccesoSteelgo RS WITH(NOLOCK) ON RS.RegistroAccesoID = RP.RegistroAccesoID AND RS.Activo = 1 " +                                    
                                    " LEFT JOIN [IBIX].[IBIXLocal].[dbo].tblDepto D WITH(NOLOCK) ON D.Depto = RS.DepartamentoID AND D.Activo = 1 AND D.Emp = 1 AND D.Nombre <> '' " +
                                " WHERE " +
                                    " RP.Salida = 0 AND A.TieneSalida = 0 AND A.Activo = 1 ";
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.Fill(ds, "Registros");
                dataGridView1.DataSource = ds.Tables[0];
                conexion.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar informacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int AsignacionGafeteID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AsignacionGafeteID"].Value.ToString());
                CapturaSalida FormSalida = new CapturaSalida();
                FormSalida.MostrarDatosDeSalida(AsignacionGafeteID);
                FormSalida.ShowDialog();
                LlenarGrid();
            }            
        }
        private void HistoricoSalidas()
        {
            try
            {
                DataSet ds = new DataSet();
                string query = " SELECT " +
                                " A.AsignacionGafeteID, " +
                                " A.Gafete2, " +
                                " CASE WHEN RS.EsAutobus = 1 THEN 'ES AUTOBUS' WHEN RS.Conductor = RP.Nombre THEN RS.Conductor WHEN RP.Nombre IS NOT NULL THEN RP.Nombre ELSE '' END Nombre, " +
                                " A.Gafete1, " +
                                " ISNULL(RS.Placa, 'NA') Placa,  " +
                                " (CONVERT(VARCHAR(30), A.FechaAsignacion, 103) + RIGHT(CONVERT(VARCHAR(32), A.FechaAsignacion, 100), 8)) FechaAsignacion,  " +
                                " (CONVERT(VARCHAR(30), A.FechaSalida, 103) + RIGHT(CONVERT(VARCHAR(32), A.FechaSalida, 100), 8)) FechaSalida,  " +                                
                                " CASE WHEN RS.EsAutobus = 1 THEN 'SI' ELSE 'NO' END EsAutobus, " +
                                " ISNULL(D.Nombre, '') Departamento, " +
                                " ISNULL(RS.Asunto, '') Asunto " +
                            " FROM " +
                                " AsignacionGafete A " +
                                " LEFT JOIN RegistroAccesoSteelgo RS ON RS.RegistroAccesoID = A.RegistroAccesoID AND RS.Activo = 1 " +
                                " LEFT JOIN RegistroAccesoPersonas RP ON RP.RegistroPersonasID = A.RegistroPersonaID AND RP.Activo = 1 " +                                
                                " LEFT JOIN [IBIX].[IBIXLocal].dbo.tblDepto D ON D.Depto = RS.DepartamentoID AND D.Activo = 1 AND D.Emp = 1 AND D.Nombre <> '' " +
                            " WHERE A.TieneSalida = 1 ";
                if (FechaDesde.Checked && FechaHasta.Checked)
                {
                    if(FechaDesde.Value < FechaHasta.Value || (FechaDesde.Value.ToString() == FechaHasta.Value.ToString() ))
                    {
                        query += " AND (CONVERT(DATETIME, CONVERT(CHAR(10), A.FechaSalida, 103), 103) >= '" + FechaDesde.Value.ToString("yyyy-MM-dd") + "' AND CONVERT(DATETIME, CONVERT(CHAR(10), A.FechaSalida, 103), 103) <= '" + FechaHasta.Value.ToString("yyyy-MM-dd") + "') ";
                    }
                    else
                    {
                        MessageBox.Show("La fecha inicial no debe ser mayor a la fecha final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                        return;                        
                    }                    
                }
                else if (FechaDesde.Checked && !FechaHasta.Checked)
                {
                    query += " AND (CONVERT(DATETIME, CONVERT(CHAR(10), A.FechaSalida, 103), 103) >= '" + FechaDesde.Value.ToString("yyyy-MM-dd") + "' )";
                }
                else if (!FechaDesde.Checked && FechaHasta.Checked)
                {
                    query += " AND (CONVERT(DATETIME, CONVERT(CHAR(10), A.FechaSalida, 103), 103) <= '" + FechaHasta.Value.ToString("yyyy-MM-dd") + "' )";
                }
                query += " ORDER BY A.FechaSalida DESC; ";
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();                
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.Fill(ds, "Salidas");
                gridHistoricoSalidas.DataSource = ds.Tables[0];
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cargando Historico Salida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarSalidas_Click(object sender, EventArgs e)
        {
            HistoricoSalidas();
        }

        private void BuscarGafeteAsignadoEnGrid(object sender, EventArgs e)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Gafete2 LIKE '{0}%'", txtGafeteBuscar.Text);
        }

        private void RelojRefrescaGrid_Tick(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BorrarGafeteOperador(object sender, EventArgs e)
        {
            txtGafeteBuscar.Text = "";
        }

        private void ToUpper(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                string text = txtGafeteBuscar.Text.Replace("'", "-");
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Gafete2 LIKE '{0}%'", text);
            }
        }

        private void btnActualizarPantalla_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void ActualizarHistoricoSalidas(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                HistoricoSalidas();
            }
        }

        private void EditarGafeteOperador(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                string gafeteOperador = dataGridView1.CurrentRow.Cells["Gafete2"].Value.ToString();
                CapturaEntrada FormEntrada = new CapturaEntrada();                
                FormEntrada.EditarGafeteOperador(gafeteOperador);                
                FormEntrada.ShowDialog();
                LlenarGrid();
            }
        }
    }
}
