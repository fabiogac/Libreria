using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.BibliotecaConnectionString))
            {

                using (SqlCommand sqlCommand = new SQlCommand("Biblioteca.dbo.spUpdateLibro", connection))
                {
                    sqlCommand.CommandType = CommandType



                    sqlCommand.Parameters.Add(new SqlParameter("@idLibro", SqlObType.Int));
                    sqlCommand.Parameters["@idLibro"].Value = Convert.ToInt32(this.idLibroTextBox.Text);

                    sqlCommand.Parameters.Add(new SqlParameter("@idCategoria", SqlObType.Int));
                    sqlCommand.Parameters["@idCategoria"].Value = Convert.ToInt32(this.idCategoriaTextBox.Text);

                    sqlCommand.Parameters.Add(new SqlParameter("@Nombre", SqlObType.String));
                    sqlCommand.Parameters["@Nombre"].Value = Convert.ToInt32(this.nombreTextBox.Text);

                }

            }

        }

        private void modificarButton_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.BibliotecaConnectionString))
            {

                using (SqlCommand sqlCommand = new SQlCommand("Biblioteca.dbo.spUpdateLibro", connection))
                {
                    sqlCommand.CommandType = CommandType



                    sqlCommand.Parameters.Add(new SqlParameter("@idLibro", SqlObType.Int));
                    sqlCommand.Parameters["@idLibro"].Value = Convert.ToInt32(this.idLibroTextBox.Text);

                    sqlCommand.Parameters.Add(new SqlParameter("@idCategoria", SqlObType.Int));
                    sqlCommand.Parameters["@idCategoria"].Value = Convert.ToInt32(this.idCategoriaTextBox.Text);

                }

            }




        }

        private void Borrar_Click(object sender, EventArgs e)
        {

        }

    }
}
