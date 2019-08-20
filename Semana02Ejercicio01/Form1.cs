using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Semana02Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Leon"].ConnectionString);


        //Crear Metodo de lista de años comboBox
        public void ListaAnios()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_ListaAnios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        //El metodo Fill cargara los datos en el procedimiento almacenado
                        da.Fill(df, "ListaAnios");
                        //Enviar los datos al combobox
                        CboAnios.DataSource = df.Tables["ListaAnios"];
                        CboAnios.DisplayMember = "Anios";
                        CboAnios.ValueMember = "Anios";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaAnios();
        }
        

        private void CboAnios_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Pedidos_Anios", cn))
            {
                using (SqlDataAdapter Da = new SqlDataAdapter())
                {
                    Da.SelectCommand = cmd;
                    Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Da.SelectCommand.Parameters.AddWithValue("@anio", CboAnios.SelectedValue);
                    using (DataSet df = new DataSet())
                    {
                        Da.Fill(df, "Pedidos");
                        //Mostrar los datos en el datagrid
                        DgPedidos.DataSource = df.Tables["Pedidos"];
                        LblNumero.Text = df.Tables["Pedidos"].Rows.Count.ToString();

                    }
                }

            }

        }


        private void DgPedidos_DoubleClick(object sender, EventArgs e)
        {
            //Capturar la columna del pedido
            int Codigo;
            Codigo = Convert.ToInt32(DgPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd= new SqlCommand("Usp_Detalle_Pedido",cn))
            {
                using (SqlDataAdapter Da = new SqlDataAdapter())
                {
                    Da.SelectCommand = cmd;
                    Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Da.SelectCommand.Parameters.AddWithValue("@idpedido", Codigo);
                    using (DataSet df = new DataSet())
                    {
                        Da.Fill(df, "Detalles");
                        //Mostrar los datos en el DtagridVIew
                        DgDetalle.DataSource = df.Tables["Detalles"];
                        LblMonto.Text = df.Tables["Detalles"].Compute("Sum(Monto)", "").ToString();
                    }
                }
            }
        }
        
       
    }
}
