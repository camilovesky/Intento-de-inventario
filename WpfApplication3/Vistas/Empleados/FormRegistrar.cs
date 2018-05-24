using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApplication3.Vistas.Empleados
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        
                
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            // Configurar la clase SQLCONNECT //
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Cs_proyecto "].ConnectionString
                );
            cn.Open();

            MessageBox.Show("Conexion exitosa");

            cn.Close();

        }
    }
    
}

